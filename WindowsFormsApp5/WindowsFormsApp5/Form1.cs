using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double número1 = Convert.ToDouble(textBox1.Text);
            double número2 = Convert.ToDouble(textBox2.Text);

            if (checkBox1.Checked == true)
            {
                double suma = número1 + número2;
                label3.Text = suma.ToString();

            }
            if (checkBox2.Checked == true)
            {
                double resta = número1 - número2;
                label3.Text = resta.ToString();

            }
        }
    }
}
