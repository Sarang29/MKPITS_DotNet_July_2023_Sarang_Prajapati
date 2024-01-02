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

namespace Ado_Example_Employe_Details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "server=.\\SQLEXPRESS;integrated security=true;database=Testdb";

            SqlConnection con = new SqlConnection(str);

            try
            {
                con.Open();
                MessageBox.Show("Connected Successfully");
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
            string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=Testdb";
            SqlConnection con = new SqlConnection(strcon);

            try
            {
                string strcmd = "insert into employee values('"+textBox1
            }
        }
    }
}
