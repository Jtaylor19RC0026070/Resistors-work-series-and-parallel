﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double R = Convert.ToDouble(textBox1.Text);
            double C = Convert.ToDouble(textBox2.Text);

            double t = R * C;
            double DeceyConstant = 1 / t; 
        }
    }
}
