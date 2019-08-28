namespace ImportCSV
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10000D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 30000D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2000D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10000D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 30000D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2000D);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelStatistic = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label1_1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label2_1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label3_1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label4_1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label5_1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label6_1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label7_1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label8_1 = new System.Windows.Forms.Label();
            this.groupBoxVisualizations = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxStatistics.SuspendLayout();
            this.tableLayoutPanelStatistic.SuspendLayout();
            this.groupBoxVisualizations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(620, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(476, 400);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBoxStatistics, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxVisualizations, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(640, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(150, 430);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBoxStatistics
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBoxStatistics, 2);
            this.groupBoxStatistics.Controls.Add(this.tableLayoutPanelStatistic);
            this.groupBoxStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxStatistics.Location = new System.Drawing.Point(2, 2);
            this.groupBoxStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(146, 211);
            this.groupBoxStatistics.TabIndex = 0;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "Statistics";
            // 
            // tableLayoutPanelStatistic
            // 
            this.tableLayoutPanelStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelStatistic.ColumnCount = 2;
            this.tableLayoutPanelStatistic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanelStatistic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanelStatistic.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelStatistic.Controls.Add(this.label1_1, 1, 0);
            this.tableLayoutPanelStatistic.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelStatistic.Controls.Add(this.label2_1, 1, 1);
            this.tableLayoutPanelStatistic.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanelStatistic.Controls.Add(this.label3_1, 1, 2);
            this.tableLayoutPanelStatistic.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanelStatistic.Controls.Add(this.label4_1, 1, 3);
            this.tableLayoutPanelStatistic.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanelStatistic.Controls.Add(this.label5_1, 1, 4);
            this.tableLayoutPanelStatistic.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanelStatistic.Controls.Add(this.label6_1, 1, 5);
            this.tableLayoutPanelStatistic.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanelStatistic.Controls.Add(this.label7_1, 1, 6);
            this.tableLayoutPanelStatistic.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanelStatistic.Controls.Add(this.label8_1, 1, 7);
            this.tableLayoutPanelStatistic.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanelStatistic.Name = "tableLayoutPanelStatistic";
            this.tableLayoutPanelStatistic.RowCount = 2;
            this.tableLayoutPanelStatistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelStatistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelStatistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelStatistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelStatistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelStatistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelStatistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelStatistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelStatistic.Size = new System.Drawing.Size(142, 202);
            this.tableLayoutPanelStatistic.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mean";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1_1
            // 
            this.label1_1.AutoSize = true;
            this.label1_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1_1.Location = new System.Drawing.Point(141, 0);
            this.label1_1.Name = "label1_1";
            this.label1_1.Size = new System.Drawing.Size(9, 20);
            this.label1_1.TabIndex = 1;
            this.label1_1.Text = "1234";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Median";
            // 
            // label2_1
            // 
            this.label2_1.AutoSize = true;
            this.label2_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2_1.Location = new System.Drawing.Point(141, 20);
            this.label2_1.Name = "label2_1";
            this.label2_1.Size = new System.Drawing.Size(9, 20);
            this.label2_1.TabIndex = 3;
            this.label2_1.Text = "111";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3_1
            // 
            this.label3_1.AutoSize = true;
            this.label3_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3_1.Location = new System.Drawing.Point(141, 40);
            this.label3_1.Name = "label3_1";
            this.label3_1.Size = new System.Drawing.Size(9, 20);
            this.label3_1.TabIndex = 5;
            this.label3_1.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Max";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4_1
            // 
            this.label4_1.AutoSize = true;
            this.label4_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4_1.Location = new System.Drawing.Point(141, 60);
            this.label4_1.Name = "label4_1";
            this.label4_1.Size = new System.Drawing.Size(9, 20);
            this.label4_1.TabIndex = 7;
            this.label4_1.Text = "2222";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(3, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Standard Deviation";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5_1
            // 
            this.label5_1.AutoSize = true;
            this.label5_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5_1.Location = new System.Drawing.Point(141, 80);
            this.label5_1.Name = "label5_1";
            this.label5_1.Size = new System.Drawing.Size(9, 20);
            this.label5_1.TabIndex = 9;
            this.label5_1.Text = "22";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(3, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Unique Values";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6_1
            // 
            this.label6_1.AutoSize = true;
            this.label6_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6_1.Location = new System.Drawing.Point(141, 100);
            this.label6_1.Name = "label6_1";
            this.label6_1.Size = new System.Drawing.Size(9, 15);
            this.label6_1.TabIndex = 11;
            this.label6_1.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(3, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Missing Values";
            // 
            // label7_1
            // 
            this.label7_1.AutoSize = true;
            this.label7_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7_1.Location = new System.Drawing.Point(141, 120);
            this.label7_1.Name = "label7_1";
            this.label7_1.Size = new System.Drawing.Size(9, 20);
            this.label7_1.TabIndex = 13;
            this.label7_1.Text = "65432";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(3, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Feature Type";
            // 
            // label8_1
            // 
            this.label8_1.AutoSize = true;
            this.label8_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8_1.Location = new System.Drawing.Point(141, 140);
            this.label8_1.Name = "label8_1";
            this.label8_1.Size = new System.Drawing.Size(9, 62);
            this.label8_1.TabIndex = 15;
            this.label8_1.Text = "Numeric";
            // 
            // groupBoxVisualizations
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBoxVisualizations, 2);
            this.groupBoxVisualizations.Controls.Add(this.chart1);
            this.groupBoxVisualizations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxVisualizations.Location = new System.Drawing.Point(2, 217);
            this.groupBoxVisualizations.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxVisualizations.Name = "groupBoxVisualizations";
            this.groupBoxVisualizations.Size = new System.Drawing.Size(146, 211);
            this.groupBoxVisualizations.TabIndex = 1;
            this.groupBoxVisualizations.TabStop = false;
            this.groupBoxVisualizations.Text = "Visualizations";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(3, 21);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.AxisLabel = "1";
            dataPoint2.AxisLabel = "2";
            dataPoint3.AxisLabel = "3";
            dataPoint4.AxisLabel = "4";
            dataPoint5.AxisLabel = "5";
            dataPoint6.AxisLabel = "6";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(140, 187);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBoxStatistics.ResumeLayout(false);
            this.tableLayoutPanelStatistic.ResumeLayout(false);
            this.tableLayoutPanelStatistic.PerformLayout();
            this.groupBoxVisualizations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxStatistics;
        private System.Windows.Forms.GroupBox groupBoxVisualizations;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStatistic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label1_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label2_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label3_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label4_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label5_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label6_1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label7_1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label8_1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

