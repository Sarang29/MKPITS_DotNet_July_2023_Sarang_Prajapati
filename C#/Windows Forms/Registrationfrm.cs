using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiForms_Register_Login
{
    public partial class Registrationfrm : Form
    {
        public Registrationfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name : " + textBox1.Text + "\n");
            sb.Append("Mobile Number : "+maskedTextBox1.Text + "\n");
            
            if(radioButton1.Checked)
            {
                sb.Append("Gender : Male\n");
            }
            else if(radioButton2.Checked)
            {
                sb.Append("Gender : Female\n");
            }

            sb.Append("State : " + comboBox1.Text + "\n");
            sb.Append("City : " + comboBox2.Text + "\n");

            label6.Text = sb.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Maharashtra")
            {
                comboBox2.Items.Add("Nagpur");
                comboBox2.Items.Add("Pune");
                comboBox2.Items.Add("Nashik");
            }
            else if(comboBox1.Text=="Haryana")
            {
                comboBox2.Items.Add("Gurugram");
                comboBox2.Items.Add("Karnal");
                comboBox2.Items.Add("Wagha Border");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
