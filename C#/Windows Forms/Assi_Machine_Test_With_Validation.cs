using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assi_Machine_Test_With_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (textBox1.Text=="")
            {
                MessageBox.Show("Please Enter Name & Age");
                textBox1.Focus();
            }
            sb.Append("Name : " + textBox1.Text + "\n");

            if (numericUpDown1.Value < 18)
            {
                MessageBox.Show("Please Select Age 18 or Above 18");
            }
            else
            {
                sb.Append("Age : " + numericUpDown1.Value.ToString());
            }
            
            
            
            label3.Text=sb.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numericUpDown1.Value = 0;
            label3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome");
        }
    }
}
