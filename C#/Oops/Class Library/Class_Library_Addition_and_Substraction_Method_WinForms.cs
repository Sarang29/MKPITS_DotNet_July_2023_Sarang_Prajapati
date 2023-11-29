using Class_Library_Addition_and_Substraction_Method;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Library_Addition_and_Substraction_Method_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculate c1 = new Calculate();
        private void button1_Click(object sender, EventArgs e)
        {
            int display = c1.addition(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text="Addition : "+display;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int display = c1.substraction(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
            label3.Text = "Substraction : " + display;
        }
    }
}
