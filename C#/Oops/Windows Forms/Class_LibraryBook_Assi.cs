using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_LibraryBook_Assi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LibraryBook[] book = new LibraryBook[3];
        int counter = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            book[0] = new LibraryBook();
            book[1] = new LibraryBook();
            book[2] = new LibraryBook();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter < 3)
            {
                book[counter].Title = textBox1.Text;
                book[counter].Author = textBox2.Text;
                if (checkBox1.Checked)
                {
                    book[counter].IsAvailable = true;
                }
                counter++;
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

                if (counter == 3)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("You Have Entered 3 Book Details");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Details of Available Books are : \n");
            for(int i=0;i<3;i++)
            {
                if (book[i].IsAvailable == true)
                {
                    sb.Append("---------------------------------\n");
                    sb.Append("Title : " + book[i].Title + "\n");
                    sb.Append("Author : " + book[i].Author + "\n");
                    sb.Append("---------------------------------\n");
                }
            }
            label3.Text= sb.ToString();
        }
    }
}
