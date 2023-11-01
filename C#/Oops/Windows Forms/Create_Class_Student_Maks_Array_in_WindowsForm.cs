using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_Class_Student_Maks_Array_in_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student1 = new Student();

            string name=textBox1.Text;
            int no=Convert.ToInt32(textBox2.Text);
            int maths=Convert.ToInt32(textBox3.Text);
            int science=Convert.ToInt32(textBox4.Text);
            int english=Convert.ToInt32(textBox5.Text);

            student1.getdata(name, no, maths, science, english);

            StringBuilder sb = new StringBuilder();
            sb.Append("\nStudent Name : " + name);
            sb.Append("\nStudent Roll No : " + no);
            sb.Append("\nTotal : " + student1.total);
            sb.Append("\nAverage : " + student1.avg);
            label4.Text= sb.ToString();
        }
    }
}
