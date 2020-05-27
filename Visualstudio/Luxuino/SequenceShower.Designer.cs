namespace LedController
{
    partial class SequenceMaker
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
            LedController.Sequencepoint sequencepoint1 = new LedController.Sequencepoint();
            LedController.Sequencepoint sequencepoint2 = new LedController.Sequencepoint();
            LedController.Sequencepoint sequencepoint3 = new LedController.Sequencepoint();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gradient1 = new LedController.Gradient();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // gradient1
            // 
            this.gradient1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradient1.HeightMultiplier = 1F;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            sequencepoint1.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            sequencepoint1.ColorAsArgb = -65536;
            sequencepoint1.time = 0F;
            sequencepoint2.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            sequencepoint2.ColorAsArgb = -16711936;
            sequencepoint2.time = 0.5F;
            sequencepoint3.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            sequencepoint3.ColorAsArgb = -16776961;
            sequencepoint3.time = 1F;
            this.gradient1.SequencePoints = new LedController.Sequencepoint[] {
        sequencepoint1,
        sequencepoint2,
        sequencepoint3};
            this.gradient1.Size = new System.Drawing.Size(316, 67);
            this.gradient1.TabIndex = 0;
            this.gradient1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gradient1_KeyDown);
            this.gradient1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SequenceMaker_MouseDown);
            this.gradient1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SequenceMaker_MouseUp);
            // 
            // SequenceMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gradient1);
            this.Name = "SequenceMaker";
            this.Size = new System.Drawing.Size(316, 90);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SequenceMaker_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SequenceMaker_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SequenceMaker_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private Gradient gradient1;
    }
}
