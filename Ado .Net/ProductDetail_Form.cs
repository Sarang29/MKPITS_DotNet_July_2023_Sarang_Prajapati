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
        enum Nationality { Indian,NRI}
        Nationality nat;
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

        public void GetPrice()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableProduct where ProductID=@ProductID", con);
                    da.SelectCommand.Parameters.AddWithValue("@ProductID", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "tableprice");
                    foreach (DataRow dr in ds.Tables["tableprice"].Rows)
                    {
                        textBox9.Text = dr["Product_Price"].ToString();
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetCategory();
            GetProduct();
            GetPrice();
            nat = Nationality.Indian;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox10.Text = "0";
            //textBox11.Text = "0";
            GetProduct();

            if(comboBox1.Text != "System.Data.DataRowView")
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableProductGSTDetails where Gst_Details_Name=@GDN", con);
                da.SelectCommand.Parameters.AddWithValue("@GDN", comboBox1.Text);
                ds = new DataSet();
                ds.Clear();
                da.Fill(ds, "PGD");
                foreach (DataRow dr in ds.Tables["PGD"].Rows)
                {
                    textBox3.Text = dr["cgst"].ToString();
                    textBox4.Text = dr["sgst"].ToString();
                    textBox5.Text = dr["igst"].ToString();
                }
            }

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
            else
            {
                try
                {
                    con = new SqlConnection(strcon);
                    con.Open();
                    string str = "insert into TableInvoiceDetails values(@Customer_Name,@Customer_Contact," +
                        "@Product_Category_ID,@Product_ID,@Residentail_Type_ID,@Invoice_Date,@Quantity," +
                        "@Price,@CGST,@SGST,@IGST,@CGST_Value,@SGST_Value,@IGST_Value,@TotalAmount)";
                    SqlCommand command = new SqlCommand(str, con);
                    command.Parameters.AddWithValue("@Customer_Name", SqlDbType.VarChar).Value = textBox1.Text;
                    command.Parameters.AddWithValue("@Customer_Contact", SqlDbType.Int).Value = textBox2.Text;
                    command.Parameters.AddWithValue("@Product_Category_ID", SqlDbType.Int).Value = comboBox1.SelectedValue;
                    command.Parameters.AddWithValue("@Product_ID", SqlDbType.Int).Value = comboBox2.SelectedValue;
                    command.Parameters.AddWithValue("@Residentail_Type_ID", SqlDbType.Int).Value = 1001;
                    command.Parameters.AddWithValue("@Invoice_Date", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                    command.Parameters.AddWithValue("@Quantity", SqlDbType.Int).Value = textBox10.Text;
                    command.Parameters.AddWithValue("@Price", SqlDbType.Int).Value = textBox9.Text;
                    command.Parameters.AddWithValue("@CGST", SqlDbType.Int).Value = textBox3.Text;
                    command.Parameters.AddWithValue("@SGST", SqlDbType.Int).Value = textBox4.Text;
                    command.Parameters.AddWithValue("@IGST", SqlDbType.Int).Value = textBox5.Text;
                    command.Parameters.AddWithValue("@CGST_Value", SqlDbType.Int).Value = textBox8.Text;
                    command.Parameters.AddWithValue("@SGST_Value", SqlDbType.Int).Value = textBox7.Text;
                    command.Parameters.AddWithValue("@IGST_Value", SqlDbType.Int).Value = textBox6.Text;
                    command.Parameters.AddWithValue("@TotalAmount", SqlDbType.Int).Value = textBox11.Text;
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");
                    Clear();
                }
                catch(Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled= true;
                MessageBox.Show("Please Enter Only Number");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox10.Text = "0";
            textBox11.Text = "0"; 
            GetPrice();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        double tcgst = 0;
        double tsgst = 0;
        double tigst = 0;
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                double price = Convert.ToDouble(textBox9.Text);
                double quantity = Convert.ToDouble(textBox10.Text);
                double totalamount = price * quantity;
                textBox11.Text = totalamount.ToString();




                if (nat.ToString() == "Indian")
                {
                    double pcgst = Convert.ToDouble(textBox3.Text);
                    tcgst = totalamount * (pcgst / 100);
                    textBox8.Text = tcgst.ToString();

                    double psgst = Convert.ToDouble(textBox4.Text);
                    tsgst = totalamount * (psgst / 100);
                    textBox7.Text = tsgst.ToString();

                    double netamt = Convert.ToDouble(textBox7.Text) + Convert.ToDouble(textBox8.Text) + Convert.ToDouble(textBox11.Text);
                    textBox12.Text = netamt.ToString();
                }

                else if (nat.ToString() == "NRI")
                {
                    double pigst = Convert.ToDouble(textBox5.Text);
                    tigst = totalamount * (pigst / 100);
                    textBox6.Text = tigst.ToString();

                    double netamt = Convert.ToDouble(textBox6.Text) + Convert.ToDouble(textBox11.Text);
                    textBox12.Text = netamt.ToString();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Number");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                nat = Nationality.Indian;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                nat = Nationality.NRI;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            dateTimePicker1.Value = DateTime.Now;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text="0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            comboBox1.Text = "Select";
            comboBox2.Text = "Select";
        }
    }
}
