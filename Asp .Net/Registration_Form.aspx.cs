using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_Form
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Username : " + TextBox1.Text + "<br>");
            sb.Append("Password : " + TextBox2.Text + "<br>");
            sb.Append("Address : " + TextBox3.Text + "<br>");

            string g = null;
            if(RadioButton1.Checked)
            {
                g = RadioButton1.Text;
            }
            else if(RadioButton2.Checked)
            {
                g = RadioButton2.Text;
            }
            sb.Append("Gender : " + g + "<br>");

            string h = null;
            if(CheckBox1.Checked)
            {
                h = h + " " + CheckBox1.Text + "<br>";
            }
            if(CheckBox2.Checked)
            {
                h = h + " " + CheckBox2.Text + "<br>";
            }
            sb.Append("Hobby : " + h + "<br>");

            sb.Append("Country : " + DropDownList1.Text + "<br>");
            sb.Append("City : " + DropDownList2.Text + "<br>");
           

            Label1.Text = sb.ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            string c = DropDownList1.Text;
            DropDownList2.Items.Clear();

            switch (c)
            {
                case "India":
                    DropDownList2.Items.Add("Nagpur");
                    DropDownList2.Items.Add("Pune");
                    break;
                case "Usa":
                    DropDownList2.Items.Add("London");
                    DropDownList2.Items.Add("Denmark");
                    break;
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}