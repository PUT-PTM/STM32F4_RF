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

namespace RadioControl
{
    public partial class Form1 : Form
    {
        _RadioControl Radio;

        public Form1()
        {
            InitializeComponent();

            this.Radio = new _RadioControl();
            string[] p = Radio.CheckPorts();
            foreach (string port in p) {
                this.textBox1.AppendText(port + "\n");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //string[] p = Radio.CheckPorts();
            Radio.CreatPort("COM3");
            Radio.ChangePower("7");
            Radio.ChangeSpeed("50");
            Radio.ChangeSensitiveness("3");
            Radio.ChangeChannel("1");

            this.textBox1.AppendText(Radio.GetSets());

            Thread oThread = new Thread(new ThreadStart(Radio.ListeningSignal));
            oThread.Start();

            this.timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Radio.SendData("sas");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Radio.CheckSignal())
            {
                if (this.radioButton1.Checked == false)
                {
                    this.radioButton1.Checked = true;
                    this.radioButton1.Text = "TRUE";
                }
            }
            else
            {
                if (this.radioButton1.Checked == true)
                {
                    this.radioButton1.Checked = false;
                    this.radioButton1.Text = "FALSE";
                    this.textBox2.AppendText(DateTime.Now.ToString("h:mm:ss tt") + " - Rozłączono.\n");
                }
            }
        }
    }
}
