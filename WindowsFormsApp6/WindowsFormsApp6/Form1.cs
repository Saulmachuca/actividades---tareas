using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double número1 = Convert.ToDouble(textBox1.Text);
            double número2 = Convert.ToDouble(textBox2.Text);
            double suma = número1 + número2;
            label3.Text = "La suma es: " + suma.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double número1 = Convert.ToDouble(textBox1.Text);
            double número2 = Convert.ToDouble(textBox2.Text);
            double resta = número1 - número2;
            label3.Text = "La suma es: " + resta.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            double número1 = Convert.ToDouble(textBox1.Text);
            double número2 = Convert.ToDouble(textBox2.Text);
            double multiplicación = número1 * número2;
            label3.Text = "El resultado es: " + multiplicación.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            double número1 = Convert.ToDouble(textBox1.Text);
            double número2 = Convert.ToDouble(textBox2.Text);
            double división = número1 / número2;
            label3.Text = "El resultado es: " + división.ToString();
        }
    }
}
