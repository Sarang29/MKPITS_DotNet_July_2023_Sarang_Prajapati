using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Create_Class_Person_Having_Attri_Method_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p1 = new Person();

            p1.getdata(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text);
            
            StringBuilder sb = new StringBuilder();

            sb.Append("\nName : " + p1.Name);
            sb.Append("\nAge : " + p1.Age);
            sb.Append("\nAddress : " + p1.Address);

            label4.Text = sb.ToString();    
        }
    }
}
