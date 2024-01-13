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

namespace Disconnect_Enviro_MdiForm_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=mkpits";
        SqlConnection con = null;
        SqlCommand command = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strcon);

                string str = "select count (*) from users where username=@username and password=@password";
                con.Open();
                command = new SqlCommand(str, con);

                command.Parameters.Add("@username", SqlDbType.VarChar, 20).Value = textBox1.Text;
                command.Parameters.Add("@password", SqlDbType.VarChar, 20).Value = textBox2.Text;

                int cnt = Convert.ToInt32(command.ExecuteScalar());

                if (cnt > 0)
                {
                    MessageBox.Show("Login Successfull");
                    menuStrip1.Visible = true;
                    panel1.Visible= false;
                }
                else
                {
                    MessageBox.Show("Invalid Credentials, Try Again");
                }
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
