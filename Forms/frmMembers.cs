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

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

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

        public void InsertData(SQLiteConnection conn, string bookName, string bookCode)
        {
            try
            {
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = $"INSERT INTO TB_Books (BK_Name, BK_Code) VALUES('{bookName}', '{bookCode}'); ";
                sqlite_cmd.ExecuteNonQuery();

                MessageBox.Show("کتاب ذخیره شد", "پایگاه داده");
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("خطایی در ذخیره اطلاعات رخ داد", "پایگاه داده");
                return;
            }
        }

        public void DeleteBook(SQLiteConnection conn, int bookID)
        {
            try
            {
                SQLiteDataReader sqlite_datareader;
                SQLiteCommand sqlite_cmd;

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = $"DELETE FROM TB_Books WHERE BK_ID = {bookID}";
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
