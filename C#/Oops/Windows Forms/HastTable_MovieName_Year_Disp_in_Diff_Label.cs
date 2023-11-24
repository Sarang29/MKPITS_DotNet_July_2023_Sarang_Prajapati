using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastTable_MovieName_Year_Disp_in_Diff_Label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable ht = new Hashtable();
        private void button1_Click(object sender, EventArgs e)
        {
            ht.Add(textBox1.Text,Convert.ToInt32(textBox2.Text));
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ICollection key = ht.Keys;
            
            StringBuilder sb = new StringBuilder();
            foreach(string osi in key)
            {
                sb.Append("Movie Name : " + osi + "\n");
            }
            label3.Text= sb.ToString();

            ICollection val = ht.Values;
            StringBuilder sb1 = new StringBuilder();

            foreach(int osi in val)
            {
                sb1.Append("Release Year : " + osi + "\n");
            }

            label4.Text= sb1.ToString();    
        }
    }
}
