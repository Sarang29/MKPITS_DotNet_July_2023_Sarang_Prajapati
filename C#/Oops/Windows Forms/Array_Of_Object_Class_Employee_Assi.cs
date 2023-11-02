using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Of_Object_Class_Employee_Assi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employe[] emp = new Employe[3];
        int counter = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            emp[0] = new Employe();
            emp[1] = new Employe();
            emp[2] = new Employe();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(counter < 3)
            {
                emp[counter].EmployeId = Convert.ToInt32(textBox1.Text);
                emp[counter].EmployeName = textBox2.Text;
                emp[counter].EmployeSalary = Convert.ToInt32(textBox3.Text);
                counter++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }
            if (counter == 3)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Details Of Employee : \n");
            for (int i=0;i<3; i++)
            {
                sb.Append("-----------------------------------------\n");
                sb.Append("Employe Id : " + emp[i].EmployeId+"\n");
                sb.Append("Employe Name : " + emp[i].EmployeName+"\n");
                sb.Append("Employe Salary : " + emp[i].EmployeSalary+"\n");
                sb.Append("-----------------------------------------\n");

                label4.Text = sb.ToString();

                double high = emp[0].EmployeSalary;
                int foundat = 0;
                int innercounter;

                for(innercounter=0;innercounter<3;innercounter++)
                {
                      if (high < emp[innercounter].EmployeSalary)
                      {
                          high = emp[innercounter].EmployeSalary;
                          foundat = innercounter;
                      }
                }
                StringBuilder sb1 = new StringBuilder();

                sb1.Append("Employe With Highest Salary : \n");
                sb1.Append("-------------------------------------------------\n");
                sb1.Append("Employe Id : " + emp[foundat].EmployeId + "\n");
                sb1.Append("Employe Name : " + emp[foundat].EmployeName + "\n");
                sb1.Append("Employe Salary : " + emp[foundat].EmployeSalary + "\n");

                label5.Text= sb1.ToString();
            }
        }
    }
}
