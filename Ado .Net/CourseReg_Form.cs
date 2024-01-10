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

namespace CourseReg_Form
{
    public partial class Form1 : Form
    {
        string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=CourseTest";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }
        public enum category { Student,IT_Professional}
        public enum gender { Male,Female,Other}

        category cat;
        gender gen;

        float fp;
        public void CalculateFees()
        {
            if (cat.ToString() == "Student")
            {
                float ta = Convert.ToSingle(textBox2.Text);
                fp = ta * 0.05f;
                float amt = Convert.ToSingle(textBox3.Text);
                if (amt < fp)
                {
                    MessageBox.Show("Minimum Paid Amount Must be 50%");
                }
                else
                {
                    float bamt =  ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }

            else if (cat.ToString() == "IT_Professional")
            {
                float ta = Convert.ToSingle(textBox2.Text);
                fp = ta * 0.08f;
                float amt = Convert.ToSingle(textBox3.Text);
                if (amt < fp)
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
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gen = gender.Male;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            GetNation();
            GetState();
            GetCity();

            if(radioButton1.Checked)
            {
                cat = category.Student;
            }
            else if(radioButton2.Checked)
            {
                cat = category.IT_Professional;
            }
            if( radioButton3.Checked)
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

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetState();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            if(comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableState where NationID=@NationID", con);
                    da.SelectCommand.Parameters.AddWithValue("@NationID", comboBox1.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds,"tablestate");
                    comboBox2.DataSource = ds.Tables["tablestate"];
                    comboBox2.DisplayMember = "StateName";
                    comboBox2.ValueMember = "StateID";
                }
                catch(Exception ee)
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

        public void InsertRegAddress()
        {
            try
            {

                con.Open();
                string str = "select max(CourseRegID) from TableCourseRegDetail";
                SqlCommand command = new SqlCommand(str, con);
                int mcid = Convert.ToInt32(command.ExecuteScalar());
                string str1 = "insert into TableRegAddress values(@CourseRegID,@NationID,@StateID,@CityID)";
                SqlCommand command1 = new SqlCommand(str1, con);
                command1.Parameters.Add("@CourseRegID", SqlDbType.Int).Value=mcid;
                command1.Parameters.Add("@NationID", SqlDbType.Int).Value=comboBox1.SelectedValue;
                command1.Parameters.Add("@StateID", SqlDbType.Int).Value = comboBox2.SelectedValue;
                command1.Parameters.Add("@CityID", SqlDbType.Int).Value = comboBox3.SelectedValue;
               
                command1.ExecuteNonQuery();
                MessageBox.Show("Address Inserted Successfully");
                con.Close();

                InsertFeeDetail();
            
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        public void InsertFeeDetail()
        {
            try
            {

                con.Open();
                string str = "select max(CourseRegID) from TableCourseRegDetail";
                SqlCommand command = new SqlCommand(str, con);
                int mcid = Convert.ToInt32(command.ExecuteScalar());
                string str1 = "insert into TableFeeDetail values(@CourseRegID,@TotalAmount,@MinPer,@PaidAmount,@BalAmount,@PaidDate)";
                SqlCommand command1 = new SqlCommand(str1, con);
                command1.Parameters.Add("@CourseRegID", SqlDbType.Int).Value = mcid;
                command1.Parameters.Add("@TotalAmount", SqlDbType.Int).Value = textBox2.Text;
                command1.Parameters.Add("@MinPer", SqlDbType.Decimal).Value = fp;
                command1.Parameters.Add("@PaidAmount", SqlDbType.Int).Value = textBox3.Text;
                command1.Parameters.Add("@BalAmount", SqlDbType.Int).Value = textBox4.Text;
                command1.Parameters.Add("@PaidDate", SqlDbType.DateTime).Value = dateTimePicker1.Value;

                command1.ExecuteNonQuery();
                MessageBox.Show("Fee details Inserted Successfully");
                con.Close();

                

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Candidate Name Should be Blank");
            }
            else
            {
                MessageBox.Show("Category " + cat);
                MessageBox.Show("Gender " + gen);
                SaveRegDetails(cat,gen);
            }
            DateTime SelectedDate = dateTimePicker1.Value;
            if(SelectedDate.Date<DateTime.Today)
            {
                MessageBox.Show("PaidSate Should not be before today");
            }

        }

        public void SaveRegDetails(category c,gender g)
        {
            try
            {
                con = new SqlConnection(strcon);
                string str = "insert into TableCourseRegDetail values(@CategoryID,@FullName,@GenderID)";
                SqlCommand command = new SqlCommand(str, con);
                command.Parameters.AddWithValue("@CategoryID",Convert.ToInt32(c));
                command.Parameters.AddWithValue("@FullName", textBox1.Text);
                command.Parameters.AddWithValue("@GenderID",Convert.ToInt32(g));
                con.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully");
                con.Close();
                InsertRegAddress();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
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
            cat = category.IT_Professional;
            textBox2.Text = "3000";
            textBox3.Text = "0";
            textBox4.Text = "0";
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if(cat.ToString() == "Student")
            {
              
                float ta = Convert.ToSingle(textBox2.Text);
                fp = ta * 0.05f;
                float amt = Convert.ToSingle(textBox3.Text);
                if(amt < fp)
                {
                    MessageBox.Show("Minimum Paid Amount Must be 50%");
                }
                else
                {
                    float bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }

            else if (cat.ToString() == "IT_Professional")
            {
                
                float ta = Convert.ToSingle(textBox2.Text);
                fp = ta * 0.08f;
                float amt = Convert.ToSingle(textBox3.Text);
                if (amt < fp)
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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            gen = gender.Female;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            gen = gender.Other;
        }

        private void PaidDate(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            radioButton1.Checked = false;
            radioButton2.Checked=false;
            radioButton3.Checked=false;
            radioButton4.Checked=false;
            radioButton5.Checked=false;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToString();
        }
    }
}
