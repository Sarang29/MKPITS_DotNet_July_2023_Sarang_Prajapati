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

namespace SortedList_SingerName_Song_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        SortedList sl = new SortedList();
        private void button1_Click(object sender, EventArgs e)
        {
            sl.Add(textBox1.Text, textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ICollection key = sl.Keys;

            StringBuilder sb = new StringBuilder();
            foreach(string singer in key)
            {
                sb.Append("Singer Name : "+singer+"       Song Name : " + sl[singer]+"\n");
            }
            label3.Text = sb.ToString();    
        }
    }
}
