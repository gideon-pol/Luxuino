namespace LedController
{
    partial class SequenceEditor
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
            LedController.Sequencepoint sequencepoint1 = new LedController.Sequencepoint();
            LedController.Sequencepoint sequencepoint2 = new LedController.Sequencepoint();
            this.sequenceColorWheel = new ColorPickers.ColorWheel();
            this.sequencePanel = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.sequenceRgb = new System.Windows.Forms.TextBox();
            this.sequenceHsv = new System.Windows.Forms.TextBox();
            this.sequenceHex = new System.Windows.Forms.TextBox();
            this.applySequence = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.sequenceLength = new System.Windows.Forms.TextBox();
            this.discardSequence = new MetroFramework.Controls.MetroButton();
            this.sequenceMaker1 = new LedController.SequenceMaker();
            this.SuspendLayout();
            // 
            // sequenceColorWheel
            // 
            this.sequenceColorWheel.BackColor = System.Drawing.Color.White;
            this.sequenceColorWheel.Framerate = 30;
            this.sequenceColorWheel.InnerTriangleRadius = 0.65F;
            this.sequenceColorWheel.InnerWhiteRadius = 0.8F;
            this.sequenceColorWheel.Location = new System.Drawing.Point(17, 93);
            this.sequenceColorWheel.Name = "sequenceColorWheel";
            this.sequenceColorWheel.Outlinecolor = System.Drawing.Color.White;
            this.sequenceColorWheel.Outlinewidth = 2.5F;
            this.sequenceColorWheel.PickedColor = System.Drawing.Color.Red;
            this.sequenceColorWheel.RingMarkersize = 1.3F;
            this.sequenceColorWheel.Size = new System.Drawing.Size(230, 230);
            this.sequenceColorWheel.SizeMultiplier = 0.97F;
            this.sequenceColorWheel.TabIndex = 6;
            this.sequenceColorWheel.TriangleMarkersize = 0.15F;
            this.sequenceColorWheel.ColorChanged += new ColorPickers.ColorWheel.Handler(this.sequenceColorWheel_ColorChanged);
            // 
            // sequencePanel
            // 
            this.sequencePanel.BackColor = System.Drawing.Color.Red;
            this.sequencePanel.Location = new System.Drawing.Point(495, 169);
            this.sequencePanel.Name = "sequencePanel";
            this.sequencePanel.Size = new System.Drawing.Size(60, 60);
            this.sequencePanel.TabIndex = 31;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(310, 190);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "HSV:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(308, 152);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "RGB:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(259, 112);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Hexadecimal:";
            // 
            // sequenceRgb
            // 
            this.sequenceRgb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sequenceRgb.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.sequenceRgb.Location = new System.Drawing.Point(351, 145);
            this.sequenceRgb.Name = "sequenceRgb";
            this.sequenceRgb.Size = new System.Drawing.Size(113, 32);
            this.sequenceRgb.TabIndex = 26;
            this.sequenceRgb.Text = "255,255,255";
            this.sequenceRgb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.staticRgb_KeyDown);
            // 
            // sequenceHsv
            // 
            this.sequenceHsv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sequenceHsv.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.sequenceHsv.Location = new System.Drawing.Point(351, 184);
            this.sequenceHsv.Name = "sequenceHsv";
            this.sequenceHsv.Size = new System.Drawing.Size(113, 32);
            this.sequenceHsv.TabIndex = 27;
            this.sequenceHsv.Text = "0,1,1";
            this.sequenceHsv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.staticHsv_KeyDown);
            // 
            // sequenceHex
            // 
            this.sequenceHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sequenceHex.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.sequenceHex.Location = new System.Drawing.Point(351, 103);
            this.sequenceHex.Name = "sequenceHex";
            this.sequenceHex.Size = new System.Drawing.Size(113, 36);
            this.sequenceHex.TabIndex = 25;
            this.sequenceHex.Text = "#FFFFFF";
            this.sequenceHex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.staticHex_KeyDown);
            // 
            // applySequence
            // 
            this.applySequence.Location = new System.Drawing.Point(466, 277);
            this.applySequence.Name = "applySequence";
            this.applySequence.Size = new System.Drawing.Size(113, 46);
            this.applySequence.TabIndex = 32;
            this.applySequence.Text = "Apply";
            this.applySequence.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.applySequence.Click += new System.EventHandler(this.applySequence_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(268, 239);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(77, 19);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Length(sec):";
            // 
            // sequenceLength
            // 
            this.sequenceLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sequenceLength.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.sequenceLength.Location = new System.Drawing.Point(351, 232);
            this.sequenceLength.Name = "sequenceLength";
            this.sequenceLength.Size = new System.Drawing.Size(113, 32);
            this.sequenceLength.TabIndex = 33;
            this.sequenceLength.Text = "3";
            this.sequenceLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sequenceLength_KeyDown);
            // 
            // discardSequence
            // 
            this.discardSequence.Location = new System.Drawing.Point(351, 277);
            this.discardSequence.Name = "discardSequence";
            this.discardSequence.Size = new System.Drawing.Size(113, 46);
            this.discardSequence.TabIndex = 35;
            this.discardSequence.Text = "Discard";
            this.discardSequence.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // sequenceMaker1
            // 
            this.sequenceMaker1.BackColor = System.Drawing.Color.White;
            this.sequenceMaker1.Location = new System.Drawing.Point(14, 7);
            this.sequenceMaker1.Name = "sequenceMaker1";
            sequencepoint1.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            sequencepoint1.ColorAsArgb = -1;
            sequencepoint1.time = 0F;
            sequencepoint2.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            sequencepoint2.ColorAsArgb = -16777216;
            sequencepoint2.time = 1F;
            this.sequenceMaker1.SequencePoints = new LedController.Sequencepoint[] {
        sequencepoint1,
        sequencepoint2};
            this.sequenceMaker1.Size = new System.Drawing.Size(553, 80);
            this.sequenceMaker1.TabIndex = 7;
            this.sequenceMaker1.MarkerSelected += new LedController.SequenceMaker.Handler(this.sequenceMaker1_MarkerSelected);
            // 
            // SequenceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.discardSequence);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.sequenceLength);
            this.Controls.Add(this.applySequence);
            this.Controls.Add(this.sequencePanel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.sequenceRgb);
            this.Controls.Add(this.sequenceHsv);
            this.Controls.Add(this.sequenceHex);
            this.Controls.Add(this.sequenceMaker1);
            this.Controls.Add(this.sequenceColorWheel);
            this.Name = "SequenceEditor";
            this.Size = new System.Drawing.Size(582, 326);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SequenceMaker sequenceMaker1;
        private ColorPickers.ColorWheel sequenceColorWheel;
        private System.Windows.Forms.Panel sequencePanel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox sequenceRgb;
        private System.Windows.Forms.TextBox sequenceHsv;
        private System.Windows.Forms.TextBox sequenceHex;
        public MetroFramework.Controls.MetroButton applySequence;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox sequenceLength;
        public MetroFramework.Controls.MetroButton discardSequence;
    }
}
