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
    public partial class Rainbow : CustomUserControl
    {
        public float CycleLength = 20;

        public Rainbow()
        {
            InitializeComponent();
        }

        private void Rainbow_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime && Application.OpenForms.OfType<Start>().FirstOrDefault().Styler.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                BackColor = Color.FromArgb(17, 17, 17);
                foreach (Control c in Controls)
                {
                    c.BackColor = Color.FromArgb(17, 17, 17);
                    c.ForeColor = Color.DimGray;
                }
            }
        }

        private void rainbowLength_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                TextBox box = sender as TextBox;
                if (box.Text.Length >= 1)
                {
                    try
                    {
                        CycleLength = float.Parse(box.Text);
                    }
                    catch
                    {
                        return;
                    }
                    metroLabel1.Focus();
                    e.SuppressKeyPress = true;
                }
            }
        }
    }
}
