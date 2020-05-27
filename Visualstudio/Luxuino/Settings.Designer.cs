namespace LedController
{
    partial class Settings
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
            this.settingsLight = new MetroFramework.Controls.MetroComboBox();
            this.settingsAccent = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.settingsSet = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Light/Dark:";
            // 
            // settingsLight
            // 
            this.settingsLight.FormattingEnabled = true;
            this.settingsLight.ItemHeight = 23;
            this.settingsLight.Location = new System.Drawing.Point(112, 16);
            this.settingsLight.Name = "settingsLight";
            this.settingsLight.Size = new System.Drawing.Size(121, 29);
            this.settingsLight.TabIndex = 1;
            // 
            // settingsAccent
            // 
            this.settingsAccent.FormattingEnabled = true;
            this.settingsAccent.ItemHeight = 23;
            this.settingsAccent.Location = new System.Drawing.Point(112, 51);
            this.settingsAccent.Name = "settingsAccent";
            this.settingsAccent.Size = new System.Drawing.Size(121, 29);
            this.settingsAccent.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Accent color:";
            // 
            // settingsSet
            // 
            this.settingsSet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.settingsSet.Location = new System.Drawing.Point(460, 287);
            this.settingsSet.Name = "settingsSet";
            this.settingsSet.Size = new System.Drawing.Size(113, 46);
            this.settingsSet.TabIndex = 33;
            this.settingsSet.Text = "Set";
            this.settingsSet.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.settingsSet.Click += new System.EventHandler(this.settingsSet_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.settingsSet);
            this.Controls.Add(this.settingsAccent);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.settingsLight);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(582, 336);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox settingsLight;
        private MetroFramework.Controls.MetroComboBox settingsAccent;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroButton settingsSet;
    }
}
