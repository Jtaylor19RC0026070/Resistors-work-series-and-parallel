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
            try
            {
                double R1 = Convert.ToDouble(textBox1.Text);
                double R2 = Convert.ToDouble(textBox2.Text);
                double R3 = Convert.ToDouble(textBox3.Text);

                double t = R1 + R2 + R3;
                double DeceyConstant = 1 / t; 

                label5.Text = "Decey Constant = " + DeceyConstant.ToString("0.00");
            }
            catch
            {
                label5.Text = "Decey Constant = ";
            }
           

        }
    }
}
