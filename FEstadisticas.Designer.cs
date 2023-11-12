
namespace TP2_Lab
{
    partial class FEstadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cTorta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.gBxTorta = new System.Windows.Forms.GroupBox();
            this.gBxBarras = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.cTorta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBarras)).BeginInit();
            this.gBxTorta.SuspendLayout();
            this.gBxBarras.SuspendLayout();
            this.SuspendLayout();
            // 
            // cTorta
            // 
            chartArea3.Name = "ChartArea1";
            this.cTorta.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cTorta.Legends.Add(legend3);
            this.cTorta.Location = new System.Drawing.Point(42, 56);
            this.cTorta.Name = "cTorta";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.cTorta.Series.Add(series3);
            this.cTorta.Size = new System.Drawing.Size(350, 222);
            this.cTorta.TabIndex = 0;
            this.cTorta.Text = "chart1";
            // 
            // cBarras
            // 
            chartArea4.Name = "ChartArea1";
            this.cBarras.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.cBarras.Legends.Add(legend4);
            this.cBarras.Location = new System.Drawing.Point(35, 37);
            this.cBarras.Name = "cBarras";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.cBarras.Series.Add(series4);
            this.cBarras.Size = new System.Drawing.Size(380, 232);
            this.cBarras.TabIndex = 1;
            this.cBarras.Text = "chart2";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(261, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gBxTorta
            // 
            this.gBxTorta.Controls.Add(this.gBxBarras);
            this.gBxTorta.Controls.Add(this.cTorta);
            this.gBxTorta.Location = new System.Drawing.Point(108, 29);
            this.gBxTorta.Name = "gBxTorta";
            this.gBxTorta.Size = new System.Drawing.Size(511, 329);
            this.gBxTorta.TabIndex = 3;
            this.gBxTorta.TabStop = false;
            this.gBxTorta.Text = "Grafico Torta";
            // 
            // gBxBarras
            // 
            this.gBxBarras.Controls.Add(this.cBarras);
            this.gBxBarras.Location = new System.Drawing.Point(78, 9);
            this.gBxBarras.Name = "gBxBarras";
            this.gBxBarras.Size = new System.Drawing.Size(511, 314);
            this.gBxBarras.TabIndex = 4;
            this.gBxBarras.TabStop = false;
            this.gBxBarras.Text = "Graficos Barras";
            // 
            // FEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.gBxTorta);
            this.Controls.Add(this.button1);
            this.Name = "FEstadisticas";
            this.Text = "FEstadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.cTorta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBarras)).EndInit();
            this.gBxTorta.ResumeLayout(false);
            this.gBxBarras.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataVisualization.Charting.Chart cBarras;
        public System.Windows.Forms.DataVisualization.Charting.Chart cTorta;
        public System.Windows.Forms.GroupBox gBxTorta;
        public System.Windows.Forms.GroupBox gBxBarras;
    }
}