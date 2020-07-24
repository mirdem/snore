using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snore
{
    public partial class frmRemote : Form
    {
        public frmRemote()
        {
            InitializeComponent();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        int saniye = 60;
        int dakika = 0;
        void IslemYap()
        {
            try
            {
                if (radioShutdown.Checked == true)
                {
                    System.Diagnostics.Process.Start("shutdown", @"-m \\192.168.1.21 -s -f -t 0");
                }
                else
              if (radioRestart.Checked == true)
                {
                    System.Diagnostics.Process.Start("shutdown", @"-m \\"+txtRemoteIP.Text+"-r -t 0");
                //    Process.Start("shutdown", "/r /t 0");
                }
                else
              if (radioLogOff.Checked == true)
                {
                //    ExitWindowsEx(0, 0);
                }
                else
                    if (radioLock.Checked == true)
                {
                   // LockWorkStation();
                }
               
            }
            catch
            {

            }
        }
        void IslemYapNoTimer()
        {

        }
        private void frmRemote_Load(object sender, EventArgs e)
        {
          
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            try
            {
                if (radioShutdown.Checked == false && radioRestart.Checked == false && radioLogOff.Checked == false && radioLock.Checked == false)
                {
                    MessageBox.Show("Please Select the action!", "Snore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    btnSet.Enabled = false;
                timer1.Start();
                dakika = Convert.ToInt32(txtTime.Text);
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            saniye = saniye - 1;
            lblCountdownSecond.Text = Convert.ToString(saniye);
            lblCountdownMin.Text = Convert.ToString(dakika - 1);
            if (saniye == 0)
            {

                dakika = dakika - 1;
                lblCountdownMin.Text = Convert.ToString(dakika);
                saniye = 60;
            }

            if (lblCountdownMin.Text == "-1")
            {
                timer1.Stop();
                lblCountdownMin.Text = "00";
                lblCountdownSecond.Text = "00";
                if (lblCountdownMin.Text == "00" && lblCountdownSecond.Text == "00")
                {
                    IslemYap();
                }
            }
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Stop();
            lblCountdownMin.Text = "00";
            lblCountdownSecond.Text = "00";
            btnCancel.Enabled = false;
            btnSet.Enabled = true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Do you want this Transaction to be applied immediately?", "Snore", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                IslemYapNoTimer();
            }
            else
            {
                MessageBox.Show("Process cancelled.","Snore",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Fill it like this: 192.168.1.100", "Snore", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
