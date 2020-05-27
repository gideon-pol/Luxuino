namespace LedController
{
    partial class Arduino
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
            this.arduinoDevice = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Ports = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // arduinoDevice
            // 
            this.arduinoDevice.FormattingEnabled = true;
            this.arduinoDevice.ItemHeight = 23;
            this.arduinoDevice.Location = new System.Drawing.Point(112, 17);
            this.arduinoDevice.Name = "arduinoDevice";
            this.arduinoDevice.Size = new System.Drawing.Size(121, 29);
            this.arduinoDevice.TabIndex = 5;
            this.arduinoDevice.SelectedValueChanged += new System.EventHandler(this.arduinoDevice_SelectedValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Arduino Type:";
            // 
            // Ports
            // 
            this.Ports.FormattingEnabled = true;
            this.Ports.ItemHeight = 23;
            this.Ports.Location = new System.Drawing.Point(112, 52);
            this.Ports.Name = "Ports";
            this.Ports.Size = new System.Drawing.Size(121, 29);
            this.Ports.TabIndex = 7;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Serial port:";
            // 
            // Arduino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Ports);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.arduinoDevice);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Arduino";
            this.Size = new System.Drawing.Size(570, 280);
            this.Load += new System.EventHandler(this.Arduino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox arduinoDevice;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroComboBox Ports;
    }
}
