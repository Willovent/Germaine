using System.Threading.Tasks;
using System;
using Windows.Media.SpeechRecognition;
using Windows.UI.Xaml.Controls;
using Windows.UI.Core;
using Windows.Globalization;
using System.Linq;
using HouseOvent.Business;
using Windows.Media.SpeechSynthesis;
using OventService;
using System.IO;
using System.Xml.Linq;
using System.Text;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Storage;

namespace HouseOvent
{
    public sealed partial class MainPage : Page
    {
        private SpeechRecognizer speechRecognizer;
        private CoreDispatcher dispatcher;
        private SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        private OventBusinessService oventService = new OventBusinessService();
        private KodiBusinessService kodiBusinessService = new KodiBusinessService();
        public MainPage()
        {
            this.InitializeComponent();
            speechSynthesizer.Voice = SpeechSynthesizer.AllVoices.FirstOrDefault(x => x.Language == "fr-FR");
            dispatcher = CoreWindow.GetForCurrentThread().Dispatcher;
            ListenToMeAsync(new Language("fr-FR"));

            kodiBusinessService.AllumerLaTeleAsync();
        }

        async void ListenToMeAsync(Language recognizerLanguage)
        {

            if (speechRecognizer != null)
            {
                speechRecognizer.ContinuousRecognitionSession.Completed -= ContinuousRecognitionSession_Completed;
                speechRecognizer.ContinuousRecognitionSession.ResultGenerated -= ContinuousRecognitionSession_ResultGenerated;
                speechRecognizer.HypothesisGenerated -= SpeechRecognizer_HypothesisGenerated;
                speechRecognizer.StateChanged -= SpeechRecognizer_StateChanged;

                this.speechRecognizer.Dispose();
                this.speechRecognizer = null;
            }
            this.speechRecognizer = new SpeechRecognizer(recognizerLanguage);
            var storageFile = await Windows.Storage.StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///rules.xml"));
            XDocument rules;
            using (var stream = await storageFile.OpenAsync(Windows.Storage.FileAccessMode.Read))
            {
                using (var inputStream = stream.GetInputStreamAt(0))
                {
                    rules = XDocument.Load(inputStream.AsStreamForRead());
                }
            }
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            var seriesRules = rules.Root.Elements().Where(x => x.Attribute("id")?.Value == "series").First();
            seriesRules.ReplaceWith(await GenerateRulesForSeries());
            SanityzeXmlDoc(rules);
            StorageFolder appInstalledFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            StorageFile sampleFile = await storageFolder.CreateFileAsync("rules.xml", CreationCollisionOption.ReplaceExisting);
            using (var stream = await sampleFile.OpenAsync(FileAccessMode.ReadWrite))
            {
                using (var outputStream = stream.GetOutputStreamAt(0))
                {
                    await outputStream.WriteAsync(Encoding.UTF8.GetBytes(@"<?xml version=""1.0"" encoding=""UTF-8""?>" + rules.ToString()).AsBuffer());
                }
            }

            var grammarfileConstraint = new SpeechRecognitionGrammarFileConstraint(sampleFile);
            speechRecognizer.Constraints.Add(grammarfileConstraint);
            var result = await speechRecognizer.CompileConstraintsAsync();

            speechRecognizer.ContinuousRecognitionSession.ResultGenerated += ContinuousRecognitionSession_ResultGenerated;
            speechRecognizer.HypothesisGenerated += SpeechRecognizer_HypothesisGenerated;
            speechRecognizer.StateChanged += SpeechRecognizer_StateChanged;
            speechRecognizer.ContinuousRecognitionSession.Completed += ContinuousRecognitionSession_Completed;
            await speechRecognizer.ContinuousRecognitionSession.StartAsync(SpeechContinuousRecognitionMode.PauseOnRecognition);
        }

        private async void SpeechRecognizer_StateChanged(SpeechRecognizer sender, SpeechRecognizerStateChangedEventArgs args)
        {
            if (args.State == SpeechRecognizerState.SoundEnded)
            {
                await Task.Delay(2000);
                await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => Result.Text = "");
            }
        }

        private async void ContinuousRecognitionSession_ResultGenerated(SpeechContinuousRecognitionSession sender, SpeechContinuousRecognitionResultGeneratedEventArgs args)
        {
            var stream = await speechSynthesizer.SynthesizeTextToStreamAsync("Ok Chef !");

            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => Result.Text = args.Result.Text);
            var result = args.Result.SemanticInterpretation.Properties.First().Value[0].Split('|');
            switch (result[0])
            {
                case "lightstore":
                    await SaySomethingAsync("Ok Chef !");
                    await oventService.HandleLightStoreAsync(result[1], result[2], result[3]);
                    break;
                case "musique":
                    if (result[1] == "power")
                    {
                        await SaySomethingAsync("Ok Chef !");
                        await oventService.PowerMusiqueAsync();
                    }
                    else if (result[1] == "playlist")
                    {
                        await SaySomethingAsync("Ok Chef !");
                        await oventService.HandlePlaylistAsync(int.Parse(result[2]));
                    }
                    break;
            }
            speechRecognizer.ContinuousRecognitionSession.Resume();
            await Task.Delay(2000);
            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => Result.Text = "");
        }

        private async void ContinuousRecognitionSession_Completed(SpeechContinuousRecognitionSession sender, SpeechContinuousRecognitionCompletedEventArgs args)
        {
            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => Result.Text = args.Status.ToString());
        }

        private async void SpeechRecognizer_HypothesisGenerated(SpeechRecognizer sender, SpeechRecognitionHypothesisGeneratedEventArgs args)
        {
            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => Result.Text = args.Hypothesis.Text);
        }

        private bool canSpeak = true;

        private async Task SaySomethingAsync(string sentance)
        {
            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () =>
             {
                 if (canSpeak)
                 {
                     var stream = await speechSynthesizer.SynthesizeTextToStreamAsync(sentance);
                     try
                     {
                         Media.SetSource(stream, stream.ContentType);
                         Media.Play();
                     }
                     catch
                     {
                         canSpeak = false;
                         Result.Text = sentance;
                     }
                 }
                 else
                 {
                     Result.Text = sentance;
                 }
             });
        }

        private async Task<XElement> GenerateRulesForSeries()
        {
            var series = await kodiBusinessService.GetSeries();
            var elem = new XElement("rule", new XAttribute("id", "series"), new XAttribute("scope", "private"));
            var oneOf = new XElement("one-of");
            elem.Add(oneOf);
            foreach (var serie in series)
            {
                var current = new XElement("item");
                current.Value = serie.title;
                var tag = new XElement("tag");
                tag.Value = $"out=\"{serie.title}\";";
                current.Add(tag);
                oneOf.Add(current);
            }
            return elem;
        }
        private void SanityzeXmlDoc(XDocument doc)
        {
            foreach (var node in doc.Root.Descendants())
            {
                if (node.Name.NamespaceName == "")
                {
                    node.Attributes("xmlns").Remove();
                    node.Name = node.Parent.Name.Namespace + node.Name.LocalName;
                }
            }
        }
    }
}
