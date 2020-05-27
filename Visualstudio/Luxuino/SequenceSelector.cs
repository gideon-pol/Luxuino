using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Drawing.Drawing2D;

namespace LedController
{
    public partial class SequenceSelector : CustomUserControl
    {
        List<Sequence> sequences = new List<Sequence>();
        Gradient targetGradient;

        public Sequence targetSequence;
        int targetSequenceIndex;
        SequenceEditor currentEditor;

        string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Luxuino");
        string path;

        XmlSerializer xml = new XmlSerializer(typeof(List<Sequence>));

        public SequenceSelector()
        {
            InitializeComponent();
        }

        private void SequenceSelector_Load(object sender, EventArgs e)
        {
            path = directory + "/Sequences.xml";
            ShowButtons(false);
            tableLayoutPanel1.AutoScroll = false;
            tableLayoutPanel1.HorizontalScroll.Enabled = false;
            tableLayoutPanel1.VerticalScroll.Maximum = 326;
            
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 61));
            tableLayoutPanel1.AutoScroll = true;
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            if (!File.Exists(path))
            {
                using (TextWriter writer = new StreamWriter(path))
                {
                    xml.Serialize(writer, sequences);
                }
            }
            using (Stream reader = new FileStream(path, FileMode.Open))
            {
                sequences = xml.Deserialize(reader) as List<Sequence>;
            }
            
