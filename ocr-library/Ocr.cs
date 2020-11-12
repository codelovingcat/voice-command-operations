using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace ocr_library
{
    public partial class Ocr : Form
    {
        public Ocr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                var image = new Bitmap(openFileDialog1.FileName);
                var ocr = new TesseractEngine("./tessdata", "eng");
                var result = ocr.Process(image);
                richTextBox1.Text = result.GetText();
            }
        }
    }
}
