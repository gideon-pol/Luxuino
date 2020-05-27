namespace LedController
{
    partial class Static
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
            this.staticPanel = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.staticRgb = new System.Windows.Forms.TextBox();
            this.staticHsv = new System.Windows.Forms.TextBox();
            this.staticHex = new System.Windows.Forms.TextBox();
            this.staticColorWheel = new ColorPickers.ColorWheel();
            this.SuspendLayout();
            // 
            // staticPanel
            // 
            this.staticPanel.BackColor = System.Drawing.Color.Red;
            this.staticPanel.Location = new System.Drawing.Point(489, 107);
            this.staticPanel.Name = "staticPanel";
            this.staticPanel.Size = new System.Drawing.Size(60, 60);
            this.staticPanel.TabIndex = 23;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(304, 164);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "HSV:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(302, 126);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "RGB:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(253, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Hexadecimal:";
            // 
            // staticRgb
            // 
            this.staticRgb.BackColor = System.Drawing.Color.White;
            this.staticRgb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staticRgb.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.staticRgb.Location = new System.Drawing.Point(345, 119);
            this.staticRgb.Name = "staticRgb";
            this.staticRgb.Size = new System.Drawing.Size(113, 32);
            this.staticRgb.TabIndex = 17;
            this.staticRgb.Text = "255,255,255";
            this.staticRgb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.staticRgb_KeyDown);
            // 
            // staticHsv
            // 
            this.staticHsv.BackColor = System.Drawing.Color.White;
            this.staticHsv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staticHsv.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.staticHsv.Location = new System.Drawing.Point(345, 158);
            this.staticHsv.Name = "staticHsv";
            this.staticHsv.Size = new System.Drawing.Size(113, 32);
            this.staticHsv.TabIndex = 18;
            this.staticHsv.Text = "0,1,1";
            this.staticHsv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.staticHsv_KeyDown);
            // 
            // staticHex
            // 
            this.staticHex.BackColor = System.Drawing.Color.White;
            this.staticHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staticHex.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.staticHex.Location = new System.Drawing.Point(345, 77);
            this.staticHex.Name = "staticHex";
            this.staticHex.Size = new System.Drawing.Size(113, 36);
            this.staticHex.TabIndex = 16;
            this.staticHex.Text = "#FFFFFF";
            this.staticHex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.staticHex_KeyDown);
            // 
            // staticColorWheel
            // 
            this.staticColorWheel.BackColor = System.Drawing.Color.White;
            this.staticColorWheel.Framerate = 30;
            this.staticColorWheel.InnerTriangleRadius = 0.7F;
            this.staticColorWheel.InnerWhiteRadius = 0.8F;
            this.staticColorWheel.Location = new System.Drawing.Point(2, 14);
            this.staticColorWheel.Name = "staticColorWheel";
            this.staticColorWheel.Outlinecolor = System.Drawing.Color.White;
            this.staticColorWheel.Outlinewidth = 2.5F;
            this.staticColorWheel.PickedColor = System.Drawing.Color.Red;
            this.staticColorWheel.RingMarkersize = 1.3F;
            this.staticColorWheel.Size = new System.Drawing.Size(250, 250);
            this.staticColorWheel.SizeMultiplier = 0.95F;
            this.staticColorWheel.TabIndex = 15;
            this.staticColorWheel.TriangleMarkersize = 0.15F;
            this.staticColorWheel.ColorChanged += new ColorPickers.ColorWheel.Handler(this.staticColorWheel_ColorChanged);
            // 
            // Static
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.staticPanel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.staticRgb);
            this.Controls.Add(this.staticHsv);
            this.Controls.Add(this.staticHex);
            this.Controls.Add(this.staticColorWheel);
            this.Name = "Static";
            this.Size = new System.Drawing.Size(570, 287);
            this.Load += new System.EventHandler(this.Static_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel staticPanel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox staticRgb;
        private System.Windows.Forms.TextBox staticHsv;
        private System.Windows.Forms.TextBox staticHex;
        private ColorPickers.ColorWheel staticColorWheel;
    }
}
