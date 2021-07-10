using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_fial
{
    public partial class FormBMR : Form
    {
        string sex;
        int age;
        DateTime BD;
        public FormBMR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxW.Text == "" | textBoxT.Text == "" | comboBox1.Text=="")
            {
                MessageBox.Show("โปรดระบุข้อมูลให้ครบถ้วน");
            }
            else
            {
                double Hg = double.Parse(textBoxW.Text);
                double GG = double.Parse(textBoxT.Text);
                double Year = age;
                double BMR = 0;
                double TDEE = 0;

                if (sex == "ชาย")
                {
                    BMR = 66 + (13.7 * GG) + (5 * Hg) - (6.8 * Year);
                }

                else if (sex == "หญิง")
                {
                    BMR = 665 + (9.6 * GG) + (1.8 * Hg) - (4.7 * Year);
                }

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        TDEE = BMR * 1.2;
                        textBox1.Text = string.Format("{0:F2}", BMR);
                        textBox2.Text = string.Format("{0:F2}", TDEE);
                        break;
                    case 1:
                        TDEE = BMR * 1.375;
                        textBox1.Text = string.Format("{0:F2}", BMR);
                        textBox2.Text = string.Format("{0:F2}", TDEE);
                        break;
                    case 2:
                        TDEE = BMR * 1.55;
                        textBox1.Text = string.Format("{0:F2}", BMR);
                        textBox2.Text = string.Format("{0:F2}", TDEE);
                        break;
                    case 3:
                        TDEE = BMR * 1.725;
                        textBox1.Text = string.Format("{0:F2}", BMR);
                        textBox2.Text = string.Format("{0:F2}", TDEE);
                        break;
                    case 4:
                        TDEE = BMR * 1.9;
                        textBox1.Text = string.Format("{0:F2}", BMR);
                        textBox2.Text = string.Format("{0:F2}", TDEE);
                        break;
                }
            }
           
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
            conn.Open();
            string sql = "SELECT sex,birthday FROM login WHERE Username = '" + Program.user + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                sex = reader.GetValue(0).ToString();
                BD = Convert.ToDateTime(reader.GetValue(1).ToString());
            }
            comboBox1.Text = "";
            DateTime now = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            DateTime zero = new DateTime(1, 1, 1);
            TimeSpan year = now - BD;
            age = (zero + year).Year - 1;
            label13.Text = "สวัสดีคุณ " + Program.user + " ยินดีต้อนรับเข้าสู่ ZEUS GOOD HEALTH";

        }

        private void textBoxT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("กรุณาใส่เฉพาะตัวเลข");
                e.Handled = true;
            }
        }

        private void textBoxW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("กรุณาใส่เฉพาะตัวเลข");
                e.Handled = true;
            }
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("กรุณาใส่เฉพาะตัวเลข");
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxW.Clear();
            textBoxT.Clear();
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
        }

        private void ปดโปรแกรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void คำนวณคาBMRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBMR f5 = new FormBMR();
            this.Hide();
            f5.Show();
        }

        private void คำนวณคาBMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBMI f4 = new FormBMI();
            this.Hide();
            f4.Show();
        }

        private void บนทกขอมลToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSavedata f7 = new FormSavedata();
            this.Hide();
            f7.Show();
        }


        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin f2 = new FormLogin();
            this.Hide();
            f2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Program.bmr = textBox1.Text;
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Program.tdee = textBox2.Text;
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
