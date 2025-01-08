namespace RestaurantDesktop
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
            btnAddAccount = new Button();
            btnEditAccount = new Button();
            btnDeleteAccount = new Button();
            label6 = new Label();
            lvAccounts = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 15);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 44);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 73);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Họ và tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 102);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(143, 131);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 4;
            label5.Text = "Số điện thoại";
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(227, 12);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(273, 23);
            txtAccountName.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(227, 41);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(273, 23);
            txtPassword.TabIndex = 6;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(227, 70);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(273, 23);
            txtFullName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(227, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(273, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtTell
            // 
            txtTell.Location = new Point(227, 128);
            txtTell.Name = "txtTell";
            txtTell.Size = new Size(273, 23);
            txtTell.TabIndex = 9;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(205, 157);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(75, 23);
            btnAddAccount.TabIndex = 10;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(304, 157);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(75, 23);
            btnEditAccount.TabIndex = 11;
            btnEditAccount.Text = "Sửa";
            btnEditAccount.UseVisualStyleBackColor = true;
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(403, 157);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(75, 23);
            btnDeleteAccount.TabIndex = 12;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 183);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 13;
            label6.Text = "Danh sách tài khoản";
            // 
            // lvAccounts
            // 
            lvAccounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvAccounts.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lvAccounts.FullRowSelect = true;
            lvAccounts.GridLines = true;
            lvAccounts.Location = new Point(12, 201);
            lvAccounts.Name = "lvAccounts";
            lvAccounts.Size = new Size(606, 237);
            lvAccounts.TabIndex = 14;
            lvAccounts.UseCompatibleStateImageBehavior = false;
            lvAccounts.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên tài khoản";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mật khẩu";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Họ và tên";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Số điện thoại";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Ngày tạo";
            columnHeader6.Width = 100;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 450);
            Controls.Add(lvAccounts);
            Controls.Add(label6);
            Controls.Add(btnDeleteAccount);
            Controls.Add(btnEditAccount);
            Controls.Add(btnAddAccount);
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
            Text = "Quản lý tài khoản người dùng";
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
        private Button btnAddAccount;
        private Button btnEditAccount;
        private Button btnDeleteAccount;
        private Label label6;
        private ListView lvAccounts;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}