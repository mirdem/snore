namespace Snore
{
    partial class frmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new DarkUI.Controls.DarkButton();
            this.btnExit = new DarkUI.Controls.DarkButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.radioShutdown = new DarkUI.Controls.DarkRadioButton();
            this.radioRestart = new DarkUI.Controls.DarkRadioButton();
            this.radioLogOff = new DarkUI.Controls.DarkRadioButton();
            this.radioLock = new DarkUI.Controls.DarkRadioButton();
            this.txtTime = new DarkUI.Controls.DarkTextBox();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.btnStopAlarm = new System.Windows.Forms.Button();
            this.darkLabel6 = new DarkUI.Controls.DarkLabel();
            this.btnStop = new DarkUI.Controls.DarkButton();
            this.btnStart = new DarkUI.Controls.DarkButton();
            this.lblCountdownMin = new DarkUI.Controls.DarkLabel();
            this.darkLabel5 = new DarkUI.Controls.DarkLabel();
            this.btnCloseApp = new DarkUI.Controls.DarkButton();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.radioAlarm = new DarkUI.Controls.DarkRadioButton();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCountdownSecond = new DarkUI.Controls.DarkLabel();
            this.darkLabel7 = new DarkUI.Controls.DarkLabel();
            this.btnSysTray = new DarkUI.Controls.DarkButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnAbout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.darkSectionPanel3 = new DarkUI.Controls.DarkSectionPanel();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.radioShutdown2 = new DarkUI.Controls.DarkRadioButton();
            this.RadioRestart2 = new DarkUI.Controls.DarkRadioButton();
            this.radioLock2 = new DarkUI.Controls.DarkRadioButton();
            this.radioLogOff2 = new DarkUI.Controls.DarkRadioButton();
            this.radioJustAlarm2 = new DarkUI.Controls.DarkRadioButton();
            this.darkLabel8 = new DarkUI.Controls.DarkLabel();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.darkSectionPanel4 = new DarkUI.Controls.DarkSectionPanel();
            this.darkNumericUpDown1 = new DarkUI.Controls.DarkNumericUpDown();
            this.darkLabel9 = new DarkUI.Controls.DarkLabel();
            this.lblBatteryLevel = new DarkUI.Controls.DarkLabel();
            this.darkLabel10 = new DarkUI.Controls.DarkLabel();
            this.timerBattery = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.darkSectionPanel2.SuspendLayout();
            this.darkSectionPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.darkSectionPanel3.SuspendLayout();
            this.darkSectionPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(84)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.darkLabel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(298, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(5);
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(323, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5);
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 1;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(3, 9);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(45, 18);
            this.darkLabel1.TabIndex = 1;
            this.darkLabel1.Text = "Snore";
            // 
            // radioShutdown
            // 
            this.radioShutdown.AutoSize = true;
            this.radioShutdown.Location = new System.Drawing.Point(8, 43);
            this.radioShutdown.Name = "radioShutdown";
            this.radioShutdown.Size = new System.Drawing.Size(73, 17);
            this.radioShutdown.TabIndex = 2;
            this.radioShutdown.TabStop = true;
            this.radioShutdown.Text = "Shutdown";
            // 
            // radioRestart
            // 
            this.radioRestart.AutoSize = true;
            this.radioRestart.Location = new System.Drawing.Point(98, 43);
            this.radioRestart.Name = "radioRestart";
            this.radioRestart.Size = new System.Drawing.Size(61, 17);
            this.radioRestart.TabIndex = 3;
            this.radioRestart.TabStop = true;
            this.radioRestart.Text = "Restart";
            // 
            // radioLogOff
            // 
            this.radioLogOff.AutoSize = true;
            this.radioLogOff.Location = new System.Drawing.Point(176, 43);
            this.radioLogOff.Name = "radioLogOff";
            this.radioLogOff.Size = new System.Drawing.Size(61, 17);
            this.radioLogOff.TabIndex = 4;
            this.radioLogOff.TabStop = true;
            this.radioLogOff.Text = "Log Off";
            // 
            // radioLock
            // 
            this.radioLock.AutoSize = true;
            this.radioLock.Location = new System.Drawing.Point(261, 43);
            this.radioLock.Name = "radioLock";
            this.radioLock.Size = new System.Drawing.Size(46, 17);
            this.radioLock.TabIndex = 5;
            this.radioLock.TabStop = true;
            this.radioLock.Text = "Lock";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtTime.Location = new System.Drawing.Point(94, 36);
            this.txtTime.MaxLength = 4;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 21);
            this.txtTime.TabIndex = 4;
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(15, 38);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(73, 13);
            this.darkLabel3.TabIndex = 5;
            this.darkLabel3.Text = "Time(Minute):";
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Controls.Add(this.btnStopAlarm);
            this.darkSectionPanel2.Controls.Add(this.darkLabel6);
            this.darkSectionPanel2.Controls.Add(this.btnStop);
            this.darkSectionPanel2.Controls.Add(this.btnStart);
            this.darkSectionPanel2.Controls.Add(this.darkLabel3);
            this.darkSectionPanel2.Controls.Add(this.txtTime);
            this.darkSectionPanel2.Location = new System.Drawing.Point(8, 123);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = null;
            this.darkSectionPanel2.Size = new System.Drawing.Size(340, 100);
            this.darkSectionPanel2.TabIndex = 6;
            // 
            // btnStopAlarm
            // 
            this.btnStopAlarm.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnStopAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopAlarm.Image = ((System.Drawing.Image)(resources.GetObject("btnStopAlarm.Image")));
            this.btnStopAlarm.Location = new System.Drawing.Point(220, 53);
            this.btnStopAlarm.Name = "btnStopAlarm";
            this.btnStopAlarm.Size = new System.Drawing.Size(30, 29);
            this.btnStopAlarm.TabIndex = 15;
            this.btnStopAlarm.UseVisualStyleBackColor = true;
            this.btnStopAlarm.Visible = false;
            this.btnStopAlarm.Click += new System.EventHandler(this.btnStopAlarm_Click);
            // 
            // darkLabel6
            // 
            this.darkLabel6.AutoSize = true;
            this.darkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel6.Location = new System.Drawing.Point(5, 5);
            this.darkLabel6.Name = "darkLabel6";
            this.darkLabel6.Size = new System.Drawing.Size(74, 13);
            this.darkLabel6.TabIndex = 8;
            this.darkLabel6.Text = "Time settings:";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(256, 68);
            this.btnStop.Name = "btnStop";
            this.btnStop.Padding = new System.Windows.Forms.Padding(5);
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(256, 38);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(5);
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblCountdownMin
            // 
            this.lblCountdownMin.AutoSize = true;
            this.lblCountdownMin.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountdownMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblCountdownMin.Location = new System.Drawing.Point(129, 279);
            this.lblCountdownMin.Name = "lblCountdownMin";
            this.lblCountdownMin.Size = new System.Drawing.Size(39, 29);
            this.lblCountdownMin.TabIndex = 7;
            this.lblCountdownMin.Text = "00";
            // 
            // darkLabel5
            // 
            this.darkLabel5.AutoSize = true;
            this.darkLabel5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.darkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel5.Location = new System.Drawing.Point(119, 253);
            this.darkLabel5.Name = "darkLabel5";
            this.darkLabel5.Size = new System.Drawing.Size(102, 16);
            this.darkLabel5.TabIndex = 8;
            this.darkLabel5.Text = "Remaining time:";
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Location = new System.Drawing.Point(264, 339);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Padding = new System.Windows.Forms.Padding(5);
            this.btnCloseApp.Size = new System.Drawing.Size(75, 23);
            this.btnCloseApp.TabIndex = 9;
            this.btnCloseApp.Text = "Exit";
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Controls.Add(this.radioAlarm);
            this.darkSectionPanel1.Controls.Add(this.darkLabel2);
            this.darkSectionPanel1.Controls.Add(this.radioLogOff);
            this.darkSectionPanel1.Controls.Add(this.radioLock);
            this.darkSectionPanel1.Controls.Add(this.radioRestart);
            this.darkSectionPanel1.Controls.Add(this.radioShutdown);
            this.darkSectionPanel1.Location = new System.Drawing.Point(8, 3);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = null;
            this.darkSectionPanel1.Size = new System.Drawing.Size(340, 101);
            this.darkSectionPanel1.TabIndex = 10;
            // 
            // radioAlarm
            // 
            this.radioAlarm.AutoSize = true;
            this.radioAlarm.Location = new System.Drawing.Point(126, 80);
            this.radioAlarm.Name = "radioAlarm";
            this.radioAlarm.Size = new System.Drawing.Size(75, 17);
            this.radioAlarm.TabIndex = 7;
            this.radioAlarm.TabStop = true;
            this.radioAlarm.Text = "Just Alarm";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(6, 6);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(79, 13);
            this.darkLabel2.TabIndex = 6;
            this.darkLabel2.Text = "Choose action:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCountdownSecond
            // 
            this.lblCountdownSecond.AutoSize = true;
            this.lblCountdownSecond.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountdownSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblCountdownSecond.Location = new System.Drawing.Point(182, 279);
            this.lblCountdownSecond.Name = "lblCountdownSecond";
            this.lblCountdownSecond.Size = new System.Drawing.Size(39, 29);
            this.lblCountdownSecond.TabIndex = 11;
            this.lblCountdownSecond.Text = "00";
            // 
            // darkLabel7
            // 
            this.darkLabel7.AutoSize = true;
            this.darkLabel7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.darkLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel7.Location = new System.Drawing.Point(164, 278);
            this.darkLabel7.Name = "darkLabel7";
            this.darkLabel7.Size = new System.Drawing.Size(21, 29);
            this.darkLabel7.TabIndex = 12;
            this.darkLabel7.Text = ":";
            // 
            // btnSysTray
            // 
            this.btnSysTray.Location = new System.Drawing.Point(183, 339);
            this.btnSysTray.Name = "btnSysTray";
            this.btnSysTray.Padding = new System.Windows.Forms.Padding(5);
            this.btnSysTray.Size = new System.Drawing.Size(75, 23);
            this.btnSysTray.TabIndex = 4;
            this.btnSysTray.Text = "SysTray";
            this.btnSysTray.Click += new System.EventHandler(this.btnSysTray_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.Location = new System.Drawing.Point(11, 330);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(40, 32);
            this.btnAbout.TabIndex = 14;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(351, 395);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabPage1.Controls.Add(this.darkSectionPanel1);
            this.tabPage1.Controls.Add(this.btnAbout);
            this.tabPage1.Controls.Add(this.darkSectionPanel2);
            this.tabPage1.Controls.Add(this.btnSysTray);
            this.tabPage1.Controls.Add(this.lblCountdownMin);
            this.tabPage1.Controls.Add(this.darkLabel7);
            this.tabPage1.Controls.Add(this.darkLabel5);
            this.tabPage1.Controls.Add(this.lblCountdownSecond);
            this.tabPage1.Controls.Add(this.btnCloseApp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(343, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabPage2.Controls.Add(this.lblBatteryLevel);
            this.tabPage2.Controls.Add(this.darkLabel9);
            this.tabPage2.Controls.Add(this.darkSectionPanel4);
            this.tabPage2.Controls.Add(this.darkSectionPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(343, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Battery Triggered";
            // 
            // darkSectionPanel3
            // 
            this.darkSectionPanel3.Controls.Add(this.RadioRestart2);
            this.darkSectionPanel3.Controls.Add(this.radioLock2);
            this.darkSectionPanel3.Controls.Add(this.radioShutdown2);
            this.darkSectionPanel3.Controls.Add(this.radioLogOff2);
            this.darkSectionPanel3.Controls.Add(this.radioJustAlarm2);
            this.darkSectionPanel3.Controls.Add(this.darkLabel4);
            this.darkSectionPanel3.Location = new System.Drawing.Point(6, 6);
            this.darkSectionPanel3.Name = "darkSectionPanel3";
            this.darkSectionPanel3.SectionHeader = null;
            this.darkSectionPanel3.Size = new System.Drawing.Size(331, 107);
            this.darkSectionPanel3.TabIndex = 0;
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel4.Location = new System.Drawing.Point(5, 1);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(79, 13);
            this.darkLabel4.TabIndex = 0;
            this.darkLabel4.Text = "Choose action:";
            // 
            // radioShutdown2
            // 
            this.radioShutdown2.AutoSize = true;
            this.radioShutdown2.Location = new System.Drawing.Point(8, 46);
            this.radioShutdown2.Name = "radioShutdown2";
            this.radioShutdown2.Size = new System.Drawing.Size(73, 17);
            this.radioShutdown2.TabIndex = 1;
            this.radioShutdown2.TabStop = true;
            this.radioShutdown2.Text = "Shutdown";
            // 
            // RadioRestart2
            // 
            this.RadioRestart2.AutoSize = true;
            this.RadioRestart2.Location = new System.Drawing.Point(87, 46);
            this.RadioRestart2.Name = "RadioRestart2";
            this.RadioRestart2.Size = new System.Drawing.Size(64, 17);
            this.RadioRestart2.TabIndex = 2;
            this.RadioRestart2.TabStop = true;
            this.RadioRestart2.Text = " Restart";
            // 
            // radioLock2
            // 
            this.radioLock2.AutoSize = true;
            this.radioLock2.Location = new System.Drawing.Point(254, 46);
            this.radioLock2.Name = "radioLock2";
            this.radioLock2.Size = new System.Drawing.Size(46, 17);
            this.radioLock2.TabIndex = 3;
            this.radioLock2.Text = "Lock";
            // 
            // radioLogOff2
            // 
            this.radioLogOff2.AutoSize = true;
            this.radioLogOff2.Location = new System.Drawing.Point(170, 46);
            this.radioLogOff2.Name = "radioLogOff2";
            this.radioLogOff2.Size = new System.Drawing.Size(61, 17);
            this.radioLogOff2.TabIndex = 4;
            this.radioLogOff2.Text = "Log Off";
            // 
            // radioJustAlarm2
            // 
            this.radioJustAlarm2.AutoSize = true;
            this.radioJustAlarm2.Location = new System.Drawing.Point(121, 86);
            this.radioJustAlarm2.Name = "radioJustAlarm2";
            this.radioJustAlarm2.Size = new System.Drawing.Size(75, 17);
            this.radioJustAlarm2.TabIndex = 5;
            this.radioJustAlarm2.Text = "Just Alarm";
            // 
            // darkLabel8
            // 
            this.darkLabel8.AutoSize = true;
            this.darkLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel8.Location = new System.Drawing.Point(12, 54);
            this.darkLabel8.Name = "darkLabel8";
            this.darkLabel8.Size = new System.Drawing.Size(68, 13);
            this.darkLabel8.TabIndex = 2;
            this.darkLabel8.Text = "Choose level";
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(252, 37);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(75, 23);
            this.darkButton1.TabIndex = 3;
            this.darkButton1.Text = "Apply";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // darkButton2
            // 
            this.darkButton2.Location = new System.Drawing.Point(252, 67);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(75, 23);
            this.darkButton2.TabIndex = 4;
            this.darkButton2.Text = "Cancel";
            this.darkButton2.Click += new System.EventHandler(this.darkButton2_Click);
            // 
            // darkSectionPanel4
            // 
            this.darkSectionPanel4.Controls.Add(this.darkLabel10);
            this.darkSectionPanel4.Controls.Add(this.darkNumericUpDown1);
            this.darkSectionPanel4.Controls.Add(this.darkButton2);
            this.darkSectionPanel4.Controls.Add(this.darkButton1);
            this.darkSectionPanel4.Controls.Add(this.darkLabel8);
            this.darkSectionPanel4.Location = new System.Drawing.Point(6, 129);
            this.darkSectionPanel4.Name = "darkSectionPanel4";
            this.darkSectionPanel4.SectionHeader = null;
            this.darkSectionPanel4.Size = new System.Drawing.Size(331, 107);
            this.darkSectionPanel4.TabIndex = 5;
            // 
            // darkNumericUpDown1
            // 
            this.darkNumericUpDown1.Location = new System.Drawing.Point(86, 52);
            this.darkNumericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.darkNumericUpDown1.Name = "darkNumericUpDown1";
            this.darkNumericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.darkNumericUpDown1.TabIndex = 5;
            this.darkNumericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // darkLabel9
            // 
            this.darkLabel9.AutoSize = true;
            this.darkLabel9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.darkLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel9.Location = new System.Drawing.Point(113, 260);
            this.darkLabel9.Name = "darkLabel9";
            this.darkLabel9.Size = new System.Drawing.Size(112, 14);
            this.darkLabel9.TabIndex = 6;
            this.darkLabel9.Text = "Now Battery Level:";
            // 
            // lblBatteryLevel
            // 
            this.lblBatteryLevel.AutoSize = true;
            this.lblBatteryLevel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBatteryLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblBatteryLevel.Location = new System.Drawing.Point(151, 288);
            this.lblBatteryLevel.Name = "lblBatteryLevel";
            this.lblBatteryLevel.Size = new System.Drawing.Size(38, 18);
            this.lblBatteryLevel.TabIndex = 7;
            this.lblBatteryLevel.Text = "100";
            this.lblBatteryLevel.Click += new System.EventHandler(this.lblBatteryLevel_Click);
            // 
            // darkLabel10
            // 
            this.darkLabel10.AutoSize = true;
            this.darkLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel10.Location = new System.Drawing.Point(8, 6);
            this.darkLabel10.Name = "darkLabel10";
            this.darkLabel10.Size = new System.Drawing.Size(94, 13);
            this.darkLabel10.TabIndex = 6;
            this.darkLabel10.Text = "Set Battery Level:";
            // 
            // timerBattery
            // 
            this.timerBattery.Interval = 1000;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(356, 428);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.darkSectionPanel2.ResumeLayout(false);
            this.darkSectionPanel2.PerformLayout();
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.darkSectionPanel3.ResumeLayout(false);
            this.darkSectionPanel3.PerformLayout();
            this.darkSectionPanel4.ResumeLayout(false);
            this.darkSectionPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkNumericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DarkUI.Controls.DarkButton btnMinimize;
        private DarkUI.Controls.DarkButton btnExit;
        private DarkUI.Controls.DarkRadioButton radioLock;
        private DarkUI.Controls.DarkRadioButton radioLogOff;
        private DarkUI.Controls.DarkRadioButton radioShutdown;
        private DarkUI.Controls.DarkRadioButton radioRestart;
        private DarkUI.Controls.DarkTextBox txtTime;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
        private DarkUI.Controls.DarkButton btnStart;
        private DarkUI.Controls.DarkButton btnStop;
        private DarkUI.Controls.DarkLabel lblCountdownMin;
        private DarkUI.Controls.DarkLabel darkLabel5;
        private DarkUI.Controls.DarkButton btnCloseApp;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkLabel darkLabel6;
        private System.Windows.Forms.Timer timer1;
        private DarkUI.Controls.DarkLabel lblCountdownSecond;
        private DarkUI.Controls.DarkLabel darkLabel7;
        private DarkUI.Controls.DarkButton btnSysTray;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private DarkUI.Controls.DarkRadioButton radioAlarm;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnStopAlarm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel3;
        private DarkUI.Controls.DarkLabel darkLabel4;
        private DarkUI.Controls.DarkRadioButton RadioRestart2;
        private DarkUI.Controls.DarkRadioButton radioLock2;
        private DarkUI.Controls.DarkRadioButton radioShutdown2;
        private DarkUI.Controls.DarkRadioButton radioLogOff2;
        private DarkUI.Controls.DarkRadioButton radioJustAlarm2;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel4;
        private DarkUI.Controls.DarkButton darkButton2;
        private DarkUI.Controls.DarkButton darkButton1;
        private DarkUI.Controls.DarkLabel darkLabel8;
        private DarkUI.Controls.DarkNumericUpDown darkNumericUpDown1;
        private DarkUI.Controls.DarkLabel lblBatteryLevel;
        private DarkUI.Controls.DarkLabel darkLabel9;
        private DarkUI.Controls.DarkLabel darkLabel10;
        private System.Windows.Forms.Timer timerBattery;
    }
}

