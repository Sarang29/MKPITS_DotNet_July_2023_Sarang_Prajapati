using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collection_Cls_ArrayList_Class_Student_WinFroms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            Student s1 = new Student(Convert.ToInt32(textBox1.Text), textBox2.Text);
            Student s2 = new Student(Convert.ToInt32(textBox3.Text), textBox4.Text);

            ar.Add(s1);
            ar.Add(s2);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
            textBox2.Focus();
            textBox3.Focus();
            textBox4.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Student s in ar)
            {
                sb.Append("Roll No : " + s.rollno + "Name : "+s.Name+"\n");
            }
            label5.Text = sb.ToString();
        }
    }
}
