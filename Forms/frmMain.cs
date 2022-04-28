using System;
using libraryManagement.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace libraryManagement
{
    public partial class frmMain : Form
    {
        PersianCalendar pCal = new PersianCalendar();
        public string personelName = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsm_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string d = pCal.GetYear(DateTime.Now) + "/" + pCal.GetMonth(DateTime.Now) + "/" + pCal.GetDayOfMonth(DateTime.Now);
            val_TodayDate.Text = string.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(d));

            val_User.Text = personelName;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string t = pCal.GetHour(DateTime.Now) + ":" + pCal.GetMinute(DateTime.Now) + ":" + pCal.GetSecond(DateTime.Now);
            val_Time.Text = string.Format("{0:HH:MM:ss}", Convert.ToDateTime(t));
        }

        private void btn_Library_Click(object sender, EventArgs e)
        {
            frmLibrary fmL = new frmLibrary();
            fmL.ShowDialog();
        }

        private void btn_Members_Click(object sender, EventArgs e)
        {
            frmMembers fmM = new frmMembers();
            fmM.ShowDialog();
        }

        private void btn_Personels_Click(object sender, EventArgs e)
        {
            frmPersonels fmP = new frmPersonels();
            fmP.ShowDialog();
        }

        private void tsm_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برنامه نویس: مرتضی حسینی \nایمیل: Morteza_Hoseyni81@Yahoo.Com", "درباره ما", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
