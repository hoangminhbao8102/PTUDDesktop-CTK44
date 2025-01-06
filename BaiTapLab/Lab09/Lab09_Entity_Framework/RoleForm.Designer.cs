namespace Lab09_Entity_Framework
{
    partial class RoleForm
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
            btnLoad = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnViewAccounts = new Button();
            lvRoles = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lvAccounts = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtRoleName = new TextBox();
            txtPath = new TextBox();
            txtNotes = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 125);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Danh sách vai trò";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 125);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 1;
            label2.Text = "Danh sách tài khoản";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(21, 99);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(137, 23);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Hiển thị";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(164, 99);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(160, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(330, 99);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(351, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnViewAccounts
            // 
            btnViewAccounts.Location = new Point(687, 99);
            btnViewAccounts.Name = "btnViewAccounts";
            btnViewAccounts.Size = new Size(374, 23);
            btnViewAccounts.TabIndex = 5;
            btnViewAccounts.Text = "Xem danh sách";
            btnViewAccounts.UseVisualStyleBackColor = true;
            btnViewAccounts.Click += btnViewAccounts_Click;
            // 
            // lvRoles
            // 
            lvRoles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lvRoles.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvRoles.FullRowSelect = true;
            lvRoles.GridLines = true;
            lvRoles.Location = new Point(12, 143);
            lvRoles.Name = "lvRoles";
            lvRoles.Size = new Size(408, 295);
            lvRoles.TabIndex = 6;
            lvRoles.UseCompatibleStateImageBehavior = false;
            lvRoles.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên vai trò";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đường dẫn";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ghi chú";
            columnHeader4.Width = 150;
            // 
            // lvAccounts
            // 
            lvAccounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvAccounts.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            lvAccounts.FullRowSelect = true;
            lvAccounts.GridLines = true;
            lvAccounts.Location = new Point(429, 143);
            lvAccounts.Name = "lvAccounts";
            lvAccounts.Size = new Size(707, 295);
            lvAccounts.TabIndex = 7;
            lvAccounts.UseCompatibleStateImageBehavior = false;
            lvAccounts.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tên tài khoản";
            columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tên đầy đủ";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Email";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Số điện thoại";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Ngày tạo";
            columnHeader9.Width = 175;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 20);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 8;
            label3.Text = "Tên vai trò";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 44);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 9;
            label4.Text = "Đường dẫn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 73);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 10;
            label5.Text = "Ghi chú";
            // 
            // txtRoleName
            // 
            txtRoleName.Location = new Point(80, 12);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(1010, 23);
            txtRoleName.TabIndex = 11;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(80, 41);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(1010, 23);
            txtPath.TabIndex = 12;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(80, 70);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(1010, 23);
            txtNotes.TabIndex = 13;
            // 
            // RoleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 450);
            Controls.Add(txtNotes);
            Controls.Add(txtPath);
            Controls.Add(txtRoleName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lvAccounts);
            Controls.Add(lvRoles);
            Controls.Add(btnViewAccounts);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RoleForm";
            Text = "Quản lý vai trò";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnLoad;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnViewAccounts;
        private ListView lvRoles;
        private ListView lvAccounts;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtRoleName;
        private TextBox txtPath;
        private TextBox txtNotes;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
    }
}