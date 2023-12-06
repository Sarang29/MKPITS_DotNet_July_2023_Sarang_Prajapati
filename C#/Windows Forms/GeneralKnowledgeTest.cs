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
    public partial class GeneralKnowledgeTest : Form
    {
        public GeneralKnowledgeTest()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            if(radioButton3.Checked ) 
            {
                count++;
            }
            if(radioButton4.Checked )
            {
                count++;
            }
            if (radioButton8.Checked)
            {
                count++;
            }
            if (radioButton12.Checked)
            {
                count++;
            }

            sb.Append("Total Marks : " + count + "\n");
            label1.Text = sb.ToString();
        }
    }
}
