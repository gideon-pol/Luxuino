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

namespace LedController
{
    public partial class SequenceMaker : UserControl
    {
        public delegate void Handler(Sequencepoint point);
        public event Handler MarkerSelected;

        Sequencepoint[] points = new Sequencepoint[] {
                new Sequencepoint(Color.White, 0f),
                new Sequencepoint(Color.Black, 1f)
             };

        List<Marker> markers = new List<Marker>();
        Sequencepoint selectedPoint;

        

        public Sequencepoint[] SequencePoints
        {
            get { return points; }
            set { points = value; gradient1.SequencePoints = value; Invalidate(); }
        }

        public SequenceMaker()
        {
            InitializeComponent();
            DoubleBuffered = true;
            gradient1.SequencePoints = points;
        }

        private void SequenceMaker_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.SmoothingMode = SmoothingMode.AntiAlias;
            for (int i = 0; i < points.Length - 1; i++)
            {
                float startX = points[i].time * this.Width;
                float endX = points[i + 1].time * this.Width;

                if (points[i].marker == null || points[i].marker.path == null)
                {
                    Marker marker = new Marker();
                    points[i].marker = marker;
                }
                points[i].marker.CreatePath(new Point((int)startX, this.Height-23));
                if(selectedPoint == points[i])
                    gr.FillPath(Brushes.LightGray, points[i].marker.path);
                else
                    gr.FillPath(Brushes.White, points[i].marker.path);
                gr.DrawPath(Pens.Black, points[i].marker.path);

                if (i == points.Length - 2)
                {
                    i++;
                    if (points[i].marker == null || points[i].marker.path == null)
                    {
                        Marker marker = new Marker();
                        points[i].marker = marker;
                    }
                    points[i].marker.CreatePath(new Point((int)endX, this.Height - 23));
                    if (selectedPoint == points[i])
                        gr.FillPath(Brushes.LightGray, points[i].marker.path);
                    else
                        gr.FillPath(Brushes.White, points[i].marker.path);
                    gr.DrawPath(Pens.Black, points[i].marker.path);
                    break;
                }
            }
        }

        private void SequenceMaker_MouseDown(object sender, MouseEventArgs e)
        {
            Point screenPoint = this.Parent.PointToScreen(this.Location);
            selectedPoint = null;
            Sequencepoint[] invPoints = points;
            Array.Reverse(invPoints);
            foreach (Sequencepoint point in invPoints)
            {
                if (Mathf.Contains(point.marker.path.PathPoints, new Point(MousePosition.X - screenPoint.X, MousePosition.Y - screenPoint.Y)) )
                {
                    selectedPoint = point;
                    MarkerSelected?.Invoke(point);
                    Invalidate();
                    break;
                }
            }
            if (selectedPoint != null)
                timer.Start();
            else
            {
                List<Sequencepoint> lPoints = points.ToList();
                Sequencepoint newPoint = new Sequencepoint(Color.White, Mathf.Clamp((MousePosition.X - screenPoint.X) / (float)this.Width, 0.01f, 0.99f));
                lPoints.Add(newPoint);
                points = lPoints.ToArray();

                selectedPoint = newPoint;
                selectedPoint.color = GetColorOnGradient((int)(newPoint.time * this.Width));
                gradient1.SequencePoints = points;
                MarkerSelected?.Invoke(newPoint);
                if (sender.GetType() != typeof(Gradient))
                    timer.Start();
            }
        }

        private void SequenceMaker_MouseUp(object sender, MouseEventArgs e)
        {
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Point screenPoint = this.Parent.PointToScreen(this.Location);
            if (selectedPoint != null && (selectedPoint != points[0] && selectedPoint != points[points.Length - 1]))
            {
                selectedPoint.time = Mathf.Clamp((MousePosition.X - screenPoint.X) / (float)this.Width, 0.01f, 0.99f);
                gradient1.SequencePoints = points;
                Invalidate();
            }
        }

        public void SetSelectedPointColor(Color color)
        {
            if(selectedPoint != null)
                    selectedPoint.color = color; 
            gradient1.SequencePoints = points;
            Invalidate();
        }

        private void gradient1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                if(selectedPoint != points[0] && selectedPoint != points[points.Length - 1])
                {
                    List<Sequencepoint> lPoints = points.ToList();
                    lPoints.Remove(selectedPoint);
                    points = lPoints.ToArray();
                    gradient1.SequencePoints = points;
                    Invalidate();
                }
            }
        }

        Color GetColorOnGradient(int x)
        {
            using (Bitmap map = new Bitmap(1,1))
            {
                using (Graphics gr = Graphics.FromImage(map))
                {
                    Point screenPoint = this.Parent.PointToScreen(this.Location);
                    gr.CopyFromScreen(screenPoint.X+x, screenPoint.Y+1, 0, 0, new Size(1, 1));
                    return map.GetPixel(0, 0);
                }
            }
        }
    }
}
