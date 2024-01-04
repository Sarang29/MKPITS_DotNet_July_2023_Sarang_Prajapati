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

namespace Disconnect_Enviro_Mdi_Datagrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS;integrated security=true;database=NEWDATA");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlCommandBuilder cb = new SqlCommandBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            da= new SqlDataAdapter("select * from student",con);
            cb = new SqlCommandBuilder(da);

            da.Fill(ds, "stud");
            dataGridView1.DataSource = ds.Tables["stud"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds.Tables["stud"]);
                MessageBox.Show("Record Updated");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
