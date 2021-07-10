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
    public partial class FormHeartRate : Form
    {
        DateTime BD;
        int age;
        public FormHeartRate()
        {
            InitializeComponent();
        }
        private void FormHeartRate_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 1; i <= 100; i++)
            {
                comboBox1.Items.Add(i);
            }
            label16.Text = "สวัสดีคุณ " + Program.user + " ยินดีต้อนรับเข้าสู่ ZEUS GOOD HEALTH";

            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
            conn.Open();
            string sql = "SELECT birthday FROM login WHERE Username = '" + Program.user + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                BD = Convert.ToDateTime(reader.GetValue(0).ToString());
                DateTime now = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                DateTime zero = new DateTime(1, 1, 1);
                TimeSpan year = now - BD;
                age = (zero + year).Year - 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double MHR = 220-age;
            double Target = Convert.ToInt32(comboBox1.SelectedItem);
            double RHR = Convert.ToInt32(textBox1.Text);
            double HHR = (MHR - RHR);
            double THR = (MHR*Target)/100;
            textBoxHHR.Text = string.Format("{0:F2}", HHR.ToString());
            textBoxMHR.Text = string.Format("{0:F2}",MHR.ToString());
            textBoxTHR.Text = string.Format("{0:F2}", THR.ToString());
        }

        private void textBoxMHR_TextChanged(object sender, EventArgs e)
        {
            Program.MHR = textBoxMHR.Text;
            
        }

        private void textBoxTHR_TextChanged(object sender, EventArgs e)
        {
            Program.THR = textBoxTHR.Text;
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

        private void ปดโปรแกรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBoxHHR.Clear();
            textBoxMHR.Clear();
            textBoxTHR.Clear();
            comboBox1.Text = "";
        }

        private void textBoxHHR_TextChanged(object sender, EventArgs e)
        {
            Program.HHR = textBoxHHR.Text;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
