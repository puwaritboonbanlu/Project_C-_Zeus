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
    public partial class Formdatatrain : Form
    {
        MySqlDataAdapter oda;
        DataTable dt;
        int ed;
        private void showplan()
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM datatraining WHERE username = '" + Program.user + "'AND day = '" + Program.day + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_final";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Formdatatrain()
        {
            InitializeComponent();
        }

        private void Formdatatrain_Load(object sender, EventArgs e)
        {
            label6.Text = Program.day;
            label7.Text = "สวัสดีคุณ " + Program.user + " ยินดีต้อนรับเข้าสู่ ZEUS GOOD HEALTH";
            showplan();
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

        private void คำนวณคาBMRToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO `datatraining`(`username`,`day`,`exercise`,`set`,`reps`,`time`,`rest`) VALUES ('" + Program.user + "','" + Program.day + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("บันทึกเสร็จสิ้น");
            showplan();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ex = dataGridView1.Rows[ed].Cells["exercise"].FormattedValue.ToString();
            string set = dataGridView1.Rows[ed].Cells["set"].FormattedValue.ToString();
            string reps = dataGridView1.Rows[ed].Cells["reps"].FormattedValue.ToString();
            string time = dataGridView1.Rows[ed].Cells["time"].FormattedValue.ToString();
            string rest = dataGridView1.Rows[ed].Cells["rest"].FormattedValue.ToString();

            MySqlConnection conn1 = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
            conn1.Open();
            string sql1 = "UPDATE `datatraining` SET `exercise` = '" + textBox1.Text + "',`set` = '" + textBox2.Text + "',`reps` = '" + textBox3.Text + "',`time` = '" + textBox4.Text + "',`rest` = '" + textBox5.Text + "' WHERE `username` = '" + Program.user + "' AND `exercise` = '" + ex.ToString() + "' AND `set` = '" + set.ToString() + "' AND `reps` = '" + reps.ToString() + "' AND `time` = '" + time.ToString() + "' AND `rest` = '" + rest.ToString() + "'";

            MySqlCommand cmd1 = new MySqlCommand(sql1, conn1);
            cmd1.ExecuteReader();
            conn1.Close();
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย");
            showplan();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["exercise"].FormattedValue.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["set"].FormattedValue.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["reps"].FormattedValue.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["time"].FormattedValue.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["rest"].FormattedValue.ToString();
            ed = dataGridView1.CurrentCell.RowIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ex = dataGridView1.Rows[ed].Cells["exercise"].FormattedValue.ToString();
            string set = dataGridView1.Rows[ed].Cells["set"].FormattedValue.ToString();
            string reps = dataGridView1.Rows[ed].Cells["reps"].FormattedValue.ToString();
            string time = dataGridView1.Rows[ed].Cells["time"].FormattedValue.ToString();
            string rest = dataGridView1.Rows[ed].Cells["rest"].FormattedValue.ToString();

            MySqlConnection conn1 = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
            conn1.Open();
            string sql1 = "DELETE FROM datatraining WHERE `username` = '" + Program.user + "' AND `exercise` = '" + ex.ToString() + "' AND `set` = '" + set.ToString() + "' AND `reps` = '" + reps.ToString() + "' AND `time` = '" + time.ToString() + "' AND `rest` = '" + rest.ToString() + "'";

            MySqlCommand cmd1 = new MySqlCommand(sql1, conn1);
            cmd1.ExecuteReader();
            conn1.Close();
            MessageBox.Show("ลบข้อมูลเรียบร้อย");
            showplan();
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }
    }
}
