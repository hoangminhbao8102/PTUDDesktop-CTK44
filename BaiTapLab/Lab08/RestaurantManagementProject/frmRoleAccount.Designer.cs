namespace RestaurantManagementProject
{
    partial class frmRoleAccount
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
            chkActivatedNo = new CheckBox();
            chkActivatedYes = new CheckBox();
            cmdDelete = new Button();
            cmdUpdate = new Button();
            cmdAdd = new Button();
            cmdClear = new Button();
            cbbRole = new ComboBox();
            txtNotes = new TextBox();
            txtAccountName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpRight = new GroupBox();
            lsvRoleAccount = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            cmdExit = new Button();
            lblStatistic = new Label();
            grpLeft.SuspendLayout();
            grpRight.SuspendLayout();
            SuspendLayout();
            // 
            // grpLeft
            // 
            grpLeft.Controls.Add(chkActivatedNo);
            grpLeft.Controls.Add(chkActivatedYes);
            grpLeft.Controls.Add(cmdDelete);
            grpLeft.Controls.Add(cmdUpdate);
            grpLeft.Controls.Add(cmdAdd);
            grpLeft.Controls.Add(cmdClear);
            grpLeft.Controls.Add(cbbRole);
            grpLeft.Controls.Add(txtNotes);
            grpLeft.Controls.Add(txtAccountName);
            grpLeft.Controls.Add(label4);
            grpLeft.Controls.Add(label3);
            grpLeft.Controls.Add(label2);
            grpLeft.Controls.Add(label1);
            grpLeft.Location = new Point(12, 12);
            grpLeft.Name = "grpLeft";
            grpLeft.Size = new Size(332, 171);
            grpLeft.TabIndex = 0;
            grpLeft.TabStop = false;
            grpLeft.Text = "Chức năng";
            // 
            // chkActivatedNo
            // 
            chkActivatedNo.AutoSize = true;
            chkActivatedNo.Location = new Point(168, 83);
            chkActivatedNo.Name = "chkActivatedNo";
            chkActivatedNo.Size = new Size(42, 19);
            chkActivatedNo.TabIndex = 14;
            chkActivatedNo.Text = "No";
            chkActivatedNo.UseVisualStyleBackColor = true;
            // 
            // chkActivatedYes
            // 
            chkActivatedYes.AutoSize = true;
            chkActivatedYes.Location = new Point(103, 82);
            chkActivatedYes.Name = "chkActivatedYes";
            chkActivatedYes.Size = new Size(43, 19);
            chkActivatedYes.TabIndex = 13;
            chkActivatedYes.Text = "Yes";
            chkActivatedYes.UseVisualStyleBackColor = true;
            // 
            // cmdDelete
            // 
            cmdDelete.Location = new Point(249, 138);
            cmdDelete.Name = "cmdDelete";
            cmdDelete.Size = new Size(75, 23);
            cmdDelete.TabIndex = 12;
            cmdDelete.Text = "Xóa";
            cmdDelete.UseVisualStyleBackColor = true;
            cmdDelete.Click += cmdDelete_Click;
            // 
            // cmdUpdate
            // 
            cmdUpdate.Location = new Point(168, 138);
            cmdUpdate.Name = "cmdUpdate";
            cmdUpdate.Size = new Size(75, 23);
            cmdUpdate.TabIndex = 11;
            cmdUpdate.Text = "Sửa";
            cmdUpdate.UseVisualStyleBackColor = true;
            cmdUpdate.Click += cmdUpdate_Click;
            // 
            // cmdAdd
            // 
            cmdAdd.Location = new Point(87, 138);
            cmdAdd.Name = "cmdAdd";
            cmdAdd.Size = new Size(75, 23);
            cmdAdd.TabIndex = 10;
            cmdAdd.Text = "Thêm";
            cmdAdd.UseVisualStyleBackColor = true;
            cmdAdd.Click += cmdAdd_Click;
            // 
            // cmdClear
            // 
            cmdClear.Location = new Point(6, 138);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(75, 23);
            cmdClear.TabIndex = 9;
            cmdClear.Text = "Nhập lại";
            cmdClear.UseVisualStyleBackColor = true;
            cmdClear.Click += cmdClear_Click;
            // 
            // cbbRole
            // 
            cbbRole.FormattingEnabled = true;
            cbbRole.Items.AddRange(new object[] { "True", "False" });
            cbbRole.Location = new Point(103, 51);
            cbbRole.Name = "cbbRole";
            cbbRole.Size = new Size(222, 23);
            cbbRole.TabIndex = 8;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(102, 109);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(222, 23);
            txtNotes.TabIndex = 7;
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(102, 22);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(222, 23);
            txtAccountName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 112);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "Notes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Actived:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Role ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Account Name:";
            // 
            // grpRight
            // 
            grpRight.Controls.Add(lsvRoleAccount);
            grpRight.Location = new Point(350, 15);
            grpRight.Name = "grpRight";
            grpRight.Size = new Size(520, 129);
            grpRight.TabIndex = 1;
            grpRight.TabStop = false;
            grpRight.Text = "Danh mục RoleAccount";
            // 
            // lsvRoleAccount
            // 
            lsvRoleAccount.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lsvRoleAccount.FullRowSelect = true;
            lsvRoleAccount.GridLines = true;
            lsvRoleAccount.Location = new Point(6, 19);
            lsvRoleAccount.MultiSelect = false;
            lsvRoleAccount.Name = "lsvRoleAccount";
            lsvRoleAccount.Size = new Size(505, 97);
            lsvRoleAccount.TabIndex = 0;
            lsvRoleAccount.UseCompatibleStateImageBehavior = false;
            lsvRoleAccount.View = View.Details;
            lsvRoleAccount.Click += lsvRoleAccount_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Account Name";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Role ID";
            columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Actived";
            columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Notes";
            columnHeader5.Width = 200;
            // 
            // cmdExit
            // 
            cmdExit.Location = new Point(786, 150);
            cmdExit.Name = "cmdExit";
            cmdExit.Size = new Size(75, 23);
            cmdExit.TabIndex = 13;
            cmdExit.Text = "Thoát";
            cmdExit.UseVisualStyleBackColor = true;
            cmdExit.Click += cmdExit_Click;
            // 
            // lblStatistic
            // 
            lblStatistic.AutoSize = true;
            lblStatistic.Location = new Point(356, 154);
            lblStatistic.Name = "lblStatistic";
            lblStatistic.Size = new Size(57, 15);
            lblStatistic.TabIndex = 14;
            lblStatistic.Text = "Thống kê";
            // 
            // frmRoleAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 190);
            Controls.Add(lblStatistic);
            Controls.Add(cmdExit);
            Controls.Add(grpRight);
            Controls.Add(grpLeft);
            Name = "frmRoleAccount";
            Text = "THÊM - XÓA - SỬA BẢNG ROLE ACCOUNT";
            Load += frmRoleAccount_Load;
            grpLeft.ResumeLayout(false);
            grpLeft.PerformLayout();
            grpRight.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpLeft;
        private Button cmdDelete;
        private Button cmdUpdate;
        private Button cmdAdd;
        private Button cmdClear;
        private ComboBox cbbRole;
        private TextBox txtNotes;
        private TextBox txtAccountName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grpRight;
        private Button cmdExit;
        private ListView lsvRoleAccount;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label lblStatistic;
        private CheckBox chkActivatedYes;
        private CheckBox chkActivatedNo;
    }
}