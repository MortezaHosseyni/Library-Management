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
    public partial class frmLibrary : Form
    {
        ConnectToDB db = new ConnectToDB();
        public frmLibrary()
        {
            InitializeComponent();
        }

        private void frmLibrary_Load(object sender, EventArgs e)
        {
            read();
        }

        public void read()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = db.CreateConnection();
            ReadData(sqlite_conn, dgv_Books, "1=1");
        }

        public void readSearch(string searchContidion)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = db.CreateConnection();
            ReadData(sqlite_conn, dgv_Books, searchContidion);
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
        

        public void ReadData(SQLiteConnection conn, DataGridView VV, string search)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM TB_Books WHERE " + search;
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            VV.Rows.Clear();
            VV.Refresh();

            int rwo = 0;

            while (sqlite_datareader.Read())
            {
                int bookID = sqlite_datareader.GetInt32(0);
                string bookName = sqlite_datareader.GetString(1);
                string bookCode = sqlite_datareader.GetString(2);

                VV.Rows.Add();
                VV.Rows[rwo].Cells["col_BookID"].Value = bookID.ToString();
                VV.Rows[rwo].Cells["col_BookName"].Value = bookName;
                VV.Rows[rwo].Cells["col_BookCode"].Value = bookCode;

                rwo++;
            }

            conn.Close();
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            if(txt_NewBookName.Text.Trim() == "" || txt_NewBookCode.Text.Trim() == "")
            {
                MessageBox.Show("لطفا فیلدهای خالی را بررسی کنید", "فیلد خالی");
                return;
            }
            else
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = db.CreateConnection();
                InsertData(sqlite_conn, txt_NewBookName.Text.Trim(), txt_NewBookCode.Text.Trim());

                read();
                clear();
            }
        }

        public void clear()
        {
            txt_NewBookCode.Text = "";
            txt_NewBookName.Text = "";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_SearchBookName.Text.Trim() != null && txt_SearchBookCode.Text.Trim() != null)
            {
                readSearch($"BK_Name LIKE '%{txt_SearchBookName.Text.Trim()}%' AND BK_Code LIKE '%{txt_SearchBookCode.Text.Trim()}%'");
                return;
            }
            else if (txt_SearchBookName.Text.Trim() != null)
            {
                readSearch($"BK_Name LIKE '%{txt_SearchBookName.Text.Trim()}%'");
                return;
            }
            else if (txt_SearchBookCode.Text.Trim() != null)
            {
                readSearch($"BK_Code LIKE '%{txt_SearchBookCode.Text.Trim()}%'");
                return;
            }
            else
            {
                MessageBox.Show("لطفا یکی از فیلدهارا پر کنید", "فیلد خالی");
                return;
            }
        }

        private void tsm_DeleteBook_Click(object sender, EventArgs e)
        {
            int bkID = Convert.ToInt32(dgv_Books.CurrentRow.Cells["col_BookID"].Value);
            string bkName = dgv_Books.CurrentRow.Cells["col_BookName"].Value.ToString();

            if (MessageBox.Show($"آیا از حذف کتاب {bkName} مطمعن هستید؟", "حدف کتاب", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = db.CreateConnection();
                DeleteBook(sqlite_conn, bkID);
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

        private void tsm_MultiDelete_Click(object sender, EventArgs e)
        {
            frmMultiDeleteBook fmMDB = new frmMultiDeleteBook();
            fmMDB.ShowDialog();
            read();
        }
    }
}
