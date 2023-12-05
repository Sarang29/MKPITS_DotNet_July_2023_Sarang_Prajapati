using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Registration_Form_New
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            if(comboBox1.Text=="India")
            {
                comboBox2.Items.Add("Maharashtra");
                comboBox2.Items.Add("Haryana");
            }
            else if(comboBox1.Text=="USA")
            {
                comboBox2.Items.Add("California");
                comboBox2.Items.Add("Alaska");
            }
            else if(comboBox1.Text=="Europe")
            {
                comboBox2.Items.Add("Bulgaria");
                comboBox2.Items.Add("Germany");  
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox3.Text = "";
            if (comboBox2.Text == "Maharashtra")
            {
                comboBox3.Items.Add("Nagpur");
                comboBox3.Items.Add("Pune");
                comboBox3.Items.Add("Kolhapur");
            }
            else if (comboBox2.Text == "Haryana")
            {
                comboBox3.Items.Add("Gurugram");
                comboBox3.Items.Add("Karnal");
            }
            else if (comboBox2.Text == "California")
            {
                comboBox3.Items.Add("Los Angeles");
                comboBox3.Items.Add("San Fransisco");
            }
            else if (comboBox2.Text == "Alaska")
            {
                comboBox3.Items.Add("Nome");
                comboBox3.Items.Add("Fairbanks");
            }
            else if (comboBox2.Text == "Bulgaria")
            {
                comboBox3.Items.Add("Gabrovo");
                comboBox3.Items.Add("Lovech");
            }
            else if (comboBox2.Text == "Germany")
            {
                comboBox3.Items.Add("Berlin");
                comboBox3.Items.Add("Frankfrut");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Username : " + textBox1.Text + "\n");
            sb.Append("Password : " + textBox2.Text + "\n");

            string gender = null;
            if(radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }

            sb.Append("Gender : " + gender + "\n");


            string course = null;
            if(checkBox1.Checked)
            {
                course = checkBox1.Text;
            }
            if(checkBox2.Checked)
            {
                course = course +" "+ checkBox2.Text;
            }
            if(checkBox3.Checked)
            {
                course = course +" "+ checkBox3.Text;
                
            }
            sb.Append("Course : " + course + "\n");


            sb.Append("Country : " + comboBox1.Text + "\n");
            sb.Append("State : " + comboBox2.Text + "\n");
            sb.Append("City : " + comboBox3.Text + "\n");

            label8.Text = sb.ToString();
        }
    }
}
