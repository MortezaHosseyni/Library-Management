namespace libraryManagement.Forms
{
    partial class frmUpdatePassword
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
            this.txt_OldPassword = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_OldPassword = new System.Windows.Forms.Label();
            this.lbl_NewPassword = new System.Windows.Forms.Label();
            this.lbl_ConfirmNewPassword = new System.Windows.Forms.Label();
            this.txt_NewPassword = new System.Windows.Forms.TextBox();
            this.txt_ConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_OldPassword
            // 
            this.txt_OldPassword.Location = new System.Drawing.Point(96, 109);
            this.txt_OldPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_OldPassword.Name = "txt_OldPassword";
            this.txt_OldPassword.PasswordChar = '*';
            this.txt_OldPassword.Size = new System.Drawing.Size(202, 23);
            this.txt_OldPassword.TabIndex = 1;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_Title.Location = new System.Drawing.Point(96, 39);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(177, 24);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "بروزرسانی گذرواژه پرسنل";
            // 
            // lbl_OldPassword
            // 
            this.lbl_OldPassword.AutoSize = true;
            this.lbl_OldPassword.Location = new System.Drawing.Point(302, 112);
            this.lbl_OldPassword.Name = "lbl_OldPassword";
            this.lbl_OldPassword.Size = new System.Drawing.Size(68, 17);
            this.lbl_OldPassword.TabIndex = 2;
            this.lbl_OldPassword.Text = "گذرواژه قبلی";
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.AutoSize = true;
            this.lbl_NewPassword.Location = new System.Drawing.Point(302, 143);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(71, 17);
            this.lbl_NewPassword.TabIndex = 2;
            this.lbl_NewPassword.Text = "گذرواژه جدید";
            // 
            // lbl_ConfirmNewPassword
            // 
            this.lbl_ConfirmNewPassword.AutoSize = true;
            this.lbl_ConfirmNewPassword.Location = new System.Drawing.Point(302, 174);
            this.lbl_ConfirmNewPassword.Name = "lbl_ConfirmNewPassword";
            this.lbl_ConfirmNewPassword.Size = new System.Drawing.Size(101, 17);
            this.lbl_ConfirmNewPassword.TabIndex = 2;
            this.lbl_ConfirmNewPassword.Text = "تکرار گذرواژه جدید";
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.Location = new System.Drawing.Point(96, 140);
            this.txt_NewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.PasswordChar = '*';
            this.txt_NewPassword.Size = new System.Drawing.Size(202, 23);
            this.txt_NewPassword.TabIndex = 2;
            // 
            // txt_ConfirmNewPassword
            // 
            this.txt_ConfirmNewPassword.Location = new System.Drawing.Point(96, 171);
            this.txt_ConfirmNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ConfirmNewPassword.Name = "txt_ConfirmNewPassword";
            this.txt_ConfirmNewPassword.PasswordChar = '*';
            this.txt_ConfirmNewPassword.Size = new System.Drawing.Size(202, 23);
            this.txt_ConfirmNewPassword.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(96, 227);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(307, 32);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "ذخیره";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(96, 265);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(307, 32);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "لغو";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frmUpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 306);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_ConfirmNewPassword);
            this.Controls.Add(this.lbl_NewPassword);
            this.Controls.Add(this.lbl_OldPassword);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txt_ConfirmNewPassword);
            this.Controls.Add(this.txt_NewPassword);
            this.Controls.Add(this.txt_OldPassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUpdatePassword";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بروزرسانی گذرواژه";
            this.Load += new System.EventHandler(this.frmUpdatePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_OldPassword;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_OldPassword;
        private System.Windows.Forms.Label lbl_NewPassword;
        private System.Windows.Forms.Label lbl_ConfirmNewPassword;
        private System.Windows.Forms.TextBox txt_NewPassword;
        private System.Windows.Forms.TextBox txt_ConfirmNewPassword;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
    }
}