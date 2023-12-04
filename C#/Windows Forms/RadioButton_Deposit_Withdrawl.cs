using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton_Deposit_Withdrawl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int accno;
        int amount;
        int balance = 1000;
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            accno = Convert.ToInt32(textBox1.Text);
            amount = Convert.ToInt32(textBox2.Text);
            if(radioButton1.Checked)
            {
                balance = balance + amount;
                sb.Append("Account Number : " + accno + "\n");
                sb.Append("Balance : " + balance + "\n");
            }
            else if(radioButton2.Checked)
            {
                balance = balance - amount;
                sb.Append("Account Number : " + accno + "\n");
                sb.Append("Balance : " + balance + "\n");
            }

            label3.Text=sb.ToString();
        }
    }
}
