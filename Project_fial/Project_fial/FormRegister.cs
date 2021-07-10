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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        string usernamefromdb;

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin f2 = new FormLogin();
            this.Hide();
            f2.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int countCharacter = this.textBoxpw1.TextLength;
            if (countCharacter < 21 && countCharacter > 5)
            {
                if (textBoxUser.Text == "" | textBoxpw1.Text == "" | textBoxpw2.Text == ""|textBox1.Text ==""|textBox2.Text ==""|textBox3.Text == "")
                {
                    MessageBox.Show("โปรดระบุข้อมูลให้ครบถ้วน");
                }
                else if (textBoxpw1.Text != textBoxpw2.Text)
                {
                    MessageBox.Show("กรอกรหัสผ่านของคุณให้ตรงกัน");
                }
                else
                {
                    MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
                    conn.Open();
                    string sql = "SELECT * FROM login WHERE Username = '" + textBoxUser.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    bool check = false;
                    string[] em = textBox2.Text.Split('@');
                    DateTime now = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    DateTime BD = dateTimePicker1.Value;

                    while (reader.Read())
                    {
                        usernamefromdb = reader.GetString("username");
                        check = true;
                    }
                    conn.Close();

                    if (check == true)
                    {
                        MessageBox.Show("ชื่อผู้ใช้นี้มีผู้ใช้อื่นใช้แล้วกรุณาเปลี่ยนชื่อผู้ใช้ใหม่");
                    }
                    else if (em.Count()>1)
                    {
                        MessageBox.Show("ไม่ต้องพิมพ์ @");
                    }
                    else if (textBox3.TextLength != 10)
                    {
                        MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์ให้ถูกต้อง");
                    }
                    else if(BD > now)
                    {
                        MessageBox.Show("กรุณากรอก วัน เดือน ปีเกิด ใหม่อีกครั้ง");
                    }
                    else if (check == false)
                    {
                        
                        MySqlConnection conn1 = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
                        conn1.Open();
                        string sql1 = "INSERT INTO login(username,password,address,email,tel,birthday,sex,status) VALUES('" + textBoxUser.Text + "','" + textBoxpw1.Text + "','"+ textBox1.Text +"','"+ textBox2.Text+comboBox1.Text + "','"+ textBox3.Text +"','"+dateTimePicker1.Value.ToShortDateString()+"','"+comboBox2.Text+"',\"user\")";

                        MySqlCommand cmd1 = new MySqlCommand(sql1, conn1);
                        cmd1.ExecuteReader();
                        conn1.Close();
                        MessageBox.Show("ลงทะเบียนเสร็จสิ้น");

                        textBoxUser.Text = "";
                        textBoxpw1.Text = "";
                        textBoxpw2.Text = "";
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        comboBox1.SelectedIndex = 0;
                        comboBox2.SelectedIndex = 0;
                        dateTimePicker1.Value = now;
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("โปรดใส่รหัสอย่างน้อย 6-20");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBoxpw1.UseSystemPasswordChar = false;
            }
            else if (checkBox1.Checked == false)
            {
                textBoxpw1.UseSystemPasswordChar = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBoxpw1.UseSystemPasswordChar = true;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            dateTimePicker1.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }
        private void textBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void textBoxpw2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void textBoxpw1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox3.TextLength >= 10 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if ((e.KeyChar < 48 || e.KeyChar > 57)&& e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime now = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            DateTime BD = dateTimePicker1.Value;
            if(BD > now)
            {
                MessageBox.Show("กรุณากรอก วัน เดือน ปีเกิด ใหม่อีกครั้ง");
                
            }

        }
    }
}
