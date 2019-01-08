using System;
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
        private object b1Answer;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double R1, R2, R3, R4, R5;
            // 
            try
            {
                R1 = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                R1 = 0;
            }
            try
            {
                R2 = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                R2 = 0;
            }
            try
            {
                R3 = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                R3 = 0;
            }
            try
            {
                R4 = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                R4 = 0;
            }
            try
            {
                R5 = Convert.ToDouble(textBox5.Text);
            }
            catch
            {
                R5 = 0;
            }
            //
            double Rt = R1 + R2 + R3 + R4 + R5;
            // This allows my answer to be showed through the total series label to 2 decimal places
            label5.Text = "Total Series = " + Rt.ToString("0.00");
              
            // This piece of code applies R1,R2,R3,R4,R5 is equal to 0
            if (R1 == 0)
            {
                R1 = Double.PositiveInfinity;
            }
            if (R2 == 0)
            {
                R2 = Double.PositiveInfinity;
            }
            if (R3 == 0)
            {
                R3 = Double.PositiveInfinity;
            }
            if (R4 == 0)
            {
                R4 = Double.PositiveInfinity;
            }
            if (R5 == 0)
            {
                R5 = Double.PositiveInfinity;
            }

            //
            double RR = 1/R1 + 1/R2 + 1/R3 + 1/R4 + 1/R5;
            RR = 1 / RR;

            //
            label7.Text = "Total Parallel = " + RR.ToString("0.00");
           
        }
    }
}

