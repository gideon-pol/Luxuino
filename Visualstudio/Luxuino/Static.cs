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
    public partial class Static : CustomUserControl
    {
        public Color color;
        public string rgb;

        public Static()
        {
            InitializeComponent();
        }

        private void staticColorWheel_ColorChanged(Color color)
        {
            SetColor(color, false);
        }

        private void Static_Load(object sender, EventArgs e)
        {
            SetColor(Color.FromArgb(255,0,0), true);
        }

        private void staticHex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                TextBox box = sender as TextBox;
                Color color;
                try
                {
                    color = CConverter.ColorFromHex(staticHex.Text);
                }
                catch
                {
                    return;
                }
                staticPanel.Focus();
                e.SuppressKeyPress = true;
                SetColor(color, true);
            }
        }

        private void staticRgb_KeyDown(object sender, KeyEventArgs e)
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
                    staticPanel.Focus();
                    e.SuppressKeyPress = true;
                    SetColor(color, true);
                }
            }
        }

        private void staticHsv_KeyDown(object sender, KeyEventArgs e)
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
                    staticPanel.Focus();
                    e.SuppressKeyPress = true;
                    SetColor(CConverter.ColorFromHSV(hsvColor), true);
                }
            }
        }

        void SetColor(Color color, bool setColorPicker)
        {
            if (setColorPicker)
                staticColorWheel.PickedColor = color;
            staticRgb.Text = color.R + "," + color.G + "," + color.B;
            HSVcolor hsvColor = CConverter.ColorToHSV(color);
            staticHsv.Text = Math.Round(hsvColor.Hue, 0) + "," + Math.Round(hsvColor.Saturation, 2) + "," + Math.Round(hsvColor.Value, 2);
            staticHex.Text = CConverter.HexFromColor(color);
            staticPanel.BackColor = color;
            this.color = color;
            rgb = staticRgb.Text;
        }
    }
}
