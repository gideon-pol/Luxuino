using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedController
{
    public partial class Loading : UserControl
    {
        public Loading(string text = "Loading")
        {
            InitializeComponent();
            this.text.Text = text;
            this.text.Location = new Point(this.Width / 2 - this.text.Width / 2, this.text.Location.Y);
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Start>().FirstOrDefault().Styler.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                BackColor = Color.FromArgb(17, 17, 17);
                bunifuCircleProgressbar1.BackColor = Color.FromArgb(17, 17, 17);
                bunifuCircleProgressbar1.ProgressBackColor = Color.DimGray;
                bunifuCircleProgressbar1.ProgressColor = Color.Gainsboro;
                text.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
        }
    }
}
