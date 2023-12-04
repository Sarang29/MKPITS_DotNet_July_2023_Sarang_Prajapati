using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_Disp_Bonus_TotalSalary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int empno;
        float totalsalary;
        float bonus;
        string designation;
        int salary;
        private void button1_Click(object sender, EventArgs e)
        {

            empno = Convert.ToInt32(textBox1.Text);
            salary = Convert.ToInt32(textBox2.Text);

            if(comboBox1.Text=="manager")
            {
                bonus = salary * 0.45f;
                totalsalary = salary + bonus;
            }
            else if(comboBox1.Text=="clerk")
            {
                bonus = salary * 0.25f;
                totalsalary= salary + bonus;
            }
            else if(comboBox1.Text=="peon")
            {
                bonus = salary * 0.15f;
                totalsalary = salary + bonus;
            }
            StringBuilder sb = new StringBuilder();
            if(checkBox1.Checked)
            {
                sb.Append("Bonus : " + bonus+"\n");
            }
            if(checkBox2.Checked)
            {
                sb.Append("Total Salary : " + totalsalary+"\n");
            }

            label4.Text = sb.ToString();
        }
    }
}
