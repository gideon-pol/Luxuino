using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorExtension;

namespace LedController
{
    public partial class Breathing : CustomUserControl
    {
        public Color color;
        public float pulseFreq = 0.5f;
        public string rgb;

        public Breathing()
        {
            InitializeComponent();
        }

        private void breathingColorWheel_ColorChanged(Color color)
        {
            SetColor(color, false);
        }

        private void Breathing_Load(object sender, EventArgs e)
        {
            SetColor(Color.FromArgb(255, 0, 0), true);
        }

        private void breathingHex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                TextBox box = sender as TextBox;
                Color color;
                try
                {
                    color = CConverter.ColorFromHex(breathingHex.Text);
                }
                catch
                {
                    return;
                }
                breathingPanel.Focus();
                e.SuppressKeyPress = true;
                SetColor(color, true);
            }
        }

        private void breathingRgb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                TextBox box = sender as TextBox;
                if (box.Text.Length >= 5)
                {
                    string[] args = box.Text.Split(',');
                    Color color;
                    try
                    {
                        color = Color.FromArgb(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), Convert.ToInt32(args[2]));
                    }
                    catch
                    {
                        return;
                    }
                    e.SuppressKeyPress = true;
                    SetColor(color, true);
                    breathingPanel.Focus();
                }
            }
        }

        private void breathingHsv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                TextBox box = sender as TextBox;
                if (box.Text.Length >= 5)
                { 
                    string[] args = box.Text.Split(',');
                    HSVcolor hsvColor;
                    try
                    {
                        hsvColor = new HSVcolor(float.Parse(args[0]), float.Parse(args[1]), float.Parse(args[2]));
                    }
                    catch
                    {
                        return;
                    }
                    breathingPanel.Focus();
                    e.SuppressKeyPress = true;
                    SetColor(CConverter.ColorFromHSV(hsvColor), true);
                }
            }
        }

        private void breathingFreq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                TextBox box = sender as TextBox;
                if (box.Text.Length >= 1)
                {
                    try
                    {
                        pulseFreq = (float)Math.Round(float.Parse(box.Text), 3);
                    }
                    catch
                    {
                        return;
                    }
                    breathingPanel.Focus();
                    e.SuppressKeyPress = true;
                }
            }
        }

        void SetColor(Color color, bool setColorPicker)
        {
            if (setColorPicker)
                breathingColorWheel.PickedColor = color;
            breathingRgb.Text = color.R + "," + color.G + "," + color.B;
            HSVcolor hsvColor = CConverter.ColorToHSV(color);
            breathingHsv.Text = Math.Round(hsvColor.Hue, 0) + "," + Math.Round(hsvColor.Saturation, 2) + "," + Math.Round(hsvColor.Value, 2);
            breathingHex.Text = CConverter.HexFromColor(color);
            breathingPanel.BackColor = color;
            this.color = color;
            rgb = breathingRgb.Text;
        } 
    }
}
