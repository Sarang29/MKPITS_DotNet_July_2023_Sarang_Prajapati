using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acpt_Three_Num_Store_in_Array_Disp_Addition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] num = new int[3];
        int sum = 0;
        int counter=0;
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
                    MessageBox.Show("You Have Entered 3 Numbers Now Click on Result");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           for (int i=0;i<3;i++)
            {
                sum = sum + num[i];
            }
            label2.Text = "Addition = " + sum;
        }
    }
}
