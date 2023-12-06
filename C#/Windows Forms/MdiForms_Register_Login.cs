using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiForms_Register_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrationfrm r = new Registrationfrm();
            r.MdiParent = this;
            r.Show();
        }

        private void registrationFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registrationfrm r = new Registrationfrm();
            r.MdiParent = this;
            r.Show();
        }

        private void loginFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loginfrm l = new Loginfrm();
            l.MdiParent = this;
            l.Show();
        }

        private void loginFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Loginfrm l = new Loginfrm();
            l.MdiParent = this;
            l.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void arrangementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Registrationfrm r = new Registrationfrm();
            r.MdiParent = this;
            r.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Loginfrm l = new Loginfrm();
            l.MdiParent = this;
            l.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}
