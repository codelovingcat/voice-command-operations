using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
namespace voice_command
{
    public partial class Audio : Form
    {
        public Audio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
            Grammar gramer = new DictationGrammar();
            sr.LoadGrammar(gramer);

            try
            {
                btnSpeak.Text = "Konuşun";
                sr.SetInputToDefaultAudioDevice();
                RecognitionResult result = sr.Recognize();
                btnSpeak.Text = result.Text;
            }
            catch (Exception)
            {
                btnSpeak.Text = "Hata!";
            }
        }
    }
}
