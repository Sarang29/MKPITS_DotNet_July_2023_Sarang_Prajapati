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

namespace ProductDetail_Form
{
    public partial class Form1 : Form
    {
        string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=ProductStores";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }
        
        public void GetCategory()
        {
            con = new SqlConnection(strcon);
            da = new SqlDataAdapter("select * from TableProductCategory order by Product_Category_ID", con);
            ds = new DataSet();
            da.Fill(ds, "productcategory");
            comboBox1.DataSource = ds.Tables["productcategory"];
            comboBox1.DisplayMember = "Product_Type_Name";
            comboBox1.ValueMember = "Product_Category_ID";
        }

        public void GetProduct()
        {
            if(comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableProduct where Product_Category_ID=@Product_Category_ID", con);
                    da.SelectCommand.Parameters.Add("@Product_Category_ID", comboBox1.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "productproduct");
                    comboBox2.DataSource = ds.Tables["productproduct"];
                    comboBox2.DisplayMember = "Product_Name";
                    comboBox2.ValueMember = "ProductID";
                }
                catch(Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetCategory();
            GetProduct();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProduct();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime SelectedDate = dateTimePicker1.Value;

            if(SelectedDate.Date <  DateTime.Today)
            {
                MessageBox.Show("Invoice Date Should be Not Before Today");
            }

            if(textBox1.Text=="")
            {
                MessageBox.Show("FullName Cannot be Blank");
            }

            if(textBox2.Text=="")
            {
                MessageBox.Show("Mobile Number Cannot be Empty");
            }
            else if(textBox2.Text.Length < 10 )
            {
                MessageBox.Show("Please Enter Valid Mobile No");
            }
        }
    }
}
