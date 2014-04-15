using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;

namespace STM32F4_RF
{
    public class Listen
    {
        public SerialPort port;
        public string buffor;
        public Listen()
        {
            
        }

        public Listen(SerialPort p)
        {
            this.port = p;
        }

        public void Listening()
        {
             
             port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        }
        public void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        
        {
            //Console.WriteLine("Data incoming: " + port.ReadExisting());
            
            buffor += port.ReadExisting();
            if(buffor.Length > 0)
                if (buffor[buffor.Length - 1] == '&')
                {
                    if (buffor[0] == '\n') buffor = buffor.Remove(0, 1);
                    Console.WriteLine("\nSTM: " + buffor.Remove(buffor.Length - 1, 1));
                    buffor = "";
                }
            
        }
    };

    class Program
    {
        
        [STAThread]

        static private void SendSampleData(SerialPort port, string l)
        {
            port.Write(l + "&");
            port.Write(new byte[] { 0x0A, 0xE2, 0xFF }, 0, 2);

        }

        static void Main(string[] args)
        {
            SerialPort port = new SerialPort("COM6", 9600, Parity.None, 8, StopBits.One);
            port.Open();
            Listen LISTEN = new Listen(port);

            Thread oThread = new Thread(new ThreadStart(LISTEN.Listening));
            oThread.Start();

            //string line;
            //String cos;
            while(true)
            {
                string line = Console.ReadLine();
                if (line == "bb") break;
                SendSampleData(port, line);
                line = "";
            }
        }
    }
}
