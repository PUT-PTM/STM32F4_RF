using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;


namespace STM32F4_RF_PROG
{
    public partial class Form1 : Form
    {
        SerialPort portDevice;

        public Form1()
        {
            InitializeComponent();
        }

        [STAThread]

        private void SendSampleData(SerialPort port, string l)
        {
            this.portDevice.Write(l);
            //this.gettingText.AppendText(l);
            //port.Write(l + "&");
            //port.Write(new byte[] { 0x0A, 0xE2, 0xFF }, 0, 3);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BarCzulosc_ValueChanged(object sender, EventArgs e)
        {
            this.LabelCzulosc.Text = this.BarCzulosc.Value.ToString();
        }

        private void BarPower_ValueChanged(object sender, EventArgs e)
        {
            this.LabelPower.Text = this.BarPower.Value.ToString();
        }

        private void BarKanal_ValueChanged(object sender, EventArgs e)
        {
            this.LabelKanal.Text = this.BarKanal.Value.ToString();
        }

        private void BarSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LabelSpeed.Text = this.BarSpeed.SelectedItem.ToString();
        }

        private void start_Click(object sender, EventArgs e)
        {
            string com = this.textCOM.Text;

            this.portDevice = new SerialPort(com, 57600, Parity.None, 8, StopBits.One);
            this.portDevice.Open();

            Listen LISTEN = new Listen(this.portDevice, this.gettingText);

            Thread oThread = new Thread(new ThreadStart(LISTEN.Listening));
            oThread.Start();

           // this.portDevice.Write(new byte[] { 0x43, 0x78, 0x1E, 0x07, Convert.ToByte(4) }, 0, 5);
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string text = this.BoxSend.Text;
            SendSampleData(this.portDevice, text);
            this.BoxSend.Text = "";
        }

        private void saveConfig_Click(object sender, EventArgs e)
        {
            this.portDevice.Write(new byte[] { 0x43, 0x78, 0x1E, 0x09, Convert.ToByte(this.LabelPower.Text) }, 0, 5);
            this.portDevice.Write(new byte[] { 0x43, 0x78, 0x1E, 0x010, Convert.ToByte(this.LabelCzulosc.Text) }, 0, 5);
            this.portDevice.Write(new byte[] { 0x43, 0x78, 0x1E, 0x07, Convert.ToByte(this.LabelKanal.Text) }, 0, 5);
            this.portDevice.Write(new byte[] { 0x43, 0x78, 0x1E, 0x08, Convert.ToByte(this.LabelSpeed.Text) }, 0, 5);
        }

    }
}
