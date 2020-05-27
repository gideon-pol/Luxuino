namespace LedController
{
    partial class Audio
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.devices = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.coef = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.toggleButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.audioRgb = new System.Windows.Forms.TextBox();
            this.audioHsv = new System.Windows.Forms.TextBox();
            this.audioHex = new System.Windows.Forms.TextBox();
            this.audioColorWheel = new ColorPickers.ColorWheel();
            this.panelTo = new System.Windows.Forms.Panel();
            this.panelFrom = new System.Windows.Forms.Panel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.audioSensitivity = new System.Windows.Forms.TextBox();
            this.autoSensitivity = new MetroFramework.Controls.MetroCheckBox();
            this.alternativeMode = new MetroFramework.Controls.MetroCheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // devices
            // 
            this.devices.FormattingEnabled = true;
            this.devices.ItemHeight = 23;
            this.devices.Location = new System.Drawing.Point(83, 176);
            this.devices.Name = "devices";
            this.devices.Size = new System.Drawing.Size(155, 29);
            this.devices.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 181);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Device:";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(200, 152);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart2";
            // 
            // coef
            // 
            this.coef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coef.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.coef.Location = new System.Drawing.Point(83, 251);
            this.coef.Name = "coef";
            this.coef.Size = new System.Drawing.Size(113, 32);
            this.coef.TabIndex = 18;
            this.coef.Text = "2";
            this.coef.KeyDown += new System.Windows.Forms.KeyEventHandler(this.coeff_KeyDown);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 258);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Coefficient:";
            // 
            // toggleButton
            // 
            this.toggleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.toggleButton.Location = new System.Drawing.Point(460, 286);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(113, 46);
            this.toggleButton.TabIndex = 21;
            this.toggleButton.Text = "Start";
            this.toggleButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleButton.Click += new System.EventHandler(this.toggleButton_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(413, 90);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "HSV:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(411, 52);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "RGB:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(362, 12);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(87, 19);
            this.metroLabel5.TabIndex = 27;
            this.metroLabel5.Text = "Hexadecimal:";
            // 
            // audioRgb
            // 
            this.audioRgb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.audioRgb.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.audioRgb.Location = new System.Drawing.Point(454, 45);
            this.audioRgb.Name = "audioRgb";
            this.audioRgb.Size = new System.Drawing.Size(113, 32);
            this.audioRgb.TabIndex = 25;
            this.audioRgb.Text = "0,0,255";
            this.audioRgb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.audioRgb_KeyDown);
            // 
            // audioHsv
            // 
            this.audioHsv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.audioHsv.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.audioHsv.Location = new System.Drawing.Point(454, 84);
            this.audioHsv.Name = "audioHsv";
            this.audioHsv.Size = new System.Drawing.Size(113, 32);
            this.audioHsv.TabIndex = 26;
            this.audioHsv.Text = "0,0,0";
            this.audioHsv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.audioHsv_KeyDown);
            // 
            // audioHex
            // 
            this.audioHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.audioHex.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.audioHex.Location = new System.Drawing.Point(454, 3);
            this.audioHex.Name = "audioHex";
            this.audioHex.Size = new System.Drawing.Size(113, 36);
            this.audioHex.TabIndex = 24;
            this.audioHex.Text = "#000000";
            this.audioHex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.audioHex_KeyDown);
            // 
            // audioColorWheel
            // 
            this.audioColorWheel.BackColor = System.Drawing.Color.White;
            this.audioColorWheel.Framerate = 30;
            this.audioColorWheel.InnerTriangleRadius = 0.7F;
            this.audioColorWheel.InnerWhiteRadius = 0.8F;
            this.audioColorWheel.Location = new System.Drawing.Point(212, 8);
            this.audioColorWheel.Name = "audioColorWheel";
            this.audioColorWheel.Outlinecolor = System.Drawing.Color.White;
            this.audioColorWheel.Outlinewidth = 2.5F;
            this.audioColorWheel.PickedColor = System.Drawing.Color.Black;
            this.audioColorWheel.RingMarkersize = 1.3F;
            this.audioColorWheel.Size = new System.Drawing.Size(150, 150);
            this.audioColorWheel.SizeMultiplier = 0.95F;
            this.audioColorWheel.TabIndex = 23;
            this.audioColorWheel.TriangleMarkersize = 0.15F;
            this.audioColorWheel.ColorChanged += new ColorPickers.ColorWheel.Handler(this.audioColorWheel_ColorChanged);
            // 
            // panelTo
            // 
            this.panelTo.BackColor = System.Drawing.Color.Red;
            this.panelTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTo.Location = new System.Drawing.Point(454, 179);
            this.panelTo.Name = "panelTo";
            this.panelTo.Size = new System.Drawing.Size(113, 32);
            this.panelTo.TabIndex = 31;
            this.panelTo.Click += new System.EventHandler(this.panelTo_Click);
            // 
            // panelFrom
            // 
            this.panelFrom.BackColor = System.Drawing.Color.Black;
            this.panelFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelFrom.Location = new System.Drawing.Point(454, 141);
            this.panelFrom.Name = "panelFrom";
            this.panelFrom.Size = new System.Drawing.Size(113, 32);
            this.panelFrom.TabIndex = 30;
            this.panelFrom.Click += new System.EventHandler(this.panelFrom_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(370, 147);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(78, 19);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Color from:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(387, 186);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(61, 19);
            this.metroLabel7.TabIndex = 33;
            this.metroLabel7.Text = "Color to:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(9, 219);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(67, 19);
            this.metroLabel8.TabIndex = 35;
            this.metroLabel8.Text = "Sensitivity:";
            // 
            // audioSensitivity
            // 
            this.audioSensitivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.audioSensitivity.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.audioSensitivity.Location = new System.Drawing.Point(83, 213);
            this.audioSensitivity.Name = "audioSensitivity";
            this.audioSensitivity.Size = new System.Drawing.Size(113, 32);
            this.audioSensitivity.TabIndex = 34;
            this.audioSensitivity.Text = "2";
            this.audioSensitivity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.audioSensitivity_KeyDown);
            // 
            // autoSensitivity
            // 
            this.autoSensitivity.AutoSize = true;
            this.autoSensitivity.Checked = true;
            this.autoSensitivity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoSensitivity.Location = new System.Drawing.Point(202, 213);
            this.autoSensitivity.Name = "autoSensitivity";
            this.autoSensitivity.Size = new System.Drawing.Size(101, 15);
            this.autoSensitivity.TabIndex = 36;
            this.autoSensitivity.Text = "Autosensitivity";
            this.autoSensitivity.UseVisualStyleBackColor = true;
            // 
            // alternativeMode
            // 
            this.alternativeMode.AutoSize = true;
            this.alternativeMode.Location = new System.Drawing.Point(202, 230);
            this.alternativeMode.Name = "alternativeMode";
            this.alternativeMode.Size = new System.Drawing.Size(114, 15);
            this.alternativeMode.TabIndex = 37;
            this.alternativeMode.Text = "Alternative mode";
            this.alternativeMode.UseVisualStyleBackColor = true;
            this.alternativeMode.CheckedChanged += new System.EventHandler(this.alternativeMode_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Audio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.alternativeMode);
            this.Controls.Add(this.autoSensitivity);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.audioSensitivity);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.panelTo);
            this.Controls.Add(this.panelFrom);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.audioRgb);
            this.Controls.Add(this.audioHsv);
            this.Controls.Add(this.audioHex);
            this.Controls.Add(this.audioColorWheel);
            this.Controls.Add(this.toggleButton);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.coef);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.devices);
            this.Name = "Audio";
            this.Size = new System.Drawing.Size(582, 336);
            this.Load += new System.EventHandler(this.Audio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox devices;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox coef;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox audioRgb;
        private System.Windows.Forms.TextBox audioHsv;
        private System.Windows.Forms.TextBox audioHex;
        private ColorPickers.ColorWheel audioColorWheel;
        private System.Windows.Forms.Panel panelTo;
        private System.Windows.Forms.Panel panelFrom;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.TextBox audioSensitivity;
        private MetroFramework.Controls.MetroCheckBox autoSensitivity;
        private MetroFramework.Controls.MetroCheckBox alternativeMode;
        public System.Windows.Forms.Timer timer;
        public MetroFramework.Controls.MetroButton toggleButton;
    }
}
