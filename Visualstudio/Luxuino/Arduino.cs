using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArduinoUploader;
using System.IO;
using ArduinoUploader.Hardware;
using System.IO.Ports;

namespace LedController
{
    public partial class Arduino : UserControl
    {
        public ArduinoModel Model = ArduinoModel.NanoR3;
        public string Port = null;
        
        public Arduino()
        {
            InitializeComponent();
        }

        private void arduinoDevice_SelectedValueChanged(object sender, EventArgs e)
        {
            Model = (ArduinoModel)arduinoDevice.SelectedItem;
        }

        private void Arduino_Load(object sender, EventArgs e)
        {
            foreach (ArduinoModel en in Enum.GetValues(typeof(ArduinoModel)))
            {
                if (en == ArduinoModel.Mega1284)
                    continue;
                arduinoDevice.Items.Add(en);
            }
            arduinoDevice.SelectedItem = Model;

            foreach(string portName in SerialPort.GetPortNames())
            {
                Ports.Items.Add(portName);
            }
        }
    }
}
