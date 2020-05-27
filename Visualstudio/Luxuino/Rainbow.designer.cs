namespace LedController
{
    partial class Rainbow
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.rainbowLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 19);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Cycle Length(sec):";
            // 
            // rainbowLength
            // 
            this.rainbowLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rainbowLength.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.rainbowLength.Location = new System.Drawing.Point(125, 18);
            this.rainbowLength.Name = "rainbowLength";
            this.rainbowLength.Size = new System.Drawing.Size(113, 32);
            this.rainbowLength.TabIndex = 17;
            this.rainbowLength.Text = "20";
            this.rainbowLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rainbowLength_KeyDown);
            // 
            // Rainbow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.rainbowLength);
            this.Name = "Rainbow";
            this.Size = new System.Drawing.Size(570, 287);
            this.Load += new System.EventHandler(this.Rainbow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox rainbowLength;
    }
}
