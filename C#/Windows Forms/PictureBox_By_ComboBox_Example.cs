using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox_By_ComboBox_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string imgname = comboBox1.Text;
            for(int i=0;i<=100;i++)
            {
                progressBar1.Value = i;
            }
            pictureBox1.Image=System.Drawing.Image.FromFile(imgname+".jpg");
        }
    }
}
