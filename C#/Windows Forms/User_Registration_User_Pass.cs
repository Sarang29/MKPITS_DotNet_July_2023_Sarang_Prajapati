using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Registration_User_Pass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;

            StringBuilder sb = new StringBuilder();

            sb.Append("UserName : "+name+"\n");
            sb.Append("PassWord : "+password+"\n");

            label3.Text=sb.ToString();
        }
    }
}
