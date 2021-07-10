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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox6.Hide();
            groupBox7.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox6.Hide();
            groupBox7.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
            groupBox1.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox6.Hide();
            groupBox7.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Show();
            groupBox2.Hide();
            groupBox1.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox6.Hide();
            groupBox7.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox4.Show();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox1.Hide();
            groupBox5.Hide();
            groupBox6.Hide();
            groupBox7.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox5.Show();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox1.Hide();
            groupBox6.Hide();
            groupBox7.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox6.Show();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox1.Hide();
            groupBox7.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox7.Show();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox1.Hide();
            groupBox6.Hide();
        }
    }
}
