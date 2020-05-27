using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ArduinoUploader;
using ArduinoUploader.Hardware;
using System.Threading;
using System.Threading.Tasks;

namespace LedController
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Start startLoadingScreen;
        string lastMsg = "";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            sequenceSelector1.uploadSequence.Click += uploadSequence_Click;
            audio1.toggleButton.Click += toggleAudio_Click;
            audio1.Port = Port;
            screen1.toggleButton.Click += toggleScreen_Click;
            screen1.Port = Port;
            metroTabControl1.SelectedIndex = 0;
            metroTabControl2.SelectedIndex = 0;
            settings1.settingsSet.Click += settingsSet_Click;
            arduino1.Port = Port.PortName;
            arduino1.Ports.SelectedItem = Port.PortName;

            if (Application.OpenForms.OfType<Start>().FirstOrDefault().Styler.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                SetDark(true);
            }
        }

        public void SetDark(bool dark)
        {
            if (dark)
            {
                BackColor = Color.FromArgb(17, 17, 17);
                foreach (Control c in Controls)
                {
                    SetControlsColor(c, true);
                }
            }
            else
            {
                BackColor = Color.White;
                foreach (Control c in Controls)
                {
                    SetControlsColor(c, false);
                }
            }
        }

        void SetControlsColor(Control c, bool dark)
        {
            if (dark)
            {
                c.BackColor = Color.FromArgb(17, 17, 17);
                c.ForeColor = Color.DimGray;
                foreach (Control cr in c.Controls)
                {
                    cr.BackColor = Color.FromArgb(17, 17, 17);
                    if (cr.GetType().IsSubclassOf(typeof(CustomUserControl)))
                    {
                        (cr as CustomUserControl).SetDark(true);
                        continue;
                    }
                    if (cr.Controls.Count > 0)
                        SetControlsColor(cr, true);
                }
            } else
            {
                c.BackColor = Color.White;
                c.ForeColor = Color.Black;
                foreach (Control cr in c.Controls)
                {
                    cr.BackColor = Color.White;
                    if (cr.GetType().IsSubclassOf(typeof(CustomUserControl)))
                    {
                        (cr as CustomUserControl).SetDark(false);
                        continue;
                    }
                    if (cr.Controls.Count > 0)
                        SetControlsColor(cr, false);
                }
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void staticApply_Click(object sender, EventArgs e)
        {
            screen1.Stop();
            audio1.Stop();
            string msg = "st:" + static1.rgb + ":";
            lastMsg = msg;
            SendToPort(msg); 
        }

        private void breathingApply_Click(object sender, EventArgs e)
        {
            screen1.Stop();
            audio1.Stop();
            string msg = "br:" + breathing1.rgb + ":"+breathing1.pulseFreq+":";
            lastMsg = msg;
            SendToPort(msg);
        }

        private void applyRainbow_Click(object sender, EventArgs e)
        {
            screen1.Stop();
            audio1.Stop();
            string msg = "ra:" + rainbow1.CycleLength + ":";
            lastMsg = msg;
            SendToPort(msg);
        }

        private void toggleAudio_Click(object sender, EventArgs e)
        {
            screen1.Stop();
        }

        private void toggleScreen_Click(object sender, EventArgs e)
        {
            audio1.Stop();
        }

        private void uploadSequence_Click(object sender, EventArgs e)
        {
            screen1.Stop();
            audio1.Stop();
            string msg = "se:";
            foreach (Sequencepoint point in sequenceSelector1.targetSequence.SequencePoints)
            {
                msg += point.color.R+","+ point.color.G + ","+ point.color.B + ";"+Math.Round(point.time,2)+"|";
            }
            msg += ":"+sequenceSelector1.targetSequence.Length+":";
            lastMsg = msg;
            SendToPort(msg);
        }

        private void settingsSet_Click(object sender, EventArgs e)
        {
            Styler.Theme = settings1.Theme;
            Styler.Style = settings1.Style;
            if (settings1.Theme == MetroFramework.MetroThemeStyle.Dark)
                SetDark(true);
            else
                SetDark(false);
        }

        void SendToPort(string msg)
        {
            if (Port.IsOpen)
            {
                Port.WriteLine("i:");
                Port.WriteLine(msg);
            }
            else
            {
                FormClosing -= Main_FormClosing;
                Application.Restart();
            }
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedTab.Name == "Screen")
            {
                screen1.previewTimer.Start();
                audio1.timer.Stop();
            }
            else if (metroTabControl1.SelectedTab.Name == "Audio")
            {
                audio1.timer.Start();
                screen1.previewTimer.Stop();
            }
            else
            {
                audio1.timer.Stop();
                screen1.previewTimer.Stop();
            }
        }

        private void arduinoUpload_Click(object sender, EventArgs e)
        {
            Loading loading = new Loading("Uploading");
            loading.Dock = DockStyle.Fill;
            loading.Location = new Point(0, 0);
            metroTabControl1.Controls.Find("Arduino", true).FirstOrDefault().Controls.Add(loading);
            loading.BringToFront();
            if(Port.IsOpen)
                new Thread(() => UploadCodeToArduino(loading)).Start();
        }

        void UploadCodeToArduino(Loading loading)
        {
            try
            {
                string filePath = null;
                if (arduino1.Model == ArduinoModel.NanoR2 || arduino1.Model == ArduinoModel.NanoR3)
                    filePath = "/Microcontroller/led_nano_v1.0.ino.hex";
                else if (arduino1.Model == ArduinoModel.UnoR3)
                    filePath = "/Microcontroller/led_uno_v1.0.ino.hex";
                else if (arduino1.Model == ArduinoModel.Mega2560)
                    filePath = "/Microcontroller/led_mega2560_v1.0.ino.hex";
                else if (arduino1.Model == ArduinoModel.Leonardo)
                    filePath = "/Microcontroller/led_leonardo_v1.0.ino.hex";
                else if (arduino1.Model == ArduinoModel.Micro)
                    filePath = "/Microcontroller/led_micro_v1.0.ino.hex";
                ArduinoSketchUploader uploader = new ArduinoSketchUploader(
                    new ArduinoSketchUploaderOptions
                    {
                        FileName = String.Concat(Directory.GetCurrentDirectory(), filePath),
                        PortName = arduino1.Port,
                        ArduinoModel = arduino1.Model
                    }
                );
                this.Enabled = false;
                Port.Close();
                uploader.UploadSketch();
                Task.Delay(1000).Wait();
                Port.Open();
            } catch(Exception e)
            {
                MessageBox.Show("Upload Failed", "Error");
            }
            this.Enabled = true;
            metroTabControl1.Controls.Find("Arduino", true).FirstOrDefault().Controls.Remove(loading);
            loading.Dispose();
            GC.Collect();
        }

        private void saveArduino_Click(object sender, EventArgs e)
        {
            if (Port.IsOpen)
                if(lastMsg != "")
                Port.WriteLine("save:"+lastMsg);
        }
    }
}