using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        DateTime startStatus;
        DateTime counter;
        public Form1()
        {
            InitializeComponent();
            startStatus = DateTime.MinValue;
            label1.Text = startStatus.ToString("HH:mm:ss");
            counter = startStatus;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            counter = startStatus;
            label1.Text = counter.ToString("HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter = counter.AddSeconds(7);
            label1.Text = counter.ToString("HH:mm:ss");
        }
    }
}
