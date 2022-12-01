using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net;
using System.IO;
using System.Xml.Linq;


namespace Weather_API
{
    //string uri = String.Format("http://api.weatherapi.com/v1/forecast.xml?key=96e3888824724493826191411222511&q={0}&days=1&aqi=no&alerts=no", city);
    class API
    {
        public string uri { get; }
        public string apikey { get; set; }
        public XDocument doc { get; set; }
        public string city { get; set; }
        public int days { get; set; }

        public API() { }
        public API(string apikey, string city, int days)
        {
            this.apikey = apikey;
            this.city = city;
            this.days = days;
            this.uri = String.Format("http://api.weatherapi.com/v1/forecast.xml?key={0}&q={1}&days={2}&aqi=no&alerts=no", this.apikey, city, days);
            this.doc = XDocument.Load(this.uri);
        }

        public string XMLItemToStr(string itemName)
        {

            return (string)this.doc.Descendants(itemName).FirstOrDefault();
        }

        public string GetXElement(string itemName, XElement xe)
        {
            return (string)xe.Descendants(itemName).FirstOrDefault();
        }

        public Bitmap GetIconBitmap(string iconUri)
        {
            WebClient client = new WebClient();
            byte[] image = client.DownloadData("http:" + iconUri);
            MemoryStream stream = new MemoryStream(image);
            Bitmap newBitMap = new Bitmap(stream);
            return newBitMap;
        }

        public DataTable GenerateDt(string[] cols)
        {
            DataTable dt = new DataTable();
            string updatedURI = uri;
            foreach(var column in cols)
            {
                dt.Columns.Add(column, typeof(string));
            }

            foreach (var npc in this.doc.Descendants("forecastday"))
            {
                dt.Rows.Add(new object[]
                    {
                        GetXElement("country", npc),
                        GetXElement("date", npc),
                        GetXElement("maxtemp_c", npc),
                        GetXElement("mintemp_c", npc),
                        GetXElement("maxwind_mph", npc),
                        GetXElement("maxwind_kph", npc),
                        GetXElement("avghumidity", npc),
                        GetXElement("text", npc)
                });
            }
            return dt;
        }
    }
}
