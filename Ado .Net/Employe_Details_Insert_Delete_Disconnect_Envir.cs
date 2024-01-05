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

namespace Employe_Details_Insert_Delete_Disconnect_Envir
{
    public partial class Form1 : Form
    {
        public string ConnectionString = "server=DESKTOP-1UF46NE\\SQLEXPRESS;integrated security=true;database=practice;";
        SqlDataAdapter Sqlda;
        DataSet dataSet;
        SqlCommandBuilder cb;


        public Form1()
        {
            InitializeComponent();
            Sqlda = new SqlDataAdapter("select * from employee", ConnectionString);
            cb = new SqlCommandBuilder(Sqlda);
            dataSet = new DataSet();
            Sqlda.Fill(dataSet, "Emp");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = dataSet.Tables["Emp"].NewRow();

            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr[3] = Convert.ToInt32(textBox4.Text);
            dr[4] = textBox5.Text;
            dr[5] = textBox6.Text;
            dr[6] = Convert.ToInt32(textBox7.Text);

            dataSet.Tables["Emp"].Rows.Add(dr);

            Sqlda.Update(dataSet.Tables["Emp"]);

            MessageBox.Show("Data Successfully Inserted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataSet.Tables["Emp"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(DataRow dr in dataSet.Tables["Emp"].Rows)
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {
                        dr[0] = textBox1.Text;
                        dr[1] = textBox2.Text;
                        dr[2] = textBox3.Text;
                        dr[3] = Convert.ToInt32(textBox4.Text);
                        dr[4] = textBox5.Text;
                        dr[5] = textBox6.Text;
                        dr[6] = Convert.ToInt32(textBox7.Text);
                        Sqlda.Update(dataSet.Tables["Emp"]);
                        MessageBox.Show("Data Updated Successfully");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRow drTarget;
            foreach (DataRow dr in dataSet.Tables["Emp"].Rows)
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {
                        dr.Delete();
                        
                        Sqlda.Update(dataSet.Tables["Emp"]);
                        dataSet.Tables["Emp"].AcceptChanges();
                        MessageBox.Show("Data Successfully Deleted..");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = dataSet.Tables["Emp"];
            comboBox1.DisplayMember = "emp_id";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string emp_id = comboBox1.Text;
            MessageBox.Show(emp_id);
        }
    }
}
