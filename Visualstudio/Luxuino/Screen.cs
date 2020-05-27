using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ColorPickers;
using System.Runtime.CompilerServices;
using ColorExtension;

namespace LedController
{
    public partial class Screen : CustomUserControl
    {
        enum ScreenMode { SinglePixel=0, Average=1};

        ScreenMode currentMode = ScreenMode.SinglePixel;
        int x = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width/2;
        int y = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height/2;
        int previewX, previewY;
        int fps = 20;


        bool setPositionWithMouse = false;
        bool canReact = false;

        public Screen()
        {
            InitializeComponent();
        }

        private void Screen_Load(object sender, EventArgs e)
        {
            screenX.Text = x.ToString();
            screenY.Text = y.ToString();
            previewX = x;
            previewY = y;
            screenMode.Items.Add(ScreenMode.SinglePixel);
            screenMode.Items.Add(ScreenMode.Average);
            screenMode.SelectedItem = ScreenMode.SinglePixel;
        }

        public void Stop()
        {
            canReact = false;
            timer.Stop();
            toggleButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            toggleButton.Text = "Start";
        }

        private void cube1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics gr = e.Graphics;
                using (Bitmap map = new Bitmap(10, 10))
                {
                    using (Graphics graphics = Graphics.FromImage(map))
                    {
                        graphics.CopyFromScreen(previewX - 5, previewY - 5, 0, 0, new Size(10, 10));
                        gr.InterpolationMode = InterpolationMode.NearestNeighbor;
                        gr.DrawImage(map, new Rectangle(-15, -15, cube1.Width + 30, cube1.Height + 30), 0, 0, 10, 10, GraphicsUnit.Pixel);
                        gr.DrawRectangle(Pens.Black, new Rectangle(cube1.Width / 2 - 15, cube1.Height / 2 - 15, 31, 31));
                    }
                }
            } catch (Exception ex) { return; }
        }

        private void screenX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                TextBox box = sender as TextBox;
                if (box.Text.Length >= 1)
                {
                    try
                    {
                        if (currentMode == ScreenMode.SinglePixel)
                            x = (int)Mathf.Clamp(int.Parse(box.Text), 5, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - 5);
                        else
                            x = (int)Mathf.Clamp(int.Parse(box.Text), 50, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - 50);
                        previewX = x;
                    }
                    catch
                    {
                        return;
                    }
                    cube1.Focus();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void screenY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                TextBox box = sender as TextBox;
                if (box.Text.Length >= 1)
                {
                    try
                    {
                        if(currentMode == ScreenMode.SinglePixel)
                            y = (int)Mathf.Clamp(int.Parse(box.Text), 5, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 5);
                        else
                            y = (int)Mathf.Clamp(int.Parse(box.Text), 50, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 50);
                        previewY = y;
                    }
                    catch
                    {
                        return;
                    }
                    cube1.Focus();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void previewTimer_Tick(object sender, EventArgs e)
        {
            if (setPositionWithMouse)
            {
                previewX = MousePosition.X;
                previewY = MousePosition.Y;
                cube1.Focus();
            }
            cube1.Invalidate();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Port.IsOpen)
                {
                    if (currentMode == ScreenMode.SinglePixel)
                    {
                        using (Bitmap map = new Bitmap(1, 1))
                        {
                            using (Graphics graphics = Graphics.FromImage(map))
                            {
                                graphics.CopyFromScreen(x, y, 0, 0, new Size(1, 1));
                                Color color = map.GetPixel(0, 0);
                                Port.WriteLine(color.R + "," + color.G + "," + color.B + ":");
                            }
                        }
                    }
                    else if (currentMode == ScreenMode.Average)
                    {
                        using (Bitmap map = new Bitmap(200, 200))
                        {
                            using (Graphics graphics = Graphics.FromImage(map))
                            {
                                graphics.CopyFromScreen(x - 100, y - 100, 0, 0, new Size(200, 200));
                                ColorBoundless colorTotal = Color.Black;
                                for (int ys = 0; ys < 100; ys += 20)
                                {
                                    for (int xs = 0; xs < 100; xs += 20)
                                    {
                                        colorTotal += map.GetPixel(xs, ys);
                                    }
                                }
                                Color colorAverage = colorTotal / 100;
                                Port.WriteLine(colorAverage.R + "," + colorAverage.G + "," + colorAverage.B + ":");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { return; }
        }


        private void toggleButton_Click(object sender, EventArgs e)
        {
            if (Port.IsOpen)
            {
                canReact = !canReact;
                if (canReact)
                {
                    Port.WriteLine("i:");
                    Port.WriteLine("sc:" + timer.Interval + ":");
                    toggleButton.Theme = MetroFramework.MetroThemeStyle.Light;
                    toggleButton.Text = "Stop";
                    timer.Start();
                }
                else
                {
                    toggleButton.Theme = MetroFramework.MetroThemeStyle.Dark;
                    toggleButton.Text = "Start";
                    timer.Stop();
                }
            } else
                Application.Restart();
        }

        private void screenFps_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                TextBox box = sender as TextBox;
                if (box.Text.Length >= 1)
                {
                    try
                    {
                        if (int.Parse(box.Text) <= 60)
                        {
                            fps = int.Parse(box.Text);
                        }
                    }
                    catch
                    {
                        return;
                    }
                    cube1.Focus();
                    e.SuppressKeyPress = true;
                    timer.Interval = (int)(1 / (float)fps * 1000);
                    this.Stop();
                    /*if (Port.IsOpen)
                    {
                        if (canReact)
                        {
                            Port.WriteLine("i:");
                            Port.WriteLine("screen:" + timer.Interval + ":");
                        }
                    }*/
                }
            }
        }

        private void cube1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (setPositionWithMouse)
                {
                    x = previewX;
                    y = previewY;
                    setPositionWithMouse = false;
                    screenX.Text = x.ToString();
                    screenY.Text = y.ToString();
                }
            }
        }

        private void screenMode_SelectedValueChanged(object sender, EventArgs e)
        {
            currentMode = (ScreenMode)screenMode.SelectedItem;
            if (currentMode == ScreenMode.Average)
            {
                x = (int)Mathf.Clamp(x, 50, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - 50);
                y = (int)Mathf.Clamp(y, 50, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 50);
                previewX = x;
                previewY = y;
                screenX.Text = x.ToString();
                screenY.Text = y.ToString();
            }
        }

        private void mouseSet_Click(object sender, EventArgs e)
        {
            setPositionWithMouse = !setPositionWithMouse;
        }
    }
}
