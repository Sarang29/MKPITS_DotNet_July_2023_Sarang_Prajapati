using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acpt_Three_Sub_Marks_Disp_Tot_Per_Grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            int s3 = Convert.ToInt32(textBox3.Text);

            int total = s1 + s2 + s3;

            float per = (total / 300.0f) * 100.0f;

            string grade;

            if (per >= 75)
            {
                grade = "Distinction";
            }
            else if (per >= 60 && per < 75)
            {
                grade = "First";
            }
            else if(per >= 40 && per < 60)
            {
                grade = "Second";
            }
            else
            {
                grade = "Fail";
            }

            label4.Text = "Total : " + total;

            label5.Text = "Percentage : " + per;

            label6.Text = "Grade : " + grade;
        }
    }
}
