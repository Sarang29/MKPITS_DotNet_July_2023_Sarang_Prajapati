using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Registration_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string username = textBox1.Text;
            string password = textBox2.Text;
            string course = null;
            string gender = null;
            string city = null;
            sb.Append("UserName : " + username + "\n");
            sb.Append("PassWord : " + password + "\n");
            if(radioButton1.Checked)
            {
                gender = "Male";
                sb.Append("Gender : "+gender +"\n");
            }
            else if(radioButton2.Checked)
            {
                gender = "Female";
                sb.Append("Gender : "+gender+"\n");
            }

            if(checkBox1.Checked)
            {
                course = "Java";
                sb.Append("Course : "+course+"\n");
            }
            if(checkBox2.Checked)
            {
                course = "Dotnet";
                sb.Append("Course : "+course+"\n");
            }

            if (comboBox1.Text == "Nagpur")
            {
                city = "Nagpur";
                sb.Append("City : " + city + "\n");
            }
            else if (comboBox1.Text == "Pune")
            {
                city = "Pune";
                sb.Append("City : " + city + "\n");
            }
            else if (comboBox1.Text == "Delhi")
            {
                city = "Delhi";
                sb.Append("City : " + city + "\n");
            }
            else if (comboBox1.Text == "Banglore")
            {
                city = "Delhi";
                sb.Append("City : " + city + "\n");
            }
            else if (comboBox1.Text == "Hyderabad")
            {
                city = "Delhi";
                sb.Append("City : " + city + "\n");
            }

            label6.Text = sb.ToString();
        }
    }
}
