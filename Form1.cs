using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pfhelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label22.Text = "Name: " + textBox1.Text;
            label21.Text = "Protocol: " + comboBox1.Text;
            label20.Text = "WAN connection: " + comboBox2.Text;
            label19.Text = "WAN Host IP Range: " + "0 0 0 0 - 0 0 0 0";
            label18.Text = "MAC Mapping: " + "Off";
            label17.Text = "LAN Host IPv4: " + textBox13.Text + "." +  textBox10.Text + "." + textBox12.Text + "." + textBox11.Text;
            label16.Text = "LAN Host Port Range: " + textBox16.Text + "-" + textBox17.Text;
            label15.Text = "WAN Port Range: " + textBox14.Text + "-" + textBox15.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "portfordward helper";
            radioButton2.Checked = true;
        }

        private void label23_Click(object sender, EventArgs e)
        {
            string cmdT;
            cmdT = "/K ipconfig";
            Process.Start("CMD.exe", cmdT);
        }

        private void label24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Range of ports - must be same ranges.. like 21-21, 33-33...");
        }

        private void label25_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LAN port range - must be same ranges as in port ranges like.. if port range is 21-21 lan must be 21-21");

        }
    }
}