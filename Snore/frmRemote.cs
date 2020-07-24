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
    }
}
