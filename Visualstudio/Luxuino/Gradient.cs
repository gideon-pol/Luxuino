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
using System.Windows.Markup;
using ColorPickers;
using System.Xml.Serialization;

namespace LedController
{
    public partial class Gradient : UserControl
    {
        Sequencepoint[] points = new Sequencepoint[] {
                new Sequencepoint(Color.White, 0f),
                new Sequencepoint(Color.Black, 1f)
             };
        float height = 1f;

        public Sequencepoint[] SequencePoints
        {
            get { return points; }
            set { points = value; Invalidate(); }
        }
        
        public float HeightMultiplier
        {
            get { return height; }
            set { height = value; Invalidate(); }
        }

        public Gradient()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Gradient_Paint(object sender, PaintEventArgs e)
        {
            Array.Sort(points);
            Graphics gr = e.Graphics;
            gr.SmoothingMode = SmoothingMode.AntiAlias;
            for(int i = 0; i<points.Length-1; i++) {
                float startX = points[i].time * this.Width;
                float endX = points[i+1].time * this.Width;
                LinearGradientBrush brush = new LinearGradientBrush(
                        new PointF(startX-1, 0),
                        new PointF(endX+1, 0),
                        (Color)points[i].color,
                        (Color)points[i+1].color
                        );
                gr.FillRectangle(brush, startX, 0, endX+1, this.Height * height);
            }
        }
    }

    public class Sequencepoint : IComparable<Sequencepoint>
    {
        [XmlIgnore]
        public Color color { get; set; }
        [XmlElement("color")]
        public int ColorAsArgb
        {
            get { return color.ToArgb(); }
            set { color = Color.FromArgb(value); }
        }

        public float time { get; set; }
        [XmlIgnore]
        public Marker marker = null;

        public Sequencepoint(Color color = default(Color), float time = 0.1f)
        {
            this.color = color;
            this.time = time;
        }

        public Sequencepoint()
        {}

        public int CompareTo(Sequencepoint other)
        {
            return time.CompareTo(other.time);
        }
    }

    public class Marker
    {
        public PointF points;
        public GraphicsPath path;

        public GraphicsPath CreatePath(Point position)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddPolygon(
                new PointF[] {
                    new PointF(position.X, position.Y),
                    new PointF(position.X-6, position.Y + 6),
                    new PointF(position.X-6, position.Y + 20),
                    new PointF(position.X+6, position.Y + 20),
                    new PointF(position.X+6, position.Y + 6)
                }
            );
            this.path = path;
            return path;
        }
    }
}
