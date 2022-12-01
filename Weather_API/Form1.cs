using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Weather_API
{
    public partial class Form1 : Form
    {
        private string apikey { get; }
        public Form1()
        {
            InitializeComponent();
            this.apikey = "********************";
        }

        private void btnShowCloud_Click(object sender, EventArgs e)
        {
            string uri = String.Format("http://api.weatherapi.com/v1/forecast.xml?key=96e3888824724493826191411222511&q={0}&days=1&aqi=no&alerts=no", city);
            
            API apiOneDay = new API(this.apikey, txtCity.Text, 1);
            
            string maxTemp_c = apiOneDay.XMLItemToStr("maxtemp_c");
            string minTemp_c = apiOneDay.XMLItemToStr("mintemp_c");
            string maxWindSpeed_kph = apiOneDay.XMLItemToStr("maxwind_kph");
            string maxWindSpeed_mph = apiOneDay.XMLItemToStr("maxwind_mph");
            string humidity = apiOneDay.XMLItemToStr("avghumidity");
            string country = apiOneDay.XMLItemToStr("country");
            string cloud = apiOneDay.XMLItemToStr("text");
            string iconUri = apiOneDay.XMLItemToStr("icon");

            Bitmap icon = apiOneDay.GetIconBitmap(iconUri);

            lblCountry.Text = country;
            txtMaxTemp.Text = maxTemp_c;
            txtMinTemp.Text = minTemp_c;
            txtWindSpdMph.Text = maxWindSpeed_mph;
            txtWindSpdKph.Text = maxWindSpeed_kph;
            txtHumidity.Text = humidity;
            lblCloudState.Text = cloud;
            picCloud.Image = icon;
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            API apiWeek = new API(this.apikey, txtCity.Text, 7);
            string[] colNames = new string[]
            {
                "Country", "Date", "Max temp",
                "Min temp", "Max wind mph", "Max wind kph",
                "Humidity", "Cloud"
            };

            DataTable dt = apiWeek.GenerateDt(colNames);
            dgvDays.DataSource = dt;
        }
    }
}
