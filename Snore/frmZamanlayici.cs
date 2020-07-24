using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.IO;
namespace Snore
{
    public partial class frmZamanlayici : Form
    {
     
        Process process = new Process();
        ProcessStartInfo startInfo = new ProcessStartInfo();
        public frmZamanlayici()
        {
            InitializeComponent();
   
        }
       

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void HourlyEnable()
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;

            cmd.Start();

            cmd.StandardInput.WriteLine("SCHTASKS /CHANGE /TN \"Snore Hourly\\Snore Task\" /ENABLE");

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

        }

        void DailyEnable()
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;

            cmd.Start();

            cmd.StandardInput.WriteLine("SCHTASKS /CHANGE /TN \"Snore Daily\\Snore Task\" /ENABLE");

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

        }
        void WeeklyEnable()
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;

            cmd.Start();

            cmd.StandardInput.WriteLine("SCHTASKS /CHANGE /TN \"Snore Weekly\\Snore Task\" /ENABLE");

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

        }

        void HourlyDisable()
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
          
            cmd.Start();

           cmd.StandardInput.WriteLine("SCHTASKS /CHANGE /TN \"Snore Hourly\\Snore Task\" /DISABLE");
          
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            
        }

        void DailyDisable()
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;

            cmd.Start();

            cmd.StandardInput.WriteLine("SCHTASKS /CHANGE /TN \"Snore Daily\\Snore Task\" /DISABLE");

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

        }
        void WeeklyDisable()
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;

            cmd.Start();

            cmd.StandardInput.WriteLine("SCHTASKS /CHANGE /TN \"Snore Weekly\\Snore Task\" /DISABLE");

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

        }
        void HourlyEtkinlikKaydet()
        {
            if(txtAction.Text=="Hourly")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine(txtCommand.Text);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
            }
        }

        void DailyEtkinlikKaydet()
        {
            if (txtAction.Text == "Daily")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine(txtCommand.Text);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
            }
        }

        void WeeklyEtkinlikKaydet()
        {
            if (txtAction.Text == "Weekly")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine(txtCommand.Text);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
           
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmZamanlayici_Load(object sender, EventArgs e)
        {
           
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if(darkRadioButton1.Checked==false && darkRadioButton2.Checked==false && darkRadioButton3.Checked==false)
            {
                MessageBox.Show("Please Select the action!", "Snore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(darkRadioButton1.Checked==true)
            {
                DailyEtkinlikKaydet();
            }
            else
                if(darkRadioButton2.Checked==true)
            {
                HourlyEtkinlikKaydet();
            }
            else
                if(darkRadioButton3.Checked==true)
            {
                WeeklyEtkinlikKaydet();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void darkRadioButton2_Click(object sender, EventArgs e)
        {
            txtAction.Text = "Hourly";
            txtCommand.Text= "SCHTASKS /CREATE /SC HOURLY /TN \"Snore Hourly\\Snore Task\" /TR \"shutdown -L\" /ST " + timePicker.Value.ToShortTimeString();

        }

        private void darkRadioButton1_Click(object sender, EventArgs e)
        {
            txtAction.Text = "Daily";
            txtCommand.Text = "SCHTASKS /CREATE /SC DAILY /TN \"Snore Daily\\Snore Task\" /TR \"shutdown -L\" /ST " + timePicker.Value.ToShortTimeString();

        }

        private void darkRadioButton3_Click(object sender, EventArgs e)
        {
            txtAction.Text = "Weekly";
            txtCommand.Text = "SCHTASKS /CREATE /SC WEEKLY /TN \"Snore Weekly\\Snore Task\" /TR \"shutdown -L\" /ST " + timePicker.Value.ToShortTimeString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (darkRadioButton1.Checked == true)
            {
                DailyDisable();
            }
            else
                if (darkRadioButton2.Checked == true)
            {
                HourlyDisable();
            }
            else
                if (darkRadioButton3.Checked == true)
            {
                WeeklyDisable();
            }
        }

        private void darkButton2_Click(object sender, EventArgs e)
        {
            if (darkRadioButton1.Checked == true)
            {
                DailyEnable();
            }
            else
                if (darkRadioButton2.Checked == true)
            {
                HourlyEnable();
            }
            else
                if (darkRadioButton3.Checked == true)
            {
                WeeklyEnable();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }
    }
}
