namespace RestaurantManagementProject
{
    partial class frmAccount
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
            grpLeft = new GroupBox();
            cmdDelete = new Button();
            cmdUpdate = new Button();
            cmdAdd = new Button();
            cmdClear = new Button();
            dtpDateCreated = new DateTimePicker();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            txtPassword = new TextBox();
            txtAccountName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpRight = new GroupBox();
            lsvAccount = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            lblStatistic = new Label();
            cmdExit = new Button();
            grpLeft.SuspendLayout();
            grpRight.SuspendLayout();
            SuspendLayout();
            // 
            // grpLeft
            // 
            grpLeft.Controls.Add(cmdDelete);
            grpLeft.Controls.Add(cmdUpdate);
            grpLeft.Controls.Add(cmdAdd);
            grpLeft.Controls.Add(cmdClear);
            grpLeft.Controls.Add(dtpDateCreated);
            grpLeft.Controls.Add(txtPhone);
            grpLeft.Controls.Add(txtEmail);
            grpLeft.Controls.Add(txtFullName);
            grpLeft.Controls.Add(txtPassword);
            grpLeft.Controls.Add(txtAccountName);
            grpLeft.Controls.Add(label6);
            grpLeft.Controls.Add(label5);
            grpLeft.Controls.Add(label4);
            grpLeft.Controls.Add(label3);
            grpLeft.Controls.Add(label2);
            grpLeft.Controls.Add(label1);
            grpLeft.Location = new Point(12, 12);
            grpLeft.Name = "grpLeft";
            grpLeft.Size = new Size(331, 226);
            grpLeft.TabIndex = 0;
            grpLeft.TabStop = false;
            grpLeft.Text = "Chức năng";
            // 
            // cmdDelete
            // 
            cmdDelete.Location = new Point(250, 196);
            cmdDelete.Name = "cmdDelete";
            cmdDelete.Size = new Size(75, 23);
            cmdDelete.TabIndex = 27;
            cmdDelete.Text = "Xóa";
            cmdDelete.UseVisualStyleBackColor = true;
            cmdDelete.Click += cmdDelete_Click;
            // 
            // cmdUpdate
            // 
            cmdUpdate.Location = new Point(169, 196);
            cmdUpdate.Name = "cmdUpdate";
            cmdUpdate.Size = new Size(75, 23);
            cmdUpdate.TabIndex = 26;
            cmdUpdate.Text = "Sửa";
            cmdUpdate.UseVisualStyleBackColor = true;
            cmdUpdate.Click += cmdUpdate_Click;
            // 
            // cmdAdd
            // 
            cmdAdd.Location = new Point(88, 196);
            cmdAdd.Name = "cmdAdd";
            cmdAdd.Size = new Size(75, 23);
            cmdAdd.TabIndex = 25;
            cmdAdd.Text = "Thêm";
            cmdAdd.UseVisualStyleBackColor = true;
            cmdAdd.Click += cmdAdd_Click;
            // 
            // cmdClear
            // 
            cmdClear.Location = new Point(7, 196);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(75, 23);
            cmdClear.TabIndex = 24;
            cmdClear.Text = "Nhập lại";
            cmdClear.UseVisualStyleBackColor = true;
            cmdClear.Click += cmdClear_Click;
            // 
            // dtpDateCreated
            // 
            dtpDateCreated.Location = new Point(88, 167);
            dtpDateCreated.Name = "dtpDateCreated";
            dtpDateCreated.Size = new Size(237, 23);
            dtpDateCreated.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(88, 138);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(237, 23);
            txtPhone.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(88, 109);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(88, 80);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(237, 23);
            txtFullName.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(88, 51);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(237, 23);
            txtPassword.TabIndex = 7;
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(88, 22);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(237, 23);
            txtAccountName.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 173);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "Ngày tạo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 141);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 4;
            label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 112);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoản";
            // 
            // grpRight
            // 
            grpRight.Controls.Add(lsvAccount);
            grpRight.Location = new Point(349, 15);
            grpRight.Name = "grpRight";
            grpRight.Size = new Size(873, 187);
            grpRight.TabIndex = 1;
            grpRight.TabStop = false;
            grpRight.Text = "Danh sách tài khoản";
            // 
            // lsvAccount
            // 
            lsvAccount.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lsvAccount.FullRowSelect = true;
            lsvAccount.GridLines = true;
            lsvAccount.Location = new Point(6, 22);
            lsvAccount.Name = "lsvAccount";
            lsvAccount.Size = new Size(855, 159);
            lsvAccount.TabIndex = 0;
            lsvAccount.UseCompatibleStateImageBehavior = false;
            lsvAccount.View = View.Details;
            lsvAccount.Click += lsvAccount_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên tài khoản";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mật khẩu";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Họ tên";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Email";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Số điện thoại";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Ngày tạo";
            columnHeader7.Width = 100;
            // 
            // lblStatistic
            // 
            lblStatistic.AutoSize = true;
            lblStatistic.Location = new Point(359, 212);
            lblStatistic.Name = "lblStatistic";
            lblStatistic.Size = new Size(57, 15);
            lblStatistic.TabIndex = 6;
            lblStatistic.Text = "Thống kê";
            // 
            // cmdExit
            // 
            cmdExit.Location = new Point(1135, 208);
            cmdExit.Name = "cmdExit";
            cmdExit.Size = new Size(75, 23);
            cmdExit.TabIndex = 3;
            cmdExit.Text = "Thoát";
            cmdExit.UseVisualStyleBackColor = true;
            cmdExit.Click += cmdExit_Click;
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 246);
            Controls.Add(cmdExit);
            Controls.Add(lblStatistic);
            Controls.Add(grpRight);
            Controls.Add(grpLeft);
            Name = "frmAccount";
            Text = "QUẢN LÝ TÀI KHOẢN";
            Load += frmAccount_Load;
            grpLeft.ResumeLayout(false);
            grpLeft.PerformLayout();
            grpRight.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpLeft;
        private GroupBox grpRight;
        private DateTimePicker dtpDateCreated;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private TextBox txtPassword;
        private TextBox txtAccountName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblStatistic;
        private Button cmdDelete;
        private Button cmdUpdate;
        private Button cmdAdd;
        private Button cmdClear;
        private ListView lsvAccount;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button cmdExit;
    }
}