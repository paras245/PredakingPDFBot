using System.Speech.Synthesis;
using System.Text.RegularExpressions;

namespace ChatApp1.Services
{
    public class SpeechService
    {
        private readonly SpeechSynthesizer _sythesizer;

        public SpeechService()
        {
            _sythesizer = new SpeechSynthesizer();
            _sythesizer.SetOutputToDefaultAudioDevice();
        }

        public void Speak(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                string cleanedText = Regex.Replace(text, @"<citation.*", "",RegexOptions.Singleline);
                _sythesizer.SpeakAsync(cleanedText);
            }
        }
    }
}
