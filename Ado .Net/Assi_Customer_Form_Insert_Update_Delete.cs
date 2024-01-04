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

namespace Assi_Customer_Form_Insert_Update_Delete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=mkpits";

            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();

                string str = "insert into customer values(@CustId,@CustName,@CustAddress,@MobileNo,@EmailId)";

                using (SqlCommand command =  new SqlCommand(str, con))
                {
                    command.Parameters.AddWithValue("@CustId", Convert.ToInt32(textBox1.Text));
                    command.Parameters.AddWithValue("@CustName", textBox2.Text);
                    command.Parameters.AddWithValue("@CustAddress", textBox3.Text);
                    command.Parameters.AddWithValue("@MobileNo", maskedTextBox1.Text);
                    command.Parameters.AddWithValue("@EmailId", textBox4.Text);

                    command.ExecuteNonQuery();
                    con.Close();
                    label6.Text = "Record Inserted Successfully";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=mkpits";

            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();

                string str = "update customer set CustName=@CustName,CustAddress=@CustAddress,MobileNo=@MobileNo,EmailId=@EmailId where CustId=@CustId";

                using (SqlCommand command = new SqlCommand(str, con))
                {
                    
                    command.Parameters.AddWithValue("@CustName", textBox2.Text);
                    command.Parameters.AddWithValue("@CustAddress", textBox3.Text);
                    command.Parameters.AddWithValue("@MobileNo", maskedTextBox1.Text);
                    command.Parameters.AddWithValue("@EmailId", textBox4.Text);
                    command.Parameters.AddWithValue("@CustId", Convert.ToInt32(textBox1.Text));

                    command.ExecuteNonQuery();
                    con.Close();
                    label6.Text = "Record Updated Successfully";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=mkpits";

            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();

                string str = "delete from customer where CustName=@CustName or CustId=@CustId";

                using (SqlCommand command = new SqlCommand(str, con))
                {

                    command.Parameters.AddWithValue("@CustName", textBox2.Text);
                    command.Parameters.AddWithValue("@CustId", Convert.ToInt32(textBox1.Text));

                    command.ExecuteNonQuery();
                    con.Close();
                    label6.Text = "Record Deleted Successfully";
                }
            }
        }
    }
}