            for (int i = 0; i<sequences.Count; i++)
            {
                Gradient gradient = new Gradient();
                gradient.Location = new Point(4, 4);
                gradient.Size = new Size(575, 61);
                gradient.SequencePoints = sequences[i].SequencePoints;
                gradient.DoubleClick += GradientDoubleClicked;
                gradient.MouseEnter += GradientEnterHover;
                sequences[i].Gradient = gradient;
                Panel p = new Panel();
                p.Controls.Add(gradient);
                p.Size = new Size(575, 61);
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 61));
                tableLayoutPanel1.Controls.Add(p);
            }
            tableLayoutPanel1.Controls.Add(addSequence);
        }

        public override void SetDark(bool dark)
        {
            base.SetDark(dark);
            uploadSequence.BackColor = Color.White;
            editSequence.BackColor = Color.White;
            deleteSequence.BackColor = Color.White;
            addSequence.BackColor = Color.White;
            if(currentEditor != null)
                currentEditor.SetDark(IsDark);
        }

        private void GradientDoubleClicked(object sender, EventArgs e)
        {
            OpenSequenceEditor(sender as Gradient);
        }

        private void GradientEnterHover(object sender, EventArgs e)
        {
            ShowButtons(true);
            Gradient g = sender as Gradient;
            g.Parent.Controls.Add(uploadSequence);
            g.Parent.Controls.Add(editSequence);
            g.Parent.Controls.Add(deleteSequence);
            g.Parent.Controls.Add(lengthLabel);
            g.Parent.Controls.Add(pointsLabel);

            uploadSequence.BringToFront();
            editSequence.BringToFront();
            deleteSequence.BringToFront();
            lengthLabel.BringToFront();
            pointsLabel.BringToFront();
            targetGradient = sender as Gradient;
            targetSequenceIndex = sequences.IndexOf(sequences.Where(i => targetGradient == i.Gradient).FirstOrDefault());
            targetSequence = sequences[targetSequenceIndex];
            lengthLabel.Text = "Length: " +targetSequence.Length + " sec";
            lengthLabel.Location = new Point(435 - lengthLabel.Size.Width-10, lengthLabel.Location.Y);
            pointsLabel.Text = "Points: " + targetSequence.SequencePoints.Length;
            pointsLabel.Location = new Point(435 - pointsLabel.Size.Width - 10, pointsLabel.Location.Y);
        }

        void OpenSequenceEditor(Gradient gradient)
        {
            SequenceEditor editor = new SequenceEditor(gradient.SequencePoints, targetSequence.Length);
            editor.SetDark(IsDark);
            editor.Location = new Point(0, 3);
            Controls.Add(editor);
            editor.BringToFront();
            editor.applySequence.Click += CloseSequenceEditor;
            editor.discardSequence.Click += DiscardSequenceEditor;
            currentEditor = editor;
        }

        private void CloseSequenceEditor(object sender, EventArgs e)
        {
            SequenceEditor editor = currentEditor;
            sequences[targetSequenceIndex] = new Sequence(editor.SequencePoints, editor.Length, targetGradient);
            currentEditor = null;
            targetGradient.SequencePoints = sequences[targetSequenceIndex].SequencePoints;
            lengthLabel.Text = "Length: " + sequences[targetSequenceIndex].Length + " sec";
            lengthLabel.Location = new Point(435 - lengthLabel.Size.Width - 10, lengthLabel.Location.Y);
            pointsLabel.Text = "Points: " + sequences[targetSequenceIndex].SequencePoints.Length;
            pointsLabel.Location = new Point(435 - pointsLabel.Size.Width - 10, pointsLabel.Location.Y);
            Controls.Remove((sender as Control).Parent);
            SaveSequences();
        }

        private void DiscardSequenceEditor(object sender, EventArgs e)
        {
            Controls.Remove((sender as Control).Parent);
        }

        private void addSequence_Click(object sender, EventArgs e)
        {
            sequences.Add(new Sequence(
                new Sequencepoint[] {
                    new Sequencepoint(Color.White, 0f),
                    new Sequencepoint(Color.Black, 1f)
                 }, 3f));
            
            Gradient gradient = new Gradient();
            gradient.Location = new Point(4, 4);
            gradient.Size = new Size(575, 61);
            gradient.SequencePoints = sequences[sequences.Count-1].SequencePoints;
            gradient.DoubleClick += GradientDoubleClicked;
            gradient.MouseEnter += GradientEnterHover;
            sequences[sequences.Count - 1].Gradient = gradient;
            Panel p = new Panel();
            p.Controls.Add(gradient);
            p.Size = new Size(575, 61);

            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 61));
            tableLayoutPanel1.Controls.Add(p);

            tableLayoutPanel1.Controls.Remove(addSequence);
            tableLayoutPanel1.Controls.Add(addSequence);

            SaveSequences();
        }

        private void editSequence_Click(object sender, EventArgs e)
        {
            OpenSequenceEditor(targetGradient);
        }

        private void deleteSequence_Click(object sender, EventArgs e)
        {
            sequences.Remove(sequences.Where(i=> targetGradient == i.Gradient).FirstOrDefault());
            tableLayoutPanel1.Controls.Remove(targetGradient.Parent);

            tableLayoutPanel1.AutoScroll = false;
            tableLayoutPanel1.HorizontalScroll.Enabled = false;
            tableLayoutPanel1.VerticalScroll.Maximum = 326;
            tableLayoutPanel1.AutoScroll = true;

            ShowButtons(false);
            SaveSequences();
        }

        private void ShowButtons(bool show)
        {
            uploadSequence.Visible = show;
            uploadSequence.Enabled = show;

            editSequence.Visible = show;
            editSequence.Enabled = show;

            deleteSequence.Visible = show;
            deleteSequence.Enabled = show;

            lengthLabel.Visible = show;
            lengthLabel.Enabled = show;

            pointsLabel.Visible = show;
            pointsLabel.Enabled = show;
        }

        private void SaveSequences()
        {
            if (File.Exists(path))
            {
                using (TextWriter writer = new StreamWriter(path))
                {
                    xml.Serialize(writer, sequences);
                }
            }
        }
    }

    public class Sequence
    {
        public Sequencepoint[] SequencePoints;
        public float Length;

        [XmlIgnore]
        public Gradient Gradient;

        public Sequence(Sequencepoint[] SequencePoints, float Length)
        {
            this.SequencePoints = SequencePoints;
            this.Length = Length;
        }

        public Sequence(Sequencepoint[] SequencePoints, float Length, Gradient Gradient)
        {
            this.SequencePoints = SequencePoints;
            this.Length = Length;
            this.Gradient = Gradient;
        }

        public Sequence() {
        }
    }
}
