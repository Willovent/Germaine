using System.Threading.Tasks;
using System;
using Windows.Media.SpeechRecognition;
using Windows.UI.Xaml.Controls;
using Windows.UI.Core;
using Windows.Globalization;
using System.Collections.Generic;
using System.Linq;
using HouseOvent.Business;
using Windows.Media.SpeechSynthesis;
using System.IO;
using Windows.UI.Popups;

namespace HouseOvent
{
    public sealed partial class MainPage : Page
    {
        private SpeechRecognizer speechRecognizer;
        private CoreDispatcher dispatcher;
        private SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        private OventBusinessService oventService = new OventBusinessService();
        public MainPage()
        {
            this.InitializeComponent();
            speechSynthesizer.Voice = SpeechSynthesizer.AllVoices.FirstOrDefault(x => x.Language == "fr-FR");
            dispatcher = CoreWindow.GetForCurrentThread().Dispatcher;
            ListenToMe(new Language("fr-FR"));
        }

        async Task ListenToMe(Language recognizerLanguage)
        {
            //await dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () =>
            // {
            //     var media = new MediaElement();
            //     var stream = await speechSynthesizer.SynthesizeTextToStreamAsync("Ok Chef !");
            //     media.SetSource(stream, stream.ContentType);
            //     media.Play();
            // });
            //await new KodiBusinessService().PlayMovie("");
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
            var grammarfileConstraint = new SpeechRecognitionGrammarFileConstraint(storageFile);
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
                case "lightstore": oventService.HandleLightStoreAsync(result[1], result[2], result[3]); break;
                case "musique":
                    if (result[1] == "power")
                    {
                        oventService.PowerMusique();
                    }
                    else if (result[1] == "playlist")
                    {
                        oventService.HandlePlaylist(int.Parse(result[2]));
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
    }
}
