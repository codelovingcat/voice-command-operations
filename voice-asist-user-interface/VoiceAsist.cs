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
using System.Speech.Recognition;

namespace voice_asist_user_interface
{
    public partial class VoiceAsist : Form
    {
        NorthwindEntities1 entities = new NorthwindEntities1();
        public void ProductList()
        {
            var products = entities.Products.ToList();
            dataGridView1.DataSource = products;
        }
        void enable()
        {
            textBoxCategoryID.Enabled = false;
            textBoxDiscontinued.Enabled = false;
            textBoxProductName.Enabled = false;
            textBoxQuantityPerUnit.Enabled = false;
            textBoxReorderLevel.Enabled = false;
            textBoxSupplierID.Enabled = false;
            textBoxUnitPrice.Enabled = false;
            textBoxUnitsInStock.Enabled = false;
            textBoxUnitsOnOrder.Enabled = false;
        }
        public VoiceAsist()
        {
            InitializeComponent();
        }

        private void btnStartSpeak_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine speech = new SpeechRecognitionEngine();
            Grammar grammar = new DictationGrammar();
            speech.LoadGrammar(grammar);
            try
            {
                btnStartSpeak.Text = "Please Speak";
                speech.SetInputToDefaultAudioDevice();
                RecognitionResult result = speech.Recognize();
                richTextBox1.Text = result.Text;
            }
            catch (Exception)
            {
                richTextBox1.Text = "Error Try Again!";
            }
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            SpVoice spVoice = new SpVoice();
            spVoice.Speak(richTextBox1.Text);
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            ProductList();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxProductName.BackColor == Color.DarkSeaGreen)
            {
                textBoxProductName.Text = richTextBox1.Text;
            }

            if (richTextBox1.Text=="Hi" || richTextBox1.Text=="Hello")
            {
                ProductList();
            }
            if (richTextBox1.Text == "Product name")
            {
                textBoxProductName.Focus();
                textBoxProductName.BackColor = Color.DarkSeaGreen;
                
            }
            if (richTextBox1.Text=="Exit" || richTextBox1.Text == "Exits")
            {
                Application.Exit();
            }
            if (richTextBox1.Text=="Paint")
            {
                System.Diagnostics.Process.Start("MsPaint");
            }
            if (richTextBox1.Text == "Visual Studio")
            {
                System.Diagnostics.Process.Start("devenv.exe");
            }
            
        }

        private void VoiceAsist_Load(object sender, EventArgs e)
        {
            enable();
        }
    }
}
