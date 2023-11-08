using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Of_Object_Class_Student_Disp_Fees_and_FeesDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student[] student1 = new Student[10];
        int counter = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            student1[0] = new Student();
            student1[1] = new Student();
            student1[2] = new Student();
            student1[3] = new Student();
            student1[4] = new Student();
            student1[5] = new Student();
            student1[6] = new Student();
            student1[7] = new Student();
            student1[8] = new Student();
            student1[9] = new Student();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter<10)
            {
                student1[counter].RollNo = Convert.ToInt32(textBox1.Text);
                student1[counter].StudentName = textBox2.Text;
                student1[counter].Fees = Convert.ToInt32(textBox3.Text);
                student1[counter].date = textBox4.Text;
                counter++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();

                if(counter == 10)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("Student Details Accepted Now Click on Submit");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Student Details : \n");
            int i;

            for (i = 0; i < 10; i++) 
            {
                sb.Append("---------------------------------------------------------\n");
                sb.Append("Student Roll No : " + student1[i].RollNo + "\n");
                sb.Append("Student Name : " + student1[i].StudentName + "\n");
                sb.Append("Student Fees : " + student1[i].Fees + "\n");
                sb.Append("Student Fees Date : " + student1[i].date + "\n");
                sb.Append("---------------------------------------------------------\n");
            }
            richTextBox1.Text = sb.ToString();

            int flag = student1[0].Fees;
            int foundat = 0;

            for(int p=0; p<10; p++)
            {
                if (flag < student1[p].Fees)
                {
                    flag = student1[p].Fees;
                    foundat = p;
                }
            }

            StringBuilder sb1 = new StringBuilder();
            sb.Append("--------------------------------------------------------\n");
            sb.Append("Student Roll No : " + student1[foundat].RollNo+"\n");
            sb.Append("Student Name : " + student1[foundat].StudentName + "\n");
            sb.Append("Student Fees : " + student1[foundat].Fees + "\n");
            sb.Append("Student Date : " + student1[foundat].date + "\n");

            label5.Text = sb1.ToString();

        }
    }
}
