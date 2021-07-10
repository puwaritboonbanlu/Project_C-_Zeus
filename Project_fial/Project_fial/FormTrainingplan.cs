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
    public partial class FormTrainingplan : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_final";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void numex()
        {
            List<string> days = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            foreach(var i in days) //monday
            {
                cmd.CommandText = "SELECT COUNT(*) FROM datatraining WHERE username = '" + Program.user + "'AND day ='" + i + "'";
                string num = Convert.ToString(cmd.ExecuteScalar());
                switch (i)
                {
                    case "Monday":label8.Text = num; break;
                    case "Tuesday": label9.Text = num; break;
                    case "Wednesday": label10.Text = num; break;
                    case "Thursday": label11.Text = num; break;
                    case "Friday": label12.Text = num; break;
                    case "Saturday": label13.Text = num; break;
                    case "Sunday": label14.Text = num; break;
                }

            }
          
        }
        public FormTrainingplan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.day = "Monday";
            this.Hide();
            Formdatatrain fm = new Formdatatrain();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.day = "Tuesday";
            this.Hide();
            Formdatatrain fm = new Formdatatrain();
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.day = "Wednesday";
            this.Hide();
            Formdatatrain fm = new Formdatatrain();
            fm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.day = "Thursday";
            this.Hide();
            Formdatatrain fm = new Formdatatrain();
            fm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.day = "Friday";
            this.Hide();
            Formdatatrain fm = new Formdatatrain();
            fm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.day = "Saturday";
            this.Hide();
            Formdatatrain fm = new Formdatatrain();
            fm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.day = "Sunday";
            this.Hide();
            Formdatatrain fm = new Formdatatrain();
            fm.Show();
        }

        private void trainingPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTrainingplan ft = new FormTrainingplan();
            ft.Show();
        }

        private void คำนวณคาBMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBMI f4 = new FormBMI();
            this.Hide();
            f4.Show();
        }

        private void คำนวณคาBMRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBMR fb = new FormBMR();
            fb.Show();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormTrainingplan_Load(object sender, EventArgs e)
        {
            numex();
            label16.Text = "สวัสดีคุณ " + Program.user + " ยินดีต้อนรับเข้าสู่ ZEUS GOOD HEALTH";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
