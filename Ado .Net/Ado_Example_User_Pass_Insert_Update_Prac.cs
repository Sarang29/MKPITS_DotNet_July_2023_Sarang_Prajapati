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

namespace Ado_Example_User_Pass_Insert_Update
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "server=.\\SQLEXPRESS;integrated security=true;database=mkpits";

            SqlConnection con = new SqlConnection(str);

            try
            {
                con.Open();
                MessageBox.Show("Connected Succesfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=mkpits";
            SqlConnection con = new SqlConnection(strcon);
            try
            {
                con.Open();
                string constr = "insert into users values('" + textBox1.Text + "','" + textBox2.Text + "')";
                SqlCommand command = new SqlCommand(constr, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "Record Inserted Successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=mkpits";
            SqlConnection con = new SqlConnection( strcon);

            try
            {
                con.Open();
                string strcmd = "Update users set password='" + textBox2.Text + "' where username='" + textBox1.Text + "'";
                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "Record Updated Successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
