using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace ProjektB
{
    public static class Chart
    {
        public static List<decimal> temperature = new List<decimal>();
        public static List<string> time = new List<string>();

        private static string ObtainDataToString()
        {
            string result = "";
            WebClient client = new WebClient();

            Stream obtainedData = client.OpenRead("https://www.yr.no/place/Czech_Republic/Moravia-Silesia/Ostrava/forecast.xml");
            StreamReader reader = new StreamReader(obtainedData);

            string s = reader.ReadToEnd();

            result = result + s;

            obtainedData.Close();
            reader.Close();

            return result;
        }

        public static void SaveData()
        {
            CultureInfo cultureInfo = new CultureInfo("cs-CZ");
            cultureInfo.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = cultureInfo;

            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(ObtainDataToString());

            var tempElements = xDoc.GetElementsByTagName("temperature");
            var timeElements = xDoc.GetElementsByTagName("time");

            foreach (XmlElement element in tempElements)
            {
                temperature.Add(decimal.Parse(element.GetAttribute("value")));
            }

            foreach (XmlElement element in timeElements)
            {
                string parsed = element.GetAttribute("from").ToString().Replace("T", " ").Trim();
                DateTime par1 = DateTime.Parse(parsed);

                parsed = element.GetAttribute("to").ToString().Replace("T", " ").Trim();
                DateTime par2 = DateTime.Parse(parsed);

                string res = par1.Hour.ToString("00") + ":" + par1.Minute.ToString("00") + "-" + par2.Hour.ToString("00") + ":" + par2.Minute.ToString("00");
                time.Add(res);
            }
        }
    }
}
