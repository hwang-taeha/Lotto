namespace LottoQuiz
{
    partial class FrmOrder
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GridOddOrEven = new System.Windows.Forms.DataGridView();
            this.btnGridVisible = new System.Windows.Forms.Button();
            this.btnChartVisible = new System.Windows.Forms.Button();
            this.btnSection = new System.Windows.Forms.Button();
            this.btnAdmit = new System.Windows.Forms.Button();
            this.gridSection = new System.Windows.Forms.DataGridView();
            this.nmcSection = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartSection = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOddOrEven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSection)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(630, 531);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // GridOddOrEven
            // 
            this.GridOddOrEven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOddOrEven.Location = new System.Drawing.Point(0, 0);
            this.GridOddOrEven.Name = "GridOddOrEven";
            this.GridOddOrEven.RowTemplate.Height = 23;
            this.GridOddOrEven.Size = new System.Drawing.Size(630, 531);
            this.GridOddOrEven.TabIndex = 1;
            this.GridOddOrEven.Visible = false;
            // 
            // btnGridVisible
            // 
            this.btnGridVisible.Location = new System.Drawing.Point(636, 41);
            this.btnGridVisible.Name = "btnGridVisible";
            this.btnGridVisible.Size = new System.Drawing.Size(172, 23);
            this.btnGridVisible.TabIndex = 2;
            this.btnGridVisible.Text = "홀짝 통계 차트";
            this.btnGridVisible.UseVisualStyleBackColor = true;
            this.btnGridVisible.Click += new System.EventHandler(this.btnGridVisible_Click);
            // 
            // btnChartVisible
            // 
            this.btnChartVisible.Location = new System.Drawing.Point(636, 70);
            this.btnChartVisible.Name = "btnChartVisible";
            this.btnChartVisible.Size = new System.Drawing.Size(172, 23);
            this.btnChartVisible.TabIndex = 3;
            this.btnChartVisible.Text = "회차별 홀짝 통계";
            this.btnChartVisible.UseVisualStyleBackColor = true;
            this.btnChartVisible.Click += new System.EventHandler(this.btnChartVisible_Click);
            // 
            // btnSection
            // 
            this.btnSection.Location = new System.Drawing.Point(636, 12);
            this.btnSection.Name = "btnSection";
            this.btnSection.Size = new System.Drawing.Size(172, 23);
            this.btnSection.TabIndex = 4;
            this.btnSection.Text = "구간별 통계 차트";
            this.btnSection.UseVisualStyleBackColor = true;
            this.btnSection.Click += new System.EventHandler(this.btnSection_Click);
            // 
            // btnAdmit
            // 
            this.btnAdmit.Location = new System.Drawing.Point(742, 496);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(75, 23);
            this.btnAdmit.TabIndex = 7;
            this.btnAdmit.Text = "확인";
            this.btnAdmit.UseVisualStyleBackColor = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // gridSection
            // 
            this.gridSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSection.Location = new System.Drawing.Point(0, 0);
            this.gridSection.Name = "gridSection";
            this.gridSection.RowTemplate.Height = 23;
            this.gridSection.Size = new System.Drawing.Size(630, 531);
            this.gridSection.TabIndex = 8;
            this.gridSection.Visible = false;
            // 
            // nmcSection
            // 
            this.nmcSection.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmcSection.Location = new System.Drawing.Point(675, 479);
            this.nmcSection.Maximum = new decimal(new int[] {
            834,
            0,
            0,
            0});
            this.nmcSection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmcSection.Name = "nmcSection";
            this.nmcSection.Size = new System.Drawing.Size(39, 21);
            this.nmcSection.TabIndex = 9;
            this.nmcSection.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(640, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "최근";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(720, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "주간 구간별 당첨";
            // 
            // chartSection
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSection.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSection.Legends.Add(legend2);
            this.chartSection.Location = new System.Drawing.Point(0, 0);
            this.chartSection.Name = "chartSection";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartSection.Series.Add(series2);
            this.chartSection.Size = new System.Drawing.Size(630, 531);
            this.chartSection.TabIndex = 12;
            this.chartSection.Text = "chart2";
            this.chartSection.Visible = false;
            this.chartSection.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartSection_MouseMove);
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 531);
            this.Controls.Add(this.chartSection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmcSection);
            this.Controls.Add(this.gridSection);
            this.Controls.Add(this.btnAdmit);
            this.Controls.Add(this.btnSection);
            this.Controls.Add(this.btnChartVisible);
            this.Controls.Add(this.btnGridVisible);
            this.Controls.Add(this.GridOddOrEven);
            this.Controls.Add(this.chart1);
            this.Name = "FrmOrder";
            this.Text = "로또통계";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOddOrEven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView GridOddOrEven;
        private System.Windows.Forms.Button btnGridVisible;
        private System.Windows.Forms.Button btnChartVisible;
        private System.Windows.Forms.Button btnSection;
        private System.Windows.Forms.Button btnAdmit;
        private System.Windows.Forms.DataGridView gridSection;
        private System.Windows.Forms.NumericUpDown nmcSection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSection;
    }
}