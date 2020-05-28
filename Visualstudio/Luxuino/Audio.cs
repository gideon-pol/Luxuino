using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ColorPickers;
using ColorExtension;
using MetroFramework.Components;
using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace LedController
{
    public partial class Audio : CustomUserControl
    {
        public SerialPort Port;

        float coefficient = 2;
        float multiplier = 2;
        bool canReact = false;

        Panel targetPanel;
        Color colorFrom = Color.Black;
        Color colorTo = Color.Red;

        float averageAudioLevel = 0;
        MMDevice targetDevice;
        WasapiLoopbackCapture capture = new WasapiLoopbackCapture();
        DateTime lastTimeAudioTriggered = DateTime.Now;
        DateTime lastTimeChartRendered = DateTime.Now;
        DateTime lastTimeSensitivityChanged = DateTime.Now;

        public Audio()
        {
            InitializeComponent();
        }

        private void Audio_Load(object sender, EventArgs e)
        {
            capture.DataAvailable += waveIn_DataAvailable;

            targetPanel = panelFrom;
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            MMDeviceCollection audioDevices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);

            devices.Items.AddRange(audioDevices.ToArray());
            devices.SelectedItem = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            targetDevice = devices.SelectedItem as MMDevice;

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = Mathf.Clamp(1 / multiplier, 0.1f, 1);
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorTickMark.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorTickMark.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorTickMark.Enabled = false;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 0.2;
            chart1.ChartAreas[0].AxisY.LabelStyle.Interval = 0.2;
            chart1.ChartAreas[0].BackColor = Color.White;
            chart1.Series[0].Color = Color.Black;
            chart1.Series[0]["PieLabelStyle"] = "Disabled";
        }

        public override void SetDark(bool dark)
        {
            base.SetDark(dark);

            if (dark)
            {
                chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.DarkGray;
                chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.DarkGray;
                chart1.ChartAreas[0].BackColor = Color.FromArgb(17, 17, 17);
                BackColor = Color.FromArgb(17, 17, 17);
                chart1.Series[0].Color = Color.DarkGray;
                panelFrom.BackColor = colorFrom;
                panelTo.BackColor = colorTo;
            } else
            {
                chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
                chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;
                chart1.ChartAreas[0].BackColor = Color.White;
                BackColor = Color.White;
                chart1.Series[0].Color = Color.Black;
                panelFrom.BackColor = colorFrom;
                panelTo.BackColor = colorTo;
            }
        }

        public void Stop()
        {
            canReact = false;
            timer.Stop();
            toggleButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            toggleButton.Text = "Start";
            capture.StopRecording();
        }

        private void coeff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                TextBox box = sender as TextBox;
                if (box.Text.Length >= 1)
                {
                    try
                    {
                        coefficient = float.Parse(box.Text);
                    }
                    catch
                    {
                        return;
                    }
                    chart1.Focus();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void audioSensitivity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && !autoSensitivity.Checked)
            {
                TextBox box = sender as TextBox;
                if (box.Text.Length >= 1)
                {
                    try
                    {
                        multiplier = float.Parse(box.Text);
                    }
                    catch
                    {
                        return;
                    }
                    chart1.Focus();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void alternativeMode_CheckedChanged(object sender, EventArgs e)
        {
            if (alternativeMode.Checked)
            {
                targetDevice = devices.SelectedItem as MMDevice;
                if (targetDevice != null)
                {
                    float init = targetDevice.AudioMeterInformation.MasterPeakValue;
                }
                else
                {
                    targetDevice = null;
                    alternativeMode.Checked = false;
                }
            }
        }

        private void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (!Port.IsOpen) return;
            if (DateTime.Now.Subtract(lastTimeAudioTriggered).Milliseconds >= 30)
            {
                lastTimeAudioTriggered = DateTime.Now;

                float rawAudioLevel = 0;
                if (alternativeMode.Checked && targetDevice != null)
                {
                    rawAudioLevel = targetDevice.AudioMeterInformation.MasterPeakValue;
                }
                else
                {
                    try
                    {
                        int sampleLength = 1024;
                        double average = 0;
                        double[] fft = new double[sampleLength];

                        for (int i = 0; i < sampleLength * 8; i += 8)
                        {
                            fft[i / 8] = BitConverter.ToSingle(e.Buffer, i);
                        }

                        fft = GetFFT(fft);
                        double[] realFFT = new double[sampleLength / 2];
                        Array.Copy(fft, realFFT, realFFT.Length);

                        foreach (double d in realFFT)
                        {
                            average += Math.Abs(d);
                        }
                        if (realFFT.Length == 0 || double.IsNaN(average))
                            return;
                        else
                            average /= realFFT.Length;
                        rawAudioLevel = (float)average * 1000;
                    }
                    catch (Exception ex) { }
                }

                if (DateTime.Now.Subtract(lastTimeSensitivityChanged).Milliseconds >= 70)
                {
                    if (rawAudioLevel > 0.01f && autoSensitivity.Checked)
                    {
                        lastTimeSensitivityChanged = DateTime.Now;
                        averageAudioLevel += (rawAudioLevel + 0.2f - averageAudioLevel) / 20;
                        multiplier = 1 / averageAudioLevel;
                    }
                }

                rawAudioLevel *= multiplier;
                float calculatedAudioLevel = Mathf.Clamp((float)Math.Pow(rawAudioLevel, coefficient), 0, 1f) * 100;
                Port.WriteLine(Math.Round(calculatedAudioLevel, 0) + ":");
            }
        }

        public double[] GetFFT(double[] data)
        {
            double[] fft = new double[data.Length];
            System.Numerics.Complex[] fftComplex = new System.Numerics.Complex[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                fftComplex[i] = new System.Numerics.Complex(data[i], 0.0);
            }
            Accord.Math.FourierTransform.FFT(fftComplex, Accord.Math.FourierTransform.Direction.Forward);
            for (int i = 0; i < data.Length; i++)
            {
                fft[i] = fftComplex[i].Magnitude;
            }
            return fft;
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {
            canReact = !canReact;
            if (canReact)
            {
                if (Port.IsOpen)
                {
                    Port.WriteLine("i:");
                    Port.WriteLine("au:" + colorFrom.R + "," + colorFrom.G + "," + colorFrom.B + "|" + colorTo.R + "," + colorTo.G + "," + colorTo.B + ":");
                    toggleButton.Theme = MetroFramework.MetroThemeStyle.Light;
                    toggleButton.Text = "Stop";
                    targetDevice = devices.SelectedItem as MMDevice;
                    capture.StartRecording();
                } else
                    Application.Restart();
            }
            else
            {
                Port.WriteLine("i:");
                toggleButton.Theme = MetroFramework.MetroThemeStyle.Dark;
                toggleButton.Text = "Start";
                capture.StopRecording();
            }
        }

        private void panelFrom_Click(object sender, EventArgs e)
        {
            targetPanel = panelFrom;
            SetColor(panelFrom.BackColor, true);
        }

        private void panelTo_Click(object sender, EventArgs e)
        {
            targetPanel = panelTo;
            SetColor(panelTo.BackColor, true);
        }

        private void audioColorWheel_ColorChanged(Color color)
        {
            SetColor(color, false);
        }

        private void audioHex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                TextBox box = sender as TextBox;
                Color color;
                try
                {
                    color = CConverter.ColorFromHex(audioHex.Text);
                }
                catch
                {
                    return;
                }
                chart1.Focus();
                e.SuppressKeyPress = true;
                SetColor(color, true);
            }
        }

        private void audioRgb_KeyDown(object sender, KeyEventArgs e)
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
                    chart1.Focus();
                    e.SuppressKeyPress = true;
                    SetColor(color, true);
                }
            }
        }

        private void audioHsv_KeyDown(object sender, KeyEventArgs e)
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
                    chart1.Focus();
                    e.SuppressKeyPress = true;
                    SetColor(CConverter.ColorFromHSV(hsvColor), true);
                }
            }
        }

        void SetColor(Color color, bool setColorPicker)
        {
            if (setColorPicker)
                audioColorWheel.PickedColor = color;
            audioRgb.Text = color.R + "," + color.G + "," + color.B;
            HSVcolor hsvColor = CConverter.ColorToHSV(color);
            audioHsv.Text = Math.Round(hsvColor.Hue, 0) + "," + Math.Round(hsvColor.Saturation, 2) + "," + Math.Round(hsvColor.Value, 2);
            audioHex.Text = CConverter.HexFromColor(color);
            targetPanel.BackColor = color;
            if (targetPanel == panelFrom)
            {
                colorFrom = color;
            }
            if (targetPanel == panelTo)
            {
                colorTo = color;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.Maximum = Mathf.Clamp(1 / multiplier, 0.1f, 2);
            if (chart1.ChartAreas[0].AxisX.Maximum > 1)
                chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 0.4;
            else if (chart1.ChartAreas[0].AxisX.Maximum <= 1)
                chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 0.2;
            for (int i = 0; i < 20; i++)
            {
                float x = i / 20f;
                chart1.Series[0].Points.AddXY(x / multiplier, Math.Pow(x, coefficient));
            }
        }
    }
}
