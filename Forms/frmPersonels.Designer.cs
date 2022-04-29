namespace libraryManagement.Forms
{
    partial class frmPersonels
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonels));
            this.dgv_Personels = new System.Windows.Forms.DataGridView();
            this.col_PersonelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BrithDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_DeletePersonel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_UpdatePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_NewPersonel = new System.Windows.Forms.Panel();
            this.txt_NewPersonelBrithDate = new BPersianCalender.BPersianCalenderTextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_AddNewPersonel = new System.Windows.Forms.Button();
            this.txt_NewPersonelPassword = new System.Windows.Forms.TextBox();
            this.txt_NewPersonelUserName = new System.Windows.Forms.TextBox();
            this.txt_NewPersonelLastName = new System.Windows.Forms.TextBox();
            this.txt_NewPersonelFirstName = new System.Windows.Forms.TextBox();
            this.txt_NewPersonelNCode = new System.Windows.Forms.TextBox();
            this.lbl_NewPersonelPassword = new System.Windows.Forms.Label();
            this.lbl_NewPersonelUsername = new System.Windows.Forms.Label();
            this.lbl_NewPersonelBrithDate = new System.Windows.Forms.Label();
            this.lbl_NewPersonelLastName = new System.Windows.Forms.Label();
            this.lbl_NewPersonelFirstName = new System.Windows.Forms.Label();
            this.lbl_NewPersonelNCode = new System.Windows.Forms.Label();
            this.pnl_SearchPersonel = new System.Windows.Forms.Panel();
            this.txt_SearchPersonelBrithDate = new BPersianCalender.BPersianCalenderTextBox();
            this.txt_SearchPersonelNCode = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_SearchPersonelNCode = new System.Windows.Forms.Label();
            this.lbl_SearchPersonelFirstName = new System.Windows.Forms.Label();
            this.txt_SearchPersonelUsername = new System.Windows.Forms.TextBox();
            this.lbl_SearchPersonelLastName = new System.Windows.Forms.Label();
            this.lbl_SearchPersonelBrithDate = new System.Windows.Forms.Label();
            this.txt_SearchPersonelLastName = new System.Windows.Forms.TextBox();
            this.lbl_SearchPersonelUsername = new System.Windows.Forms.Label();
            this.txt_SearchPersonelFirstName = new System.Windows.Forms.TextBox();
            this.lbl_NewPersonel = new System.Windows.Forms.Label();
            this.lbl_SearchPersonel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Personels)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.pnl_NewPersonel.SuspendLayout();
            this.pnl_SearchPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Personels
            // 
            this.dgv_Personels.AllowUserToAddRows = false;
            this.dgv_Personels.AllowUserToDeleteRows = false;
            this.dgv_Personels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Personels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_PersonelID,
            this.col_NCode,
            this.col_FirstName,
            this.col_LastName,
            this.col_BrithDate,
            this.col_Username});
            this.dgv_Personels.ContextMenuStrip = this.contextMenuStrip;
            this.dgv_Personels.Location = new System.Drawing.Point(12, 12);
            this.dgv_Personels.Name = "dgv_Personels";
            this.dgv_Personels.Size = new System.Drawing.Size(781, 258);
            this.dgv_Personels.TabIndex = 0;
            // 
            // col_PersonelID
            // 
            this.col_PersonelID.HeaderText = "PersonelID";
            this.col_PersonelID.Name = "col_PersonelID";
            this.col_PersonelID.Visible = false;
            // 
            // col_NCode
            // 
            this.col_NCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_NCode.HeaderText = "کدملی";
            this.col_NCode.Name = "col_NCode";
            // 
            // col_FirstName
            // 
            this.col_FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_FirstName.HeaderText = "نام";
            this.col_FirstName.Name = "col_FirstName";
            // 
            // col_LastName
            // 
            this.col_LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_LastName.HeaderText = "نام خانوادگی";
            this.col_LastName.Name = "col_LastName";
            // 
            // col_BrithDate
            // 
            this.col_BrithDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_BrithDate.HeaderText = "تاریخ تولد";
            this.col_BrithDate.Name = "col_BrithDate";
            // 
            // col_Username
            // 
            this.col_Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Username.HeaderText = "نام کاربری";
            this.col_Username.Name = "col_Username";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_DeletePersonel,
            this.tsm_UpdatePassword});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip.Size = new System.Drawing.Size(162, 48);
            // 
            // tsm_DeletePersonel
            // 
            this.tsm_DeletePersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tsm_DeletePersonel.Name = "tsm_DeletePersonel";
            this.tsm_DeletePersonel.Size = new System.Drawing.Size(161, 22);
            this.tsm_DeletePersonel.Text = "حذف پرسنل";
            this.tsm_DeletePersonel.Click += new System.EventHandler(this.tsm_DeletePersonel_Click);
            // 
            // tsm_UpdatePassword
            // 
            this.tsm_UpdatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsm_UpdatePassword.Name = "tsm_UpdatePassword";
            this.tsm_UpdatePassword.Size = new System.Drawing.Size(161, 22);
            this.tsm_UpdatePassword.Text = "بروزرسانی گذرواژه";
            this.tsm_UpdatePassword.Click += new System.EventHandler(this.tsm_UpdatePassword_Click);
            // 
            // pnl_NewPersonel
            // 
            this.pnl_NewPersonel.Controls.Add(this.txt_NewPersonelBrithDate);
            this.pnl_NewPersonel.Controls.Add(this.btn_Clear);
            this.pnl_NewPersonel.Controls.Add(this.btn_AddNewPersonel);
            this.pnl_NewPersonel.Controls.Add(this.txt_NewPersonelPassword);
            this.pnl_NewPersonel.Controls.Add(this.txt_NewPersonelUserName);
            this.pnl_NewPersonel.Controls.Add(this.txt_NewPersonelLastName);
            this.pnl_NewPersonel.Controls.Add(this.txt_NewPersonelFirstName);
            this.pnl_NewPersonel.Controls.Add(this.txt_NewPersonelNCode);
            this.pnl_NewPersonel.Controls.Add(this.lbl_NewPersonelPassword);
            this.pnl_NewPersonel.Controls.Add(this.lbl_NewPersonelUsername);
            this.pnl_NewPersonel.Controls.Add(this.lbl_NewPersonelBrithDate);
            this.pnl_NewPersonel.Controls.Add(this.lbl_NewPersonelLastName);
            this.pnl_NewPersonel.Controls.Add(this.lbl_NewPersonelFirstName);
            this.pnl_NewPersonel.Controls.Add(this.lbl_NewPersonelNCode);
            this.pnl_NewPersonel.Location = new System.Drawing.Point(418, 293);
            this.pnl_NewPersonel.Name = "pnl_NewPersonel";
            this.pnl_NewPersonel.Size = new System.Drawing.Size(375, 199);
            this.pnl_NewPersonel.TabIndex = 1;
            // 
            // txt_NewPersonelBrithDate
            // 
            this.txt_NewPersonelBrithDate.Location = new System.Drawing.Point(147, 103);
            this.txt_NewPersonelBrithDate.Miladi = new System.DateTime(((long)(0)));
            this.txt_NewPersonelBrithDate.Name = "txt_NewPersonelBrithDate";
            this.txt_NewPersonelBrithDate.NowDateSelected = false;
            this.txt_NewPersonelBrithDate.ReadOnly = true;
            this.txt_NewPersonelBrithDate.SelectedDate = null;
            this.txt_NewPersonelBrithDate.Shamsi = null;
            this.txt_NewPersonelBrithDate.Size = new System.Drawing.Size(148, 23);
            this.txt_NewPersonelBrithDate.TabIndex = 4;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(19, 106);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(113, 78);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "انصراف";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_AddNewPersonel
            // 
            this.btn_AddNewPersonel.Location = new System.Drawing.Point(19, 16);
            this.btn_AddNewPersonel.Name = "btn_AddNewPersonel";
            this.btn_AddNewPersonel.Size = new System.Drawing.Size(113, 81);
            this.btn_AddNewPersonel.TabIndex = 7;
            this.btn_AddNewPersonel.Text = "افزودن";
            this.btn_AddNewPersonel.UseVisualStyleBackColor = true;
            this.btn_AddNewPersonel.Click += new System.EventHandler(this.btn_AddNewPersonel_Click);
            // 
            // txt_NewPersonelPassword
            // 
            this.txt_NewPersonelPassword.Location = new System.Drawing.Point(147, 161);
            this.txt_NewPersonelPassword.Name = "txt_NewPersonelPassword";
            this.txt_NewPersonelPassword.PasswordChar = '*';
            this.txt_NewPersonelPassword.Size = new System.Drawing.Size(148, 23);
            this.txt_NewPersonelPassword.TabIndex = 6;
            // 
            // txt_NewPersonelUserName
            // 
            this.txt_NewPersonelUserName.Location = new System.Drawing.Point(147, 132);
            this.txt_NewPersonelUserName.Name = "txt_NewPersonelUserName";
            this.txt_NewPersonelUserName.Size = new System.Drawing.Size(148, 23);
            this.txt_NewPersonelUserName.TabIndex = 5;
            // 
            // txt_NewPersonelLastName
            // 
            this.txt_NewPersonelLastName.Location = new System.Drawing.Point(147, 74);
            this.txt_NewPersonelLastName.Name = "txt_NewPersonelLastName";
            this.txt_NewPersonelLastName.Size = new System.Drawing.Size(148, 23);
            this.txt_NewPersonelLastName.TabIndex = 3;
            // 
            // txt_NewPersonelFirstName
            // 
            this.txt_NewPersonelFirstName.Location = new System.Drawing.Point(147, 45);
            this.txt_NewPersonelFirstName.Name = "txt_NewPersonelFirstName";
            this.txt_NewPersonelFirstName.Size = new System.Drawing.Size(148, 23);
            this.txt_NewPersonelFirstName.TabIndex = 2;
            // 
            // txt_NewPersonelNCode
            // 
            this.txt_NewPersonelNCode.Location = new System.Drawing.Point(147, 16);
            this.txt_NewPersonelNCode.Name = "txt_NewPersonelNCode";
            this.txt_NewPersonelNCode.Size = new System.Drawing.Size(148, 23);
            this.txt_NewPersonelNCode.TabIndex = 1;
            // 
            // lbl_NewPersonelPassword
            // 
            this.lbl_NewPersonelPassword.AutoSize = true;
            this.lbl_NewPersonelPassword.Location = new System.Drawing.Point(301, 164);
            this.lbl_NewPersonelPassword.Name = "lbl_NewPersonelPassword";
            this.lbl_NewPersonelPassword.Size = new System.Drawing.Size(46, 17);
            this.lbl_NewPersonelPassword.TabIndex = 2;
            this.lbl_NewPersonelPassword.Text = "گذرواژه";
            // 
            // lbl_NewPersonelUsername
            // 
            this.lbl_NewPersonelUsername.AutoSize = true;
            this.lbl_NewPersonelUsername.Location = new System.Drawing.Point(301, 135);
            this.lbl_NewPersonelUsername.Name = "lbl_NewPersonelUsername";
            this.lbl_NewPersonelUsername.Size = new System.Drawing.Size(58, 17);
            this.lbl_NewPersonelUsername.TabIndex = 2;
            this.lbl_NewPersonelUsername.Text = "نام کاربری";
            // 
            // lbl_NewPersonelBrithDate
            // 
            this.lbl_NewPersonelBrithDate.AutoSize = true;
            this.lbl_NewPersonelBrithDate.Location = new System.Drawing.Point(301, 106);
            this.lbl_NewPersonelBrithDate.Name = "lbl_NewPersonelBrithDate";
            this.lbl_NewPersonelBrithDate.Size = new System.Drawing.Size(53, 17);
            this.lbl_NewPersonelBrithDate.TabIndex = 2;
            this.lbl_NewPersonelBrithDate.Text = "تاریخ تولد";
            // 
            // lbl_NewPersonelLastName
            // 
            this.lbl_NewPersonelLastName.AutoSize = true;
            this.lbl_NewPersonelLastName.Location = new System.Drawing.Point(301, 77);
            this.lbl_NewPersonelLastName.Name = "lbl_NewPersonelLastName";
            this.lbl_NewPersonelLastName.Size = new System.Drawing.Size(65, 17);
            this.lbl_NewPersonelLastName.TabIndex = 2;
            this.lbl_NewPersonelLastName.Text = "نام خانوادگی";
            // 
            // lbl_NewPersonelFirstName
            // 
            this.lbl_NewPersonelFirstName.AutoSize = true;
            this.lbl_NewPersonelFirstName.Location = new System.Drawing.Point(301, 48);
            this.lbl_NewPersonelFirstName.Name = "lbl_NewPersonelFirstName";
            this.lbl_NewPersonelFirstName.Size = new System.Drawing.Size(19, 17);
            this.lbl_NewPersonelFirstName.TabIndex = 2;
            this.lbl_NewPersonelFirstName.Text = "نام";
            // 
            // lbl_NewPersonelNCode
            // 
            this.lbl_NewPersonelNCode.AutoSize = true;
            this.lbl_NewPersonelNCode.Location = new System.Drawing.Point(301, 19);
            this.lbl_NewPersonelNCode.Name = "lbl_NewPersonelNCode";
            this.lbl_NewPersonelNCode.Size = new System.Drawing.Size(35, 17);
            this.lbl_NewPersonelNCode.TabIndex = 2;
            this.lbl_NewPersonelNCode.Text = "کدملی";
            // 
            // pnl_SearchPersonel
            // 
            this.pnl_SearchPersonel.Controls.Add(this.txt_SearchPersonelBrithDate);
            this.pnl_SearchPersonel.Controls.Add(this.txt_SearchPersonelNCode);
            this.pnl_SearchPersonel.Controls.Add(this.btn_Search);
            this.pnl_SearchPersonel.Controls.Add(this.lbl_SearchPersonelNCode);
            this.pnl_SearchPersonel.Controls.Add(this.lbl_SearchPersonelFirstName);
            this.pnl_SearchPersonel.Controls.Add(this.txt_SearchPersonelUsername);
            this.pnl_SearchPersonel.Controls.Add(this.lbl_SearchPersonelLastName);
            this.pnl_SearchPersonel.Controls.Add(this.lbl_SearchPersonelBrithDate);
            this.pnl_SearchPersonel.Controls.Add(this.txt_SearchPersonelLastName);
            this.pnl_SearchPersonel.Controls.Add(this.lbl_SearchPersonelUsername);
            this.pnl_SearchPersonel.Controls.Add(this.txt_SearchPersonelFirstName);
            this.pnl_SearchPersonel.Location = new System.Drawing.Point(12, 293);
            this.pnl_SearchPersonel.Name = "pnl_SearchPersonel";
            this.pnl_SearchPersonel.Size = new System.Drawing.Size(389, 199);
            this.pnl_SearchPersonel.TabIndex = 1;
            // 
            // txt_SearchPersonelBrithDate
            // 
            this.txt_SearchPersonelBrithDate.Location = new System.Drawing.Point(152, 119);
            this.txt_SearchPersonelBrithDate.Miladi = new System.DateTime(((long)(0)));
            this.txt_SearchPersonelBrithDate.Name = "txt_SearchPersonelBrithDate";
            this.txt_SearchPersonelBrithDate.NowDateSelected = false;
            this.txt_SearchPersonelBrithDate.ReadOnly = true;
            this.txt_SearchPersonelBrithDate.SelectedDate = null;
            this.txt_SearchPersonelBrithDate.Shamsi = null;
            this.txt_SearchPersonelBrithDate.Size = new System.Drawing.Size(148, 23);
            this.txt_SearchPersonelBrithDate.TabIndex = 12;
            // 
            // txt_SearchPersonelNCode
            // 
            this.txt_SearchPersonelNCode.Location = new System.Drawing.Point(152, 32);
            this.txt_SearchPersonelNCode.Name = "txt_SearchPersonelNCode";
            this.txt_SearchPersonelNCode.Size = new System.Drawing.Size(148, 23);
            this.txt_SearchPersonelNCode.TabIndex = 9;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(15, 32);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(113, 139);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.Text = "جستجو";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_SearchPersonelNCode
            // 
            this.lbl_SearchPersonelNCode.AutoSize = true;
            this.lbl_SearchPersonelNCode.Location = new System.Drawing.Point(306, 35);
            this.lbl_SearchPersonelNCode.Name = "lbl_SearchPersonelNCode";
            this.lbl_SearchPersonelNCode.Size = new System.Drawing.Size(35, 17);
            this.lbl_SearchPersonelNCode.TabIndex = 2;
            this.lbl_SearchPersonelNCode.Text = "کدملی";
            // 
            // lbl_SearchPersonelFirstName
            // 
            this.lbl_SearchPersonelFirstName.AutoSize = true;
            this.lbl_SearchPersonelFirstName.Location = new System.Drawing.Point(306, 64);
            this.lbl_SearchPersonelFirstName.Name = "lbl_SearchPersonelFirstName";
            this.lbl_SearchPersonelFirstName.Size = new System.Drawing.Size(19, 17);
            this.lbl_SearchPersonelFirstName.TabIndex = 2;
            this.lbl_SearchPersonelFirstName.Text = "نام";
            // 
            // txt_SearchPersonelUsername
            // 
            this.txt_SearchPersonelUsername.Location = new System.Drawing.Point(152, 148);
            this.txt_SearchPersonelUsername.Name = "txt_SearchPersonelUsername";
            this.txt_SearchPersonelUsername.Size = new System.Drawing.Size(148, 23);
            this.txt_SearchPersonelUsername.TabIndex = 13;
            // 
            // lbl_SearchPersonelLastName
            // 
            this.lbl_SearchPersonelLastName.AutoSize = true;
            this.lbl_SearchPersonelLastName.Location = new System.Drawing.Point(306, 93);
            this.lbl_SearchPersonelLastName.Name = "lbl_SearchPersonelLastName";
            this.lbl_SearchPersonelLastName.Size = new System.Drawing.Size(65, 17);
            this.lbl_SearchPersonelLastName.TabIndex = 2;
            this.lbl_SearchPersonelLastName.Text = "نام خانوادگی";
            // 
            // lbl_SearchPersonelBrithDate
            // 
            this.lbl_SearchPersonelBrithDate.AutoSize = true;
            this.lbl_SearchPersonelBrithDate.Location = new System.Drawing.Point(306, 122);
            this.lbl_SearchPersonelBrithDate.Name = "lbl_SearchPersonelBrithDate";
            this.lbl_SearchPersonelBrithDate.Size = new System.Drawing.Size(53, 17);
            this.lbl_SearchPersonelBrithDate.TabIndex = 2;
            this.lbl_SearchPersonelBrithDate.Text = "تاریخ تولد";
            // 
            // txt_SearchPersonelLastName
            // 
            this.txt_SearchPersonelLastName.Location = new System.Drawing.Point(152, 90);
            this.txt_SearchPersonelLastName.Name = "txt_SearchPersonelLastName";
            this.txt_SearchPersonelLastName.Size = new System.Drawing.Size(148, 23);
            this.txt_SearchPersonelLastName.TabIndex = 11;
            // 
            // lbl_SearchPersonelUsername
            // 
            this.lbl_SearchPersonelUsername.AutoSize = true;
            this.lbl_SearchPersonelUsername.Location = new System.Drawing.Point(306, 151);
            this.lbl_SearchPersonelUsername.Name = "lbl_SearchPersonelUsername";
            this.lbl_SearchPersonelUsername.Size = new System.Drawing.Size(58, 17);
            this.lbl_SearchPersonelUsername.TabIndex = 2;
            this.lbl_SearchPersonelUsername.Text = "نام کاربری";
            // 
            // txt_SearchPersonelFirstName
            // 
            this.txt_SearchPersonelFirstName.Location = new System.Drawing.Point(152, 61);
            this.txt_SearchPersonelFirstName.Name = "txt_SearchPersonelFirstName";
            this.txt_SearchPersonelFirstName.Size = new System.Drawing.Size(148, 23);
            this.txt_SearchPersonelFirstName.TabIndex = 10;
            // 
            // lbl_NewPersonel
            // 
            this.lbl_NewPersonel.AutoSize = true;
            this.lbl_NewPersonel.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_NewPersonel.Location = new System.Drawing.Point(735, 273);
            this.lbl_NewPersonel.Name = "lbl_NewPersonel";
            this.lbl_NewPersonel.Size = new System.Drawing.Size(61, 17);
            this.lbl_NewPersonel.TabIndex = 2;
            this.lbl_NewPersonel.Text = "پرسنل جدید";
            // 
            // lbl_SearchPersonel
            // 
            this.lbl_SearchPersonel.AutoSize = true;
            this.lbl_SearchPersonel.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_SearchPersonel.Location = new System.Drawing.Point(363, 273);
            this.lbl_SearchPersonel.Name = "lbl_SearchPersonel";
            this.lbl_SearchPersonel.Size = new System.Drawing.Size(41, 17);
            this.lbl_SearchPersonel.TabIndex = 2;
            this.lbl_SearchPersonel.Text = "جستجو";
            // 
            // frmPersonels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 504);
            this.Controls.Add(this.lbl_SearchPersonel);
            this.Controls.Add(this.lbl_NewPersonel);
            this.Controls.Add(this.pnl_SearchPersonel);
            this.Controls.Add(this.pnl_NewPersonel);
            this.Controls.Add(this.dgv_Personels);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(821, 543);
            this.MinimumSize = new System.Drawing.Size(821, 543);
            this.Name = "frmPersonels";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پرسنل";
            this.Load += new System.EventHandler(this.frmPersonels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Personels)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.pnl_NewPersonel.ResumeLayout(false);
            this.pnl_NewPersonel.PerformLayout();
            this.pnl_SearchPersonel.ResumeLayout(false);
            this.pnl_SearchPersonel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Personels;
        private System.Windows.Forms.Panel pnl_NewPersonel;
        private System.Windows.Forms.Panel pnl_SearchPersonel;
        private System.Windows.Forms.Label lbl_NewPersonel;
        private System.Windows.Forms.Label lbl_SearchPersonel;
        private System.Windows.Forms.Label lbl_NewPersonelPassword;
        private System.Windows.Forms.Label lbl_NewPersonelUsername;
        private System.Windows.Forms.Label lbl_NewPersonelBrithDate;
        private System.Windows.Forms.Label lbl_NewPersonelLastName;
        private System.Windows.Forms.Label lbl_NewPersonelFirstName;
        private System.Windows.Forms.Label lbl_NewPersonelNCode;
        private System.Windows.Forms.TextBox txt_NewPersonelPassword;
        private System.Windows.Forms.TextBox txt_NewPersonelUserName;
        private System.Windows.Forms.TextBox txt_NewPersonelLastName;
        private System.Windows.Forms.TextBox txt_NewPersonelFirstName;
        private System.Windows.Forms.TextBox txt_NewPersonelNCode;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_AddNewPersonel;
        private System.Windows.Forms.TextBox txt_SearchPersonelNCode;
        private System.Windows.Forms.Label lbl_SearchPersonelNCode;
        private System.Windows.Forms.Label lbl_SearchPersonelFirstName;
        private System.Windows.Forms.TextBox txt_SearchPersonelUsername;
        private System.Windows.Forms.Label lbl_SearchPersonelLastName;
        private System.Windows.Forms.Label lbl_SearchPersonelBrithDate;
        private System.Windows.Forms.TextBox txt_SearchPersonelLastName;
        private System.Windows.Forms.Label lbl_SearchPersonelUsername;
        private System.Windows.Forms.TextBox txt_SearchPersonelFirstName;
        private System.Windows.Forms.Button btn_Search;
        private BPersianCalender.BPersianCalenderTextBox txt_NewPersonelBrithDate;
        private BPersianCalender.BPersianCalenderTextBox txt_SearchPersonelBrithDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PersonelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BrithDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Username;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsm_DeletePersonel;
        private System.Windows.Forms.ToolStripMenuItem tsm_UpdatePassword;
    }
}