using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace Snore
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        [DllImport("user32")]
        public static extern void LockWorkStation();
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        int saniye = 60;
        int dakika = 0;
        void NotifyIcon()
        {
            this.Hide();
            MyIcon.Visible = true;
            MyIcon.Text = "Snore";
            MyIcon.BalloonTipTitle = "Snore still running.";
           MyIcon.BalloonTipText = "The program is located in the lower right corner.";
            MyIcon.BalloonTipIcon = ToolTipIcon.Info;
            MyIcon.ShowBalloonTip(2000);

            // notifyIcon için event ataması yaptık
            MyIcon.MouseDoubleClick += new MouseEventHandler(notify_Icon_MouseDoubleClick);
        }
        void notify_Icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            MyIcon.Visible = false;
        }
        void IslemYap()
        {     try
            { 
                if (radioShutdown.Checked == true)
                {
                    Process.Start("shutdown", "/s /t 0");
                }
                else
              if (radioRestart.Checked == true)
                {
                    Process.Start("shutdown", "/r /t 0");
                }
                else
              if (radioLogOff.Checked == true)
                {
                    ExitWindowsEx(0, 0);
                }
                else
                    if (radioLock.Checked == true)
                {
                    LockWorkStation();
                }
                else
                    if(radioAlarm.Checked==true)
                {
                    btnStopAlarm.Visible = true;
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"data\alarm.wav");
                    player.Play();
                }
            }
            catch
            {

            }
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            { 
            if(radioShutdown.Checked==false && radioRestart.Checked==false && radioLogOff.Checked==false && radioLock.Checked==false && radioAlarm.Checked==false)
            {
                MessageBox.Show("Please Select the action!", "Snore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            timer1.Start();
            dakika = Convert.ToInt32(txtTime.Text);
            }
            catch
            {

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblCountdownMin.Text = "00";
            lblCountdownSecond.Text = "00";
        }

        private void btnSysTray_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        NotifyIcon MyIcon = new NotifyIcon();

        private void frmMain_Load(object sender, EventArgs e)
        {
            MyIcon.Icon = new Icon(@"data\images\sleep.ico");

        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                NotifyIcon();
        }
 
        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            this.Hide();
            frmAbout.Show();
        }

        private void btnStopAlarm_Click(object sender, EventArgs e)
        {
            player.Stop();
            btnStopAlarm.Visible = false;
        }
    }
}
