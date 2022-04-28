using System;
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
            val_TodayDate.Text = pCal.GetYear(DateTime.Now) + "/" + pCal.GetMonth(DateTime.Now) + "/" + pCal.GetDayOfMonth(DateTime.Now);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            val_Time.Text = pCal.GetHour(DateTime.Now) + ":" + pCal.GetMinute(DateTime.Now) + ":" + pCal.GetSecond(DateTime.Now);
        }
    }
}
