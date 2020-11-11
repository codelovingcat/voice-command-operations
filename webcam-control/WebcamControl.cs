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

namespace webcam_control
{
    public partial class WebcamControl : Form
    {
        public WebcamControl()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfo;
        VideoCaptureDevice videoCapture;
        private void Form1_Load(object sender, EventArgs e)
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
            if (result==DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFile.FileName);
            }
        }
    }
}
