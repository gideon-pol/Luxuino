using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LedController
{
    public class CustomUserControl : UserControl
    {
        public bool IsDark = false;

        public virtual void SetDark(bool dark)
        {
            IsDark = dark;
            if (dark)
            {
                BackColor = Color.FromArgb(17, 17, 17);
                foreach (Control c in Controls)
                {
                    c.BackColor = Color.FromArgb(17, 17, 17);
                    if(c.GetType() == typeof(TextBox))
                        c.ForeColor = Color.DarkGray;
                    else
                        c.ForeColor = Color.DimGray;
                }
            }
            else
            {
                BackColor = Color.White;
                foreach (Control c in Controls)
                {
                    c.BackColor = Color.White;
                    c.ForeColor = Color.Black;
                }
            }
        }
    }
}
