using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace live_chart_geo_map
{
    public partial class TurkeyMap : Form
    {
        public TurkeyMap()
        {
            InitializeComponent();
        }

        private void TurkeyMap_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();
            Dictionary<string, double> valuePairs = new Dictionary<string, double>();
            valuePairs["2146"] = 1000;
            valuePairs["3060"] = 50;
            valuePairs["2141"] = 10;
            valuePairs["2139"] = 10;
            valuePairs["2143"] = 5;
            geoMap.HeatMap = valuePairs;
            geoMap.Source = $"{Application.StartupPath}\\Turkey.xml";
            this.Controls.Add(geoMap);
            geoMap.BackColor= Color.Green;
            geoMap.Dock = DockStyle.Fill;

            //event handler oluşturuyorum.
            geoMap.LandClick += GeoMap_LandClick;

            //Zoom yapılabilmesine izin veriyorum.
            geoMap.EnableZoomingAndPanning = true;

            //ülke sınırlarını belirginleştirmek için.
            geoMap.LandStrokeThickness = 3;

            //Mouse Hover ile ülkelere ait gelen veriler.
            geoMap.Hoverable = true;
        }
        private void GeoMap_LandClick(object arg1, LiveCharts.Maps.MapData arg2)
        {
            //üzerine tıklanan şehrin adını göster.
            MessageBox.Show(arg2.Name);

        }
        
    }
}
