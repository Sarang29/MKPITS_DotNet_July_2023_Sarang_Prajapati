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

namespace Course_Registration_Form
{
    public partial class Form1 : Form
    {
        string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=CourseRegistration";
        SqlConnection con=null;
        SqlDataAdapter da=null;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            GetNation();
            GetState();
            GetCity();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCity(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetState();

        }

        enum category { Student,IT_Professional}
        enum gender { Male,Female,Other}

        category cat;
        gender gen;

        public void GetCity()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select *  from TableCity where State_ID=@State_ID", con);

                    da.SelectCommand.Parameters.AddWithValue("@State_ID", comboBox2.SelectedValue);

                    ds = new DataSet();
                    ds.Clear();

                    da.Fill(ds, "tablecity");
                    comboBox3.DataSource = ds.Tables["tablecity"];
                    comboBox3.DisplayMember = "City_Name";
                    comboBox3.ValueMember = "City_ID";
                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }

        public void GetNation()
        {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select *  from TableNation order by Nation_ID", con);

                    ds = new DataSet();

                    da.Fill(ds, "tablenation");
                    comboBox1.DataSource = ds.Tables["tablenation"];
                    comboBox1.DisplayMember = "Nation_Name";
                    comboBox1.ValueMember = "Nation_ID";
                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
        }

        public void GetState()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select *  from TableState where Nation_ID=@Nation_ID", con);

                    da.SelectCommand.Parameters.AddWithValue("@Nation_ID", comboBox1.SelectedValue);

                    ds = new DataSet();
                    ds.Clear();

                    da.Fill(ds, "tablestate");
                    comboBox2.DataSource = ds.Tables["tablestate"];
                    comboBox2.DisplayMember = "State_Name";
                    comboBox2.ValueMember = "State_ID";
                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Candidate Name Cannot be Blank");
            }
            else
            {
                if(radioButton1.Checked)
                {
                    cat = category.Student;
                }
                else if(radioButton2.Checked)
                {
                    cat = category.IT_Professional;
                }
                MessageBox.Show("Category " + cat);

                if(radioButton3.Checked)
                {
                    gen = gender.Male;
                }
                else if(radioButton4.Checked)
                {
                    gen = gender.Female;
                }
                else if(radioButton5.Checked)
                {
                    gen = gender.Other;
                }
                MessageBox.Show("Gender " + gen);
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            CalculateFees();
        }

        public void CalculateFees()
        {
            if(cat.ToString()=="Student")
            {
                float ta=Convert.ToSingle(textBox2.Text);
                float fp = ta * 0.05f;
                float amt = Convert.ToSingle(textBox3.Text);

                if(amt<ta)
                {
                    MessageBox.Show("Minimum Amount to be paid is 50%");
                }
                else
                {
                    float bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }
            else if(cat.ToString()=="IT_Professional")
            {
                float ta = Convert.ToSingle(textBox2.Text);
                float fp = ta * 0.08f;
                float amt = Convert.ToSingle(textBox3.Text);

                if(amt<fp)
                {
                    MessageBox.Show("Minimum Amount to be Paid is 80%");
                }
                else
                {
                    float bamt = ta - fp;
                    textBox4.Text= bamt.ToString();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
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





        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
