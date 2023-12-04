using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_Bonus_TotalSalary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        float totalsalary = 0;
        float bonus = 0;
        int salary;
        int empno;
        string designation;
        private void button1_Click(object sender, EventArgs e)
        {
            empno = Convert.ToInt32(textBox1.Text);
            salary = Convert.ToInt32(textBox2.Text);
            designation = textBox3.Text;

            StringBuilder sb = new StringBuilder();
            sb.Append("Employee Number " + empno + "\n");

            if (designation == "manager")
            {
                bonus = salary * 0.50f;
                totalsalary = salary + bonus;
            }
            else if(designation == "clerk")
            {
                bonus = salary * 0.45f;
                totalsalary = salary + bonus;
            }
            else if (designation == "peon")
            {
                bonus = salary * 0.25f;
                totalsalary = salary + bonus;
            }

            if(checkBox1.Checked)
            {
                sb.Append("Bonus : " + bonus + "\n");
            }
            if(checkBox2.Checked)
            {
                sb.Append("Total Salary : " + totalsalary+"\n");
            }
            
            label4.Text=sb.ToString();
        }
    }
}
