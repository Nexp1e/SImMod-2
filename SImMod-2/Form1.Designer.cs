namespace SImMod_2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelInputCur1 = new System.Windows.Forms.Label();
            this.inputCur1 = new System.Windows.Forms.NumericUpDown();
            this.inputCur2 = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.checkbox1 = new System.Windows.Forms.CheckBox();
            this.checkboxDisplayValues = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCur1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCur2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(12, 38);
            this.chart1.Name = "chart1";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Red;
            series7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series7.IsValueShownAsLabel = true;
            series7.LabelForeColor = System.Drawing.Color.Red;
            series7.Legend = "Legend1";
            series7.Name = "Currency 1";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Green;
            series8.IsValueShownAsLabel = true;
            series8.LabelForeColor = System.Drawing.Color.Green;
            series8.Legend = "Legend1";
            series8.Name = "Currency 2";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(859, 367);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // labelInputCur1
            // 
            this.labelInputCur1.AutoSize = true;
            this.labelInputCur1.Location = new System.Drawing.Point(14, 14);
            this.labelInputCur1.Name = "labelInputCur1";
            this.labelInputCur1.Size = new System.Drawing.Size(65, 13);
            this.labelInputCur1.TabIndex = 1;
            this.labelInputCur1.Text = "Initial prices:";
            // 
            // inputCur1
            // 
            this.inputCur1.DecimalPlaces = 4;
            this.inputCur1.Location = new System.Drawing.Point(113, 12);
            this.inputCur1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.inputCur1.Name = "inputCur1";
            this.inputCur1.Size = new System.Drawing.Size(120, 20);
            this.inputCur1.TabIndex = 2;
            this.inputCur1.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // inputCur2
            // 
            this.inputCur2.DecimalPlaces = 4;
            this.inputCur2.Location = new System.Drawing.Point(285, 12);
            this.inputCur2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.inputCur2.Name = "inputCur2";
            this.inputCur2.Size = new System.Drawing.Size(120, 20);
            this.inputCur2.TabIndex = 4;
            this.inputCur2.Value = new decimal(new int[] {
            87,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(796, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start/Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSize = true;
            this.checkbox1.Location = new System.Drawing.Point(430, 13);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(134, 17);
            this.checkbox1.TabIndex = 6;
            this.checkbox1.Text = "Show only last 10 days";
            this.checkbox1.UseVisualStyleBackColor = true;
            this.checkbox1.CheckedChanged += new System.EventHandler(this.checkbox1_CheckedChanged);
            // 
            // checkboxDisplayValues
            // 
            this.checkboxDisplayValues.AutoSize = true;
            this.checkboxDisplayValues.Checked = true;
            this.checkboxDisplayValues.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxDisplayValues.Location = new System.Drawing.Point(613, 13);
            this.checkboxDisplayValues.Name = "checkboxDisplayValues";
            this.checkboxDisplayValues.Size = new System.Drawing.Size(136, 17);
            this.checkboxDisplayValues.TabIndex = 8;
            this.checkboxDisplayValues.Text = "Display values on chart";
            this.checkboxDisplayValues.UseVisualStyleBackColor = true;
            this.checkboxDisplayValues.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 417);
            this.Controls.Add(this.checkboxDisplayValues);
            this.Controls.Add(this.checkbox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputCur2);
            this.Controls.Add(this.inputCur1);
            this.Controls.Add(this.labelInputCur1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCur1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCur2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelInputCur1;
        private System.Windows.Forms.NumericUpDown inputCur1;
        private System.Windows.Forms.NumericUpDown inputCur2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkbox1;
        private System.Windows.Forms.CheckBox checkboxDisplayValues;
    }
}

