using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_Class_Rectangle_in_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle rect1 = new Rectangle();

            rect1.Width = Convert.ToInt32(textBox1.Text);
            rect1.Height = Convert.ToInt32(textBox2.Text);

            StringBuilder sb = new StringBuilder();
            rect1.getdata(rect1.Width, rect1.Height);
            sb.Append("Area of Rectangle : " + rect1.Area);
            label3.Text = sb.ToString();
        }
    }
}
