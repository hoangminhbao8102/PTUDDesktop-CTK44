namespace RestaurantManagementProject
{
    partial class frmPhanQuyen
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
            cmdAssign = new Button();
            cmdDelete = new Button();
            cmdUpdate = new Button();
            cmdAdd = new Button();
            cmdClear = new Button();
            chkActive = new CheckBox();
            cmbRoles = new ComboBox();
            txtAccountName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpRight = new GroupBox();
            lsvUsers = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            cmdExit = new Button();
            lblStatistic = new Label();
            grpLeft.SuspendLayout();
            grpRight.SuspendLayout();
            SuspendLayout();
            // 
            // grpLeft
            // 
            grpLeft.Controls.Add(cmdAssign);
            grpLeft.Controls.Add(cmdDelete);
            grpLeft.Controls.Add(cmdUpdate);
            grpLeft.Controls.Add(cmdAdd);
            grpLeft.Controls.Add(cmdClear);
            grpLeft.Controls.Add(chkActive);
            grpLeft.Controls.Add(cmbRoles);
            grpLeft.Controls.Add(txtAccountName);
            grpLeft.Controls.Add(label3);
            grpLeft.Controls.Add(label2);
            grpLeft.Controls.Add(label1);
            grpLeft.Location = new Point(12, 12);
            grpLeft.Name = "grpLeft";
            grpLeft.Size = new Size(414, 159);
            grpLeft.TabIndex = 0;
            grpLeft.TabStop = false;
            grpLeft.Text = "Chức năng";
            // 
            // cmdAssign
            // 
            cmdAssign.Location = new Point(330, 112);
            cmdAssign.Name = "cmdAssign";
            cmdAssign.Size = new Size(75, 23);
            cmdAssign.TabIndex = 11;
            cmdAssign.Text = "Gán quyền";
            cmdAssign.UseVisualStyleBackColor = true;
            cmdAssign.Click += cmdAssign_Click;
            // 
            // cmdDelete
            // 
            cmdDelete.Location = new Point(249, 112);
            cmdDelete.Name = "cmdDelete";
            cmdDelete.Size = new Size(75, 23);
            cmdDelete.TabIndex = 10;
            cmdDelete.Text = "Xóa";
            cmdDelete.UseVisualStyleBackColor = true;
            cmdDelete.Click += cmdDelete_Click;
            // 
            // cmdUpdate
            // 
            cmdUpdate.Location = new Point(168, 112);
            cmdUpdate.Name = "cmdUpdate";
            cmdUpdate.Size = new Size(75, 23);
            cmdUpdate.TabIndex = 9;
            cmdUpdate.Text = "Sửa";
            cmdUpdate.UseVisualStyleBackColor = true;
            cmdUpdate.Click += cmdUpdate_Click;
            // 
            // cmdAdd
            // 
            cmdAdd.Location = new Point(87, 112);
            cmdAdd.Name = "cmdAdd";
            cmdAdd.Size = new Size(75, 23);
            cmdAdd.TabIndex = 8;
            cmdAdd.Text = "Thêm";
            cmdAdd.UseVisualStyleBackColor = true;
            cmdAdd.Click += cmdAdd_Click;
            // 
            // cmdClear
            // 
            cmdClear.Location = new Point(6, 112);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(75, 23);
            cmdClear.TabIndex = 7;
            cmdClear.Text = "Nhập lại";
            cmdClear.UseVisualStyleBackColor = true;
            cmdClear.Click += cmdClear_Click;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(90, 87);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(83, 19);
            chkActive.TabIndex = 5;
            chkActive.Text = "Hoạt động";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(90, 58);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(315, 23);
            cmbRoles.TabIndex = 4;
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(90, 29);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(315, 23);
            txtAccountName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 87);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Trạng thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Chọn quyền";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoản";
            // 
            // grpRight
            // 
            grpRight.Controls.Add(lsvUsers);
            grpRight.Location = new Point(432, 12);
            grpRight.Name = "grpRight";
            grpRight.Size = new Size(472, 132);
            grpRight.TabIndex = 1;
            grpRight.TabStop = false;
            grpRight.Text = "Danh sách phân quyền";
            // 
            // lsvUsers
            // 
            lsvUsers.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvUsers.FullRowSelect = true;
            lsvUsers.GridLines = true;
            lsvUsers.Location = new Point(6, 22);
            lsvUsers.MultiSelect = false;
            lsvUsers.Name = "lsvUsers";
            lsvUsers.Size = new Size(455, 97);
            lsvUsers.TabIndex = 0;
            lsvUsers.UseCompatibleStateImageBehavior = false;
            lsvUsers.View = View.Details;
            lsvUsers.Click += lsvUsers_Click;
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
            columnHeader3.Text = "Vai trò";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Trạng thái";
            columnHeader4.Width = 100;
            // 
            // cmdExit
            // 
            cmdExit.Location = new Point(818, 150);
            cmdExit.Name = "cmdExit";
            cmdExit.Size = new Size(75, 23);
            cmdExit.TabIndex = 12;
            cmdExit.Text = "Thoát";
            cmdExit.UseVisualStyleBackColor = true;
            cmdExit.Click += cmdExit_Click;
            // 
            // lblStatistic
            // 
            lblStatistic.AutoSize = true;
            lblStatistic.Location = new Point(438, 154);
            lblStatistic.Name = "lblStatistic";
            lblStatistic.Size = new Size(57, 15);
            lblStatistic.TabIndex = 13;
            lblStatistic.Text = "Thống kê";
            // 
            // frmPhanQuyen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 177);
            Controls.Add(lblStatistic);
            Controls.Add(cmdExit);
            Controls.Add(grpRight);
            Controls.Add(grpLeft);
            Name = "frmPhanQuyen";
            Text = "THÊM - XOÁ - SỬA PHÂN QUYỀN";
            Load += frmPhanQuyen_Load;
            grpLeft.ResumeLayout(false);
            grpLeft.PerformLayout();
            grpRight.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpLeft;
        private ComboBox cmbRoles;
        private TextBox txtAccountName;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grpRight;
        private Button cmdAssign;
        private Button cmdDelete;
        private Button cmdUpdate;
        private Button cmdAdd;
        private Button cmdClear;
        private CheckBox chkActive;
        private Button cmdExit;
        private ListView lsvUsers;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label lblStatistic;
    }
}