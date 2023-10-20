using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Print_Height_Drawf_Tall_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int height = Convert.ToInt32(textBox1.Text);

            if(height >= 147)
            {
                label2.Text = "Height is Drawf";
            }
            else if(height > 147 && height <= 165)
            {
                label2.Text = "Height is Taller";
            }
        }
    }
}
