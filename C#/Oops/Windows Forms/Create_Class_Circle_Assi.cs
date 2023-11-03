using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_Class_Circle_Assi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
           int radius=Convert.ToInt32(textBox1.Text);
            

            circle.getdata(radius);

            label2.Text = "Area of Circle = " + circle.area;
        }
    }
}
