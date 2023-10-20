using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Print_Greatest_num_Among_3_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;

            n1=Convert.ToInt32(textBox1.Text);
            n2=Convert.ToInt32(textBox2.Text);
            n3=Convert.ToInt32(textBox3.Text);

            if(n1 > n2 && n1 > n3)
            {
                label4.Text = "Number 1 is Greatest";
            }
            else if(n2 > n1 && n2 > n3)
            {
                label4.Text = "Number 2 is Greatest";
            }
            else if(n3 > n1 && n3 > n2)
            {
                label4.Text = "Number 3 is Greatest";
            }
            else
            {
                label4.Text = "invalid";
            }
        }
    }
}
