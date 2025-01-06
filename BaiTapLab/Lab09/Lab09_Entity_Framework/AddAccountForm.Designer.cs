namespace Lab09_Entity_Framework
{
    partial class AddAccountForm
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
            label6 = new Label();
            txtAccountName = new TextBox();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            comboRole = new ComboBox();
            btnAddAccount = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên đầy đủ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 102);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 131);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 160);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 5;
            label6.Text = "Vai trò";
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(96, 12);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(172, 23);
            txtAccountName.TabIndex = 6;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(96, 41);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(172, 23);
            txtFullName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(96, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(172, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(96, 99);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(172, 23);
            txtPhone.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(96, 128);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(172, 23);
            txtPassword.TabIndex = 10;
            // 
            // comboRole
            // 
            comboRole.FormattingEnabled = true;
            comboRole.Location = new Point(96, 157);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(172, 23);
            comboRole.TabIndex = 11;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddAccount.Location = new Point(80, 186);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(103, 23);
            btnAddAccount.TabIndex = 12;
            btnAddAccount.Text = "Thêm tài khoản";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(189, 186);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Thoát";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddAccountForm
            // 
            AcceptButton = btnAddAccount;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(280, 221);
            Controls.Add(btnCancel);
            Controls.Add(btnAddAccount);
            Controls.Add(comboRole);
            Controls.Add(txtPassword);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(txtAccountName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddAccountForm";
            Text = "Thêm tài khoản";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAccountName;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private ComboBox comboRole;
        private Button btnAddAccount;
        private Button btnCancel;
    }
}