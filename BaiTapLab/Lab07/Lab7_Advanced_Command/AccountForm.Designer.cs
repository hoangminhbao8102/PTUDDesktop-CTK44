namespace Lab7_Advanced_Command
{
    partial class AccountForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAccountName = new TextBox();
            txtPassword = new TextBox();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtTell = new TextBox();
            dgvAccounts = new DataGridView();
            btnAddAccount = new Button();
            btnResetPassword = new Button();
            btnUpdateAccount = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 233);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 262);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 291);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Họ và tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 320);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(213, 349);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 4;
            label5.Text = "Số điện thoại:";
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(301, 230);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(307, 23);
            txtAccountName.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(301, 259);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(307, 23);
            txtPassword.TabIndex = 6;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(301, 288);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(307, 23);
            txtFullName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(301, 317);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(307, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtTell
            // 
            txtTell.Location = new Point(301, 346);
            txtTell.Name = "txtTell";
            txtTell.Size = new Size(307, 23);
            txtTell.TabIndex = 9;
            // 
            // dgvAccounts
            // 
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Location = new Point(12, 12);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.Size = new Size(776, 212);
            dgvAccounts.TabIndex = 10;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(233, 375);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(123, 23);
            btnAddAccount.TabIndex = 11;
            btnAddAccount.Text = "Thêm tài khoản mới";
            btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(479, 375);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(99, 23);
            btnResetPassword.TabIndex = 12;
            btnResetPassword.Text = "Reset mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.Location = new Point(379, 375);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(66, 23);
            btnUpdateAccount.TabIndex = 13;
            btnUpdateAccount.Text = "Cập nhật";
            btnUpdateAccount.UseVisualStyleBackColor = true;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 405);
            Controls.Add(btnUpdateAccount);
            Controls.Add(btnResetPassword);
            Controls.Add(btnAddAccount);
            Controls.Add(dgvAccounts);
            Controls.Add(txtTell);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(txtPassword);
            Controls.Add(txtAccountName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AccountForm";
            Text = "AccountForm";
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAccountName;
        private TextBox txtPassword;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtTell;
        private DataGridView dgvAccounts;
        private Button btnAddAccount;
        private Button btnResetPassword;
        private Button btnUpdateAccount;
    }
}