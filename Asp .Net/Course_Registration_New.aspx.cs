using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Course_Registration
{
    public partial class Course_Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                stype = "Student";
                TextBox2.Text = "1000";
            }
        }
        static string stype = "Student";
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string state = DropDownList1.SelectedValue;
            DropDownList2.Items.Clear();

            switch(state)
            {
                case "India":
                    DropDownList2.Items.Add("Maharashtra");
                    DropDownList2.Items.Add("MP");
                    break;
                case "USA":
                    DropDownList2.Items.Add("California");
                    DropDownList2.Items.Add("Florida");
                    break;
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city = DropDownList2.SelectedValue;
            DropDownList3.Items.Clear();

            switch (city)
            {
                case "Maharashtra":
                    DropDownList3.Items.Add("Nagpur");
                    DropDownList3.Items.Add("Pune");
                    break;
                case "MP":
                    DropDownList3.Items.Add("Jabalpur");
                    DropDownList3.Items.Add("Katni");
                    break;
                case "California":
                    DropDownList3.Items.Add("Las Vegas");
                    DropDownList3.Items.Add("San Jose");
                    break;
                case "Florida":
                    DropDownList3.Items.Add("San Andreas");
                    DropDownList3.Items.Add("Washington DC");
                    break;
            }
        }

        

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton1.Checked)
            {
                stype = "Student";
                TextBox2.Text = "1000";
                TextBox3.Text = "0";
                TextBox4.Text = "0";
            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton2.Checked)
            {
                stype = "IT_Professional";
                TextBox2.Text="3000";
                TextBox3.Text = "0";
                TextBox4.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string c=null;
            if (RadioButton1.Checked)
            {
                c = RadioButton1.Text;
            }
            else if (RadioButton2.Checked)
            {
                c = RadioButton2.Text;
            }
            sb.Append("Category : " + c + "<br>");

            sb.Append("Full Name : " + TextBox1.Text + "<br>");

            string g = null;
            if (RadioButton3.Checked)
            {
                g = RadioButton3.Text;
            }
            else if (RadioButton4.Checked)
            {
                g = RadioButton4.Text;
            }
            else if (RadioButton5.Checked)
            {
                g = RadioButton5.Text;
            }
            sb.Append("Gender : " + g + "<br>");
            sb.Append("Nation : " + DropDownList1.Text + "<br>");
            sb.Append("State : " + DropDownList2.Text + "<br>");
            sb.Append("City : " + DropDownList3.Text + "<br>");
            sb.Append("Total Amount : " + TextBox2.Text + "<br>");
            sb.Append("Fees Paid : " + TextBox3.Text + "<br>");
            sb.Append("Balance Amount : " + TextBox4.Text + "<br>");
            sb.Append("Payment Date : " + TextBox6.Text + "<br>");

            Label1.Text = sb.ToString();
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            double ta = Convert.ToInt32(TextBox2.Text);
            if(stype=="Student")
            {
                double fp = Convert.ToDouble(TextBox2.Text)*0.5;
                if(Convert.ToDouble(TextBox3.Text) < fp)
                {
                    Label1.Text = "Paid Amount Should be Equal or More than 50%";
                }
                else
                {
                    double amt = Convert.ToDouble(TextBox2.Text) - Convert.ToDouble(TextBox3.Text);
                    TextBox4.Text = amt.ToString();
                    Label1.Text = "";
                }

            }
            else if (stype == "IT_Professional")
            {
                double fp = Convert.ToDouble(TextBox2.Text) * 0.8;
                if (Convert.ToDouble(TextBox3.Text) < fp)
                {
                    Label1.Text = "Paid Amount Should be Equal or More than 80%";
                }
                else
                {
                    double amt = Convert.ToDouble(TextBox2.Text) - Convert.ToDouble(TextBox3.Text);
                    TextBox4.Text = amt.ToString();
                    Label1.Text = "";
                }

            }

        }
    }
}