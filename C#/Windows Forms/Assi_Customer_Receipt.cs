using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assi_Customer_Receipt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Customer Name : " + textBox1.Text + "\n");
            sb.Append("Mobile Number : "+maskedTextBox1.Text + "\n");
            sb.Append("Category : " + comboBox1.Text + "\n");
            sb.Append("Item : "+comboBox2.Text + "\n");
            sb.Append("Rate : " + textBox2.Text + "\n");
            
            sb.Append("Quantity : " + textBox3.Text + "\n");
            int quantity = Convert.ToInt32(textBox3.Text);
            int price = Convert.ToInt32(textBox2.Text);

            int result = quantity * price;

            sb.Append("Total Amount : " + result + "\n");

            label7.Text = sb.ToString();           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Components")
            {
                comboBox2.Enabled = true;
                comboBox2.Items.Add("Keyboard");
                comboBox2.Items.Add("Mouse");
                comboBox2.Items.Add("Monitor");
                comboBox2.Items.Add("Cpu");
            }
            else if(comboBox1.Text=="Electronics")
            {
                comboBox2.Enabled = true;
                comboBox2.Items.Add("RAM");
                comboBox2.Items.Add("SSD");
                comboBox2.Items.Add("Antivirus");
                comboBox2.Items.Add("Graphics Card");
            }




        }
    }
}
