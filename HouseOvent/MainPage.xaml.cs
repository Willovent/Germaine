using System.Threading.Tasks;
using System;
using Windows.Media.SpeechRecognition;
using Windows.UI.Xaml.Controls;
using Windows.UI.Core;
using Windows.Globalization;
using System.Collections.Generic;
using System.Linq;
using HouseOvent.Business;

namespace HouseOvent
{
    public sealed partial class MainPage : Page
    {
        private SpeechRecognizer speechRecognizer;
        private CoreDispatcher dispatcher;
        private OventBusinessService oventService = new OventBusinessService();
        public MainPage()
        {
            this.InitializeComponent();
            dispatcher = CoreWindow.GetForCurrentThread().Dispatcher;
            //PopulateLanguageDropdown();
           ListenToMe(new Language("fr-FR"));
        }

        async Task ListenToMe(Language recognizerLanguage)
        {
            if (speechRecognizer != null)
            {
                // cleanup prior to re-initializing this scenario.
                speechRecognizer.StateChanged -= SpeechRecognizer_StateChanged;
                speechRecognizer.ContinuousRecognitionSession.Completed -= ContinuousRecognitionSession_Completed;
                speechRecognizer.ContinuousRecognitionSession.ResultGenerated -= ContinuousRecognitionSession_ResultGenerated;
                speechRecognizer.HypothesisGenerated -= SpeechRecognizer_HypothesisGenerated;

                this.speechRecognizer.Dispose();
                this.speechRecognizer = null;
            }
            this.speechRecognizer = new SpeechRecognizer(recognizerLanguage);
            speechRecognizer.StateChanged += SpeechRecognizer_StateChanged;
            var storageFile = await Windows.Storage.StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///rules.xml"));
            var grammarfileConstraint = new SpeechRecognitionGrammarFileConstraint(storageFile);
            speechRecognizer.Constraints.Add(grammarfileConstraint);
            var result = await speechRecognizer.CompileConstraintsAsync();

            speechRecognizer.ContinuousRecognitionSession.ResultGenerated += ContinuousRecognitionSession_ResultGenerated;
            speechRecognizer.HypothesisGenerated += SpeechRecognizer_HypothesisGenerated;
            speechRecognizer.ContinuousRecognitionSession.Completed += ContinuousRecognitionSession_Completed;
            await speechRecognizer.ContinuousRecognitionSession.StartAsync(SpeechContinuousRecognitionMode.PauseOnRecognition);
        }

        private async void ContinuousRecognitionSession_ResultGenerated(SpeechContinuousRecognitionSession sender, SpeechContinuousRecognitionResultGeneratedEventArgs args)
        {
            var result = args.Result.SemanticInterpretation.Properties.First().Value[0].Split('|');
            switch (result[0])
            {
                case "lightstore": await oventService.HandleLightStoreAsync(result[1], result[2], result[3]); break;
                case "musique": 
                    if(result[1] == "power")
                    {
                        await oventService.PowerMusique();
                    } else if (result[1] == "playlist") {
                        await oventService.HandlePlaylist(int.Parse(result[2]));
                    }
                    break;
            }
            speechRecognizer.ContinuousRecognitionSession.Resume();
        }

        //private void PopulateLanguageDropdown()
        //{
        //    Language defaultLanguage = SpeechRecognizer.SystemSpeechLanguage;
        //    IEnumerable<Language> supportedLanguages = SpeechRecognizer.SupportedTopicLanguages;
        //    foreach (Language lang in supportedLanguages)
        //    {
        //        ComboBoxItem item = new ComboBoxItem();
        //        item.Tag = lang;
        //        item.Content = lang.DisplayName;

        //        cbLanguageSelection.Items.Add(item);
        //        if (lang.LanguageTag == defaultLanguage.LanguageTag)
        //        {
        //            item.IsSelected = true;
        //            cbLanguageSelection.SelectedItem = item;
        //        }
        //    }
        //}


        private async void ContinuousRecognitionSession_Completed(SpeechContinuousRecognitionSession sender, SpeechContinuousRecognitionCompletedEventArgs args)
        {
            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => Result.Text = args.Status.ToString());
        }

        private async void SpeechRecognizer_HypothesisGenerated(SpeechRecognizer sender, SpeechRecognitionHypothesisGeneratedEventArgs args)
        {
            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => Result.Text = args.Hypothesis.Text);
        }

        private async void SpeechRecognizer_StateChanged(SpeechRecognizer sender, SpeechRecognizerStateChangedEventArgs args)
        {
            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => Status.Text = args.State.ToString());
        }

        //private async void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        //{
        //    var item = (ComboBoxItem)(cbLanguageSelection.SelectedItem);
        //    var newLanguage = (Language)item.Tag;
        //    await ListenToMe(newLanguage);
        //}

        private async void Button_Click_2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            await speechRecognizer.StopRecognitionAsync();
        }
    }
}
