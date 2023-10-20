using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acpt_Two_Num_Choose_Calculation
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
            int choice = Convert.ToInt32(textBox3.Text);
            int total = 0;

            if (choice == 1)
            {
                total = num1 + num2;
                label4.Text = "Result = " + total;
            }
            else if(choice == 2)
            {
                total = num1 - num2;
                label4.Text = "Result = " + total;
            }
            else if(choice == 3)
            {
                total = num1 * num2;
                label4.Text = "Result = " + total;
            }
            else if(choice == 4)
            {
                total = num1 / num2;
                label4.Text = "Result = " + total;
            }
            else
            {
                label4.Text = "Invalid Choice";
            }

            
        }
    }
}
