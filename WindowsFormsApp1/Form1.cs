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
            double Rt = R1 + R2 + R3;

            label5.Text = "Total resistance = " + Rt.ToString("0.00");

        }
    }
}
