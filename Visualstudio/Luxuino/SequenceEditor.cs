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
using MetroFramework.Components;
using MetroFramework.Controls;

namespace LedController
{
    public partial class SequenceEditor : CustomUserControl
    {
        public Sequencepoint[] SequencePoints = null;
        public float Length;

        public SequenceEditor(Sequencepoint[] pointsToEdit, float Length)
        {
            InitializeComponent();
            SequencePoints = pointsToEdit;
            sequenceMaker1.SequencePoints = SequencePoints;
            this.Length = Length;
            sequenceLength.Text = Length + "";
        }

        private void sequenceMaker1_MarkerSelected(Sequencepoint point)
        {
            sequenceColorWheel.SetColor(point.color);
        }

        private void sequenceColorWheel_ColorChanged(Color color)
        {
            sequenceMaker1.SetSelectedPointColor(color);
            SetColor(color, false);
        }

        public override void SetDark(bool dark)
        {
            base.SetDark(dark);
            metroLabel1.Theme = (dark ? MetroFramework.MetroThemeStyle.Dark : MetroFramework.MetroThemeStyle.Light);
            metroLabel2.Theme = (dark ? MetroFramework.MetroThemeStyle.Dark : MetroFramework.MetroThemeStyle.Light);
            metroLabel3.Theme = (dark ? MetroFramework.MetroThemeStyle.Dark : MetroFramework.MetroThemeStyle.Light);
            metroLabel4.Theme = (dark ? MetroFramework.MetroThemeStyle.Dark : MetroFramework.MetroThemeStyle.Light);
        }

        private void staticHex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                TextBox box = sender as TextBox;
                Color color;
                try
                {
                    color = CConverter.ColorFromHex(sequenceHex.Text);
                }
                catch
                {
                    return;
                }
                sequencePanel.Focus();
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
                    sequencePanel.Focus();
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
                    sequencePanel.Focus();
                    e.SuppressKeyPress = true;
                    SetColor(CConverter.ColorFromHSV(hsvColor), true);
                }
            }
        }

        private void sequenceLength_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                TextBox box = sender as TextBox;
                if (box.Text.Length > 0)
                {
                    try
                    {
                        Length = float.Parse(box.Text);
                    }
                    catch
                    {
                        return;
                    }
                    sequencePanel.Focus();
                    e.SuppressKeyPress = true;
                }
            }
        }

        void SetColor(Color color, bool setColorPicker)
        {
            if (setColorPicker)
                sequenceColorWheel.PickedColor = color;
            sequenceRgb.Text = color.R + "," + color.G + "," + color.B;
            HSVcolor hsvColor = CConverter.ColorToHSV(color);
            sequenceHsv.Text = Math.Round(hsvColor.Hue, 0) + "," + Math.Round(hsvColor.Saturation, 2) + "," + Math.Round(hsvColor.Value, 2);
            sequenceHex.Text = CConverter.HexFromColor(color);
            sequencePanel.BackColor = color;
            sequenceMaker1.SetSelectedPointColor(color);
        }

        private void applySequence_Click(object sender, EventArgs e)
        {
            SequencePoints = sequenceMaker1.SequencePoints;
        }
    }
}
