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
    public partial class frmMultiDeleteBook : Form
    {
        ConnectToDB db = new ConnectToDB();
        public frmMultiDeleteBook()
        {
            InitializeComponent();
        }

        private void frmMultiDeleteBook_Load(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف این کتاب‌ها مطمعن هستید؟", "حذف چندتایی", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = db.CreateConnection();
                DeleteBook(sqlite_conn, Convert.ToInt32(txt_DeleteCodeOn.Text.Trim()), Convert.ToInt32(txt_DeleteCodeTo.Text.Trim()));
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        public void DeleteBook(SQLiteConnection conn, int numOne, int numTwo)
        {
            try
            {
                SQLiteDataReader sqlite_datareader;
                SQLiteCommand sqlite_cmd;

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = $"DELETE FROM TB_Books WHERE BK_Code BETWEEN {numOne} AND {numTwo}";
                sqlite_datareader = sqlite_cmd.ExecuteReader();

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطایی در خواندن اطلاعات داده رخ داد", "پایگاه داده");
                return;
            }
        }
    }
}
