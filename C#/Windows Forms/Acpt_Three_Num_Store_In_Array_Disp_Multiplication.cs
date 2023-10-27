using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acpt_Three_Num_Store_In_Array_Disp_Multiplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] num = new int[3];
        int mul = 1;
        int counter = 0;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(counter < 3)
            {
                num[counter] = Convert.ToInt32(textBox1.Text);
                counter++;
                textBox1.Clear();
                textBox1.Focus();

                if(counter == 3)
                {
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("You Have Entered 3 Numbers Now Click Result");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<3;i++)
            {
                mul = mul * num[i];
            }
            label2.Text = "Multiplication = " + mul;
        }
    }
}
