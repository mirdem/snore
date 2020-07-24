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
using Microsoft.Win32;

namespace Snore
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        [DllImport("Powrprof.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        string ProgramAdi = "Snore";

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
        void checkStarts()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                if (key.GetValue(ProgramAdi).ToString() == "\"" + Application.ExecutablePath + "\"")
                { 
                    chkWinStarts.Checked = true;
                }
            }
            catch
            {

            }
        }
        void BataryaIslemYap()
        {
            darkButton1.Enabled = true;

            try
            {
                if (radioShutdown2.Checked == true)
                {
                    Process.Start("shutdown", "/s /t 0");
                }
                else
              if (radioHibernate.Checked == true)
                {
                    SetSuspendState(true, true, true);
                }
                else
              if (radioStandby.Checked == true)
                {
                    SetSuspendState(false, true, true);
                }
                else
                    if (radioJustAlarm2.Checked == true)
                {
                    btnStopAlarm2.Visible = true;
                    radioJustAlarm2.Visible = true;
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"data\alarm.wav");
                    player.Play();
                }
            }
            catch
            {

            }
            timerBattery.Enabled = false;
        }

        void IslemYap()
        {
            btnStart.Enabled = true;

            try
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
            timerBattery.Enabled = false;
            try
            {
                if (radioShutdown.Checked == false && radioRestart.Checked == false && radioLogOff.Checked == false && radioLock.Checked == false && radioAlarm.Checked == false)
                {
                    MessageBox.Show("Please Select the action!", "Snore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    btnStart.Enabled = false;
            timer1.Start();
            dakika = Convert.ToInt32(txtTime.Text);
            }
            catch
            {

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            timer1.Stop();
            lblCountdownMin.Text = "00";
            lblCountdownSecond.Text = "00";
        }

        private void btnSysTray_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

            if (FormWindowState.Minimized == WindowState)
                NotifyIcon();

        }

        NotifyIcon MyIcon = new NotifyIcon();

        private void frmMain_Load(object sender, EventArgs e)
        {
            checkStarts();
            MyIcon.Icon = new Icon(Application.StartupPath+@"\data\images\sleep.ico");
            metroTabControl1.SelectedIndex = 0;
            lblVersion.Text = "Version " + this.ProductVersion;
           
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
        }
 
        private void btnAbout_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStopAlarm_Click(object sender, EventArgs e)
        {
            player.Stop();
            btnStopAlarm.Visible = false;
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblBatteryLevel_Click(object sender, EventArgs e)
        {
    
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            timerBattery.Enabled = true;
            
        }

        private void darkButton2_Click(object sender, EventArgs e)
        {
            timerBattery.Enabled = false;

        }

        private void timerBattery_Tick(object sender, EventArgs e)
        {
            timerBattery.Interval = 500;

             if(darkNumericUpDown1.DecimalPlaces < Int32.Parse(lblBatteryLevel.Text))
            {
                BataryaIslemYap();
            }
            else
            {
                MessageBox.Show("Hata");
            }
                   
        }

        private void btnStopAlarm2_Click(object sender, EventArgs e)
        {
            player.Stop();
            timerBattery.Enabled = false;
            btnStopAlarm2.Visible = false;
        }

        private void CheckBattery_Tick(object sender, EventArgs e)
        {
            PowerStatus status = SystemInformation.PowerStatus;
            textBox1.Text = status.BatteryLifePercent.ToString("P0");

            string yazi = textBox1.Text;

            string KalanYazi = yazi.Remove(0, 1);

            textBox1.Text = KalanYazi.ToString();

            lblBatteryLevel.Text = textBox1.Text;
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mirdem.wordpress.com/applications/snore/");
        }

        private void btnLinkedIn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/muhammed-irdem-2b5218107/");

        }

        private void chkWinStarts_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWinStarts.Checked)
            { //işaretlendi ise Regedit e açılışta çalıştır olarak ekle
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue(ProgramAdi, "\"" + Application.ExecutablePath + "\"");
                txtWinStarts.Text = "True";
            }
            else
            {  //işaret kaldırıldı ise Regeditten açılışta çalıştırılacaklardan kaldır
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue(ProgramAdi);
                txtWinStarts.Text = "False";
            }
        }

        private void btnRemote_Click(object sender, EventArgs e)
        {
            btnStop.PerformClick();
            this.Hide();
            frmRemote frmRemote = new frmRemote();
            frmRemote.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            btnStop.PerformClick();
            this.Hide();
            frmZamanlayici frmZamanlayici = new frmZamanlayici();
            frmZamanlayici.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved.", "Snore", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
