﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;
using System.Speech.Recognition;

namespace siri_simulation
{
    public partial class SiriSimulation : Form
    {
        SpVoice spVoice = new SpVoice();
        public SiriSimulation()
        {
            InitializeComponent();
        }

        private void btnSpeak_TextChanged(object sender, EventArgs e)
        {
            if (btnSpeak.Text == "Hello")
            {
                lblAnswear.Text = "Hi!";
                spVoice.Speak("Hi");
            }
            if (btnSpeak.Text == "What is like")
            {
                lblAnswear.Text = "I like coding.";
                spVoice.Speak("I like coding");
            }
            if (btnSpeak.Text == "Water")
            {
                lblAnswear.Text = "Water.";
                spVoice.Speak("Water");
            }
            if (btnSpeak.Text == "Spanish")
            {
                lblAnswear.Text = "Barselona , Real Madrid, Messi , Ronaldo.";
            }
            if (btnSpeak.Text == "Turkey")
            {
                lblAnswear.Text = "Sesi dinle...";
                lblAnswear.Text = "Istanbul, Ankara, Sultan Ahmet, Ayasofya";
                spVoice.Speak("Turkey beautiful country");
                pictureBox1.ImageLocation = @"D:\GitHub\voice-command-operations\siri-simulation\images\turkey.jpg";
                pictureBox2.ImageLocation = @"D:\GitHub\voice-command-operations\siri-simulation\images\galata-kulesi.jpg";
                pictureBox3.ImageLocation = @"D:\GitHub\voice-command-operations\siri-simulation\images\kiz-kulesi.jpg";
            }
            if (btnSpeak.Text == "Watermelon")
            {
                lblAnswear.Text = "Google Açılıyor...";
                webBrowser1.Navigate("https://www.google.com/search?q=karpuz&oq=karpuz&aqs=chrome..69i57j46i433j0i433j0l5.2660j0j4&sourceid=chrome&ie=UTF-8");
            }
            if (btnSpeak.Text == "Melon")
            {
                lblAnswear.Text = "Google Açılıyor...";
                webBrowser1.Navigate("https://www.google.com/search?sxsrf=ALeKk033vCZ6g61t1Ae0faSPMrhwHs_wjg%3A1605102603150&ei=C-yrX83RCMKOrwSZ2orYDQ&q=kavun&oq=kavun&gs_lcp=CgZwc3ktYWIQAzIHCAAQsQMQQzIECC4QQzICCAAyBAgAEEMyAggAMgIIADICCAAyAggAMgIIADICCAA6BAgjECc6BggjECcQEzoFCAAQsQM6BQguELEDUIxdWO9kYLNnaABwAXgAgAGeAYgBtQWSAQMwLjWYAQCgAQGqAQdnd3Mtd2l6wAEB&sclient=psy-ab&ved=0ahUKEwiNg_ST0frsAhVCx4sKHRmtAtsQ4dUDCA0&uact=5");
            }
            if (btnSpeak.Text == "Paint")
            {
                lblAnswear.Text = "Paint açılıyor...";
                System.Diagnostics.Process.Start("Mspaint.exe");
            }
        }

        private void btnSpeak_Click(object sender, EventArgs e)
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

        private void btnAsistan_Click(object sender, EventArgs e)
        {
            spVoice.Speak(richTextBox1.Text);
        }
    }
}
