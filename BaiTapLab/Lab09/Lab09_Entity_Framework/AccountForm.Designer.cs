namespace Lab09_Entity_Framework
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtSearchUserName = new TextBox();
            txtSearchRole = new TextBox();
            btnSearch = new Button();
            btnChangePassword = new Button();
            btnUpdateAccount = new Button();
            btnResetPassword = new Button();
            btnAddAccount = new Button();
            lvwAccount = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsmDeleteAccount = new ToolStripMenuItem();
            tsmViewRoles = new ToolStripMenuItem();
            label3 = new Label();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 15);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên tài khoản cần tìm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 44);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập tên Role cần tìm";
            // 
            // txtSearchUserName
            // 
            txtSearchUserName.Location = new Point(312, 12);
            txtSearchUserName.Name = "txtSearchUserName";
            txtSearchUserName.Size = new Size(187, 23);
            txtSearchUserName.TabIndex = 2;
            // 
            // txtSearchRole
            // 
            txtSearchRole.Location = new Point(312, 41);
            txtSearchRole.Name = "txtSearchRole";
            txtSearchRole.Size = new Size(187, 23);
            txtSearchRole.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(88, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(556, 70);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(119, 23);
            btnChangePassword.TabIndex = 5;
            btnChangePassword.Text = "Thay đổi mật khẩu";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.Location = new Point(295, 70);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(117, 23);
            btnUpdateAccount.TabIndex = 6;
            btnUpdateAccount.Text = "Cập nhật tài khoản";
            btnUpdateAccount.UseVisualStyleBackColor = true;
            btnUpdateAccount.Click += btnUpdateAccount_Click;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(440, 70);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(97, 23);
            btnResetPassword.TabIndex = 7;
            btnResetPassword.Text = "Reset mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(178, 70);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(100, 23);
            btnAddAccount.TabIndex = 8;
            btnAddAccount.Text = "Thêm tài khoản";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // lvwAccount
            // 
            lvwAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwAccount.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lvwAccount.ContextMenuStrip = contextMenuStrip1;
            lvwAccount.FullRowSelect = true;
            lvwAccount.GridLines = true;
            lvwAccount.Location = new Point(12, 114);
            lvwAccount.Name = "lvwAccount";
            lvwAccount.Size = new Size(711, 324);
            lvwAccount.TabIndex = 9;
            lvwAccount.UseCompatibleStateImageBehavior = false;
            lvwAccount.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên tài khoản";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên đầy đủ";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Email";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Số điện thoại";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Mật khẩu";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Ngày tạo";
            columnHeader6.Width = 100;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsmDeleteAccount, tsmViewRoles });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(192, 48);
            // 
            // tsmDeleteAccount
            // 
            tsmDeleteAccount.Name = "tsmDeleteAccount";
            tsmDeleteAccount.Size = new Size(191, 22);
            tsmDeleteAccount.Text = "Xóa tài khoản";
            tsmDeleteAccount.Click += tsmDeleteAccount_Click;
            // 
            // tsmViewRoles
            // 
            tsmViewRoles.Name = "tsmViewRoles";
            tsmViewRoles.Size = new Size(191, 22);
            tsmViewRoles.Text = "Xem danh sách vai trò";
            tsmViewRoles.Click += tsmViewRoles_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 96);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 10;
            label3.Text = "Danh sách tài khoản";
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 450);
            Controls.Add(label3);
            Controls.Add(lvwAccount);
            Controls.Add(btnAddAccount);
            Controls.Add(btnResetPassword);
            Controls.Add(btnUpdateAccount);
            Controls.Add(btnChangePassword);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchRole);
            Controls.Add(txtSearchUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AccountForm";
            Text = "Quản lý tài khoản";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSearchUserName;
        private TextBox txtSearchRole;
        private Button btnSearch;
        private Button btnChangePassword;
        private Button btnUpdateAccount;
        private Button btnResetPassword;
        private Button btnAddAccount;
        private ListView lvwAccount;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsmDeleteAccount;
        private ToolStripMenuItem tsmViewRoles;
    }
}