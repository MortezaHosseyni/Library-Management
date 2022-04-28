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
    public partial class frmMembers : Form
    {
        ConnectToDB db = new ConnectToDB();
        public frmMembers()
        {
            InitializeComponent();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            read();
        }

        private void btn_AddNewMember_Click(object sender, EventArgs e)
        {
            if (txt_NewMemberNCode.Text.Trim() == "" || txt_NewMemberFirstName.Text.Trim() == "" || txt_NewMemberLastName.Text.Trim() == "" || txt_NewMemberBrithDate.Text.Trim() == "")
            {
                MessageBox.Show("لطفا فیلدهای خالی را بررسی کنید", "فیلد خالی");
                return;
            }
            else
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = db.CreateConnection();
                InsertData(sqlite_conn, txt_NewMemberNCode.Text.Trim(), txt_NewMemberFirstName.Text.Trim(), txt_NewMemberLastName.Text.Trim(), txt_NewMemberBrithDate.Text.Trim());

                read();
                clear();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            readSearch($"MM_NCode LIKE '%{txt_SearchMemberNCode.Text.Trim()}%' AND MM_FirstName LIKE '%{txt_SearchMemberFirstName.Text.Trim()}%' AND MM_LastName LIKE '%{txt_SearchMemberLastName.Text.Trim()}%' AND MM_BrithDate LIKE '%{txt_SearchMemberBrithDate.Text.Trim()}%'");
        }

        private void tsm_DeleteMember_Click(object sender, EventArgs e)
        {
            int memID = Convert.ToInt32(dgv_Members.CurrentRow.Cells["col_MemberID"].Value);
            string memName = dgv_Members.CurrentRow.Cells["col_FirstName"].Value.ToString() + " " + dgv_Members.CurrentRow.Cells["col_LastName"].Value.ToString();

            if (MessageBox.Show($"آیا از حذف {memName} مطمعن هستید؟", "حذف عضو", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = db.CreateConnection();
                DeleteBook(sqlite_conn, memID);
            }
        }









        public void clear()
        {
            txt_NewMemberNCode.Text = "";
            txt_NewMemberFirstName.Text = "";
            txt_NewMemberLastName.Text = "";
            txt_NewMemberBrithDate.Text = "";
        }


        public void read()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = db.CreateConnection();
            ReadData(sqlite_conn, dgv_Members, "1=1");
        }

        public void readSearch(string searchContidion)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = db.CreateConnection();
            ReadData(sqlite_conn, dgv_Members, searchContidion);
        }


        public void ReadData(SQLiteConnection conn, DataGridView VV, string search)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM TB_Members WHERE " + search;
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            VV.Rows.Clear();
            VV.Refresh();

            int rwo = 0;

            while (sqlite_datareader.Read())
            {
                int memID = sqlite_datareader.GetInt32(0);
                string memNCode = sqlite_datareader.GetString(1);
                string memFirstName = sqlite_datareader.GetString(2);
                string memLastName = sqlite_datareader.GetString(3);
                string memBrithDate = sqlite_datareader.GetString(4);

                VV.Rows.Add();
                VV.Rows[rwo].Cells["col_MemberID"].Value = memID.ToString();
                VV.Rows[rwo].Cells["col_NCode"].Value = memNCode;
                VV.Rows[rwo].Cells["col_FirstName"].Value = memFirstName;
                VV.Rows[rwo].Cells["col_LastName"].Value = memLastName;
                VV.Rows[rwo].Cells["col_BrithDate"].Value = memBrithDate;
                
                rwo++;
            }

            conn.Close();
        }

        public void InsertData(SQLiteConnection conn, string memNCode, string memFirstName, string memLastName, string memBrithDate)
        {
            try
            {
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = $"INSERT INTO TB_Members (MM_NCode, MM_FirstName, MM_LastName, MM_BrithDate) VALUES('{memNCode}', '{memFirstName}', '{memLastName}', '{memBrithDate}'); ";
                sqlite_cmd.ExecuteNonQuery();

                MessageBox.Show("عضو جدید با موفقیت ثبت شد", "پایگاه داده");
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("خطایی در ذخیره اطلاعات رخ داد", "پایگاه داده");
                return;
            }
        }

        public void DeleteBook(SQLiteConnection conn, int memberID)
        {
            try
            {
                SQLiteDataReader sqlite_datareader;
                SQLiteCommand sqlite_cmd;

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = $"DELETE FROM TB_Members WHERE MM_ID = {memberID}";
                sqlite_datareader = sqlite_cmd.ExecuteReader();

                read();
            }
            catch (Exception)
            {
                MessageBox.Show("خطایی در خواندن اطلاعات داده رخ داد", "پایگاه داده");
                return;
            }
        }

        
    }
}
