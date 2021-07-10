using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_fial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin f2 = new FormLogin();
            this.Hide();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegister f3 = new FormRegister();
            this.Hide();
            f3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormLogin f2 = new FormLogin();
            this.Hide();
            f2.Show();
        }
    }
}
