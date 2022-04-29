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
    public partial class frmPersonels : Form
    {
        ConnectToDB db = new ConnectToDB();
        public frmPersonels()
        {
            InitializeComponent();
        }

        private void frmPersonels_Load(object sender, EventArgs e)
        {
            read();
        }

        private void btn_AddNewPersonel_Click(object sender, EventArgs e)
        {
            if (txt_NewPersonelNCode.Text.Trim() == "" || txt_NewPersonelFirstName.Text.Trim() == "" || txt_NewPersonelLastName.Text.Trim() == "" || txt_NewPersonelBrithDate.Text.Trim() == "" || txt_NewPersonelUserName.Text.Trim() == "" || txt_NewPersonelPassword.Text.Trim() == "")
            {
                MessageBox.Show("لطفا فیلدهای خالی را بررسی کنید", "فیلد خالی");
                return;
            }
            else
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = db.CreateConnection();
                InsertData(sqlite_conn, txt_NewPersonelNCode.Text.Trim(), txt_NewPersonelFirstName.Text.Trim(), txt_NewPersonelLastName.Text.Trim(), txt_NewPersonelBrithDate.Text.Trim(), txt_NewPersonelUserName.Text.Trim(), txt_NewPersonelPassword.Text.Trim());

                read();
                clear();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            readSearch($"PR_NCode LIKE '%{txt_SearchPersonelNCode.Text.Trim()}%' AND PR_FirstName LIKE '%{txt_SearchPersonelFirstName.Text.Trim()}%' AND PR_LastName LIKE '%{txt_SearchPersonelLastName.Text.Trim()}%' AND PR_BrithDate LIKE '%{txt_SearchPersonelBrithDate.Text.Trim()}%' AND PR_Username LIKE '%{txt_SearchPersonelUsername.Text.Trim()}%'");
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void tsm_DeletePersonel_Click(object sender, EventArgs e)
        {
            int memID = Convert.ToInt32(dgv_Personels.CurrentRow.Cells["col_PersonelID"].Value);
            string memName = dgv_Personels.CurrentRow.Cells["col_FirstName"].Value.ToString() + " " + dgv_Personels.CurrentRow.Cells["col_LastName"].Value.ToString();

            if (MessageBox.Show($"آیا از حذف {memName} مطمعن هستید؟", "حذف عضو", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = db.CreateConnection();
                DeletePersonel(sqlite_conn, memID);
            }
        }

        private void tsm_UpdatePassword_Click(object sender, EventArgs e)
        {
            int memID = Convert.ToInt32(dgv_Personels.CurrentRow.Cells["col_PersonelID"].Value);
            string memName = dgv_Personels.CurrentRow.Cells["col_FirstName"].Value.ToString() + " " + dgv_Personels.CurrentRow.Cells["col_LastName"].Value.ToString();
            
            frmUpdatePassword fmUP = new frmUpdatePassword();
            fmUP.perID = memID;
            fmUP.perName = memName;
            fmUP.Show();
        }














        public void clear()
        {
            txt_NewPersonelNCode.Text     = "";
            txt_NewPersonelFirstName.Text = "";
            txt_NewPersonelLastName.Text  = "";
            txt_NewPersonelBrithDate.Text = "";
            txt_NewPersonelUserName.Text  = "";
            txt_NewPersonelPassword.Text  = "";
        }


        public void read()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = db.CreateConnection();
            ReadData(sqlite_conn, dgv_Personels, "1=1");
        }

        public void readSearch(string searchContidion)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = db.CreateConnection();
            ReadData(sqlite_conn, dgv_Personels, searchContidion);
        }


        public void ReadData(SQLiteConnection conn, DataGridView VV, string search)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM TB_Personels WHERE " + search;
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            VV.Rows.Clear();
            VV.Refresh();

            int rwo = 0;

            while (sqlite_datareader.Read())
            {
                int perID = sqlite_datareader.GetInt32(0);
                string perNCode = sqlite_datareader.GetString(1);
                string perFirstName = sqlite_datareader.GetString(2);
                string perLastName = sqlite_datareader.GetString(3);
                string perBrithDate = sqlite_datareader.GetString(4);
                string perUsername = sqlite_datareader.GetString(5);

                VV.Rows.Add();
                VV.Rows[rwo].Cells["col_PersonelID"].Value = perID.ToString();
                VV.Rows[rwo].Cells["col_NCode"].Value = perNCode;
                VV.Rows[rwo].Cells["col_FirstName"].Value = perFirstName;
                VV.Rows[rwo].Cells["col_LastName"].Value = perLastName;
                VV.Rows[rwo].Cells["col_BrithDate"].Value = perBrithDate;
                VV.Rows[rwo].Cells["col_Username"].Value = perUsername;

                rwo++;
            }

            conn.Close();
        }

        public void InsertData(SQLiteConnection conn, string perNCode, string perFirstName, string perLastName, string perBrithDate, string perUsername, string perPassword)
        {
            try
            {
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = $"INSERT INTO TB_Personels (PR_NCode, PR_FirstName, PR_LastName, PR_BrithDate, PR_Username, PR_Password) VALUES('{perNCode}', '{perFirstName}', '{perLastName}', '{perBrithDate}', '{perUsername}', {perPassword}); ";
                sqlite_cmd.ExecuteNonQuery();

                MessageBox.Show("پرسنل جدید با موفقیت ثبت شد", "پایگاه داده");
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("خطایی در ذخیره اطلاعات رخ داد", "پایگاه داده");
                return;
            }
        }

        public void DeletePersonel(SQLiteConnection conn, int personelID)
        {
            try
            {
                SQLiteDataReader sqlite_datareader;
                SQLiteCommand sqlite_cmd;

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = $"DELETE FROM TB_Personels WHERE PR_ID = {personelID}";
                sqlite_datareader = sqlite_cmd.ExecuteReader();

                read();
            }
            catch (Exception)
            {
                MessageBox.Show("خطایی در خواندن اطلاعات داده رخ داد", "پایگاه داده");
                return;
            }
            conn.Close();
        }
    }
}
