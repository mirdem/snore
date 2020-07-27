namespace Snore
{
    partial class frmZamanlayici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZamanlayici));
            this.darkRadioButton1 = new DarkUI.Controls.DarkRadioButton();
            this.darkRadioButton2 = new DarkUI.Controls.DarkRadioButton();
            this.darkRadioButton3 = new DarkUI.Controls.DarkRadioButton();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.btnSet = new DarkUI.Controls.DarkButton();
            this.btnDelete = new DarkUI.Controls.DarkButton();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.btnClose = new DarkUI.Controls.DarkButton();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.radioShutdown = new DarkUI.Controls.DarkRadioButton();
            this.radioRestart = new DarkUI.Controls.DarkRadioButton();
            this.radioHibernate = new DarkUI.Controls.DarkRadioButton();
            this.darkLabel5 = new DarkUI.Controls.DarkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.darkSectionPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.darkSectionPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkRadioButton1
            // 
            this.darkRadioButton1.AutoSize = true;
            this.darkRadioButton1.Location = new System.Drawing.Point(116, 48);
            this.darkRadioButton1.Name = "darkRadioButton1";
            this.darkRadioButton1.Size = new System.Drawing.Size(48, 17);
            this.darkRadioButton1.TabIndex = 1;
            this.darkRadioButton1.Text = "Daily";
            this.darkRadioButton1.Click += new System.EventHandler(this.darkRadioButton1_Click);
            // 
            // darkRadioButton2
            // 
            this.darkRadioButton2.AutoSize = true;
            this.darkRadioButton2.Checked = true;
            this.darkRadioButton2.Location = new System.Drawing.Point(7, 48);
            this.darkRadioButton2.Name = "darkRadioButton2";
            this.darkRadioButton2.Size = new System.Drawing.Size(56, 17);
            this.darkRadioButton2.TabIndex = 2;
            this.darkRadioButton2.TabStop = true;
            this.darkRadioButton2.Text = "Hourly";
            this.darkRadioButton2.Click += new System.EventHandler(this.darkRadioButton2_Click);
            // 
            // darkRadioButton3
            // 
            this.darkRadioButton3.AutoSize = true;
            this.darkRadioButton3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.darkRadioButton3.Location = new System.Drawing.Point(218, 48);
            this.darkRadioButton3.Name = "darkRadioButton3";
            this.darkRadioButton3.Size = new System.Drawing.Size(60, 17);
            this.darkRadioButton3.TabIndex = 3;
            this.darkRadioButton3.Text = "Weekly";
            this.darkRadioButton3.Click += new System.EventHandler(this.darkRadioButton3_Click);
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Controls.Add(this.darkLabel2);
            this.darkSectionPanel1.Controls.Add(this.timePicker);
            this.darkSectionPanel1.Controls.Add(this.darkLabel1);
            this.darkSectionPanel1.Controls.Add(this.darkRadioButton2);
            this.darkSectionPanel1.Controls.Add(this.darkRadioButton3);
            this.darkSectionPanel1.Controls.Add(this.darkRadioButton1);
            this.darkSectionPanel1.Location = new System.Drawing.Point(6, 34);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = null;
            this.darkSectionPanel1.Size = new System.Drawing.Size(321, 123);
            this.darkSectionPanel1.TabIndex = 4;
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(4, 86);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(33, 13);
            this.darkLabel2.TabIndex = 13;
            this.darkLabel2.Text = "Time:";
            // 
            // timePicker
            // 
            this.timePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(43, 81);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(70, 21);
            this.timePicker.TabIndex = 12;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(4, 10);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(79, 13);
            this.darkLabel1.TabIndex = 0;
            this.darkLabel1.Text = "Select Choose:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(84)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.darkLabel3);
            this.panel1.Controls.Add(this.darkButton1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 24);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(3, 8);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(79, 13);
            this.darkLabel3.TabIndex = 1;
            this.darkLabel3.Text = "Task Scheduler";
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(309, 0);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(24, 24);
            this.darkButton1.TabIndex = 0;
            this.darkButton1.Text = "X";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(250, 163);
            this.btnSet.Name = "btnSet";
            this.btnSet.Padding = new System.Windows.Forms.Padding(5);
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 6;
            this.btnSet.Text = "Save";
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(250, 193);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5);
            this.btnDelete.Size = new System.Drawing.Size(75, 45);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Disable selected task";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(359, 280);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(485, 21);
            this.txtCommand.TabIndex = 9;
            // 
            // txtAction
            // 
            this.txtAction.Location = new System.Drawing.Point(402, 253);
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(100, 21);
            this.txtAction.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 308);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 12;
            // 
            // darkButton2
            // 
            this.darkButton2.Location = new System.Drawing.Point(250, 243);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(75, 45);
            this.darkButton2.TabIndex = 13;
            this.darkButton2.Text = "Enable selected task";
            this.darkButton2.Click += new System.EventHandler(this.darkButton2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(250, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(5);
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Controls.Add(this.radioShutdown);
            this.darkSectionPanel2.Controls.Add(this.radioRestart);
            this.darkSectionPanel2.Controls.Add(this.radioHibernate);
            this.darkSectionPanel2.Controls.Add(this.darkLabel5);
            this.darkSectionPanel2.Location = new System.Drawing.Point(437, 27);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = null;
            this.darkSectionPanel2.Size = new System.Drawing.Size(327, 100);
            this.darkSectionPanel2.TabIndex = 16;
            // 
            // radioShutdown
            // 
            this.radioShutdown.AutoSize = true;
            this.radioShutdown.Location = new System.Drawing.Point(19, 52);
            this.radioShutdown.Name = "radioShutdown";
            this.radioShutdown.Size = new System.Drawing.Size(73, 17);
            this.radioShutdown.TabIndex = 17;
            this.radioShutdown.TabStop = true;
            this.radioShutdown.Text = "Shutdown";
            this.radioShutdown.Click += new System.EventHandler(this.radioShutdown_Click);
            // 
            // radioRestart
            // 
            this.radioRestart.AutoSize = true;
            this.radioRestart.Location = new System.Drawing.Point(127, 52);
            this.radioRestart.Name = "radioRestart";
            this.radioRestart.Size = new System.Drawing.Size(61, 17);
            this.radioRestart.TabIndex = 18;
            this.radioRestart.TabStop = true;
            this.radioRestart.Text = "Restart";
            this.radioRestart.Click += new System.EventHandler(this.radioRestart_Click);
            // 
            // radioHibernate
            // 
            this.radioHibernate.AutoSize = true;
            this.radioHibernate.Location = new System.Drawing.Point(216, 52);
            this.radioHibernate.Name = "radioHibernate";
            this.radioHibernate.Size = new System.Drawing.Size(72, 17);
            this.radioHibernate.TabIndex = 19;
            this.radioHibernate.TabStop = true;
            this.radioHibernate.Text = "Hibernate";
            this.radioHibernate.Click += new System.EventHandler(this.radioHibernate_Click);
            // 
            // darkLabel5
            // 
            this.darkLabel5.AutoSize = true;
            this.darkLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel5.Location = new System.Drawing.Point(4, 7);
            this.darkLabel5.Name = "darkLabel5";
            this.darkLabel5.Size = new System.Drawing.Size(48, 13);
            this.darkLabel5.TabIndex = 0;
            this.darkLabel5.Text = "Process:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmZamanlayici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(332, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.darkButton2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtAction);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.darkSectionPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmZamanlayici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scheduler";
            this.Load += new System.EventHandler(this.frmZamanlayici_Load);
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.darkSectionPanel2.ResumeLayout(false);
            this.darkSectionPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkRadioButton darkRadioButton1;
        private DarkUI.Controls.DarkRadioButton darkRadioButton2;
        private DarkUI.Controls.DarkRadioButton darkRadioButton3;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private System.Windows.Forms.Panel panel1;
        private DarkUI.Controls.DarkButton darkButton1;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkButton btnSet;
        private DarkUI.Controls.DarkButton btnDelete;
        private System.Windows.Forms.DateTimePicker timePicker;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkButton darkButton2;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkButton btnClose;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
        private DarkUI.Controls.DarkLabel darkLabel5;
        private DarkUI.Controls.DarkRadioButton radioShutdown;
        private DarkUI.Controls.DarkRadioButton radioRestart;
        private DarkUI.Controls.DarkRadioButton radioHibernate;
        public System.Windows.Forms.TextBox txtCommand;
        public System.Windows.Forms.TextBox txtAction;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}