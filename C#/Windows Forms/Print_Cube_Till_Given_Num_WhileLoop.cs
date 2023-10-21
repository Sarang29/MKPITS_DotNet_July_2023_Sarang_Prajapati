using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Print_Cube_Till_Given_Num_WhileLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 1;
            int num;
            int cube = 0;

            num = Convert.ToInt32(textBox1.Text);

            while (counter <= num)
            {
                cube = counter * counter * counter;
                label2.Text = "Cube = " + cube;
                counter++;
            }
        }
    }
}
