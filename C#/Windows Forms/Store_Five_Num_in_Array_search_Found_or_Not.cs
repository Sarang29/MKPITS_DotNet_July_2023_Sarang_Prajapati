using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Five_Num_in_Array_search_Found_or_Not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] num = new int[5];
        int counter;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(counter < 5)
            {
                num[counter] = Convert.ToInt32(textBox1.Text);
                counter++;
                textBox1.Clear();
                textBox1.Focus();

                if(counter == 5)
                {
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("You Have Entered 5 Number Now Check Number in Array");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int flag = 0;
            int unum = Convert.ToInt32(textBox2.Text);
            int index = 0;

            for (int i=0;i<num.Length; i++)
            {
                if (num[i]==unum)
                {
                    flag = 1;
                    index = i + 1;
                    break;
                }
            }
            if (flag == 1)
            {
                label3.Text = "Number Found in Array";
            }
            else
            {
                label3.Text = "Number Not Found in Array";
            }
        }
    }
}
