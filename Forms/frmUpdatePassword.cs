using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using libraryManagement.DB;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagement.Forms
{
    public partial class frmUpdatePassword : Form
    {
        ConnectToDB db = new ConnectToDB();

        public int perID;
        public string perName = "";
        public frmUpdatePassword()
        {
            InitializeComponent();
        }

        private void frmUpdatePassword_Load(object sender, EventArgs e)
        {
            lbl_Title.Text = $"بروزرسانی گذرواژه کاربر {perName}";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            if (txt_OldPassword.Text.Trim() == "" || txt_NewPassword.Text.Trim() == "" || txt_ConfirmNewPassword.Text.Trim() == "")
            {
                MessageBox.Show("لطفا فیلدهای خالی را بررسی کنید", "فیلد خالی");
                return;
            }
            if (txt_NewPassword.Text.Trim() != txt_ConfirmNewPassword.Text.Trim())
            {
                MessageBox.Show("تکرار گذرواژه با گذرواژه جدید همخوانی ندارد", "تکرار گذرواژه");
                return;
            }
            else
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = db.CreateConnection();
                UpdatePassword(sqlite_conn, txt_NewPassword.Text.Trim(), txt_OldPassword.Text.Trim());
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }










        

        public void UpdatePassword(SQLiteConnection conn, string newPass, string oldPass)
        {
            try
            {
                SQLiteDataReader sqlite_checkOld;
                SQLiteCommand sqlite_cmdCheckOld;
                sqlite_cmdCheckOld = conn.CreateCommand();
                sqlite_cmdCheckOld.CommandText = $"SELECT * FROM TB_Personels WHERE PR_ID = {perID}";
                sqlite_checkOld = sqlite_cmdCheckOld.ExecuteReader();

                while (sqlite_checkOld.Read())
                {
                    string dbOldPass = sqlite_checkOld.GetString(6);
                    if (dbOldPass == oldPass)
                    {
                        SQLiteDataReader sqlite_datareader;
                        SQLiteCommand sqlite_cmd;
                        sqlite_cmd = conn.CreateCommand();
                        sqlite_cmd.CommandText = $"UPDATE TB_Personels SET PR_Password = '{newPass}' WHERE PR_ID = {perID}";
                        sqlite_datareader = sqlite_cmd.ExecuteReader();

                        MessageBox.Show($"گذرواژه {perName} با موفقیت بروزرسانی شد", "پایگاه داده");
                        conn.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("گذرواژه واژه قبلی همخوانی ندارد", "بروزرسانی گذرواژه");
                        return;
                    }
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطایی در ذخیره اطلاعات رخ داد", "پایگاه داده");
                return;
            }
        }
    }
}
