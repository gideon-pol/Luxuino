namespace LedController
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Styler = new MetroFramework.Components.MetroStyleManager(this.components);
            this.Screen = new MetroFramework.Controls.MetroTabPage();
            this.Sequence = new MetroFramework.Controls.MetroTabPage();
            this.Presets = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.Static = new MetroFramework.Controls.MetroTabPage();
            this.staticApply = new MetroFramework.Controls.MetroButton();
            this.Breathing = new MetroFramework.Controls.MetroTabPage();
            this.breathingApply = new MetroFramework.Controls.MetroButton();
            this.Rainbow = new MetroFramework.Controls.MetroTabPage();
            this.applyRainbow = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Audio = new MetroFramework.Controls.MetroTabPage();
            this.Arduino = new MetroFramework.Controls.MetroTabPage();
            this.saveArduino = new MetroFramework.Controls.MetroButton();
            this.arduinoUpload = new MetroFramework.Controls.MetroButton();
            this.Settings = new MetroFramework.Controls.MetroTabPage();
            this.Port = new System.IO.Ports.SerialPort(this.components);
            this.Logo = new System.Windows.Forms.Panel();
            this.static1 = new LedController.Static();
            this.breathing1 = new LedController.Breathing();
            this.rainbow1 = new LedController.Rainbow();
            this.sequenceSelector1 = new LedController.SequenceSelector();
            this.screen1 = new LedController.Screen();
            this.audio1 = new LedController.Audio();
            this.arduino1 = new LedController.Arduino();
            this.settings1 = new LedController.Settings();
            ((System.ComponentModel.ISupportInitialize)(this.Styler)).BeginInit();
            this.Screen.SuspendLayout();
            this.Sequence.SuspendLayout();
            this.Presets.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.Static.SuspendLayout();
            this.Breathing.SuspendLayout();
            this.Rainbow.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.Audio.SuspendLayout();
            this.Arduino.SuspendLayout();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 0;
            // 
            // Styler
            // 
            this.Styler.Owner = this;
            // 
            // Screen
            // 
            this.Screen.Controls.Add(this.screen1);
            this.Screen.HorizontalScrollbarBarColor = true;
            this.Screen.Location = new System.Drawing.Point(4, 35);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(582, 336);
            this.Screen.TabIndex = 3;
            this.Screen.Text = "Screen";
            this.Screen.VerticalScrollbarBarColor = true;
            // 
            // Sequence
            // 
            this.Sequence.BackColor = System.Drawing.Color.White;
            this.Sequence.Controls.Add(this.sequenceSelector1);
            this.Sequence.HorizontalScrollbarBarColor = true;
            this.Sequence.Location = new System.Drawing.Point(4, 35);
            this.Sequence.Name = "Sequence";
            this.Sequence.Size = new System.Drawing.Size(582, 336);
            this.Sequence.TabIndex = 1;
            this.Sequence.Text = "Sequence ";
            this.Sequence.VerticalScrollbarBarColor = true;
            // 
            // Presets
            // 
            this.Presets.Controls.Add(this.metroTabControl2);
            this.Presets.HorizontalScrollbarBarColor = true;
            this.Presets.Location = new System.Drawing.Point(4, 35);
            this.Presets.Name = "Presets";
            this.Presets.Size = new System.Drawing.Size(582, 336);
            this.Presets.TabIndex = 0;
            this.Presets.Text = "Presets";
            this.Presets.VerticalScrollbarBarColor = true;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.Static);
            this.metroTabControl2.Controls.Add(this.Breathing);
            this.metroTabControl2.Controls.Add(this.Rainbow);
            this.metroTabControl2.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(578, 340);
            this.metroTabControl2.TabIndex = 2;
            // 
            // Static
            // 
            this.Static.BackColor = System.Drawing.Color.White;
            this.Static.Controls.Add(this.staticApply);
            this.Static.Controls.Add(this.static1);
            this.Static.HorizontalScrollbarBarColor = true;
            this.Static.Location = new System.Drawing.Point(4, 35);
            this.Static.Name = "Static";
            this.Static.Size = new System.Drawing.Size(570, 301);
            this.Static.TabIndex = 0;
            this.Static.Text = "Static";
            this.Static.VerticalScrollbarBarColor = true;
            // 
            // staticApply
            // 
            this.staticApply.Location = new System.Drawing.Point(456, 252);
            this.staticApply.Name = "staticApply";
            this.staticApply.Size = new System.Drawing.Size(113, 46);
            this.staticApply.TabIndex = 20;
            this.staticApply.Text = "Apply";
            this.staticApply.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.staticApply.Click += new System.EventHandler(this.staticApply_Click);
            // 
            // Breathing
            // 
            this.Breathing.BackColor = System.Drawing.Color.White;
            this.Breathing.Controls.Add(this.breathingApply);
            this.Breathing.Controls.Add(this.breathing1);
            this.Breathing.HorizontalScrollbarBarColor = true;
            this.Breathing.Location = new System.Drawing.Point(4, 35);
            this.Breathing.Name = "Breathing";
            this.Breathing.Size = new System.Drawing.Size(570, 301);
            this.Breathing.TabIndex = 1;
            this.Breathing.Text = "Breathing";
            this.Breathing.VerticalScrollbarBarColor = true;
            // 
            // breathingApply
            // 
            this.breathingApply.Location = new System.Drawing.Point(456, 252);
            this.breathingApply.Name = "breathingApply";
            this.breathingApply.Size = new System.Drawing.Size(113, 46);
            this.breathingApply.TabIndex = 21;
            this.breathingApply.Text = "Apply";
            this.breathingApply.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.breathingApply.Click += new System.EventHandler(this.breathingApply_Click);
            // 
            // Rainbow
            // 
            this.Rainbow.BackColor = System.Drawing.Color.White;
            this.Rainbow.Controls.Add(this.applyRainbow);
            this.Rainbow.Controls.Add(this.rainbow1);
            this.Rainbow.HorizontalScrollbarBarColor = true;
            this.Rainbow.Location = new System.Drawing.Point(4, 35);
            this.Rainbow.Name = "Rainbow";
            this.Rainbow.Size = new System.Drawing.Size(570, 301);
            this.Rainbow.TabIndex = 2;
            this.Rainbow.Text = "Rainbow";
            this.Rainbow.VerticalScrollbarBarColor = true;
            // 
            // applyRainbow
            // 
            this.applyRainbow.Location = new System.Drawing.Point(456, 252);
            this.applyRainbow.Name = "applyRainbow";
            this.applyRainbow.Size = new System.Drawing.Size(113, 46);
            this.applyRainbow.TabIndex = 22;
            this.applyRainbow.Text = "Apply";
            this.applyRainbow.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.applyRainbow.Click += new System.EventHandler(this.applyRainbow_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Presets);
            this.metroTabControl1.Controls.Add(this.Sequence);
            this.metroTabControl1.Controls.Add(this.Screen);
            this.metroTabControl1.Controls.Add(this.Audio);
            this.metroTabControl1.Controls.Add(this.Arduino);
            this.metroTabControl1.Controls.Add(this.Settings);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(590, 375);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // Audio
            // 
            this.Audio.Controls.Add(this.audio1);
            this.Audio.HorizontalScrollbarBarColor = true;
            this.Audio.Location = new System.Drawing.Point(4, 35);
            this.Audio.Name = "Audio";
            this.Audio.Size = new System.Drawing.Size(582, 336);
            this.Audio.TabIndex = 2;
            this.Audio.Text = "Audio";
            this.Audio.VerticalScrollbarBarColor = true;
            // 
            // Arduino
            // 
            this.Arduino.Controls.Add(this.saveArduino);
            this.Arduino.Controls.Add(this.arduinoUpload);
            this.Arduino.Controls.Add(this.arduino1);
            this.Arduino.HorizontalScrollbarBarColor = true;
            this.Arduino.Location = new System.Drawing.Point(4, 35);
            this.Arduino.Name = "Arduino";
            this.Arduino.Size = new System.Drawing.Size(582, 336);
            this.Arduino.TabIndex = 5;
            this.Arduino.Text = "Arduino ";
            this.Arduino.VerticalScrollbarBarColor = true;
            // 
            // saveArduino
            // 
            this.saveArduino.Location = new System.Drawing.Point(341, 287);
            this.saveArduino.Name = "saveArduino";
            this.saveArduino.Size = new System.Drawing.Size(113, 46);
            this.saveArduino.TabIndex = 4;
            this.saveArduino.Text = "Save";
            this.saveArduino.Theme = MetroFramework.MetroThemeStyle.Light;
            this.saveArduino.Click += new System.EventHandler(this.saveArduino_Click);
            // 
            // arduinoUpload
            // 
            this.arduinoUpload.Location = new System.Drawing.Point(460, 287);
            this.arduinoUpload.Name = "arduinoUpload";
            this.arduinoUpload.Size = new System.Drawing.Size(113, 46);
            this.arduinoUpload.TabIndex = 2;
            this.arduinoUpload.Text = "Upload";
            this.arduinoUpload.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.arduinoUpload.Click += new System.EventHandler(this.arduinoUpload_Click);
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.settings1);
            this.Settings.HorizontalScrollbarBarColor = true;
            this.Settings.Location = new System.Drawing.Point(4, 35);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(582, 336);
            this.Settings.TabIndex = 4;
            this.Settings.Text = "Settings";
            this.Settings.VerticalScrollbarBarColor = true;
            // 
            // Port
            // 
            this.Port.BaudRate = 38400;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(108, 30);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(34, 20);
            this.Logo.TabIndex = 1;
            // 
            // static1
            // 
            this.static1.BackColor = System.Drawing.Color.White;
            this.static1.Location = new System.Drawing.Point(0, 10);
            this.static1.Name = "static1";
            this.static1.Size = new System.Drawing.Size(570, 287);
            this.static1.TabIndex = 2;
            // 
            // breathing1
            // 
            this.breathing1.BackColor = System.Drawing.Color.White;
            this.breathing1.Location = new System.Drawing.Point(0, 10);
            this.breathing1.Name = "breathing1";
            this.breathing1.Size = new System.Drawing.Size(570, 287);
            this.breathing1.TabIndex = 2;
            // 
            // rainbow1
            // 
            this.rainbow1.BackColor = System.Drawing.Color.White;
            this.rainbow1.Location = new System.Drawing.Point(0, 10);
            this.rainbow1.Name = "rainbow1";
            this.rainbow1.Size = new System.Drawing.Size(570, 287);
            this.rainbow1.TabIndex = 2;
            // 
            // sequenceSelector1
            // 
            this.sequenceSelector1.BackColor = System.Drawing.Color.White;
            this.sequenceSelector1.Location = new System.Drawing.Point(0, 10);
            this.sequenceSelector1.Name = "sequenceSelector1";
            this.sequenceSelector1.Size = new System.Drawing.Size(582, 326);
            this.sequenceSelector1.TabIndex = 3;
            // 
            // screen1
            // 
            this.screen1.BackColor = System.Drawing.Color.White;
            this.screen1.Location = new System.Drawing.Point(0, 1);
            this.screen1.Name = "screen1";
            this.screen1.Size = new System.Drawing.Size(582, 335);
            this.screen1.TabIndex = 2;
            // 
            // audio1
            // 
            this.audio1.BackColor = System.Drawing.Color.White;
            this.audio1.Location = new System.Drawing.Point(0, 13);
            this.audio1.Name = "audio1";
            this.audio1.Size = new System.Drawing.Size(582, 324);
            this.audio1.TabIndex = 2;
            // 
            // arduino1
            // 
            this.arduino1.BackColor = System.Drawing.Color.White;
            this.arduino1.Location = new System.Drawing.Point(0, 0);
            this.arduino1.Name = "arduino1";
            this.arduino1.Size = new System.Drawing.Size(570, 280);
            this.arduino1.TabIndex = 3;
            // 
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.Color.White;
            this.settings1.Location = new System.Drawing.Point(0, 1);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(582, 335);
            this.settings1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "Luxuino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Styler)).EndInit();
            this.Screen.ResumeLayout(false);
            this.Sequence.ResumeLayout(false);
            this.Presets.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.Static.ResumeLayout(false);
            this.Breathing.ResumeLayout(false);
            this.Rainbow.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.Audio.ResumeLayout(false);
            this.Arduino.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Presets;
        private MetroFramework.Controls.MetroTabPage Screen;
        private MetroFramework.Controls.MetroTabPage Sequence;
        private MetroFramework.Controls.MetroTabPage Static;
        private Static static1;
        private MetroFramework.Controls.MetroTabPage Breathing;
        private Breathing breathing1;
        private MetroFramework.Controls.MetroTabPage Rainbow;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroButton staticApply;
        private MetroFramework.Controls.MetroButton breathingApply;
        public System.IO.Ports.SerialPort Port;
        private Rainbow rainbow1;
        private MetroFramework.Controls.MetroButton applyRainbow;
        private SequenceSelector sequenceSelector1;
        private MetroFramework.Controls.MetroTabPage Audio;
        private Audio audio1;
        private Screen screen1;
        public MetroFramework.Components.MetroStyleManager Styler;
        private MetroFramework.Controls.MetroTabPage Settings;
        public Settings settings1;
        private MetroFramework.Controls.MetroTabPage Arduino;
        private MetroFramework.Controls.MetroButton arduinoUpload;
        private Arduino arduino1;
        private System.Windows.Forms.Panel Logo;
        private MetroFramework.Controls.MetroButton saveArduino;
    }
}