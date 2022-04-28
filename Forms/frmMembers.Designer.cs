namespace libraryManagement.Forms
{
    partial class frmMembers
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
            this.dgv_Members = new System.Windows.Forms.DataGridView();
            this.pnl_NewMember = new System.Windows.Forms.Panel();
            this.pnl_SearchMember = new System.Windows.Forms.Panel();
            this.lbl_NewMember = new System.Windows.Forms.Label();
            this.lbl_SearchMember = new System.Windows.Forms.Label();
            this.lbl_NewMemberFirstName = new System.Windows.Forms.Label();
            this.lbl_NewMemberNCode = new System.Windows.Forms.Label();
            this.lbl_NewMemberLastName = new System.Windows.Forms.Label();
            this.lbl_NewMemberBrithDate = new System.Windows.Forms.Label();
            this.txt_NewMemberNCode = new System.Windows.Forms.TextBox();
            this.txt_NewMemberFirstName = new System.Windows.Forms.TextBox();
            this.txt_NewMemberLastName = new System.Windows.Forms.TextBox();
            this.txt_NewMemberBrithDate = new BPersianCalender.BPersianCalenderTextBox();
            this.btn_AddNewMember = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_SearchMemberFirstName = new System.Windows.Forms.Label();
            this.lbl_SearchMemberLastName = new System.Windows.Forms.Label();
            this.lbl_SearchMemberBrithDate = new System.Windows.Forms.Label();
            this.lbl_SearchMemberNCode = new System.Windows.Forms.Label();
            this.txt_SearchMemberNCode = new System.Windows.Forms.TextBox();
            this.txt_SearchMemberFirstName = new System.Windows.Forms.TextBox();
            this.txt_SearchMemberLastName = new System.Windows.Forms.TextBox();
            this.txt_SearchMemberBrithDate = new BPersianCalender.BPersianCalenderTextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.col_NCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BrithDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Members)).BeginInit();
            this.pnl_NewMember.SuspendLayout();
            this.pnl_SearchMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Members
            // 
            this.dgv_Members.AllowUserToAddRows = false;
            this.dgv_Members.AllowUserToDeleteRows = false;
            this.dgv_Members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Members.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_NCode,
            this.col_FirstName,
            this.col_LastName,
            this.col_BrithDate});
            this.dgv_Members.Location = new System.Drawing.Point(16, 15);
            this.dgv_Members.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Members.Name = "dgv_Members";
            this.dgv_Members.Size = new System.Drawing.Size(669, 233);
            this.dgv_Members.TabIndex = 0;
            // 
            // pnl_NewMember
            // 
            this.pnl_NewMember.Controls.Add(this.btn_Clear);
            this.pnl_NewMember.Controls.Add(this.btn_AddNewMember);
            this.pnl_NewMember.Controls.Add(this.txt_NewMemberBrithDate);
            this.pnl_NewMember.Controls.Add(this.txt_NewMemberLastName);
            this.pnl_NewMember.Controls.Add(this.txt_NewMemberFirstName);
            this.pnl_NewMember.Controls.Add(this.txt_NewMemberNCode);
            this.pnl_NewMember.Controls.Add(this.lbl_NewMemberNCode);
            this.pnl_NewMember.Controls.Add(this.lbl_NewMemberBrithDate);
            this.pnl_NewMember.Controls.Add(this.lbl_NewMemberLastName);
            this.pnl_NewMember.Controls.Add(this.lbl_NewMemberFirstName);
            this.pnl_NewMember.Location = new System.Drawing.Point(362, 272);
            this.pnl_NewMember.Name = "pnl_NewMember";
            this.pnl_NewMember.Size = new System.Drawing.Size(323, 196);
            this.pnl_NewMember.TabIndex = 1;
            // 
            // pnl_SearchMember
            // 
            this.pnl_SearchMember.Controls.Add(this.txt_SearchMemberNCode);
            this.pnl_SearchMember.Controls.Add(this.btn_Search);
            this.pnl_SearchMember.Controls.Add(this.lbl_SearchMemberFirstName);
            this.pnl_SearchMember.Controls.Add(this.txt_SearchMemberBrithDate);
            this.pnl_SearchMember.Controls.Add(this.lbl_SearchMemberLastName);
            this.pnl_SearchMember.Controls.Add(this.txt_SearchMemberLastName);
            this.pnl_SearchMember.Controls.Add(this.lbl_SearchMemberBrithDate);
            this.pnl_SearchMember.Controls.Add(this.txt_SearchMemberFirstName);
            this.pnl_SearchMember.Controls.Add(this.lbl_SearchMemberNCode);
            this.pnl_SearchMember.Location = new System.Drawing.Point(16, 272);
            this.pnl_SearchMember.Name = "pnl_SearchMember";
            this.pnl_SearchMember.Size = new System.Drawing.Size(340, 196);
            this.pnl_SearchMember.TabIndex = 1;
            // 
            // lbl_NewMember
            // 
            this.lbl_NewMember.AutoSize = true;
            this.lbl_NewMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_NewMember.Location = new System.Drawing.Point(627, 252);
            this.lbl_NewMember.Name = "lbl_NewMember";
            this.lbl_NewMember.Size = new System.Drawing.Size(59, 17);
            this.lbl_NewMember.TabIndex = 2;
            this.lbl_NewMember.Text = "عضو جدید";
            // 
            // lbl_SearchMember
            // 
            this.lbl_SearchMember.AutoSize = true;
            this.lbl_SearchMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_SearchMember.Location = new System.Drawing.Point(318, 252);
            this.lbl_SearchMember.Name = "lbl_SearchMember";
            this.lbl_SearchMember.Size = new System.Drawing.Size(41, 17);
            this.lbl_SearchMember.TabIndex = 2;
            this.lbl_SearchMember.Text = "جستجو";
            // 
            // lbl_NewMemberFirstName
            // 
            this.lbl_NewMemberFirstName.AutoSize = true;
            this.lbl_NewMemberFirstName.Location = new System.Drawing.Point(231, 41);
            this.lbl_NewMemberFirstName.Name = "lbl_NewMemberFirstName";
            this.lbl_NewMemberFirstName.Size = new System.Drawing.Size(19, 17);
            this.lbl_NewMemberFirstName.TabIndex = 0;
            this.lbl_NewMemberFirstName.Text = "نام";
            // 
            // lbl_NewMemberNCode
            // 
            this.lbl_NewMemberNCode.AutoSize = true;
            this.lbl_NewMemberNCode.Location = new System.Drawing.Point(231, 12);
            this.lbl_NewMemberNCode.Name = "lbl_NewMemberNCode";
            this.lbl_NewMemberNCode.Size = new System.Drawing.Size(35, 17);
            this.lbl_NewMemberNCode.TabIndex = 0;
            this.lbl_NewMemberNCode.Text = "کدملی";
            // 
            // lbl_NewMemberLastName
            // 
            this.lbl_NewMemberLastName.AutoSize = true;
            this.lbl_NewMemberLastName.Location = new System.Drawing.Point(231, 70);
            this.lbl_NewMemberLastName.Name = "lbl_NewMemberLastName";
            this.lbl_NewMemberLastName.Size = new System.Drawing.Size(65, 17);
            this.lbl_NewMemberLastName.TabIndex = 0;
            this.lbl_NewMemberLastName.Text = "نام خانوادگی";
            // 
            // lbl_NewMemberBrithDate
            // 
            this.lbl_NewMemberBrithDate.AutoSize = true;
            this.lbl_NewMemberBrithDate.Location = new System.Drawing.Point(231, 99);
            this.lbl_NewMemberBrithDate.Name = "lbl_NewMemberBrithDate";
            this.lbl_NewMemberBrithDate.Size = new System.Drawing.Size(53, 17);
            this.lbl_NewMemberBrithDate.TabIndex = 0;
            this.lbl_NewMemberBrithDate.Text = "تاریخ تولد";
            // 
            // txt_NewMemberNCode
            // 
            this.txt_NewMemberNCode.Location = new System.Drawing.Point(38, 9);
            this.txt_NewMemberNCode.Name = "txt_NewMemberNCode";
            this.txt_NewMemberNCode.Size = new System.Drawing.Size(186, 23);
            this.txt_NewMemberNCode.TabIndex = 1;
            // 
            // txt_NewMemberFirstName
            // 
            this.txt_NewMemberFirstName.Location = new System.Drawing.Point(38, 38);
            this.txt_NewMemberFirstName.Name = "txt_NewMemberFirstName";
            this.txt_NewMemberFirstName.Size = new System.Drawing.Size(186, 23);
            this.txt_NewMemberFirstName.TabIndex = 2;
            // 
            // txt_NewMemberLastName
            // 
            this.txt_NewMemberLastName.Location = new System.Drawing.Point(38, 67);
            this.txt_NewMemberLastName.Name = "txt_NewMemberLastName";
            this.txt_NewMemberLastName.Size = new System.Drawing.Size(186, 23);
            this.txt_NewMemberLastName.TabIndex = 3;
            // 
            // txt_NewMemberBrithDate
            // 
            this.txt_NewMemberBrithDate.Location = new System.Drawing.Point(38, 96);
            this.txt_NewMemberBrithDate.Miladi = new System.DateTime(((long)(0)));
            this.txt_NewMemberBrithDate.Name = "txt_NewMemberBrithDate";
            this.txt_NewMemberBrithDate.NowDateSelected = false;
            this.txt_NewMemberBrithDate.ReadOnly = true;
            this.txt_NewMemberBrithDate.SelectedDate = null;
            this.txt_NewMemberBrithDate.Shamsi = null;
            this.txt_NewMemberBrithDate.Size = new System.Drawing.Size(186, 23);
            this.txt_NewMemberBrithDate.TabIndex = 4;
            // 
            // btn_AddNewMember
            // 
            this.btn_AddNewMember.Location = new System.Drawing.Point(38, 125);
            this.btn_AddNewMember.Name = "btn_AddNewMember";
            this.btn_AddNewMember.Size = new System.Drawing.Size(255, 27);
            this.btn_AddNewMember.TabIndex = 5;
            this.btn_AddNewMember.Text = "افزودن";
            this.btn_AddNewMember.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(38, 158);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(255, 27);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "انصراف";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // lbl_SearchMemberFirstName
            // 
            this.lbl_SearchMemberFirstName.AutoSize = true;
            this.lbl_SearchMemberFirstName.Location = new System.Drawing.Point(244, 44);
            this.lbl_SearchMemberFirstName.Name = "lbl_SearchMemberFirstName";
            this.lbl_SearchMemberFirstName.Size = new System.Drawing.Size(19, 17);
            this.lbl_SearchMemberFirstName.TabIndex = 0;
            this.lbl_SearchMemberFirstName.Text = "نام";
            // 
            // lbl_SearchMemberLastName
            // 
            this.lbl_SearchMemberLastName.AutoSize = true;
            this.lbl_SearchMemberLastName.Location = new System.Drawing.Point(244, 73);
            this.lbl_SearchMemberLastName.Name = "lbl_SearchMemberLastName";
            this.lbl_SearchMemberLastName.Size = new System.Drawing.Size(65, 17);
            this.lbl_SearchMemberLastName.TabIndex = 0;
            this.lbl_SearchMemberLastName.Text = "نام خانوادگی";
            // 
            // lbl_SearchMemberBrithDate
            // 
            this.lbl_SearchMemberBrithDate.AutoSize = true;
            this.lbl_SearchMemberBrithDate.Location = new System.Drawing.Point(244, 102);
            this.lbl_SearchMemberBrithDate.Name = "lbl_SearchMemberBrithDate";
            this.lbl_SearchMemberBrithDate.Size = new System.Drawing.Size(53, 17);
            this.lbl_SearchMemberBrithDate.TabIndex = 0;
            this.lbl_SearchMemberBrithDate.Text = "تاریخ تولد";
            // 
            // lbl_SearchMemberNCode
            // 
            this.lbl_SearchMemberNCode.AutoSize = true;
            this.lbl_SearchMemberNCode.Location = new System.Drawing.Point(244, 15);
            this.lbl_SearchMemberNCode.Name = "lbl_SearchMemberNCode";
            this.lbl_SearchMemberNCode.Size = new System.Drawing.Size(35, 17);
            this.lbl_SearchMemberNCode.TabIndex = 0;
            this.lbl_SearchMemberNCode.Text = "کدملی";
            // 
            // txt_SearchMemberNCode
            // 
            this.txt_SearchMemberNCode.Location = new System.Drawing.Point(51, 12);
            this.txt_SearchMemberNCode.Name = "txt_SearchMemberNCode";
            this.txt_SearchMemberNCode.Size = new System.Drawing.Size(186, 23);
            this.txt_SearchMemberNCode.TabIndex = 7;
            // 
            // txt_SearchMemberFirstName
            // 
            this.txt_SearchMemberFirstName.Location = new System.Drawing.Point(51, 41);
            this.txt_SearchMemberFirstName.Name = "txt_SearchMemberFirstName";
            this.txt_SearchMemberFirstName.Size = new System.Drawing.Size(186, 23);
            this.txt_SearchMemberFirstName.TabIndex = 8;
            // 
            // txt_SearchMemberLastName
            // 
            this.txt_SearchMemberLastName.Location = new System.Drawing.Point(51, 70);
            this.txt_SearchMemberLastName.Name = "txt_SearchMemberLastName";
            this.txt_SearchMemberLastName.Size = new System.Drawing.Size(186, 23);
            this.txt_SearchMemberLastName.TabIndex = 9;
            // 
            // txt_SearchMemberBrithDate
            // 
            this.txt_SearchMemberBrithDate.Location = new System.Drawing.Point(51, 99);
            this.txt_SearchMemberBrithDate.Miladi = new System.DateTime(((long)(0)));
            this.txt_SearchMemberBrithDate.Name = "txt_SearchMemberBrithDate";
            this.txt_SearchMemberBrithDate.NowDateSelected = false;
            this.txt_SearchMemberBrithDate.ReadOnly = true;
            this.txt_SearchMemberBrithDate.SelectedDate = null;
            this.txt_SearchMemberBrithDate.Shamsi = null;
            this.txt_SearchMemberBrithDate.Size = new System.Drawing.Size(186, 23);
            this.txt_SearchMemberBrithDate.TabIndex = 10;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(51, 128);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(255, 57);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "جستجو";
            this.btn_Search.UseVisualStyleBackColor = true;
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
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 480);
            this.Controls.Add(this.lbl_SearchMember);
            this.Controls.Add(this.lbl_NewMember);
            this.Controls.Add(this.pnl_SearchMember);
            this.Controls.Add(this.pnl_NewMember);
            this.Controls.Add(this.dgv_Members);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(714, 519);
            this.MinimumSize = new System.Drawing.Size(714, 519);
            this.Name = "frmMembers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعضاء";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Members)).EndInit();
            this.pnl_NewMember.ResumeLayout(false);
            this.pnl_NewMember.PerformLayout();
            this.pnl_SearchMember.ResumeLayout(false);
            this.pnl_SearchMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Members;
        private System.Windows.Forms.Panel pnl_NewMember;
        private System.Windows.Forms.Panel pnl_SearchMember;
        private System.Windows.Forms.Label lbl_NewMember;
        private System.Windows.Forms.Label lbl_SearchMember;
        private System.Windows.Forms.Label lbl_NewMemberNCode;
        private System.Windows.Forms.Label lbl_NewMemberBrithDate;
        private System.Windows.Forms.Label lbl_NewMemberLastName;
        private System.Windows.Forms.Label lbl_NewMemberFirstName;
        private System.Windows.Forms.TextBox txt_NewMemberLastName;
        private System.Windows.Forms.TextBox txt_NewMemberFirstName;
        private System.Windows.Forms.TextBox txt_NewMemberNCode;
        private BPersianCalender.BPersianCalenderTextBox txt_NewMemberBrithDate;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_AddNewMember;
        private System.Windows.Forms.TextBox txt_SearchMemberNCode;
        private System.Windows.Forms.Label lbl_SearchMemberFirstName;
        private BPersianCalender.BPersianCalenderTextBox txt_SearchMemberBrithDate;
        private System.Windows.Forms.Label lbl_SearchMemberLastName;
        private System.Windows.Forms.TextBox txt_SearchMemberLastName;
        private System.Windows.Forms.Label lbl_SearchMemberBrithDate;
        private System.Windows.Forms.TextBox txt_SearchMemberFirstName;
        private System.Windows.Forms.Label lbl_SearchMemberNCode;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BrithDate;
    }
}