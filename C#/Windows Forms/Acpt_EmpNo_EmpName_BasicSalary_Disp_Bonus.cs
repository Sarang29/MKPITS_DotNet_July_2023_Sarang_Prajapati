using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acpt_EmpNo_EmpName_BasicSalary_Disp_Bonus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(textBox1.Text);
            string name = Convert.ToString(textBox2.Text);
            int salary = Convert.ToInt32(textBox3.Text);
            string designation = Convert.ToString(textBox4.Text);
            int total=0;



            if (designation == "manager")
            {
                total = salary + 5000;
            }
            else if (designation == "clerk")
            {
                total = salary + 2000;
            }
            else if (designation == "peon") 
            {
                total = salary + 1000;
            }
            else
            {
                label5.Text = "Invalid Designation";
            }
            label5.Text = "Employe Number : " + no;
            label6.Text = "Employe Name : " + name;
            label7.Text = "Basic Salary : " + salary;
            label8.Text = "Designation : " + designation;
            label9.Text = "Salary With Bonus : " + total;


        }
    }
}
