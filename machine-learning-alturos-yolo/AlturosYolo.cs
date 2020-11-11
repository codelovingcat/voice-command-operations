using Alturos.Yolo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace machine_learning_alturos_yolo
{
    public partial class AlturosYolo : Form
    {
        public AlturosYolo()
        {
            InitializeComponent();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void btnDetection_Click(object sender, EventArgs e)
        {
            var configurationDetector = new ConfigurationDetector();
            var config = configurationDetector.Detect();
            using (var yoloWrapper = new YoloWrapper(config))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    pictureBox1.Image.Save(memoryStream, ImageFormat.Png);
                    var items = yoloWrapper.Detect(memoryStream.ToArray());
                    yoloItemBindingSource.DataSource = items;
                }
            }

        }
    }
}
