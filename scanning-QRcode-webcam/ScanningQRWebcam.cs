using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace scanning_QRcode_webcam
{
    public partial class ScanningQRWebcam : Form
    {
        FilterInfoCollection filterInfo;
        VideoCaptureDevice videoCapture;
        public ScanningQRWebcam()
        {
            InitializeComponent();
        }

        private void ScanningQRWebcam_Load(object sender, EventArgs e)
        {
            filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in filterInfo)
            {
                comboBox1.Items.Add(item.Name);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void btnWebCame_Click(object sender, EventArgs e)
        {
            videoCapture = new VideoCaptureDevice(filterInfo[comboBox1.SelectedIndex].MonikerString);
            videoCapture.NewFrame += VideoCapture_NewFrame;       
            videoCapture.Start();
            timer1.Start();
        }

        private void VideoCapture_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnCatch_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "(*.jpg)|*.jpg";
            DialogResult result = saveFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFile.FileName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image!=null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    richTextBox1.Text = result.ToString();
                    timer1.Stop();
                }
            }
           
        }
    }
}
