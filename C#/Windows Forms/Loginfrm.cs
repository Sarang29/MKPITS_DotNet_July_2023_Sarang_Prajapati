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
    public partial class Loginfrm : Form
    {
        public Loginfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           StringBuilder sb = new StringBuilder();
            sb.Append("Username : " + textBox1.Text + "\n");
            sb.Append("Password : " + textBox2.Text + "\n");

            label3.Text= sb.ToString();
        }
    }
}
