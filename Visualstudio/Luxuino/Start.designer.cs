namespace LedController
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.portSelector = new MetroFramework.Controls.MetroComboBox();
            this.Styler = new MetroFramework.Components.MetroStyleManager(this.components);
            this.connect = new MetroFramework.Controls.MetroButton();
            this.refresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.Port = new System.IO.Ports.SerialPort(this.components);
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.Error = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Styler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(112, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Select COM port:";
            // 
            // portSelector
            // 
            this.portSelector.FormattingEnabled = true;
            this.portSelector.ItemHeight = 23;
            this.portSelector.Location = new System.Drawing.Point(128, 71);
            this.portSelector.Name = "portSelector";
            this.portSelector.Size = new System.Drawing.Size(121, 29);
            this.portSelector.TabIndex = 3;
            // 
            // Styler
            // 
            this.Styler.Owner = this;
            this.Styler.Style = MetroFramework.MetroColorStyle.Lime;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(67, 126);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(91, 35);
            this.connect.TabIndex = 4;
            this.connect.Text = "Connect";
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.ImageActive = null;
            this.refresh.Location = new System.Drawing.Point(164, 130);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(28, 25);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh.TabIndex = 6;
            this.refresh.TabStop = false;
            this.refresh.Zoom = 0;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Port
            // 
            this.Port.BaudRate = 38400;
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(128, 103);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 0);
            this.Error.TabIndex = 8;
            this.Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToolTip1.SetToolTip(this.Error, "Make sure your device is connected and that you\'ve\r\nset the right COM port. Also " +
        "make sure that no other\r\nprogram is using this port.");
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(14, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(167, 25);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Connect your device";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 184);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.portSelector);
            this.Controls.Add(this.metroLabel2);
            this.DoubleBuffered = false;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.Resizable = false;
            this.Text = "Luxuino";
            this.Load += new System.EventHandler(this.LedController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Styler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox portSelector;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton connect;
        private Bunifu.Framework.UI.BunifuImageButton refresh;
        private System.IO.Ports.SerialPort Port;
        private MetroFramework.Controls.MetroLabel Error;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        public MetroFramework.Components.MetroStyleManager Styler;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

