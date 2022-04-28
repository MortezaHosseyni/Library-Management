using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libraryManagement.DB;
using System.Data.SQLite;

namespace libraryManagement.Forms
{
    public partial class frmLogin : Form
    {
        ConnectToDB db = new ConnectToDB();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text.Trim() == "" || txt_Password.Text.Trim() == "")
            {
                MessageBox.Show("لطفا همه فیلدهای خالی را پر کنید", "فیلد خالی");
                return;
            }

            SQLiteConnection sqlite_conn = db.CreateConnection();
            ReadData(sqlite_conn, txt_Username.Text.Trim(), txt_Password.Text.Trim());
        }

        private void ReadData(SQLiteConnection conn, string userName, string passWord)
        {
            try
            {
                SQLiteDataReader sqlite_datareader;
                SQLiteCommand sqlite_cmd;

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM TB_Personels";
                sqlite_datareader = sqlite_cmd.ExecuteReader();


                while (sqlite_datareader.Read())
                {
                    string uName = sqlite_datareader.GetString(5);
                    string pWord = sqlite_datareader.GetString(6);

                    if (userName == uName && passWord == pWord)
                    {
                        frmMain fm = new frmMain();

                        fm.personelName = sqlite_datareader.GetString(2) + " " + sqlite_datareader.GetString(3);
                        fm.Show();
                        this.Hide();

                        return;
                    }
                }

                MessageBox.Show("پرسنلی با این مشخصات وجود ندارد", "خطا در دریافت اطلاعات");
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("هنگام اتصال به سرور خطايي رخ داد", "پايگاه داده");
                return;
            }
        }
    }
}
