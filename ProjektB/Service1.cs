using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjektB
{
    public partial class Service1 : ServiceBase
    {
        private Timer timer1 = null;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Chart.SaveData();

            int i = 0;
            foreach (double temp in Chart.temperature)
            {
                Series ser = this.tempGraph.Series.Add(Chart.time[i++]);
                ser.Points.Add(temp);
            }

            this.tempGraph.SaveImage(AppDomain.CurrentDomain.BaseDirectory + "weather.png", ChartImageFormat.Png);
            tempGraph.Titles.Add("Temperatures");

            try { MailMonkey.SendMail(); }
            catch (Exception ex)
            {
                using (StreamWriter wr = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "log.txt"))
                {
                    wr.WriteLine(ex);
                    wr.Close();
                }
            }
        }
    }
}
