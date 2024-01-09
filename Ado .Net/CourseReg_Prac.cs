using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseReg_Prac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=CourseDb";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        enum category { Student,IT_Professional}
        enum gender { Male,Female,Other}

        category cat;
        gender gen;

        
        private void Form1_Load(object sender, EventArgs e)
        {
            GetNation();
            GetState();
            GetCity();
                    }

        public void GetNation()
        {
            con = new SqlConnection(strcon);
            da = new SqlDataAdapter("select * from TableNation order by NationID", con);
            ds = new DataSet();
            da.Fill(ds, "tablenation");
            comboBox1.DataSource = ds.Tables["tablenation"];
            comboBox1.DisplayMember = "NationName";
            comboBox1.ValueMember = "NationID";
        }

        public void GetState()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableState where NationID=@NationID", con);
                    da.SelectCommand.Parameters.AddWithValue("@NationID", comboBox1.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "tablestate");
                    comboBox2.DataSource = ds.Tables["tablestate"];
                    comboBox2.DisplayMember = "StateName";
                    comboBox2.ValueMember = "StateID";
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }


        public void GetCity()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableCity where StateID=@StateID", con);
                    da.SelectCommand.Parameters.AddWithValue("@StateID", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "tablecity");
                    comboBox3.DataSource = ds.Tables["tablecity"];
                    comboBox3.DisplayMember = "CityName";
                    comboBox3.ValueMember = "CityID";
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetState();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCity();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Full Name Cannot be Blank");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    cat = category.Student;
                }
                else if (radioButton2.Checked)
                {
                    cat = category.IT_Professional;
                }
                MessageBox.Show("Category " + cat);

                if (radioButton3.Checked)
                {
                    gen = gender.Male;
                }
                else if (radioButton4.Checked)
                {
                    gen = gender.Female;
                }
                else if (radioButton5.Checked)
                {
                    gen = gender.Other;
                }
                MessageBox.Show("Gender " + gen);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                cat = category.Student;
                textBox2.Text = "1000";
                textBox3.Text = "0";
                textBox4.Text = "0";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                cat = category.IT_Professional;
                textBox2.Text = "3000";
                textBox3.Text = "0";
                textBox4.Text = "0";
            }
        }

        public void CalculateFees()
        {
            if (cat.ToString() == "Student")
            {
                textBox2.Text = "1000";
                float ta = Convert.ToSingle(textBox2.Text);
                float fp = ta * 0.5f;
                float amt = Convert.ToSingle(textBox3.Text);

                if (amt < fp)
                {
                    MessageBox.Show("Minimum paid Amount Must be 50%");
                }
                else
                {
                    float bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }
            else if(cat.ToString()=="IT_Professional")
            {
                textBox2.Text = "3000";
                float ta = Convert.ToSingle(textBox2.Text);
                float fp = ta * 0.8f;
                float amt = Convert.ToSingle(textBox3.Text);

                if(amt < fp)
                {
                    MessageBox.Show("Minimum Paid Amount Must be 80%");
                }
                else
                {
                    float bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            CalculateFees();
        }
    }
}
