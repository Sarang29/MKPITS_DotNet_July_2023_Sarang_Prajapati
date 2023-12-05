using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text=("Full Date : "+dateTimePicker1.Text);
            label2.Text=("Short Date : "+dateTimePicker1.Value.ToShortDateString());
            label3.Text=("Current Time : "+dateTimePicker1.Value.ToShortTimeString());
            label4.Text =("Day : "+dateTimePicker1.Value.Day.ToString());
            label5.Text=("Month : "+dateTimePicker1.Value.Month.ToString());
            label6.Text=("Year : "+dateTimePicker1.Value.Year.ToString());  
        }
    }
}
