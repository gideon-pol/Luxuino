using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Reflection;
using System.Xml.Serialization;


namespace LedController
{
    public partial class Start : MetroFramework.Forms.MetroForm
    {
        SaveSettings settings = new SaveSettings();

        public Start()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public void Restart()
        {
            Port = new SerialPort("COM1", 38400);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            portSelector.Items.Clear();
            foreach (string port in SerialPort.GetPortNames())
            {
                portSelector.Items.Add(port);
            }
        }

        private void LedController_Load(object sender, EventArgs e)
        {
            portSelector.Items.Clear();
            foreach(string port in SerialPort.GetPortNames())
            {
                portSelector.Items.Add(port);
                if (port != "COM1")
                    portSelector.SelectedItem = port;
            }

            string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Luxuino");
            string path = directory + "/Settings.xml";
            XmlSerializer xml = new XmlSerializer(typeof(SaveSettings));

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            if (!File.Exists(path))
            {
                using (TextWriter writer = new StreamWriter(path))
                {
                    xml.Serialize(writer, settings);
                }
            }

            if (File.Exists(path))
            {
                using (Stream reader = new FileStream(path, FileMode.Open))
                {
                    settings = xml.Deserialize(reader) as SaveSettings;
                }
            }
            Styler.Theme = settings.Theme;
            Styler.Style = settings.Style;
        }

        private void connect_Click(object sender, EventArgs e)
        {
            
            if(portSelector.SelectedItem == null)
            {
                Error.Text = "Select a port";
                Error.Location = new Point((this.Width - Error.Width) / 2, 103);
                return;
            }
            Loading loading = new Loading();
            loading.Size = new Size(this.Width, 130);
            loading.Location = new Point(0, 53);
            Controls.Add(loading);
            loading.BringToFront();
            new System.Threading.Thread(() => WaitForConnectionAccept(loading, sender, e)).Start();
        }

        void WaitForConnectionAccept(Loading loading, object sender, EventArgs e)
        {
            try
            {
                Port.PortName = portSelector.SelectedItem.ToString();
                Port.Open();
                this.Invoke((MethodInvoker)delegate () {
                    Main main = new Main();
                    main.Port = Port;
                    main.Styler = Styler;
                    main.Styler.Owner = main;
                    main.settings1.settings = settings;
                    main.settings1.Init();
                    this.Hide();
                    main.Show();
                    main.startLoadingScreen = this;
                    main.FormClosed += (s, args)=> main = null;
                });
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(UnauthorizedAccessException))
                    Error.Text = "Access to port denied";
                else if (ex.GetType() == typeof(IOException))
                {
                    Error.Text = "Port doesnt exist";
                    portSelector.SelectedIndex = 0;
                    refresh_Click(sender, e);
                }
            }
            Error.Location = new Point((this.Width - Error.Width) / 2, 103);
            Controls.Remove(loading);
            loading.Dispose();
            GC.Collect();
        }
    }
}
