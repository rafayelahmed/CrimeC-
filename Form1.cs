﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimeDBFInal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Rafayel Ahmed CD11";
        }


        // new function added CD-12
        private void tfn()
        {
            textBox1.Text = "tfn";
            //this is a test of vs code with new jira CD-13
        }

           // new function added CD-15
        private void CD15()
        {
            textBox1.Text = "CD-15";
            //this is a test of vs code with new jira CD-13
        }


    }
}
