using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Subs_Mul_Div_Two_Num
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
        Calculate c = new Calculate();
        private void button1_Click(object sender, EventArgs e)
        {
            int res = c.Addition(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = "Addition : "+res.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int res = c.Substraction(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = "Substraction : " + res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int res = c.Multiplication(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = "Multiplication : " + res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float res = c.Division(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = "Division : " + res.ToString();
        }
    }
}
