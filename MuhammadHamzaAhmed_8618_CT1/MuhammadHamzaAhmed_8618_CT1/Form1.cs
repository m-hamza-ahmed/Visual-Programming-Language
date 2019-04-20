using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhammadHamzaAhmed_8618_CT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            MessageBox.Show("the addition result is " + (a + b));
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            MessageBox.Show("the subtraction result is " + (a - b));
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            MessageBox.Show("the multiplication result is " + (a * b));
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            MessageBox.Show("the division result is " + (a / b));
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt16(textBox1.Text);
            MessageBox.Show("the result of sin in radians is " + (Math.Sin(a)));
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt16(textBox1.Text);
            MessageBox.Show("the result of cos in radians is " + (Math.Cos(a)));
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt16(textBox1.Text);
            MessageBox.Show("the result of tan in radians is " + (Math.Tan(a)));
            Close();
        }
    }
}
