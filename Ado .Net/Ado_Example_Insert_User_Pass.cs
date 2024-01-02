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

namespace Ado_Example_Insert_User_Pass
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
                MessageBox.Show("Connected Successfully");
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "server=.\\SQLEXPRESS;integrated security=true;database=mkpits";

            SqlConnection con = new SqlConnection(str);

            try
            {
                con.Open();
                string strcmd = "insert into users values('"+textBox1.Text+"','"+textBox2.Text+"')";
                SqlCommand command = new SqlCommand(strcmd, con);
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
    }
}
