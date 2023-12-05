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
    public partial class NumericUpDown : Form
    {
        public NumericUpDown()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text=numericUpDown1.Value.ToString();
        }
    }
}
