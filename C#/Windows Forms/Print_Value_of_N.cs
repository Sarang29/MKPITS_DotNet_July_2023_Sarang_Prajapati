using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Print_Value_of_N
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m=Convert.ToInt32(textBox1.Text);

            if(m>0)
            {
                label2.Text = "Value of N = 1";
            }
            else if(m==0)
            {
                label2.Text = "Value of N = 0";
            }
            else if(m<0)
            {
                label2.Text = "Value of N = -1";
            }
            else
            {
                label2.Text = "Invalid Value";
            }
        }
    }
}
