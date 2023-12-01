using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acpt_Three_Num_Disp_Greatest_Num_Prac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int num3 = Convert.ToInt32(textBox3.Text);

            if(num1 > num2 && num1 > num3)
            {
                label4.Text = "Number 1 is Greatest : " + num1;
            }
            else if(num2 > num3 && num2 > num1)
            {
                label4.Text = "Number 2 is Greatest : " + num2;
            }
            else if(num3 > num1 && num3 > num2)
            {
                label4.Text = "Number 3 is Greatest : " + num3;
            }

        }
    }
}
