﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calender_Example
{
    public partial class Calender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text=Calendar1.SelectedDate.Date.ToShortDateString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = Calendar1.SelectedDate.Date.ToShortDateString();
        }
    }
}