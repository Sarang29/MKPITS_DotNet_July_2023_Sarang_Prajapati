using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Collection_Cls_ArrayList_Insert_in_Array_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            ar.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (object ob in ar)
            {
                sb.Append("Name : "+ob.ToString()+"\n");
            }
            label2.Text= sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ar.Insert(2, textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
