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

namespace Ado_Connection_User_Pass
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
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Connected Successfully");
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

            finally
            {
                conn.Close();
            }
        }
    }
}
