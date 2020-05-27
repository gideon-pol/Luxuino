using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ColorExtension
{
    public class HSVcolor
    {
        public float Hue, Saturation, Value;
        public HSVcolor(float h, float s, float v)
        {
            Hue = h;
            Saturation = s;
            Value = v;
        }
    }

    public static class CConverter
    {
        public static Color ColorFromHSV(HSVcolor color)
        {
            double H = color.Hue;
            while (H < 0) { H += 360; };
            while (H >= 360) { H -= 360; };
            double R, G, B;
            if (color.Value <= 0)
            { R = G = B = 0; }
            else if (color.Saturation <= 0)
            {
                R = G = B = color.Value;
            }
            else
            {
                double hf = H / 60.0;
                int i = (int)Math.Floor(hf);
                double f = hf - i;
                double pv = color.Value * (1 - color.Saturation);
                double qv = color.Value * (1 - color.Saturation * f);
                double tv = color.Value * (1 - color.Saturation * (1 - f));
                switch (i)
                {
                    case 0:
                        R = color.Value;
                        G = tv;
                        B = pv;
                        break;
                    case 1:
                        R = qv;
                        G = color.Value;
                        B = pv;
                        break;
                    case 2:
                        R = pv;
                        G = color.Value;
                        B = tv;
                        break;
                    case 3:
                        R = pv;
                        G = qv;
                        B = color.Value;
                        break;
                    case 4:
                        R = tv;
                        G = pv;
                        B = color.Value;
                        break;
                    case 5:
                        R = color.Value;
                        G = pv;
                        B = qv;
                        break;
                    case 6:
                        R = color.Value;
                        G = tv;
                        B = pv;
                        break;
                    case -1:
                        R = color.Value;
                        G = pv;
                        B = qv;
                        break;
                    default:
                        R = G = B = color.Value;
                        break;
                }
            }
            return Color.FromArgb(clamp((int)(R * 255.0), 0, 255), clamp((int)(G * 255.0), 0, 255), clamp((int)(B * 255.0), 0, 255));
        }

        static int clamp(int value, int floor, int ceiling)
        {
            if (value > ceiling)
                value = ceiling;
            else if (value < floor)
                value = floor;
            return value;
        }

        public static HSVcolor ColorToHSV(Color color)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            return new HSVcolor(color.GetHue(), (float)((max == 0) ? 0 : 1d - (1d * min / max)), max / 255f);
        }
        public static Color ColorFromHex(string hex) {
            return System.Drawing.ColorTranslator.FromHtml(hex);
        }
        public static string HexFromColor(Color color)
        {
            try
            {
                return System.Drawing.ColorTranslator.ToHtml(color);
            }
            catch { }
            return string.Empty;
        }
    }

   public class ColorBoundless
    {
        public int R;
        public int G;
        public int B;

        public ColorBoundless(int Red, int Green, int Blue)
        {
            R = Red;
            G = Green;
            B = Blue;
        }

        public static ColorBoundless operator +(ColorBoundless c1, Color c2)
        {
            ColorBoundless color = new ColorBoundless(c1.R + c2.R, c1.G + c2.G, c1.B + c2.B);
            return color;
        }

        public static ColorBoundless operator /(ColorBoundless c1, float divider)
        {
            ColorBoundless color = new ColorBoundless((int)(c1.R / divider), (int)(c1.G / divider), (int)(c1.B / divider));
            return color;
        }

        public static implicit operator Color(ColorBoundless c)
        {
            Color color = Color.FromArgb(c.R, c.G, c.B);
            return color;
        }

        public static implicit operator ColorBoundless(Color c)
        {
            ColorBoundless color = new ColorBoundless(c.R, c.G, c.B);
            return color;
        }
    }
}
