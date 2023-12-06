using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiForms_Enquiry_Admission
{
    public partial class Admissionfrm : Form
    {
        public Admissionfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Student Name : " + textBox1.Text + "\n");
            sb.Append("Class Applying for : " + textBox2.Text + "\n");
            sb.Append("Date of Birth : " + maskedTextBox1.Text + "\n");
            sb.Append("Parents Name : " + textBox3.Text + "\n");
            sb.Append("Current Address : " + textBox4.Text + "\n");
            sb.Append("Mobile Number : " + maskedTextBox2.Text + "\n");
            sb.Append("Email : " + textBox5.Text + "\n");

            label8.Text = sb.ToString();
        }
    }
}
