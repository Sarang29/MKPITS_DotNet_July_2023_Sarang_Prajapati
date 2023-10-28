using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Element_in_Array_Disp_In_Reverse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] num = new int[5];
        int sum = 0;
        int counter = 0;
        StringBuilder sb = new StringBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            if(counter<5)
            {
                num[counter] = Convert.ToInt32(textBox1.Text);
                counter++;
                textBox1.Clear();
                textBox1.Focus();

                if(counter == 5)
                {
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("You Have Entered 5 Numbers Now Click On Result");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0;i<5;i++)
            {
                sb.Append(+ num[i]);
            }
            label2.Text=sb.ToString();
        }
    }
}
