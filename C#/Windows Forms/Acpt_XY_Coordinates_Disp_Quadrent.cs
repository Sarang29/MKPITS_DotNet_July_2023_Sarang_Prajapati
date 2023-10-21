using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acpt_XY_Coordinates_Disp_Quadrent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);

            if (x > 0 && y > 0)
            {
                label3.Text = "X and Y Lies in First Quadrant";
            }
            else if (x < 0 && y > 0)
            {
                label3.Text = "X and Y Lies in Second Quadrant";
            }
            else if(x < 0 && y < 0)
            {
                label3.Text = "X and Y Lies in Third Quadrant";
            }
            else if(x > 0 && y < 0)
            {
                label3.Text = "The Coordinates Points ( " + x + " , " + y + " ) Lies in Fourth Quadrant";
            }
            else
            {
                label3.Text = "Invalid Input";
            }


        }
    }
}
