using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;

namespace voice_text_processing_speechLib
{
    public partial class SpeechLib : Form
    {
        public SpeechLib()
        {
            InitializeComponent();
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            SpVoice spVoice = new SpVoice();
            spVoice.Speak(richTextBox1.Text);
        }
    }
}
