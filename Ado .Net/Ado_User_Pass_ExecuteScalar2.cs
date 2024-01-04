using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ado_User_Pass_ExecuteScalar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=mkpits";
        SqlConnection con = null;
        SqlCommand cmd = null;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strcon);
                string str = "select count(*) from users where username=@username and password=@password";
                con.Open();
                cmd = new SqlCommand(str, con);

                cmd.Parameters.Add("@username", SqlDbType.VarChar, 20).Value = textBox1.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 20).Value = textBox2.Text;

                int cnt = Convert.ToInt32(cmd.ExecuteScalar());

                if (cnt > 0)
                {
                    label3.Text = "Login Successfull";
                }
                else
                {
                    label3.Text = "Invalid Credentials, Try Again";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
