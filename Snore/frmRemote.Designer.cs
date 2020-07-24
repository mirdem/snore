namespace Snore
{
    partial class frmRemote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemote));
            this.panel1 = new System.Windows.Forms.Panel();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.radioShutdown = new DarkUI.Controls.DarkRadioButton();
            this.radioRestart = new DarkUI.Controls.DarkRadioButton();
            this.radioLogOff = new DarkUI.Controls.DarkRadioButton();
            this.radioLock = new DarkUI.Controls.DarkRadioButton();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.btnSet = new DarkUI.Controls.DarkButton();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.txtTime = new DarkUI.Controls.DarkTextBox();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.lblCountdownMin = new DarkUI.Controls.DarkLabel();
            this.darkLabel6 = new DarkUI.Controls.DarkLabel();
            this.lblCountdownSecond = new DarkUI.Controls.DarkLabel();
            this.darkLabel8 = new DarkUI.Controls.DarkLabel();
            this.darkSectionPanel3 = new DarkUI.Controls.DarkSectionPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnApply = new DarkUI.Controls.DarkButton();
            this.darkLabel5 = new DarkUI.Controls.DarkLabel();
            this.txtRemoteIP = new DarkUI.Controls.DarkTextBox();
            this.darkLabel9 = new DarkUI.Controls.DarkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.darkSectionPanel1.SuspendLayout();
            this.darkSectionPanel2.SuspendLayout();
            this.darkSectionPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(84)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.darkLabel1);
            this.panel1.Controls.Add(this.darkButton1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 24);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(29, 6);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(44, 13);
            this.darkLabel1.TabIndex = 2;
            this.darkLabel1.Text = "Remote";
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(338, 3);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(24, 24);
            this.darkButton1.TabIndex = 1;
            this.darkButton1.Text = "X";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Controls.Add(this.radioShutdown);
            this.darkSectionPanel1.Controls.Add(this.radioRestart);
            this.darkSectionPanel1.Controls.Add(this.radioLogOff);
            this.darkSectionPanel1.Controls.Add(this.radioLock);
            this.darkSectionPanel1.Controls.Add(this.darkLabel2);
            this.darkSectionPanel1.Location = new System.Drawing.Point(13, 45);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = null;
            this.darkSectionPanel1.Size = new System.Drawing.Size(336, 107);
            this.darkSectionPanel1.TabIndex = 1;
            // 
            // radioShutdown
            // 
            this.radioShutdown.AutoSize = true;
            this.radioShutdown.Location = new System.Drawing.Point(10, 53);
            this.radioShutdown.Name = "radioShutdown";
            this.radioShutdown.Size = new System.Drawing.Size(73, 17);
            this.radioShutdown.TabIndex = 3;
            this.radioShutdown.TabStop = true;
            this.radioShutdown.Text = "Shutdown";
            // 
            // radioRestart
            // 
            this.radioRestart.AutoSize = true;
            this.radioRestart.Location = new System.Drawing.Point(95, 53);
            this.radioRestart.Name = "radioRestart";
            this.radioRestart.Size = new System.Drawing.Size(61, 17);
            this.radioRestart.TabIndex = 4;
            this.radioRestart.TabStop = true;
            this.radioRestart.Text = "Restart";
            // 
            // radioLogOff
            // 
            this.radioLogOff.AutoSize = true;
            this.radioLogOff.Enabled = false;
            this.radioLogOff.Location = new System.Drawing.Point(166, 53);
            this.radioLogOff.Name = "radioLogOff";
            this.radioLogOff.Size = new System.Drawing.Size(61, 17);
            this.radioLogOff.TabIndex = 5;
            this.radioLogOff.TabStop = true;
            this.radioLogOff.Text = "Log Off";
            // 
            // radioLock
            // 
            this.radioLock.AutoSize = true;
            this.radioLock.Enabled = false;
            this.radioLock.Location = new System.Drawing.Point(244, 53);
            this.radioLock.Name = "radioLock";
            this.radioLock.Size = new System.Drawing.Size(46, 17);
            this.radioLock.TabIndex = 6;
            this.radioLock.TabStop = true;
            this.radioLock.Text = "Lock";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(4, 6);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(79, 13);
            this.darkLabel2.TabIndex = 0;
            this.darkLabel2.Text = "Choose action:";
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Controls.Add(this.btnSet);
            this.darkSectionPanel2.Controls.Add(this.btnCancel);
            this.darkSectionPanel2.Controls.Add(this.darkLabel4);
            this.darkSectionPanel2.Controls.Add(this.txtTime);
            this.darkSectionPanel2.Controls.Add(this.darkLabel3);
            this.darkSectionPanel2.Location = new System.Drawing.Point(13, 219);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = null;
            this.darkSectionPanel2.Size = new System.Drawing.Size(336, 115);
            this.darkSectionPanel2.TabIndex = 2;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(257, 38);
            this.btnSet.Name = "btnSet";
            this.btnSet.Padding = new System.Windows.Forms.Padding(5);
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "Set";
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel4.Location = new System.Drawing.Point(2, 67);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(90, 13);
            this.darkLabel4.TabIndex = 2;
            this.darkLabel4.Text = "Set time(Minute):";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtTime.Location = new System.Drawing.Point(95, 59);
            this.txtTime.MaxLength = 4;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 21);
            this.txtTime.TabIndex = 1;
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(2, 5);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(50, 13);
            this.darkLabel3.TabIndex = 0;
            this.darkLabel3.Text = "Set time:";
            // 
            // lblCountdownMin
            // 
            this.lblCountdownMin.AutoSize = true;
            this.lblCountdownMin.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountdownMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblCountdownMin.Location = new System.Drawing.Point(134, 383);
            this.lblCountdownMin.Name = "lblCountdownMin";
            this.lblCountdownMin.Size = new System.Drawing.Size(39, 29);
            this.lblCountdownMin.TabIndex = 5;
            this.lblCountdownMin.Text = "00";
            // 
            // darkLabel6
            // 
            this.darkLabel6.AutoSize = true;
            this.darkLabel6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.darkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel6.Location = new System.Drawing.Point(166, 383);
            this.darkLabel6.Name = "darkLabel6";
            this.darkLabel6.Size = new System.Drawing.Size(21, 29);
            this.darkLabel6.TabIndex = 6;
            this.darkLabel6.Text = ":";
            // 
            // lblCountdownSecond
            // 
            this.lblCountdownSecond.AutoSize = true;
            this.lblCountdownSecond.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountdownSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblCountdownSecond.Location = new System.Drawing.Point(182, 383);
            this.lblCountdownSecond.Name = "lblCountdownSecond";
            this.lblCountdownSecond.Size = new System.Drawing.Size(39, 29);
            this.lblCountdownSecond.TabIndex = 7;
            this.lblCountdownSecond.Text = "00";
            // 
            // darkLabel8
            // 
            this.darkLabel8.AutoSize = true;
            this.darkLabel8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.darkLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel8.Location = new System.Drawing.Point(136, 358);
            this.darkLabel8.Name = "darkLabel8";
            this.darkLabel8.Size = new System.Drawing.Size(94, 14);
            this.darkLabel8.TabIndex = 8;
            this.darkLabel8.Text = "Remaining time:";
            // 
            // darkSectionPanel3
            // 
            this.darkSectionPanel3.Controls.Add(this.linkLabel1);
            this.darkSectionPanel3.Controls.Add(this.btnApply);
            this.darkSectionPanel3.Controls.Add(this.darkLabel5);
            this.darkSectionPanel3.Controls.Add(this.txtRemoteIP);
            this.darkSectionPanel3.Controls.Add(this.darkLabel9);
            this.darkSectionPanel3.Location = new System.Drawing.Point(13, 159);
            this.darkSectionPanel3.Name = "darkSectionPanel3";
            this.darkSectionPanel3.SectionHeader = null;
            this.darkSectionPanel3.Size = new System.Drawing.Size(336, 54);
            this.darkSectionPanel3.TabIndex = 9;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabel1.Location = new System.Drawing.Point(243, 32);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(14, 14);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(261, 29);
            this.btnApply.Name = "btnApply";
            this.btnApply.Padding = new System.Windows.Forms.Padding(5);
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply now";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // darkLabel5
            // 
            this.darkLabel5.AutoSize = true;
            this.darkLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel5.Location = new System.Drawing.Point(4, 5);
            this.darkLabel5.Name = "darkLabel5";
            this.darkLabel5.Size = new System.Drawing.Size(98, 13);
            this.darkLabel5.TabIndex = 2;
            this.darkLabel5.Text = "Remote IP Setting:";
            // 
            // txtRemoteIP
            // 
            this.txtRemoteIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtRemoteIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemoteIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtRemoteIP.Location = new System.Drawing.Point(113, 29);
            this.txtRemoteIP.Name = "txtRemoteIP";
            this.txtRemoteIP.Size = new System.Drawing.Size(128, 21);
            this.txtRemoteIP.TabIndex = 1;
            // 
            // darkLabel9
            // 
            this.darkLabel9.AutoSize = true;
            this.darkLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel9.Location = new System.Drawing.Point(4, 34);
            this.darkLabel9.Name = "darkLabel9";
            this.darkLabel9.Size = new System.Drawing.Size(103, 13);
            this.darkLabel9.TabIndex = 0;
            this.darkLabel9.Text = "Remote IP Address:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmRemote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(361, 431);
            this.Controls.Add(this.darkSectionPanel3);
            this.Controls.Add(this.darkLabel8);
            this.Controls.Add(this.lblCountdownMin);
            this.Controls.Add(this.darkLabel6);
            this.Controls.Add(this.lblCountdownSecond);
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.darkSectionPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRemote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRemote";
            this.Load += new System.EventHandler(this.frmRemote_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel1.PerformLayout();
            this.darkSectionPanel2.ResumeLayout(false);
            this.darkSectionPanel2.PerformLayout();
            this.darkSectionPanel3.ResumeLayout(false);
            this.darkSectionPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DarkUI.Controls.DarkButton darkButton1;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkRadioButton radioShutdown;
        private DarkUI.Controls.DarkRadioButton radioRestart;
        private DarkUI.Controls.DarkRadioButton radioLogOff;
        private DarkUI.Controls.DarkRadioButton radioLock;
        private DarkUI.Controls.DarkLabel darkLabel4;
        private DarkUI.Controls.DarkTextBox txtTime;
        private DarkUI.Controls.DarkButton btnSet;
        private DarkUI.Controls.DarkButton btnCancel;
        private DarkUI.Controls.DarkLabel lblCountdownMin;
        private DarkUI.Controls.DarkLabel darkLabel6;
        private DarkUI.Controls.DarkLabel lblCountdownSecond;
        private DarkUI.Controls.DarkLabel darkLabel8;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel3;
        private DarkUI.Controls.DarkTextBox txtRemoteIP;
        private DarkUI.Controls.DarkLabel darkLabel9;
        private System.Windows.Forms.Timer timer1;
        private DarkUI.Controls.DarkLabel darkLabel5;
        private DarkUI.Controls.DarkButton btnApply;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}