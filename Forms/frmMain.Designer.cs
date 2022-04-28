namespace libraryManagement
{
    partial class frmMain
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
            this.mns_TopMenu = new System.Windows.Forms.MenuStrip();
            this.برنامهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دربارهماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تنظیماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Library = new System.Windows.Forms.Button();
            this.btn_Members = new System.Windows.Forms.Button();
            this.btn_Personels = new System.Windows.Forms.Button();
            this.lbl_TodayDate = new System.Windows.Forms.Label();
            this.val_TodayDate = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.val_Time = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.val_User = new System.Windows.Forms.Label();
            this.mns_TopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mns_TopMenu
            // 
            this.mns_TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.برنامهToolStripMenuItem});
            this.mns_TopMenu.Location = new System.Drawing.Point(0, 0);
            this.mns_TopMenu.Name = "mns_TopMenu";
            this.mns_TopMenu.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.mns_TopMenu.Size = new System.Drawing.Size(696, 25);
            this.mns_TopMenu.TabIndex = 0;
            this.mns_TopMenu.Text = "menuStrip1";
            // 
            // برنامهToolStripMenuItem
            // 
            this.برنامهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دربارهماToolStripMenuItem,
            this.تنظیماتToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.برنامهToolStripMenuItem.Name = "برنامهToolStripMenuItem";
            this.برنامهToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
            this.برنامهToolStripMenuItem.Text = "برنامه";
            // 
            // دربارهماToolStripMenuItem
            // 
            this.دربارهماToolStripMenuItem.Name = "دربارهماToolStripMenuItem";
            this.دربارهماToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.دربارهماToolStripMenuItem.Text = "درباره ما";
            // 
            // تنظیماتToolStripMenuItem
            // 
            this.تنظیماتToolStripMenuItem.Name = "تنظیماتToolStripMenuItem";
            this.تنظیماتToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.تنظیماتToolStripMenuItem.Text = "تنظیمات";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.خروجToolStripMenuItem.Text = "خروج";
            // 
            // btn_Library
            // 
            this.btn_Library.Location = new System.Drawing.Point(463, 29);
            this.btn_Library.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Library.Name = "btn_Library";
            this.btn_Library.Size = new System.Drawing.Size(217, 62);
            this.btn_Library.TabIndex = 1;
            this.btn_Library.Text = "کتابخانه";
            this.btn_Library.UseVisualStyleBackColor = true;
            // 
            // btn_Members
            // 
            this.btn_Members.Location = new System.Drawing.Point(238, 29);
            this.btn_Members.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Members.Name = "btn_Members";
            this.btn_Members.Size = new System.Drawing.Size(217, 62);
            this.btn_Members.TabIndex = 1;
            this.btn_Members.Text = "اعضاء";
            this.btn_Members.UseVisualStyleBackColor = true;
            // 
            // btn_Personels
            // 
            this.btn_Personels.Location = new System.Drawing.Point(13, 29);
            this.btn_Personels.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Personels.Name = "btn_Personels";
            this.btn_Personels.Size = new System.Drawing.Size(217, 62);
            this.btn_Personels.TabIndex = 1;
            this.btn_Personels.Text = "پرسنل";
            this.btn_Personels.UseVisualStyleBackColor = true;
            // 
            // lbl_TodayDate
            // 
            this.lbl_TodayDate.AutoSize = true;
            this.lbl_TodayDate.Location = new System.Drawing.Point(641, 169);
            this.lbl_TodayDate.Name = "lbl_TodayDate";
            this.lbl_TodayDate.Size = new System.Drawing.Size(36, 17);
            this.lbl_TodayDate.TabIndex = 2;
            this.lbl_TodayDate.Text = "امروز";
            // 
            // val_TodayDate
            // 
            this.val_TodayDate.AutoSize = true;
            this.val_TodayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_TodayDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.val_TodayDate.Location = new System.Drawing.Point(545, 169);
            this.val_TodayDate.Name = "val_TodayDate";
            this.val_TodayDate.Size = new System.Drawing.Size(90, 18);
            this.val_TodayDate.TabIndex = 2;
            this.val_TodayDate.Text = "0000/00/00";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(438, 169);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(37, 17);
            this.lbl_Time.TabIndex = 2;
            this.lbl_Time.Text = "ساعت";
            // 
            // val_Time
            // 
            this.val_Time.AutoSize = true;
            this.val_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.val_Time.Location = new System.Drawing.Point(360, 169);
            this.val_Time.Name = "val_Time";
            this.val_Time.Size = new System.Drawing.Size(72, 18);
            this.val_Time.TabIndex = 2;
            this.val_Time.Text = "00:00:00";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(232, 169);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(65, 17);
            this.lbl_User.TabIndex = 2;
            this.lbl_User.Text = "کاربر سیستم";
            // 
            // val_User
            // 
            this.val_User.AutoSize = true;
            this.val_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.val_User.Location = new System.Drawing.Point(11, 168);
            this.val_User.Name = "val_User";
            this.val_User.Size = new System.Drawing.Size(216, 18);
            this.val_User.TabIndex = 2;
            this.val_User.Text = "نام و نام خانوادگی ادمین  وارد شده";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 235);
            this.Controls.Add(this.val_User);
            this.Controls.Add(this.val_Time);
            this.Controls.Add(this.val_TodayDate);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.lbl_TodayDate);
            this.Controls.Add(this.btn_Personels);
            this.Controls.Add(this.btn_Members);
            this.Controls.Add(this.btn_Library);
            this.Controls.Add(this.mns_TopMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.MainMenuStrip = this.mns_TopMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت کتابخانه";
            this.mns_TopMenu.ResumeLayout(false);
            this.mns_TopMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_TopMenu;
        private System.Windows.Forms.ToolStripMenuItem برنامهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دربارهماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تنظیماتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.Button btn_Library;
        private System.Windows.Forms.Button btn_Members;
        private System.Windows.Forms.Button btn_Personels;
        private System.Windows.Forms.Label lbl_TodayDate;
        private System.Windows.Forms.Label val_TodayDate;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label val_Time;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label val_User;
    }
}

