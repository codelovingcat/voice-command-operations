using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using live_chart_geo_map;

namespace live_chart_geo_map
{
    public partial class LiveChart : Form
    {
        public LiveChart()
        {
            InitializeComponent();
        }

        private void LiveChart_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();
            Dictionary<string, double> valuePairs = new Dictionary<string, double>();
            valuePairs["TR"] = 1000;
            valuePairs["RU"] = 50;
            valuePairs["FR"] = 10;
            valuePairs["CZ"] = 10;
            valuePairs["US"] = 5;
            geoMap.HeatMap = valuePairs;
            geoMap.Source = $"{Application.StartupPath}\\World.xml";
            this.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;
            geoMap.BackColor = Color.Blue;
            //event handler oluşturuyorum.
            geoMap.LandClick += GeoMap_LandClick;

            //Zoom yapılabilmesine izin veriyorum. Mouse ile zoom yapabilirsiniz.
            geoMap.EnableZoomingAndPanning = true;

            //ülke sınırlarını belirginleştirmek için aşağıdaki metodu kullanabilirsiniz.
            geoMap.LandStrokeThickness = 3;

            //Mouse Hover ile ülkelere ait gelen veri değerlerine okuma iznini açıyorum.
            geoMap.Hoverable = true;
        }
        private void GeoMap_LandClick(object arg1, LiveCharts.Maps.MapData arg2)
        {
            //üzerine tıklanan ülkenin adını göstermesini sağlıyorum.
            MessageBox.Show(arg2.Name);

        }
        private void btnTurkey_Click(object sender, EventArgs e)
        {
            TurkeyMap turkeyMap = new TurkeyMap();
            turkeyMap.Show();
        }
    }
}
