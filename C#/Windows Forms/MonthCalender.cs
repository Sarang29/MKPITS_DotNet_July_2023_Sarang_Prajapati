using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_MonthCalender_Multiple_From_Example
{
    public partial class MonthCalender : Form
    {
        public MonthCalender()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text=monthCalendar1.SelectionStart.Date.ToString();
        }
    }
}
