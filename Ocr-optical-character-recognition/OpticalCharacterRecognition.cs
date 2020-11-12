using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Ocr_optical_character_recognition
{
    public partial class OpticalCharacterRecognition : Form
    {
        public OpticalCharacterRecognition()
        {
            InitializeComponent();
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            var orc = new AutoOcr();
            var result = orc.Read(pictureBox1.Image);
            richTextBox1.Text = result.Text;
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            PdfWriter.GetInstance(document, new FileStream("D:Document.pdf", FileMode.Create));
            
            if (document.IsOpen()== false)
            {
                document.Open();
            }
            document.Add(new Paragraph(richTextBox1.Text));
            //document.Close();
        }
    }
}
