namespace libraryManagement.Forms
{
    partial class frmLibrary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_Books = new System.Windows.Forms.DataGridView();
            this.pnl_SearchBook = new System.Windows.Forms.Panel();
            this.txt_SearchBookCode = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_SearchBookName = new System.Windows.Forms.TextBox();
            this.lbl_SearchBookName = new System.Windows.Forms.Label();
            this.lbl_SearchBookCode = new System.Windows.Forms.Label();
            this.lbl_NewBook = new System.Windows.Forms.Label();
            this.pnl_NewBook = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.lbl_NewBookName = new System.Windows.Forms.Label();
            this.lbl_NewBookCode = new System.Windows.Forms.Label();
            this.txt_NewBookName = new System.Windows.Forms.TextBox();
            this.txt_NewBookCode = new System.Windows.Forms.TextBox();
            this.lbl_SearchBook = new System.Windows.Forms.Label();
            this.col_BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BookCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Books)).BeginInit();
            this.pnl_SearchBook.SuspendLayout();
            this.pnl_NewBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Books
            // 
            this.dgv_Books.AllowUserToAddRows = false;
            this.dgv_Books.AllowUserToDeleteRows = false;
            this.dgv_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_BookID,
            this.col_BookName,
            this.col_BookCode});
            this.dgv_Books.Location = new System.Drawing.Point(283, 13);
            this.dgv_Books.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Books.Name = "dgv_Books";
            this.dgv_Books.Size = new System.Drawing.Size(300, 308);
            this.dgv_Books.TabIndex = 0;
            // 
            // pnl_SearchBook
            // 
            this.pnl_SearchBook.Controls.Add(this.txt_SearchBookCode);
            this.pnl_SearchBook.Controls.Add(this.btn_Search);
            this.pnl_SearchBook.Controls.Add(this.txt_SearchBookName);
            this.pnl_SearchBook.Controls.Add(this.lbl_SearchBookName);
            this.pnl_SearchBook.Controls.Add(this.lbl_SearchBookCode);
            this.pnl_SearchBook.Location = new System.Drawing.Point(16, 196);
            this.pnl_SearchBook.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_SearchBook.Name = "pnl_SearchBook";
            this.pnl_SearchBook.Size = new System.Drawing.Size(259, 125);
            this.pnl_SearchBook.TabIndex = 1;
            // 
            // txt_SearchBookCode
            // 
            this.txt_SearchBookCode.Location = new System.Drawing.Point(19, 16);
            this.txt_SearchBookCode.Name = "txt_SearchBookCode";
            this.txt_SearchBookCode.Size = new System.Drawing.Size(182, 23);
            this.txt_SearchBookCode.TabIndex = 5;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(19, 84);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(230, 27);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "جستجو";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_SearchBookName
            // 
            this.txt_SearchBookName.Location = new System.Drawing.Point(19, 45);
            this.txt_SearchBookName.Name = "txt_SearchBookName";
            this.txt_SearchBookName.Size = new System.Drawing.Size(182, 23);
            this.txt_SearchBookName.TabIndex = 6;
            // 
            // lbl_SearchBookName
            // 
            this.lbl_SearchBookName.AutoSize = true;
            this.lbl_SearchBookName.Location = new System.Drawing.Point(207, 48);
            this.lbl_SearchBookName.Name = "lbl_SearchBookName";
            this.lbl_SearchBookName.Size = new System.Drawing.Size(45, 17);
            this.lbl_SearchBookName.TabIndex = 1;
            this.lbl_SearchBookName.Text = "نام کتاب";
            // 
            // lbl_SearchBookCode
            // 
            this.lbl_SearchBookCode.AutoSize = true;
            this.lbl_SearchBookCode.Location = new System.Drawing.Point(207, 19);
            this.lbl_SearchBookCode.Name = "lbl_SearchBookCode";
            this.lbl_SearchBookCode.Size = new System.Drawing.Size(45, 17);
            this.lbl_SearchBookCode.TabIndex = 1;
            this.lbl_SearchBookCode.Text = "کد کتاب";
            // 
            // lbl_NewBook
            // 
            this.lbl_NewBook.AutoSize = true;
            this.lbl_NewBook.ForeColor = System.Drawing.Color.Blue;
            this.lbl_NewBook.Location = new System.Drawing.Point(223, 13);
            this.lbl_NewBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NewBook.Name = "lbl_NewBook";
            this.lbl_NewBook.Size = new System.Drawing.Size(55, 17);
            this.lbl_NewBook.TabIndex = 0;
            this.lbl_NewBook.Text = "کتاب جدید";
            // 
            // pnl_NewBook
            // 
            this.pnl_NewBook.Controls.Add(this.btn_Clear);
            this.pnl_NewBook.Controls.Add(this.btn_AddBook);
            this.pnl_NewBook.Controls.Add(this.lbl_NewBookName);
            this.pnl_NewBook.Controls.Add(this.lbl_NewBookCode);
            this.pnl_NewBook.Controls.Add(this.txt_NewBookName);
            this.pnl_NewBook.Controls.Add(this.txt_NewBookCode);
            this.pnl_NewBook.Location = new System.Drawing.Point(16, 34);
            this.pnl_NewBook.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_NewBook.Name = "pnl_NewBook";
            this.pnl_NewBook.Size = new System.Drawing.Size(259, 138);
            this.pnl_NewBook.TabIndex = 1;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(19, 90);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(116, 34);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "انصراف";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.Location = new System.Drawing.Point(141, 90);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(108, 34);
            this.btn_AddBook.TabIndex = 3;
            this.btn_AddBook.Text = "افزودن";
            this.btn_AddBook.UseVisualStyleBackColor = true;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // lbl_NewBookName
            // 
            this.lbl_NewBookName.AutoSize = true;
            this.lbl_NewBookName.Location = new System.Drawing.Point(207, 55);
            this.lbl_NewBookName.Name = "lbl_NewBookName";
            this.lbl_NewBookName.Size = new System.Drawing.Size(45, 17);
            this.lbl_NewBookName.TabIndex = 1;
            this.lbl_NewBookName.Text = "نام کتاب";
            // 
            // lbl_NewBookCode
            // 
            this.lbl_NewBookCode.AutoSize = true;
            this.lbl_NewBookCode.Location = new System.Drawing.Point(207, 26);
            this.lbl_NewBookCode.Name = "lbl_NewBookCode";
            this.lbl_NewBookCode.Size = new System.Drawing.Size(45, 17);
            this.lbl_NewBookCode.TabIndex = 1;
            this.lbl_NewBookCode.Text = "کد کتاب";
            // 
            // txt_NewBookName
            // 
            this.txt_NewBookName.Location = new System.Drawing.Point(19, 52);
            this.txt_NewBookName.Name = "txt_NewBookName";
            this.txt_NewBookName.Size = new System.Drawing.Size(182, 23);
            this.txt_NewBookName.TabIndex = 2;
            // 
            // txt_NewBookCode
            // 
            this.txt_NewBookCode.Location = new System.Drawing.Point(19, 23);
            this.txt_NewBookCode.Name = "txt_NewBookCode";
            this.txt_NewBookCode.Size = new System.Drawing.Size(182, 23);
            this.txt_NewBookCode.TabIndex = 1;
            // 
            // lbl_SearchBook
            // 
            this.lbl_SearchBook.AutoSize = true;
            this.lbl_SearchBook.ForeColor = System.Drawing.Color.Blue;
            this.lbl_SearchBook.Location = new System.Drawing.Point(237, 175);
            this.lbl_SearchBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SearchBook.Name = "lbl_SearchBook";
            this.lbl_SearchBook.Size = new System.Drawing.Size(41, 17);
            this.lbl_SearchBook.TabIndex = 0;
            this.lbl_SearchBook.Text = "جستجو";
            // 
            // col_BookID
            // 
            this.col_BookID.HeaderText = "BookID";
            this.col_BookID.Name = "col_BookID";
            this.col_BookID.Visible = false;
            // 
            // col_BookName
            // 
            this.col_BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_BookName.HeaderText = "نام کتاب";
            this.col_BookName.Name = "col_BookName";
            // 
            // col_BookCode
            // 
            this.col_BookCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_BookCode.HeaderText = "کد کتاب";
            this.col_BookCode.Name = "col_BookCode";
            // 
            // frmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 334);
            this.Controls.Add(this.lbl_SearchBook);
            this.Controls.Add(this.lbl_NewBook);
            this.Controls.Add(this.pnl_NewBook);
            this.Controls.Add(this.pnl_SearchBook);
            this.Controls.Add(this.dgv_Books);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(612, 373);
            this.MinimumSize = new System.Drawing.Size(612, 373);
            this.Name = "frmLibrary";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کتابخانه";
            this.Load += new System.EventHandler(this.frmLibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Books)).EndInit();
            this.pnl_SearchBook.ResumeLayout(false);
            this.pnl_SearchBook.PerformLayout();
            this.pnl_NewBook.ResumeLayout(false);
            this.pnl_NewBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Books;
        private System.Windows.Forms.Panel pnl_SearchBook;
        private System.Windows.Forms.Label lbl_NewBook;
        private System.Windows.Forms.Panel pnl_NewBook;
        private System.Windows.Forms.Label lbl_SearchBook;
        private System.Windows.Forms.Label lbl_NewBookName;
        private System.Windows.Forms.Label lbl_NewBookCode;
        private System.Windows.Forms.TextBox txt_NewBookName;
        private System.Windows.Forms.TextBox txt_NewBookCode;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.TextBox txt_SearchBookCode;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_SearchBookName;
        private System.Windows.Forms.Label lbl_SearchBookName;
        private System.Windows.Forms.Label lbl_SearchBookCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BookCode;
    }
}