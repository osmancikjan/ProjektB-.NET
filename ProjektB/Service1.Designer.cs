namespace ProjektB
{
    partial class Service1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tempGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.tempGraph)).BeginInit();
            // 
            // tempGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.tempGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.tempGraph.Legends.Add(legend1);
            this.tempGraph.Location = new System.Drawing.Point(0, 0);
            this.tempGraph.Name = "tempGraph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.tempGraph.Series.Add(series1);
            this.tempGraph.Size = new System.Drawing.Size(300, 300);
            this.tempGraph.TabIndex = 0;
            this.tempGraph.Text = "temperatures";
            // 
            // Service1
            // 
            this.ServiceName = "Service1";
            ((System.ComponentModel.ISupportInitialize)(this.tempGraph)).EndInit();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart tempGraph;
    }
}
