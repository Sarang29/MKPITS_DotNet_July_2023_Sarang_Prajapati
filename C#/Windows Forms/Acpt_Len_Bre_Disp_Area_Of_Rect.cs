using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acpt_Len_Bre_Disp_Area_Of_Rect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(textBox1.Text);
            int breadth = Convert.ToInt32(textBox2.Text);

            int calc = length * breadth;

            label3.Text = "Area Of Rectangle = " + calc;
        }
    }
}
