using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado_StudentClass_Information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentClass s = new StudentClass();

            string g = null;
            if (radioButton1.Checked)
            {
                g = "Male";
            }
            if (radioButton2.Checked)
            {
                g = "Female";
            }

            string h = null;
            if (checkBox1.Checked)
            {
                h = "Dancing";
            }
            if (checkBox2.Checked)
            {
                if (h != null)
                {
                    h = h + " " + "Singing";
                }
                else
                {
                    h = "Singing";
                }
            }
            string result = s.InsertStudent(Convert.ToInt32(textBox1.Text), textBox2.Text, g, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text=result;
            cleartext();
        }
        public void cleartext()
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentClass s = new StudentClass();

            string g = null;
            if (radioButton1.Checked)
            {
                g = "Male";
            }
            if (radioButton2.Checked)
            {
                g = "Female";
            }

            string h = null;
            if (checkBox1.Checked)
            {
                h = "Dancing";
            }
            if (checkBox2.Checked)
            {
                if (h != null)
                {
                    h = h + " " + "Singing";
                }
                else
                {
                    h = "Singing";
                }
            }
            string result = s.UpdateStudent(Convert.ToInt32(textBox1.Text), textBox2.Text, g, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text = result;
            cleartext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentClass s = new StudentClass();

            string result = s.DeleteStudent(Convert.ToInt32(textBox1.Text), textBox2.Text);
            label7.Text = result;
            cleartext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Student> li = new List<Student>();

            StudentClass s = new StudentClass();

            li = s.SearchStudent(Convert.ToInt32(textBox1.Text));

            textBox2.Text = li[0].studname;
            string g = li[0].gender;
            if(g=="male"|| g== "Male")
            {
                radioButton1.Checked = true;
            }
            else if(g=="female"||g=="Female")
            {
                radioButton2.Checked = true;
            }

            string h = li[0].hobby;
           
            
            if(h == "Dancing" && h == "Singing")
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
            }
            else if (h == "Dancing")
            {
                checkBox1.Checked = true;
            }
            else if (h == "Singing")
            {
                checkBox2.Checked = true;
            }

            comboBox1.Text = li[0].city;
            dateTimePicker1.Text = li[0].dob;

            label7.Text = "Records Found";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}