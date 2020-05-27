namespace LedController
{
    partial class Screen
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
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.screenX = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.screenY = new System.Windows.Forms.TextBox();
            this.toggleButton = new MetroFramework.Controls.MetroButton();
            this.previewTimer = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Port = new System.IO.Ports.SerialPort(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.screenFps = new System.Windows.Forms.TextBox();
            this.mouseSet = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.screenMode = new MetroFramework.Controls.MetroComboBox();
            this.cube1 = new LedController.Cube();
            this.SuspendLayout();
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(434, 108);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(20, 19);
            this.metroLabel5.TabIndex = 29;
            this.metroLabel5.Text = "X:";
            // 
            // screenX
            // 
            this.screenX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenX.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.screenX.Location = new System.Drawing.Point(460, 100);
            this.screenX.Name = "screenX";
            this.screenX.Size = new System.Drawing.Size(113, 36);
            this.screenX.TabIndex = 28;
            this.screenX.Text = "-";
            this.screenX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.screenX_KeyDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(434, 150);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(20, 19);
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "Y:";
            // 
            // screenY
            // 
            this.screenY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenY.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.screenY.Location = new System.Drawing.Point(460, 142);
            this.screenY.Name = "screenY";
            this.screenY.Size = new System.Drawing.Size(113, 36);
            this.screenY.TabIndex = 30;
            this.screenY.Text = "-";
            this.screenY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.screenY_KeyDown);
            // 
            // toggleButton
            // 
            this.toggleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.toggleButton.Location = new System.Drawing.Point(460, 287);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(113, 46);
            this.toggleButton.TabIndex = 32;
            this.toggleButton.Text = "Start";
            this.toggleButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleButton.Click += new System.EventHandler(this.toggleButton_Click);
            // 
            // previewTimer
            // 
            this.previewTimer.Interval = 50;
            this.previewTimer.Tick += new System.EventHandler(this.previewTimer_Tick);
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(420, 208);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 19);
            this.metroLabel2.TabIndex = 35;
            this.metroLabel2.Text = "FPS:";
            // 
            // screenFps
            // 
            this.screenFps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenFps.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.screenFps.Location = new System.Drawing.Point(460, 199);
            this.screenFps.Name = "screenFps";
            this.screenFps.Size = new System.Drawing.Size(113, 36);
            this.screenFps.TabIndex = 34;
            this.screenFps.Text = "20";
            this.screenFps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.screenFps_KeyDown);
            // 
            // mouseSet
            // 
            this.mouseSet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mouseSet.Location = new System.Drawing.Point(341, 287);
            this.mouseSet.Name = "mouseSet";
            this.mouseSet.Size = new System.Drawing.Size(113, 46);
            this.mouseSet.TabIndex = 36;
            this.mouseSet.Text = "Mouse Set";
            this.mouseSet.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mouseSet.Click += new System.EventHandler(this.mouseSet_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(407, 46);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.TabIndex = 37;
            this.metroLabel3.Text = "Mode:";
            // 
            // screenMode
            // 
            this.screenMode.FormattingEnabled = true;
            this.screenMode.ItemHeight = 23;
            this.screenMode.Location = new System.Drawing.Point(460, 41);
            this.screenMode.Name = "screenMode";
            this.screenMode.Size = new System.Drawing.Size(113, 29);
            this.screenMode.TabIndex = 38;
            this.screenMode.SelectedValueChanged += new System.EventHandler(this.screenMode_SelectedValueChanged);
            // 
            // cube1
            // 
            this.cube1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cube1.Location = new System.Drawing.Point(3, 3);
            this.cube1.Name = "cube1";
            this.cube1.Size = new System.Drawing.Size(281, 281);
            this.cube1.TabIndex = 33;
            this.cube1.Paint += new System.Windows.Forms.PaintEventHandler(this.cube1_Paint);
            this.cube1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cube1_KeyDown);
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.screenMode);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mouseSet);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.screenFps);
            this.Controls.Add(this.cube1);
            this.Controls.Add(this.toggleButton);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.screenY);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.screenX);
            this.Name = "Screen";
            this.Size = new System.Drawing.Size(582, 336);
            this.Load += new System.EventHandler(this.Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox screenX;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox screenY;
        public System.Windows.Forms.Timer previewTimer;
        private Cube cube1;
        private System.Windows.Forms.Timer timer;
        public System.IO.Ports.SerialPort Port;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox screenFps;
        private MetroFramework.Controls.MetroButton mouseSet;
        public MetroFramework.Controls.MetroButton toggleButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox screenMode;
    }
}
