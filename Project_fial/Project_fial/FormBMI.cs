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
    public partial class FormBMI : Form
    {
        public FormBMI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" | textBox2.Text == "")
            {
                MessageBox.Show("โปรดระบุตัวเลขข้อมูล");
            }
            else
            {
                double weight = Convert.ToDouble(textBox1.Text);
                double hight = Convert.ToDouble(textBox2.Text);
                double bmi = weight / ((hight / 100) * (hight / 100));

                //double bmi = weight / ((hight / 100) * 2);

                textBox3.Text = string.Format("{0:F2}", bmi);

                if (bmi < 18.50)
                {
                    label9.Text = ("เกณฑ์ ผอม / น้ำหนักน้อย");
                }
                if (bmi < 22.90 && bmi > 18.50)
                {
                    label9.Text = ("เกณฑ์ ปกติ สุขภาพดี");
                }
                if (bmi < 24.90 && bmi > 23)
                {
                    label9.Text = ("เกณฑ์ ท้วม / โรคอ้วนระดับ 1");
                }
                if (bmi < 29.90 && bmi > 25)
                {
                    label9.Text = ("เกณฑ์ อ้วน / โรคอ้วนระดับ 2");
                }
                if (bmi > 30)
                {
                    label9.Text = ("อ้วนมาก / โรคอ้วนระดับ 3");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Program.bmi = textBox3.Text;
        }

        private void คำนวณHeartRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHeartRate fh = new FormHeartRate();
            fh.Show();
        }

        private void trainingPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTrainingplan ft = new FormTrainingplan();
            ft.Show();
        }

        private void คำนวณคาBMRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormBMR fb = new FormBMR();
            fb.Show();
        }

        private void คำนวณคาBMIToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormBMI f4 = new FormBMI();
            this.Hide();
            f4.Show();
        }

        private void บนทกขอมลToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormSavedata f7 = new FormSavedata();
            this.Hide();
            f7.Show();
        }

        private void ออกจากระบบToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormLogin f2 = new FormLogin();
            this.Hide();
            f2.Show();
        }

        private void ปดโปรแกรมToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormBMI_Load(object sender, EventArgs e)
        {
            label5.Text = "สวัสดีคุณ " + Program.user + " ยินดีต้อนรับเข้าสู่ ZEUS GOOD HEALTH";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
