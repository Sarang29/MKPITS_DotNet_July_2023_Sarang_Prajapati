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

namespace Course_Registration_Form_Prac
{
    public partial class Form1 : Form
    {
        string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=CourseRegistration";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableNation order by Nation_ID", con);
                ds = new DataSet();
                da.Fill(ds, "tablenation");
                comboBox1.DataSource = ds.Tables["tablenation"];
                comboBox1.DisplayMember = "Nation_Name";
                comboBox1.ValueMember = "Nation_ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
                try
                {


                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableState where Nation_ID=@Nation_ID", con);
                    da.SelectCommand.Parameters.AddWithValue("@Nation_ID", comboBox1.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "tablestate");
                    comboBox2.DataSource = ds.Tables["tablestate"];
                    comboBox2.DisplayMember = "State_Name";
                    comboBox2.ValueMember = "State_ID";
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
                try
                {


                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableCity where State_ID=@State_ID", con);
                    da.SelectCommand.Parameters.AddWithValue("@State_ID", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "tablecity");
                    comboBox3.DataSource = ds.Tables["tablecity"];
                    comboBox3.DisplayMember = "City_Name";
                    comboBox3.ValueMember = "City_ID";
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
        }
    }
}
