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
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.btnSet = new DarkUI.Controls.DarkButton();
            this.btnDelete = new DarkUI.Controls.DarkButton();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.btnClose = new DarkUI.Controls.DarkButton();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.darkSectionPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.darkSectionPanel1.Location = new System.Drawing.Point(13, 36);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = null;
            this.darkSectionPanel1.Size = new System.Drawing.Size(327, 123);
            this.darkSectionPanel1.TabIndex = 4;
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
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(325, 0);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(24, 24);
            this.darkButton1.TabIndex = 0;
            this.darkButton1.Text = "X";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(265, 165);
            this.btnSet.Name = "btnSet";
            this.btnSet.Padding = new System.Windows.Forms.Padding(5);
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 6;
            this.btnSet.Text = "Save";
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(265, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5);
            this.btnDelete.Size = new System.Drawing.Size(75, 45);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Disable selected task";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(402, 280);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(100, 21);
            this.txtCommand.TabIndex = 9;
            this.txtCommand.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // txtAction
            // 
            this.txtAction.Location = new System.Drawing.Point(402, 253);
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(100, 21);
            this.txtAction.TabIndex = 11;
            this.txtAction.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 308);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 12;
            this.textBox1.Visible = false;
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
            // darkButton2
            // 
            this.darkButton2.Location = new System.Drawing.Point(265, 245);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(75, 45);
            this.darkButton2.TabIndex = 13;
            this.darkButton2.Text = "Enable selected task";
            this.darkButton2.Click += new System.EventHandler(this.darkButton2_Click);
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(265, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(5);
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.darkLabel4.Location = new System.Drawing.Point(17, 360);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(231, 13);
            this.darkLabel4.TabIndex = 15;
            this.darkLabel4.Text = "NOTICE: Only \"Shutdown\" feature is available.";
            // 
            // frmZamanlayici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(347, 395);
            this.Controls.Add(this.darkLabel4);
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
        private System.Windows.Forms.TextBox txtCommand;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.TextBox textBox1;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkButton darkButton2;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkButton btnClose;
        private DarkUI.Controls.DarkLabel darkLabel4;
    }
}