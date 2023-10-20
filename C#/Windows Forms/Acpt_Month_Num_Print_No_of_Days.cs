using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acpt_Month_Num_Print_No_of_Days
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int monthno = Convert.ToInt32(textBox1.Text);

            if(monthno == 1 || monthno == 3 || monthno == 5 || monthno == 7 || monthno == 8 || monthno == 10 || monthno == 12)
            {
                label2.Text = " Month Has 31 Days";
            }
            else if (monthno == 2)
            {
                label2.Text = "Month Has 28 or 29 days";
            }
            else
            {
                label2.Text = "Month Has 30 Days";
            }
        }
    }
}
