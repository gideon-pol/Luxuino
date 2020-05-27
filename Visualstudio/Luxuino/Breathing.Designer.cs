namespace LedController
{
    partial class Breathing
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
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.breathingFreq = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.breathingPanel = new System.Windows.Forms.Panel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.breathingRgb = new System.Windows.Forms.TextBox();
            this.breathingHsv = new System.Windows.Forms.TextBox();
            this.breathingHex = new System.Windows.Forms.TextBox();
            this.breathingColorWheel = new ColorPickers.ColorWheel();
            this.SuspendLayout();
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(274, 163);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 19);
            this.metroLabel7.TabIndex = 35;
            this.metroLabel7.Text = "Pulse/sec:";
            // 
            // breathingFreq
            // 
            this.breathingFreq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.breathingFreq.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.breathingFreq.Location = new System.Drawing.Point(345, 157);
            this.breathingFreq.Name = "breathingFreq";
            this.breathingFreq.Size = new System.Drawing.Size(113, 32);
            this.breathingFreq.TabIndex = 34;
            this.breathingFreq.Text = "1";
            this.breathingFreq.KeyDown += new System.Windows.Forms.KeyEventHandler(this.breathingFreq_KeyDown);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(304, 102);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(36, 19);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "HSV:";
            // 
            // breathingPanel
            // 
            this.breathingPanel.BackColor = System.Drawing.Color.Red;
            this.breathingPanel.Location = new System.Drawing.Point(489, 45);
            this.breathingPanel.Name = "breathingPanel";
            this.breathingPanel.Size = new System.Drawing.Size(60, 60);
            this.breathingPanel.TabIndex = 32;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(302, 64);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(37, 19);
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "RGB:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(253, 24);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(87, 19);
            this.metroLabel6.TabIndex = 30;
            this.metroLabel6.Text = "Hexadecimal:";
            // 
            // breathingRgb
            // 
            this.breathingRgb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.breathingRgb.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.breathingRgb.Location = new System.Drawing.Point(345, 57);
            this.breathingRgb.Name = "breathingRgb";
            this.breathingRgb.Size = new System.Drawing.Size(113, 32);
            this.breathingRgb.TabIndex = 28;
            this.breathingRgb.Text = "255,255,255";
            this.breathingRgb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.breathingRgb_KeyDown);
            // 
            // breathingHsv
            // 
            this.breathingHsv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.breathingHsv.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.breathingHsv.Location = new System.Drawing.Point(345, 96);
            this.breathingHsv.Name = "breathingHsv";
            this.breathingHsv.Size = new System.Drawing.Size(113, 32);
            this.breathingHsv.TabIndex = 29;
            this.breathingHsv.Text = "0,1,1";
            this.breathingHsv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.breathingHsv_KeyDown);
            // 
            // breathingHex
            // 
            this.breathingHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.breathingHex.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.breathingHex.Location = new System.Drawing.Point(345, 15);
            this.breathingHex.Name = "breathingHex";
            this.breathingHex.Size = new System.Drawing.Size(113, 36);
            this.breathingHex.TabIndex = 27;
            this.breathingHex.Text = "#FFFFFF";
            this.breathingHex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.breathingHex_KeyDown);
            // 
            // breathingColorWheel
            // 
            this.breathingColorWheel.BackColor = System.Drawing.Color.White;
            this.breathingColorWheel.Framerate = 30;
            this.breathingColorWheel.InnerTriangleRadius = 0.7F;
            this.breathingColorWheel.InnerWhiteRadius = 0.8F;
            this.breathingColorWheel.Location = new System.Drawing.Point(2, 14);
            this.breathingColorWheel.Name = "breathingColorWheel";
            this.breathingColorWheel.Outlinecolor = System.Drawing.Color.White;
            this.breathingColorWheel.Outlinewidth = 2.5F;
            this.breathingColorWheel.PickedColor = System.Drawing.Color.Red;
            this.breathingColorWheel.RingMarkersize = 1.3F;
            this.breathingColorWheel.Size = new System.Drawing.Size(250, 250);
            this.breathingColorWheel.SizeMultiplier = 0.95F;
            this.breathingColorWheel.TabIndex = 25;
            this.breathingColorWheel.TriangleMarkersize = 0.15F;
            this.breathingColorWheel.ColorChanged += new ColorPickers.ColorWheel.Handler(this.breathingColorWheel_ColorChanged);
            // 
            // Breathing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.breathingFreq);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.breathingPanel);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.breathingRgb);
            this.Controls.Add(this.breathingHsv);
            this.Controls.Add(this.breathingHex);
            this.Controls.Add(this.breathingColorWheel);
            this.Name = "Breathing";
            this.Size = new System.Drawing.Size(570, 287);
            this.Load += new System.EventHandler(this.Breathing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox breathingFreq;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Panel breathingPanel;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TextBox breathingRgb;
        private System.Windows.Forms.TextBox breathingHsv;
        private System.Windows.Forms.TextBox breathingHex;
        private ColorPickers.ColorWheel breathingColorWheel;
    }
}
