﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PHOCapturer;

namespace PHOCapturerTest
{
    public partial class Form1 : Form
    {
        PHOCapturerWorker worker = null;

        public Form1()
        {
            InitializeComponent();
            worker = new PHOCapturerWorker();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            worker.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            worker.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            worker.Capture();
        }
    }
}
