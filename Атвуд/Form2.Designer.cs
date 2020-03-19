namespace Атвуд
{
	partial class Form2
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
         System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
         System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
         System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
         this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
         ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
         this.SuspendLayout();
         // 
         // chart1
         // 
         this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         chartArea1.Name = "ChartArea1";
         this.chart1.ChartAreas.Add(chartArea1);
         legend1.Name = "Legend1";
         this.chart1.Legends.Add(legend1);
         this.chart1.Location = new System.Drawing.Point(16, 15);
         this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.chart1.Name = "chart1";
         series1.ChartArea = "ChartArea1";
         series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
         series1.Legend = "Legend1";
         series1.LegendText = "Скорость";
         series1.Name = "Series1";
         series2.ChartArea = "ChartArea1";
         series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
         series2.Legend = "Legend1";
         series2.LegendText = "Кинетическая энергия 1 груза";
         series2.Name = "Series2";
         series3.ChartArea = "ChartArea1";
         series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
         series3.Legend = "Legend1";
         series3.LegendText = "Кинетическая энергия 2 груза";
         series3.Name = "Series3";
         this.chart1.Series.Add(series1);
         this.chart1.Series.Add(series2);
         this.chart1.Series.Add(series3);
         this.chart1.Size = new System.Drawing.Size(1049, 524);
         this.chart1.TabIndex = 0;
         this.chart1.Text = "chart1";
         title1.Name = "Title1";
         title1.Text = "Зависимости от времени";
         this.chart1.Titles.Add(title1);
         this.chart1.UseWaitCursor = true;
         this.chart1.Click += new System.EventHandler(this.chart1_Click);
         // 
         // Form2
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1067, 554);
         this.Controls.Add(this.chart1);
         this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Name = "Form2";
         this.Text = "Графики";
         this.Load += new System.EventHandler(this.Form2_Load);
         ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
         this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
	}
}