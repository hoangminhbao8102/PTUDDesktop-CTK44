namespace Lab09_Entity_Framework
{
    partial class AccountManagementForm
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
            listViewAccounts = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnAddAccount = new Button();
            btnEditAccount = new Button();
            btnDeleteAccount = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Danh sách tài khoản";
            // 
            // listViewAccounts
            // 
            listViewAccounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewAccounts.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewAccounts.FullRowSelect = true;
            listViewAccounts.GridLines = true;
            listViewAccounts.Location = new Point(12, 27);
            listViewAccounts.Name = "listViewAccounts";
            listViewAccounts.Size = new Size(606, 408);
            listViewAccounts.TabIndex = 1;
            listViewAccounts.UseCompatibleStateImageBehavior = false;
            listViewAccounts.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên tài khoản";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ho tên";
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
            columnHeader5.Text = "Ngày tạo";
            columnHeader5.Width = 100;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(105, 441);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(104, 23);
            btnAddAccount.TabIndex = 2;
            btnAddAccount.Text = "Thêm tài khoản";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(250, 441);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(117, 23);
            btnEditAccount.TabIndex = 3;
            btnEditAccount.Text = "Cập nhật tài khoản";
            btnEditAccount.UseVisualStyleBackColor = true;
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(403, 441);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(104, 23);
            btnDeleteAccount.TabIndex = 4;
            btnDeleteAccount.Text = "Xóa tài khoản";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // AccountManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 476);
            Controls.Add(btnDeleteAccount);
            Controls.Add(btnEditAccount);
            Controls.Add(btnAddAccount);
            Controls.Add(listViewAccounts);
            Controls.Add(label1);
            Name = "AccountManagementForm";
            Text = "Quản trị tài khoản";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listViewAccounts;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnAddAccount;
        private Button btnEditAccount;
        private Button btnDeleteAccount;
    }
}