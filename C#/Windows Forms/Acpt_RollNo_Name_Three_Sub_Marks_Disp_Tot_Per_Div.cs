using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acpt_RollNo_Name_Three_Sub_Marks_Disp_Tot_Per_Div
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rollno = Convert.ToInt32(textBox1.Text);
            string name = (textBox2.Text);
            int s1 = Convert.ToInt32(textBox3.Text);
            int s2 = Convert.ToInt32(textBox4.Text);
            int s3 = Convert.ToInt32(textBox5.Text);

            label6.Text = "Roll No : " + rollno;
            label7.Text = "Name : " + name;

            int total = s1 + s2 + s3;
            label8.Text = "Total : " + total;
            float per = (total / 300.0f) * 100.0f;
            label9.Text = "Percentage : " + per;
            string div;

            if(per >= 75)
            {
                div = "Distinction";
            }
            else if(per >= 60 && per < 75)
            {
                div = "First Class";
            }
            else if(per >= 40 && per < 60)
            {
                div = "Second Class";
            }
            else
            {
                div = "Fail";
            }
            label10.Text = "Division : "+div;

        }
    }
}
