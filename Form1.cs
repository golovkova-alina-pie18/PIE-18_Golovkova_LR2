using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            label4.Text = "Сложение: " + x.ToString() + " и " + y.ToString();
            int S = x + y;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = S.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            label4.Text = "Вычитание: " + x.ToString() + " и " + y.ToString();
            int S = x - y;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = S.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            label4.Text = "Умножение: " + x.ToString() + " и " + y.ToString();
            int S = x * y;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = S.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            label4.Text = "Деление: " + x.ToString() + " и " + y.ToString();
            double S = x / y;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = S.ToString();

        }

       
    }
}

