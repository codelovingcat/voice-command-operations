using Alturos.Yolo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voice_asist_user_interface
{
    public partial class Object_Detection : Form
    {
        public Object_Detection()
        {
            InitializeComponent();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnDetection_Click(object sender, EventArgs e)
        {
            var configurationDetector = new ConfigurationDetector();
            var config = configurationDetector.Detect();
            using (var yoloWrapper = new YoloWrapper(config))
            {
                using (MemoryStream ms =new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                    var item = yoloWrapper.Detect(ms.ToArray());
                    yoloItemBindingSource.DataSource = item;
                }
                
            }
        }
    }
}

//var configurationDetector = new ConfigurationDetector();
//var config = configurationDetector.Detect();
//using (var yoloWrapper = new YoloWrapper(config))
//{
    //var items = yoloWrapper.Detect(@"image.jpg");
    //items[0].Type -> "Person, Car, ..."
    //items[0].Confidence -> 0.0 (low) -> 1.0 (high)
    //items[0].X -> bounding box
    //items[0].Y -> bounding box
    //items[0].Width -> bounding box
    //items[0].Height -> bounding box
//}
