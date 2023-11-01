using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_Class_Person_In_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p1 = new Person();

            p1.Name = textBox1.Text;
            p1.Age = Convert.ToInt32(textBox2.Text);
            p1.Addresss = textBox3.Text;

            StringBuilder sb = new StringBuilder();
            sb.Append("Name : " + p1.Name);
            sb.Append("\nAge : " + p1.Age);
            sb.Append("\nAddress : " + p1.Addresss);

            label4.Text= sb.ToString();
        }
    }
}
