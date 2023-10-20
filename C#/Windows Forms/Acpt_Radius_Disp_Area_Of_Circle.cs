using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acpt_Radius_Disp_Area_Of_Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int radius = Convert.ToInt32(textBox1.Text);

            float calc = 3.14f * radius * radius;

            label2.Text = "Area Of Circle = " + calc;
        }
    }
}
