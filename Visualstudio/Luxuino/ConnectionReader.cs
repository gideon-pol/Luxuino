using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace LedController
{
    class ConnectionReader
    {
        SerialPort port;

        public delegate void Handler(string msg);
        public event Handler DataReceived;

        public ConnectionReader(SerialPort p)
        {
            port = p;
        }

        public void Start()
        {
            new Thread(() => ReadConnection());
        }

        void ReadConnection()
        {
            while (true)
            {
                try
                {
                    string msg = port.ReadLine();
                    DataReceived.Invoke(msg);
                    Console.WriteLine(msg);
                }
                catch (Exception e)
                {
                    return;
                }
            }
        }
    }
}
