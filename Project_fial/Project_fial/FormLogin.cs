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
    public partial class FormLogin : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_final";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT status FROM login WHERE username = \"{textBox1.Text}\"AND password = \"{textBoxpassword.Text}\"";

            MySqlDataReader row = cmd.ExecuteReader();
            if (row.Read())
            {
                Program.status = row.GetValue(0).ToString();
                MessageBox.Show("เข้าสู่ระบบสำเร็จ");
                this.Hide();
                Program.user = textBox1.Text;
                if(Program.status == "Admin")
                {
                    FormAdmin fa = new FormAdmin();
                    fa.Show();
                }
                else
                {
                    FormBMR f5 = new FormBMR();
                    f5.Show();
                }
            }
            else { MessageBox.Show("เข้าสู่ระบบล้มเหลว\nบัญชีผู้ใช้ หรือ รหัสผ่าน ไม่ถูกต้อง"); }
            conn.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBoxpassword.UseSystemPasswordChar = false;
            }
            else if (checkBox1.Checked == false)
            {
                textBoxpassword.UseSystemPasswordChar = true;
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxpassword.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void textBoxpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }
    }
}
