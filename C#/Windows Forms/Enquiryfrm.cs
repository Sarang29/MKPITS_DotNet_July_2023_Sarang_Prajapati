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
    public partial class Enquiryfrm : Form
    {
        public Enquiryfrm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name : " + textBox1.Text + "\n");
            sb.Append("Mobile Number : " + maskedTextBox1.Text + "\n");
            sb.Append("Email : " + textBox2.Text + "\n");
            sb.Append("City : " + textBox3.Text + "\n");

            label5.Text = sb.ToString();
        }
    }
}
