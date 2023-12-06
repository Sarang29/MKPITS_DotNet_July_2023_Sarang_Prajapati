using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiForms_Ques_Mcq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" && textBox2.Text=="admin")
            {
                panel1.Visible = false;
                menuStrip1.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Credentials!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome");
        }

        private void generalKnowledgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralKnowledgeTest exam = new GeneralKnowledgeTest();
            exam.MdiParent = this;
            exam.Show();
        }
    }
}
