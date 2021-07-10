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
    public partial class Form2 : Form
    {
        List<Bill> allbill = new List<Bill>();
        MySqlDataAdapter oda;
        DataTable dt;
        string sql;

        private void Showstat() //โชว์ข้อมูลตาราง
        {
            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
            MySqlCommand cmd = conn.CreateCommand();
            if (Program.all == true)
            {
                if (Program.daysearch == true)
                {
                    cmd.CommandText = $"SELECT {Program.Show} FROM datauser WHERE Date like '%" + Program.search + "%'";
                }
                else if (Program.namesearch == true)
                {
                    cmd.CommandText = $"SELECT {Program.Show} FROM datauser WHERE username like '%" + Program.user + "%'";
                }
                else
                {
                    cmd.CommandText = $"SELECT {Program.Show} FROM datauser ";
                }
            }
            else
            {
                if (Program.daysearch == true)
                {
                    cmd.CommandText = $"SELECT {Program.Show} FROM datauser WHERE Date like '%" + Program.search + "%'AND username = '" + Program.user + "'";
                }

                else
                {
                    cmd.CommandText = $"SELECT {Program.Show} FROM datauser WHERE username = '" + Program.user + "'";
                }
            }

            oda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Showstat();
            Billform();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("ใบรายงานข้อมูล", new Font("supermarket", 16, FontStyle.Bold), Brushes.Black, new Point(400, 50));
            e.Graphics.DrawString("ZEUS GOOD HEALTH", new Font("supermarket", 16, FontStyle.Bold), Brushes.Black, new Point(355, 90));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd/MM/yyyy HH : mm : ss น."), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(525, 150));
            if (Program.all == false)
            {
                e.Graphics.DrawString("ชื่อบัญชีผู้ใช้งาน  " + Program.user, new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 150));
            }
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(50, 285));
            if (Program.all == true)
            {
                e.Graphics.DrawString("Username      Datetime                      BMR       BMI      TDEE     HHR     MHR     THR", new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new Point(50, 315));
            }
            else
            {
                e.Graphics.DrawString("Datetime                                BMR       BMI       TDEE      HHR      MHR      THR", new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new Point(50, 315));
            }
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(50, 345));
            int y = 345;
            int number = 1;
            foreach (var i in allbill)
            {
                y = y + 35;
                if (Program.all == true)
                {
                    if (Program.name1 == true)
                    {
                        e.Graphics.DrawString("   " + i.name, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(55, y));//โชวชื่อในคอลัม

                    }
                    e.Graphics.DrawString("   " + i.Datetime, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(140, y));

                    if (Program.bmr1 == true)
                    {
                        e.Graphics.DrawString("   " + i.bmr, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(350, y));

                    }
                    if (Program.bmi1 == true)
                    {
                        e.Graphics.DrawString("   " + i.bmi, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(425, y));

                    }
                    if (Program.tdee1 == true)
                    {
                        e.Graphics.DrawString("   " + i.tdee, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(500, y));
                    }
                    if (Program.hhr1 == true)
                    {
                        e.Graphics.DrawString("   " + i.hhr, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(575, y));

                    }
                    if (Program.mhr1 == true)
                    {
                        e.Graphics.DrawString("   " + i.mhr, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(650, y));


                    }
                    if (Program.thr1 == true)
                    {
                        e.Graphics.DrawString("   " + i.thr, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(725, y));

                    }
                }
                else
                {
                    e.Graphics.DrawString("   " + i.Datetime, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(55, y));

                    if (Program.bmr1 == true)
                    {
                        e.Graphics.DrawString("   " + i.bmr, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(280, y));

                    }
                    if (Program.bmi1 == true)
                    {
                        e.Graphics.DrawString("   " + i.bmi, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(360, y));

                    }
                    if (Program.tdee1 == true)
                    {
                        e.Graphics.DrawString("   " + i.tdee, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(440, y));

                    }
                    if (Program.hhr1 == true)
                    {
                        e.Graphics.DrawString("   " + i.hhr, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(520, y));

                    }
                    if (Program.mhr1 == true)
                    {
                        e.Graphics.DrawString("   " + i.mhr, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(600, y));


                    }
                    if (Program.thr1 == true)
                    {
                        e.Graphics.DrawString("   " + i.thr, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(680, y));

                    }
                }

                number = number + 1;
            }
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(50, y + 30));
            e.Graphics.DrawString("ขอบคุณที่ใช้บริการ       ", new Font("supermarket", 16, FontStyle.Bold), Brushes.Black, new Point(80, (y + 30) + 45));
        }    
        
        private void Billform()
        {
            allbill.Clear();
            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
            MySqlCommand cmd = conn.CreateCommand();
            
            if (Program.all == true)
            {
                if(Program.daysearch == true)
                {
                    cmd.CommandText = $"SELECT {Program.Show} FROM datauser WHERE Date like '%" + Program.search + "%'";
                }
                else if(Program.namesearch == true)
                {
                    cmd.CommandText = $"SELECT {Program.Show} FROM datauser WHERE username like '%" + Program.user + "%'";
                }
                else
                {
                    cmd.CommandText = $"SELECT {Program.Show} FROM datauser ";
                }
            }
            else
            {
                if (Program.daysearch == true)
                {
                    cmd.CommandText = $"SELECT {Program.Show} FROM datauser WHERE Date like '%" + Program.search + "%'AND username = '" + Program.user + "'";
                }
                
                else
                {
                    cmd.CommandText = $"SELECT {Program.Show} FROM datauser WHERE username = '" + Program.user + "'";
                }
                
            }

            conn.Open();
            MySqlDataReader adapter = cmd.ExecuteReader();
            while (adapter.Read()) 
            {
                Program.Datetime = adapter.GetString("Date"); //เก็บค่าdate
                if(Program.name1 == true)
                {
                    Program.name = adapter.GetString("username").ToString();
                }
                if(Program.bmr1 == true)
                {
                    Program.bmr = adapter.GetString("BMR").ToString();
                }
                if (Program.bmi1 == true)
                {
                    Program.bmi = adapter.GetString("BMI").ToString();
                }
                if (Program.tdee1 == true)
                {
                    Program.tdee = adapter.GetString("TDEE").ToString();
                }
                if (Program.hhr1 == true)
                {
                    Program.HHR = adapter.GetString("HHR").ToString();
                }
                if (Program.mhr1 == true)
                {
                    Program.MHR = adapter.GetString("MHR").ToString();

                }
                if (Program.thr1 == true)
                {
                    Program.THR = adapter.GetString("THR").ToString();
                }
                Bill item = new Bill()
                {

                    name = Program.name,
                    Datetime = Program.Datetime,
                    bmr = Program.bmr,
                    bmi = Program.bmi,
                    tdee = Program.tdee,
                    hhr = Program.HHR,
                    mhr = Program.MHR,
                    thr = Program.THR,
                };
                allbill.Add(item);

            }
        }
    }
}
