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

namespace HashTable_MovieName_MovieYear_WinForms
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
            ht.Add(textBox1.Text, Convert.ToInt32(textBox2.Text));
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ICollection col = ht.Keys;

            StringBuilder sb = new StringBuilder(); 
            foreach (string oc in col)
            {
                sb.Append(oc + ":" + ht[oc]+"\n");
            }
            label3.Text= sb.ToString();
        }
    }
}
