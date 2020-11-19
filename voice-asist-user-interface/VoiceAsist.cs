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
        void colorMethod()
        {
            textBoxProductName.BackColor = Color.DarkSeaGreen;
            textBoxCategoryID.BackColor = Color.DarkSeaGreen;
            textBoxDiscontinued.BackColor = Color.DarkSeaGreen;
            textBoxQuantityPerUnit.BackColor = Color.DarkSeaGreen;
            textBoxReorderLevel.BackColor = Color.DarkSeaGreen;
            textBoxSupplierID.BackColor = Color.DarkSeaGreen;
            textBoxUnitPrice.BackColor = Color.DarkSeaGreen;
            textBoxUnitsInStock.BackColor = Color.DarkSeaGreen;
            textBoxUnitsOnOrder.BackColor = Color.DarkSeaGreen;
            maskedTextBox1.BackColor = Color.DarkSeaGreen;
            comboBox1.BackColor = Color.DarkSeaGreen;
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
            maskedTextBox1.Enabled = false;
            comboBox1.Enabled = false;
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
            if (textBoxProductName.BackColor == Color.DarkSeaGreen && textBoxProductName.Enabled == true)
            {
                textBoxProductName.Text = richTextBox1.Text;
                enable();
                colorMethod();
            }
            if (richTextBox1.Text == "Add" || richTextBox1.Text == "Add to" || richTextBox1.Text == "Add the")
            {
                Products products = new Products();
                products.ProductName = textBoxProductName.Text;
                products.QuantityPerUnit = textBoxQuantityPerUnit.Text;
                products.SupplierID = Convert.ToInt32(textBoxSupplierID.Text);
                products.UnitPrice = Convert.ToDecimal(textBoxUnitPrice.Text);
                products.ReorderLevel = Convert.ToSByte(textBoxUnitPrice.Text);
                products.UnitsInStock = Convert.ToSByte(textBoxUnitsInStock.Text);
                products.UnitsOnOrder = Convert.ToSByte(textBoxUnitsOnOrder.Text);
                //products.Dates = Convert.ToDateTime(maskedTextBox1.Text);
                //products.Status = true;
                lblPleaseWait.Text = "Products saved in Northwind Database";
            }
            if (textBoxUnitPrice.BackColor == Color.DarkSeaGreen && textBoxUnitPrice.Enabled == true)
            {
                textBoxUnitPrice.Text = richTextBox1.Text;
                enable();
                colorMethod();
            }
            if (richTextBox1.Text == "Hi" || richTextBox1.Text == "Hello")
            {
                ProductList();
            }
            if (richTextBox1.Text == "Product name" || richTextBox1.Text == "53")
            {
                textBoxProductName.Focus();
                enable();
                colorMethod();

            }
            if (richTextBox1.Text == "Stock" || richTextBox1.Text == "Number")
            {
                textBoxUnitsInStock.Focus();
                enable();
                colorMethod();

            }
            if (richTextBox1.Text == "By price" || richTextBox1.Text == "price")
            {
                textBoxUnitPrice.Focus();
                enable();
                colorMethod();

            }
            if (richTextBox1.Text == "Quantity Unit" || richTextBox1.Text == "Unit")
            {
                textBoxQuantityPerUnit.Focus();
                enable();
                colorMethod();

            }
            if (richTextBox1.Text == "Category id" || richTextBox1.Text == "id")
            {
                textBoxCategoryID.Focus();
                enable();
                colorMethod();

            }
            if (richTextBox1.Text == "Discontinued" || richTextBox1.Text == "Discont")
            {
                textBoxDiscontinued.Focus();
                enable();
                colorMethod();

            }
            if (richTextBox1.Text == "Supplier" || richTextBox1.Text == "Supp")
            {
                textBoxSupplierID.Focus();
                enable();
                colorMethod();

            }
            if (richTextBox1.Text == "Level" || richTextBox1.Text == "Reorder")
            {
                textBoxReorderLevel.Focus();
                enable();
                colorMethod();

            }
            if (richTextBox1.Text == "Order" || richTextBox1.Text == "Unit")
            {
                textBoxUnitsOnOrder.Focus();
                enable();
                colorMethod();

            }
            if (richTextBox1.Text == "Date" || richTextBox1.Text == "Day")
            {
                maskedTextBox1.Focus();
                enable();
                colorMethod();

            }
            if (richTextBox1.Text == "Date" || richTextBox1.Text == "Day")
            {
                maskedTextBox1.Focus();
                maskedTextBox1.Text = DateTime.Now.ToShortDateString();
                enable();
                colorMethod();

            }
            if (richTextBox1.Text == "State" || richTextBox1.Text == "Status")
            {
                comboBox1.Focus();
                comboBox1.Text = "Active";
                enable();
                colorMethod();

            }
            if (richTextBox1.Text == "Exit" || richTextBox1.Text == "Exits")
            {
                timer1.Stop();
                Application.Exit();
            }

            if (richTextBox1.Text == "Paint")
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
            timer1.Start();
        }

        private void maskedTextBox1_BackColorChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.BackColor == Color.DarkSeaGreen)
            {
                maskedTextBox1.Text = DateTime.Now.ToString("dd.mm.yyyy");
            }
        }

        private void comboBox1_BackColorChanged(object sender, EventArgs e)
        {
            if (comboBox1.BackColor == Color.DarkSeaGreen)
            {
                comboBox1.Text = ("Active");
            }
        }

        private void lblPleaseWait_TextChanged(object sender, EventArgs e)
        {
            SpVoice spVoice = new SpVoice();
            spVoice.Speak(lblPleaseWait.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
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
    }
}
