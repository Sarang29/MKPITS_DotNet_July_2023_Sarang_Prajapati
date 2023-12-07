using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name : " + textBox1.Text + "\n");
            sb.Append("Mobile No : " + maskedTextBox1.Text + "\n");
            sb.Append("Email : " + textBox2.Text + "\n");

            label11.Text=sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Student Name : " + textBox3.Text + "\n");
            sb1.Append("Mobile No : " + maskedTextBox2.Text + "\n");
            sb1.Append("Class You Want To Take Admission : " + textBox4.Text + "\n");
            sb1.Append("Parents Name : " + textBox5.Text + "\n");
            sb1.Append("Parents Mobile No : " + maskedTextBox3.Text + "\n");
            sb1.Append("Email : " + textBox6.Text + "\n");

            label10.Text = sb1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox7.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
    }
}
