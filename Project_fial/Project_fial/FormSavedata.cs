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
    public partial class FormSavedata : Form
    {
        public FormSavedata()
        {
            InitializeComponent();
        }
        MySqlDataAdapter oda;
        DataTable dt;
        int ed;
        private void loaddatatogid()
        {
            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
            string sql = "SELECT * FROM datauser WHERE username = '"+Program.user+"'";
            oda = new MySqlDataAdapter(sql, conn);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            textBoxUser.Text = Program.user;
            loaddatatogid();
            checkBox1.Checked = true;
            textBox1.Text = Program.bmr;
            textBoxTDEE.Text = Program.tdee;
            textBox2.Text = Program.bmi;
            textBoxmhr.Text = Program.MHR;
            textBoxthr.Text = Program.THR;
            textBoxhhr.Text = Program.HHR;
            Program.name1 = false;
            Program.daysearch = false;
            
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

        private void ปดโปรแกรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin f2 = new FormLogin();
            this.Hide();
            f2.Show();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            MySqlConnection conn1 = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
            conn1.Open();
            string sql1 = "INSERT INTO datauser(`username`,`BMR`,`BMI`,`TDEE`,`HHR`,`MHR`,`THR`) VALUES ('" + textBoxUser.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBoxTDEE.Text + "','" + textBoxhhr.Text + "','" + textBoxmhr.Text + "','" + textBoxthr.Text + "')";

            MySqlCommand cmd1 = new MySqlCommand(sql1, conn1);
            cmd1.ExecuteReader();
            conn1.Close();
            MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
            textBox1.Text = "";
            textBox2.Text = "";
            textBoxTDEE.Text = "";
            textBoxhhr.Text = "";
            textBoxmhr.Text = "";
            textBoxthr.Text = "";
            loaddatatogid();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string BMROld = dataGridView1.Rows[ed].Cells["BMR"].FormattedValue.ToString();
            string BMIOld = dataGridView1.Rows[ed].Cells["BMI"].FormattedValue.ToString();
            string TDEEOld = dataGridView1.Rows[ed].Cells["TDEE"].FormattedValue.ToString();
            string HHROld = dataGridView1.Rows[ed].Cells["HHR"].FormattedValue.ToString();
            string MHROld = dataGridView1.Rows[ed].Cells["MHR"].FormattedValue.ToString();
            string THROld = dataGridView1.Rows[ed].Cells["THR"].FormattedValue.ToString();

            MySqlConnection conn1 = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
            conn1.Open();
            string sql1 = "UPDATE `datauser` SET `BMR` = '" + textBox1.Text + "',`BMI` = '" + textBox2.Text + "',`TDEE` = '" + textBoxTDEE.Text+ "',`HHR` ='" + textBoxhhr.Text+ "',`MHR` = '" + textBoxmhr.Text+ "',`THR` ='" + textBoxthr.Text+ "' WHERE `username` ='" + textBoxUser.Text + "' AND `BMR` = '" + BMROld.ToString() + "' AND `BMI` = '" + BMIOld.ToString()+ "'AND `TDEE` = '" + TDEEOld.ToString() + "'AND `HHR` = '" + HHROld.ToString() + "'AND `MHR` = '" + MHROld.ToString() + "'AND `THR` = '" + THROld.ToString() + "'";

            MySqlCommand cmd1 = new MySqlCommand(sql1, conn1);
            cmd1.ExecuteReader();
            conn1.Close();
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย");
            loaddatatogid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["BMR"].FormattedValue.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["BMI"].FormattedValue.ToString();
            textBoxTDEE.Text = dataGridView1.Rows[e.RowIndex].Cells["TDEE"].FormattedValue.ToString();
            textBoxhhr.Text = dataGridView1.Rows[e.RowIndex].Cells["HHR"].FormattedValue.ToString();
            textBoxmhr.Text = dataGridView1.Rows[e.RowIndex].Cells["MHR"].FormattedValue.ToString();
            textBoxthr.Text = dataGridView1.Rows[e.RowIndex].Cells["THR"].FormattedValue.ToString();
            ed = dataGridView1.CurrentCell.RowIndex;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string BMROld = dataGridView1.Rows[ed].Cells["BMR"].FormattedValue.ToString();
            string BMIOld = dataGridView1.Rows[ed].Cells["BMI"].FormattedValue.ToString();
            string TDEEOld = dataGridView1.Rows[ed].Cells["TDEE"].FormattedValue.ToString();
            string HHROld = dataGridView1.Rows[ed].Cells["HHR"].FormattedValue.ToString();
            string MHROld = dataGridView1.Rows[ed].Cells["MHR"].FormattedValue.ToString();
            string THROld = dataGridView1.Rows[ed].Cells["THR"].FormattedValue.ToString();

            MySqlConnection conn1 = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
            conn1.Open();
            string sql1 = " DELETE FROM `datauser` WHERE `username` ='" + textBoxUser.Text + "' AND `TDEE` = '" + TDEEOld.ToString() + "' AND `BMR` = '" + BMROld.ToString() + "' AND `BMI` ='" + BMIOld.ToString() + "'AND `HHR` ='" + HHROld.ToString() + "'AND `MHR` = '" + MHROld.ToString() + "'AND `THR` = '" + THROld.ToString() + "'";

            MySqlCommand cmd1 = new MySqlCommand(sql1, conn1);
            cmd1.ExecuteReader();
            conn1.Close();
            MessageBox.Show("ลบข้อมูลเรียบร้อย");
            loaddatatogid();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int year = int.Parse(dateTimePicker1.Value.ToString("yyyy")) - 543;
            Program.daysearch = true;
            Program.search = dateTimePicker1.Value.ToString("" + year + "-MM-dd");
            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
            string sql = "SELECT * FROM datauser WHERE Date like '%"+Program.search+"%' AND username = '"+Program.user+"'";
            oda = new MySqlDataAdapter(sql, conn);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                Program.bmr1 = true;
                Program.bmi1 = true;
                Program.tdee1 = true;
                Program.hhr1 = true;
                Program.thr1 = true;
                Program.mhr1 = true;
            }
            else if (checkBox1.Checked == false)
            {
                Program.bmr1 = false;
                Program.bmi1 = false;
                Program.tdee1 = false;
                Program.hhr1 = false;
                Program.thr1 = false;
                Program.mhr1 = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                
            }
            if (checkBox2.Checked == true)
            {
                Program.bmr1 = true;
            }
            else if (checkBox2.Checked == false)
            {
                Program.bmr1 = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox3.Checked == true)
            {
                checkBox1.Checked = false;

            }
            if (checkBox3.Checked == true)
            {
                Program.bmi1 = true;
            }
            else if (checkBox3.Checked == false)
            {
                Program.bmi1 = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox4.Checked == true)
            {
                checkBox1.Checked = false;

            }
            if (checkBox4.Checked == true)
            {
                Program.tdee1 = true;
            }
            else if (checkBox4.Checked == false)
            {
                Program.tdee1 = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox5.Checked == true)
            {
                checkBox1.Checked = false;

            }
            if (checkBox5.Checked == true)
            {
                Program.hhr1 = true;
            }
            else if (checkBox5.Checked == false)
            {
                Program.hhr1 = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox6.Checked == true)
            {
                checkBox1.Checked = false;

            }
            if (checkBox6.Checked == true)
            {
                Program.mhr1 = true;
            }
            else if (checkBox6.Checked == false)
            {
                Program.mhr1 = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox7.Checked == true)
            {
                checkBox1.Checked = false;

            }
            if (checkBox7.Checked == true)
            {
                Program.thr1 = true;
            }
            else if (checkBox7.Checked == false)
            {
                Program.thr1 = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Show = "";
            if(checkBox1.Checked == true)
            {
                Program.Show = "*";
            }
            if(checkBox2.Checked == true && Program.Show != "")
            {
                Program.Show = Program.Show + ",BMR";
            } 
            else if (checkBox2.Checked == true && Program.Show == "")
            {
                Program.Show = "Date,BMR";
            }
            if (checkBox3.Checked == true && Program.Show != "")
            {
                Program.Show = Program.Show + ",BMI";
            }
            else if (checkBox3.Checked == true && Program.Show == "")
            {
                Program.Show = "Date,BMI";
            }
            if (checkBox4.Checked == true && Program.Show != "")
            {
                Program.Show = Program.Show + ",TDEE";
            }
            else if (checkBox4.Checked == true && Program.Show == "")
            {
                Program.Show = "Date,TDEE";
            }
            if (checkBox5.Checked == true && Program.Show != "")
            {
                Program.Show = Program.Show + ",HHR";
            }
            else if (checkBox5.Checked == true && Program.Show == "")
            {
                Program.Show = "Date,HHR";
            }
            if (checkBox6.Checked == true && Program.Show != "")
            {
                Program.Show = Program.Show + ",MHR";
            }
            else if (checkBox6.Checked == true && Program.Show == "")
            {
                Program.Show = "Date,MHR";
            }
            if (checkBox7.Checked == true && Program.Show != "")
            {
                Program.Show = Program.Show + ",THR";
            }
            else if (checkBox7.Checked == true && Program.Show == "")
            {
                Program.Show = "Date,THR";
            }
            Program.all = false;
            Form2 fm = new Form2();
            fm.Show();
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
