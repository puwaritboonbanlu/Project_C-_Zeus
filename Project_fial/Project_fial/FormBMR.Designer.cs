
namespace Project_fial
{
    partial class FormBMR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBMR));
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.เมนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.คำนวณคาBMRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.คำนวณคาBMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.คำนวณHeartRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.บนทกขอมลToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ออกจากระบบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ปดโปรแกรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("FC Lamoon", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(360, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "คำนวณ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("FC Lamoon", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(351, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "ส่วนสูง";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("FC Lamoon", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(348, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "น้ำหนัก\r\n";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("FC Lamoon", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(248, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "คำนวณเผาผลาญพลังงาน (BMR)\r\n";
            // 
            // textBoxW
            // 
            this.textBoxW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxW.Font = new System.Drawing.Font("FC Lamoon", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxW.ForeColor = System.Drawing.Color.Black;
            this.textBoxW.Location = new System.Drawing.Point(423, 282);
            this.textBoxW.Multiline = true;
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(115, 27);
            this.textBoxW.TabIndex = 20;
            this.textBoxW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxW_KeyPress);
            // 
            // textBoxT
            // 
            this.textBoxT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxT.Font = new System.Drawing.Font("FC Lamoon", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxT.ForeColor = System.Drawing.Color.Black;
            this.textBoxT.Location = new System.Drawing.Point(423, 328);
            this.textBoxT.Multiline = true;
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(115, 27);
            this.textBoxT.TabIndex = 21;
            this.textBoxT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxT_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("FC Lamoon", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(544, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 27);
            this.label6.TabIndex = 24;
            this.label6.Text = "ซม.";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("FC Lamoon", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(543, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 27);
            this.label7.TabIndex = 23;
            this.label7.Text = "กก.";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.Font = new System.Drawing.Font("FC Lamoon", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "นั่งทํางานอยู่กับที่ และไม่ได้ออกกําลังกายเลย ",
            "ออกกําลังกายหรือเล่นกีฬาเล็กน้อย ประมาณอาทิตย์ละ 1-3 วัน ",
            "ออกกําลังกายหรือเล่นกีฬาปานกลาง ประมาณอาทิตย์ละ 3-5 วัน",
            "ออกกําลังกายหรือเล่นกีฬาอย่างหนัก ประมาณอาทิตย์ละ 6-7 วัน ",
            "ออกกําลังกายหรือเล่นกีฬาอย่างหนักทุกวันเช้าเย็น"});
            this.comboBox1.Location = new System.Drawing.Point(311, 407);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(390, 30);
            this.comboBox1.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("FC Lamoon", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(226, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 27);
            this.label8.TabIndex = 27;
            this.label8.Text = "กิจกรรม";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.HotPink;
            this.label9.Location = new System.Drawing.Point(317, 593);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 35);
            this.label9.TabIndex = 29;
            this.label9.Text = "BMR";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.HotPink;
            this.label10.Location = new System.Drawing.Point(316, 659);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 35);
            this.label10.TabIndex = 30;
            this.label10.Text = "TDEE";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("FC Lamoon", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(488, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 39);
            this.button2.TabIndex = 31;
            this.button2.Text = "เคลียร์ข้อมูล";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightCyan;
            this.textBox1.Font = new System.Drawing.Font("FC Lamoon", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.Location = new System.Drawing.Point(413, 593);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 33);
            this.textBox1.TabIndex = 32;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightCyan;
            this.textBox2.Font = new System.Drawing.Font("FC Lamoon", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox2.Location = new System.Drawing.Point(413, 661);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 33);
            this.textBox2.TabIndex = 33;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("FC Lamoon", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(562, 596);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 27);
            this.label11.TabIndex = 34;
            this.label11.Text = "kcal.";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("FC Lamoon", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(562, 667);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 27);
            this.label12.TabIndex = 35;
            this.label12.Text = "kcal.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip1.Font = new System.Drawing.Font("Cloud Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.เมนToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(939, 31);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // เมนToolStripMenuItem
            // 
            this.เมนToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.เมนToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.คำนวณคาBMRToolStripMenuItem,
            this.คำนวณคาBMIToolStripMenuItem,
            this.คำนวณHeartRateToolStripMenuItem,
            this.บนทกขอมลToolStripMenuItem,
            this.trainingPlanToolStripMenuItem,
            this.ออกจากระบบToolStripMenuItem,
            this.ปดโปรแกรมToolStripMenuItem});
            this.เมนToolStripMenuItem.Font = new System.Drawing.Font("FC Lamoon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.เมนToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.เมนToolStripMenuItem.Name = "เมนToolStripMenuItem";
            this.เมนToolStripMenuItem.Size = new System.Drawing.Size(44, 27);
            this.เมนToolStripMenuItem.Text = "เมนู";
            // 
            // คำนวณคาBMRToolStripMenuItem
            // 
            this.คำนวณคาBMRToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.คำนวณคาBMRToolStripMenuItem.Font = new System.Drawing.Font("FC Lamoon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.คำนวณคาBMRToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.คำนวณคาBMRToolStripMenuItem.Name = "คำนวณคาBMRToolStripMenuItem";
            this.คำนวณคาBMRToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.คำนวณคาBMRToolStripMenuItem.Text = "คำนวณค่า BMR";
            this.คำนวณคาBMRToolStripMenuItem.Click += new System.EventHandler(this.คำนวณคาBMRToolStripMenuItem_Click_1);
            // 
            // คำนวณคาBMIToolStripMenuItem
            // 
            this.คำนวณคาBMIToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.คำนวณคาBMIToolStripMenuItem.Font = new System.Drawing.Font("FC Lamoon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.คำนวณคาBMIToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.คำนวณคาBMIToolStripMenuItem.Name = "คำนวณคาBMIToolStripMenuItem";
            this.คำนวณคาBMIToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.คำนวณคาBMIToolStripMenuItem.Text = "คำนวณค่า BMI";
            this.คำนวณคาBMIToolStripMenuItem.Click += new System.EventHandler(this.คำนวณคาBMIToolStripMenuItem_Click_1);
            // 
            // คำนวณHeartRateToolStripMenuItem
            // 
            this.คำนวณHeartRateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.คำนวณHeartRateToolStripMenuItem.Name = "คำนวณHeartRateToolStripMenuItem";
            this.คำนวณHeartRateToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.คำนวณHeartRateToolStripMenuItem.Text = "คำนวณHeart Rate";
            this.คำนวณHeartRateToolStripMenuItem.Click += new System.EventHandler(this.คำนวณHeartRateToolStripMenuItem_Click);
            // 
            // บนทกขอมลToolStripMenuItem
            // 
            this.บนทกขอมลToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.บนทกขอมลToolStripMenuItem.Font = new System.Drawing.Font("FC Lamoon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.บนทกขอมลToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.บนทกขอมลToolStripMenuItem.Name = "บนทกขอมลToolStripMenuItem";
            this.บนทกขอมลToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.บนทกขอมลToolStripMenuItem.Text = "บันทึกข้อมูล";
            this.บนทกขอมลToolStripMenuItem.Click += new System.EventHandler(this.บนทกขอมลToolStripMenuItem_Click_1);
            // 
            // trainingPlanToolStripMenuItem
            // 
            this.trainingPlanToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.trainingPlanToolStripMenuItem.Name = "trainingPlanToolStripMenuItem";
            this.trainingPlanToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.trainingPlanToolStripMenuItem.Text = "Training plan";
            this.trainingPlanToolStripMenuItem.Click += new System.EventHandler(this.trainingPlanToolStripMenuItem_Click);
            // 
            // ออกจากระบบToolStripMenuItem
            // 
            this.ออกจากระบบToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ออกจากระบบToolStripMenuItem.Font = new System.Drawing.Font("FC Lamoon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ออกจากระบบToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ออกจากระบบToolStripMenuItem.Name = "ออกจากระบบToolStripMenuItem";
            this.ออกจากระบบToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.ออกจากระบบToolStripMenuItem.Text = "ออกจากระบบ";
            this.ออกจากระบบToolStripMenuItem.Click += new System.EventHandler(this.ออกจากระบบToolStripMenuItem_Click_1);
            // 
            // ปดโปรแกรมToolStripMenuItem
            // 
            this.ปดโปรแกรมToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ปดโปรแกรมToolStripMenuItem.Font = new System.Drawing.Font("FC Lamoon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ปดโปรแกรมToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ปดโปรแกรมToolStripMenuItem.Name = "ปดโปรแกรมToolStripMenuItem";
            this.ปดโปรแกรมToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.ปดโปรแกรมToolStripMenuItem.Text = "ปิดโปรแกรม";
            this.ปดโปรแกรมToolStripMenuItem.Click += new System.EventHandler(this.ปดโปรแกรมToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.IndianRed;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(34, 27);
            this.toolStripMenuItem1.Text = "?";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("FC Lamoon", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label13.Location = new System.Drawing.Point(12, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 23);
            this.label13.TabIndex = 41;
            this.label13.Text = "0";
            // 
            // FormBMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 783);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.textBoxW);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormBMR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxW;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem เมนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem คำนวณคาBMRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem คำนวณคาBMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem คำนวณHeartRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem บนทกขอมลToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ออกจากระบบToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ปดโปรแกรมToolStripMenuItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}