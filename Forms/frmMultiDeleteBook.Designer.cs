namespace libraryManagement.Forms
{
    partial class frmMultiDeleteBook
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
            this.txt_DeleteCodeOn = new System.Windows.Forms.TextBox();
            this.lbl_DeleteOnCode = new System.Windows.Forms.Label();
            this.lbl_DeleteToCode = new System.Windows.Forms.Label();
            this.txt_DeleteCodeTo = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_DeleteCodeOn
            // 
            this.txt_DeleteCodeOn.Location = new System.Drawing.Point(255, 39);
            this.txt_DeleteCodeOn.Name = "txt_DeleteCodeOn";
            this.txt_DeleteCodeOn.Size = new System.Drawing.Size(183, 23);
            this.txt_DeleteCodeOn.TabIndex = 0;
            // 
            // lbl_DeleteOnCode
            // 
            this.lbl_DeleteOnCode.AutoSize = true;
            this.lbl_DeleteOnCode.Location = new System.Drawing.Point(444, 42);
            this.lbl_DeleteOnCode.Name = "lbl_DeleteOnCode";
            this.lbl_DeleteOnCode.Size = new System.Drawing.Size(61, 17);
            this.lbl_DeleteOnCode.TabIndex = 1;
            this.lbl_DeleteOnCode.Text = "حذف از کد";
            // 
            // lbl_DeleteToCode
            // 
            this.lbl_DeleteToCode.AutoSize = true;
            this.lbl_DeleteToCode.Location = new System.Drawing.Point(220, 42);
            this.lbl_DeleteToCode.Name = "lbl_DeleteToCode";
            this.lbl_DeleteToCode.Size = new System.Drawing.Size(29, 17);
            this.lbl_DeleteToCode.TabIndex = 1;
            this.lbl_DeleteToCode.Text = "تا کد";
            // 
            // txt_DeleteCodeTo
            // 
            this.txt_DeleteCodeTo.Location = new System.Drawing.Point(31, 39);
            this.txt_DeleteCodeTo.Name = "txt_DeleteCodeTo";
            this.txt_DeleteCodeTo.Size = new System.Drawing.Size(183, 23);
            this.txt_DeleteCodeTo.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(286, 89);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(183, 33);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(62, 89);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(183, 33);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "لغو";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frmMultiDeleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 149);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lbl_DeleteToCode);
            this.Controls.Add(this.lbl_DeleteOnCode);
            this.Controls.Add(this.txt_DeleteCodeTo);
            this.Controls.Add(this.txt_DeleteCodeOn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMultiDeleteBook";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حذف چندتایی";
            this.Load += new System.EventHandler(this.frmMultiDeleteBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_DeleteCodeOn;
        private System.Windows.Forms.Label lbl_DeleteOnCode;
        private System.Windows.Forms.Label lbl_DeleteToCode;
        private System.Windows.Forms.TextBox txt_DeleteCodeTo;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Cancel;
    }
}