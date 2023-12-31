// Token: 0x02000002 RID: 2
public partial class Form1 : global::System.Windows.Forms.Form
{
	// Token: 0x06000028 RID: 40 RVA: 0x000020F5 File Offset: 0x000002F5
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002C04 File Offset: 0x00000E04
	private void InitializeComponent()
	{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.bntMinimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRegisterHotkey = new System.Windows.Forms.Button();
            this.textBoxHotkey = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblBhopStatuslblStatus = new System.Windows.Forms.Label();
            this.lblBhopStatus = new System.Windows.Forms.Label();
            this.buttonActivarBhop = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonRegisterHotkey0 = new System.Windows.Forms.Button();
            this.textBoxHotkey0 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxAutoCopy = new System.Windows.Forms.CheckBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.timer_0 = new System.Windows.Forms.Timer(this.components);
            this.timer_1 = new System.Windows.Forms.Timer(this.components);
            this.timer_2 = new System.Windows.Forms.Timer(this.components);
            this.timer_3 = new System.Windows.Forms.Timer(this.components);
            this.timer_4 = new System.Windows.Forms.Timer(this.components);
            this.timer_5 = new System.Windows.Forms.Timer(this.components);
            this.timer_6 = new System.Windows.Forms.Timer(this.components);
            this.timer_7 = new System.Windows.Forms.Timer(this.components);
            this.timer_8 = new System.Windows.Forms.Timer(this.components);
            this.timer_9 = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButtonApocalypse = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.bntMinimize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 49);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(631, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bntMinimize
            // 
            this.bntMinimize.FlatAppearance.BorderSize = 0;
            this.bntMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.bntMinimize.ForeColor = System.Drawing.Color.White;
            this.bntMinimize.Location = new System.Drawing.Point(587, 8);
            this.bntMinimize.Name = "bntMinimize";
            this.bntMinimize.Size = new System.Drawing.Size(39, 33);
            this.bntMinimize.TabIndex = 1;
            this.bntMinimize.Text = "-";
            this.bntMinimize.UseVisualStyleBackColor = true;
            this.bntMinimize.Click += new System.EventHandler(this.bntMinimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Makima Server Fucker";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxIP);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(24, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DDOS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(98, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Attack";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Put ur IP here";
            // 
            // textBoxIP
            // 
            this.textBoxIP.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxIP.Location = new System.Drawing.Point(31, 50);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(215, 20);
            this.textBoxIP.TabIndex = 0;
            this.textBoxIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRegisterHotkey);
            this.groupBox2.Controls.Add(this.textBoxHotkey);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(17, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 87);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HotKey DDoS";
            // 
            // buttonRegisterHotkey
            // 
            this.buttonRegisterHotkey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonRegisterHotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonRegisterHotkey.Location = new System.Drawing.Point(30, 48);
            this.buttonRegisterHotkey.Name = "buttonRegisterHotkey";
            this.buttonRegisterHotkey.Size = new System.Drawing.Size(75, 23);
            this.buttonRegisterHotkey.TabIndex = 1;
            this.buttonRegisterHotkey.Text = "Set HotKey!";
            this.buttonRegisterHotkey.UseVisualStyleBackColor = false;
            this.buttonRegisterHotkey.Click += new System.EventHandler(this.buttonRegisterHotkey_Click);
            // 
            // textBoxHotkey
            // 
            this.textBoxHotkey.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxHotkey.Location = new System.Drawing.Point(18, 23);
            this.textBoxHotkey.Name = "textBoxHotkey";
            this.textBoxHotkey.Size = new System.Drawing.Size(100, 23);
            this.textBoxHotkey.TabIndex = 0;
            this.textBoxHotkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblBhopStatuslblStatus);
            this.groupBox3.Controls.Add(this.lblBhopStatus);
            this.groupBox3.Controls.Add(this.buttonActivarBhop);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(325, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 122);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auto-Bhop";
            // 
            // lblBhopStatuslblStatus
            // 
            this.lblBhopStatuslblStatus.AutoSize = true;
            this.lblBhopStatuslblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBhopStatuslblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBhopStatuslblStatus.Location = new System.Drawing.Point(3, 105);
            this.lblBhopStatuslblStatus.Name = "lblBhopStatuslblStatus";
            this.lblBhopStatuslblStatus.Size = new System.Drawing.Size(51, 13);
            this.lblBhopStatuslblStatus.TabIndex = 4;
            this.lblBhopStatuslblStatus.Text = "Status :";
            // 
            // lblBhopStatus
            // 
            this.lblBhopStatus.AutoSize = true;
            this.lblBhopStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBhopStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBhopStatus.Location = new System.Drawing.Point(52, 105);
            this.lblBhopStatus.Name = "lblBhopStatus";
            this.lblBhopStatus.Size = new System.Drawing.Size(24, 13);
            this.lblBhopStatus.TabIndex = 3;
            this.lblBhopStatus.Text = "Off";
            // 
            // buttonActivarBhop
            // 
            this.buttonActivarBhop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonActivarBhop.BackgroundImage")));
            this.buttonActivarBhop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonActivarBhop.Location = new System.Drawing.Point(140, 44);
            this.buttonActivarBhop.Name = "buttonActivarBhop";
            this.buttonActivarBhop.Size = new System.Drawing.Size(61, 51);
            this.buttonActivarBhop.TabIndex = 1;
            this.buttonActivarBhop.UseVisualStyleBackColor = true;
            this.buttonActivarBhop.Click += new System.EventHandler(this.buttonActivarBhop_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(763, 466);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "bhop";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonRegisterHotkey0);
            this.groupBox4.Controls.Add(this.textBoxHotkey0);
            this.groupBox4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.groupBox4.Location = new System.Drawing.Point(163, 82);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(134, 87);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Auto Bhop";
            // 
            // buttonRegisterHotkey0
            // 
            this.buttonRegisterHotkey0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonRegisterHotkey0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonRegisterHotkey0.Location = new System.Drawing.Point(32, 48);
            this.buttonRegisterHotkey0.Name = "buttonRegisterHotkey0";
            this.buttonRegisterHotkey0.Size = new System.Drawing.Size(75, 23);
            this.buttonRegisterHotkey0.TabIndex = 1;
            this.buttonRegisterHotkey0.Text = "Set HotKey!";
            this.buttonRegisterHotkey0.UseVisualStyleBackColor = false;
            this.buttonRegisterHotkey0.Click += new System.EventHandler(this.buttonRegisterHotkey0_Click);
            // 
            // textBoxHotkey0
            // 
            this.textBoxHotkey0.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxHotkey0.Location = new System.Drawing.Point(19, 23);
            this.textBoxHotkey0.Name = "textBoxHotkey0";
            this.textBoxHotkey0.Size = new System.Drawing.Size(100, 23);
            this.textBoxHotkey0.TabIndex = 0;
            this.textBoxHotkey0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.checkBoxAutoCopy);
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(24, 181);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(317, 185);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Settings";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox2);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.groupBox7.Location = new System.Drawing.Point(163, 20);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(134, 61);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "DDoS Config";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox2.Location = new System.Drawing.Point(70, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "255";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Delay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(72, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sockets";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(8, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "255";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxAutoCopy
            // 
            this.checkBoxAutoCopy.AutoSize = true;
            this.checkBoxAutoCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAutoCopy.Location = new System.Drawing.Point(39, 43);
            this.checkBoxAutoCopy.Name = "checkBoxAutoCopy";
            this.checkBoxAutoCopy.Size = new System.Drawing.Size(91, 17);
            this.checkBoxAutoCopy.TabIndex = 0;
            this.checkBoxAutoCopy.Text = "Auto-Paste IP";
            this.checkBoxAutoCopy.UseVisualStyleBackColor = true;
            this.checkBoxAutoCopy.CheckedChanged += new System.EventHandler(this.checkBoxAutoCopy_CheckedChanged);
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxLog.Location = new System.Drawing.Point(6, 22);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(279, 75);
            this.textBoxLog.TabIndex = 0;
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonClearLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonClearLog.Location = new System.Drawing.Point(234, 74);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(51, 23);
            this.buttonClearLog.TabIndex = 1;
            this.buttonClearLog.Text = "Clear";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.buttonClearLog_Click);
            // 
            // timer_0
            // 
            this.timer_0.Tick += new System.EventHandler(this.timer_0_Tick);
            // 
            // timer_1
            // 
            this.timer_1.Tick += new System.EventHandler(this.timer_1_Tick);
            // 
            // timer_2
            // 
            this.timer_2.Tick += new System.EventHandler(this.timer_2_Tick);
            // 
            // timer_3
            // 
            this.timer_3.Tick += new System.EventHandler(this.timer_3_Tick);
            // 
            // timer_4
            // 
            this.timer_4.Tick += new System.EventHandler(this.timer_4_Tick);
            // 
            // timer_5
            // 
            this.timer_5.Tick += new System.EventHandler(this.timer_5_Tick);
            // 
            // timer_6
            // 
            this.timer_6.Tick += new System.EventHandler(this.timer_6_Tick);
            // 
            // timer_7
            // 
            this.timer_7.Tick += new System.EventHandler(this.timer_7_Tick);
            // 
            // timer_8
            // 
            this.timer_8.Tick += new System.EventHandler(this.timer_8_Tick);
            // 
            // timer_9
            // 
            this.timer_9.Tick += new System.EventHandler(this.timer_9_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonClearLog);
            this.groupBox6.Controls.Add(this.textBoxLog);
            this.groupBox6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(359, 181);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(293, 104);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Log";
            // 
            // radioButtonApocalypse
            // 
            this.radioButtonApocalypse.AutoSize = true;
            this.radioButtonApocalypse.Checked = true;
            this.radioButtonApocalypse.Location = new System.Drawing.Point(674, 517);
            this.radioButtonApocalypse.Name = "radioButtonApocalypse";
            this.radioButtonApocalypse.Size = new System.Drawing.Size(14, 13);
            this.radioButtonApocalypse.TabIndex = 5;
            this.radioButtonApocalypse.TabStop = true;
            this.radioButtonApocalypse.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(447, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 218);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Original Creator : bruhexpertexploiter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fixed by : vivirasiesmorirdeamor";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Edited by: frenchieboy.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(688, 530);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.radioButtonApocalypse);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Makima";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	// Token: 0x0400000F RID: 15
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04000010 RID: 16
	private global::System.Windows.Forms.Panel panel1;

	// Token: 0x04000011 RID: 17
	private global::System.Windows.Forms.Button btnClose;

	// Token: 0x04000012 RID: 18
	private global::System.Windows.Forms.Button bntMinimize;

	// Token: 0x04000013 RID: 19
	private global::System.Windows.Forms.Label label1;

	// Token: 0x04000014 RID: 20
	private global::System.Windows.Forms.GroupBox groupBox1;

	// Token: 0x04000015 RID: 21
	private global::System.Windows.Forms.GroupBox groupBox2;

	// Token: 0x04000016 RID: 22
	private global::System.Windows.Forms.Button buttonRegisterHotkey;

	// Token: 0x04000017 RID: 23
	private global::System.Windows.Forms.TextBox textBoxHotkey;

	// Token: 0x04000018 RID: 24
	private global::System.Windows.Forms.Button button1;

	// Token: 0x04000019 RID: 25
	private global::System.Windows.Forms.Label label2;

	// Token: 0x0400001A RID: 26
	private global::System.Windows.Forms.TextBox textBoxIP;

	// Token: 0x0400001B RID: 27
	private global::System.Windows.Forms.GroupBox groupBox3;

	// Token: 0x0400001D RID: 29
	private global::System.Windows.Forms.CheckBox checkBox1;

	// Token: 0x0400001E RID: 30
	private global::System.Windows.Forms.Button buttonActivarBhop;

	// Token: 0x0400001F RID: 31
	private global::System.Windows.Forms.GroupBox groupBox4;

	// Token: 0x04000020 RID: 32
	private global::System.Windows.Forms.Button buttonRegisterHotkey0;

	// Token: 0x04000021 RID: 33
	private global::System.Windows.Forms.TextBox textBoxHotkey0;

	// Token: 0x04000022 RID: 34
	private global::System.Windows.Forms.GroupBox groupBox5;

	// Token: 0x04000023 RID: 35
	private global::System.Windows.Forms.CheckBox checkBoxAutoCopy;

	// Token: 0x04000024 RID: 36
	private global::System.Windows.Forms.Label lblBhopStatus;

	// Token: 0x04000025 RID: 37
	private global::System.Windows.Forms.Label lblBhopStatuslblStatus;

	// Token: 0x04000027 RID: 39
	private global::System.Windows.Forms.TextBox textBox1;

	// Token: 0x04000028 RID: 40
	private global::System.Windows.Forms.TextBox textBox2;

	// Token: 0x04000029 RID: 41
	private global::System.Windows.Forms.TextBox textBoxLog;

	// Token: 0x0400002A RID: 42
	private global::System.Windows.Forms.Button buttonClearLog;

	// Token: 0x0400002B RID: 43
	private global::System.Windows.Forms.Label label4;

	// Token: 0x0400002C RID: 44
	private global::System.Windows.Forms.GroupBox groupBox7;

	// Token: 0x0400002D RID: 45
	private global::System.Windows.Forms.Label label5;

	// Token: 0x0400002E RID: 46
	private global::System.Windows.Forms.Timer timer_0;

	// Token: 0x0400002F RID: 47
	private global::System.Windows.Forms.Timer timer_1;

	// Token: 0x04000030 RID: 48
	private global::System.Windows.Forms.Timer timer_2;

	// Token: 0x04000031 RID: 49
	private global::System.Windows.Forms.Timer timer_3;

	// Token: 0x04000032 RID: 50
	private global::System.Windows.Forms.Timer timer_4;

	// Token: 0x04000033 RID: 51
	private global::System.Windows.Forms.Timer timer_5;

	// Token: 0x04000034 RID: 52
	private global::System.Windows.Forms.Timer timer_6;

	// Token: 0x04000035 RID: 53
	private global::System.Windows.Forms.Timer timer_7;

	// Token: 0x04000036 RID: 54
	private global::System.Windows.Forms.Timer timer_8;

	// Token: 0x04000037 RID: 55
	private global::System.Windows.Forms.Timer timer_9;

	// Token: 0x04000039 RID: 57
	private global::System.Windows.Forms.GroupBox groupBox6;
    private System.ComponentModel.IContainer components;
    private System.Windows.Forms.RadioButton radioButtonApocalypse;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
}
