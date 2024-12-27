namespace RestaurantManagementProject
{
    partial class frmTable
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
            cbbStatus = new ComboBox();
            txtCapacity = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpRight = new GroupBox();
            lsvTable = new ListView();
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
            grpLeft.Controls.Add(cmdDelete);
            grpLeft.Controls.Add(cmdUpdate);
            grpLeft.Controls.Add(cmdAdd);
            grpLeft.Controls.Add(cmdClear);
            grpLeft.Controls.Add(cbbStatus);
            grpLeft.Controls.Add(txtCapacity);
            grpLeft.Controls.Add(txtName);
            grpLeft.Controls.Add(label3);
            grpLeft.Controls.Add(label2);
            grpLeft.Controls.Add(label1);
            grpLeft.Location = new Point(12, 12);
            grpLeft.Name = "grpLeft";
            grpLeft.Size = new Size(327, 207);
            grpLeft.TabIndex = 0;
            grpLeft.TabStop = false;
            grpLeft.Text = "Chức năng";
            // 
            // cmdDelete
            // 
            cmdDelete.Location = new Point(243, 133);
            cmdDelete.Name = "cmdDelete";
            cmdDelete.Size = new Size(75, 23);
            cmdDelete.TabIndex = 11;
            cmdDelete.Text = "Xóa";
            cmdDelete.UseVisualStyleBackColor = true;
            cmdDelete.Click += cmdDelete_Click;
            // 
            // cmdUpdate
            // 
            cmdUpdate.Location = new Point(162, 133);
            cmdUpdate.Name = "cmdUpdate";
            cmdUpdate.Size = new Size(75, 23);
            cmdUpdate.TabIndex = 10;
            cmdUpdate.Text = "Sửa";
            cmdUpdate.UseVisualStyleBackColor = true;
            cmdUpdate.Click += cmdUpdate_Click;
            // 
            // cmdAdd
            // 
            cmdAdd.Location = new Point(81, 133);
            cmdAdd.Name = "cmdAdd";
            cmdAdd.Size = new Size(75, 23);
            cmdAdd.TabIndex = 9;
            cmdAdd.Text = "Thêm";
            cmdAdd.UseVisualStyleBackColor = true;
            cmdAdd.Click += cmdAdd_Click;
            // 
            // cmdClear
            // 
            cmdClear.Location = new Point(0, 133);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(75, 23);
            cmdClear.TabIndex = 8;
            cmdClear.Text = "Nhập lại";
            cmdClear.UseVisualStyleBackColor = true;
            cmdClear.Click += cmdClear_Click;
            // 
            // cbbStatus
            // 
            cbbStatus.FormattingEnabled = true;
            cbbStatus.Items.AddRange(new object[] { "Trống", "Đang sử dụng" });
            cbbStatus.Location = new Point(72, 75);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.Size = new Size(246, 23);
            cbbStatus.TabIndex = 5;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(72, 104);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(246, 23);
            txtCapacity.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(72, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(246, 23);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 107);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Số chỗ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Trạng thái";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 49);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên bàn";
            // 
            // grpRight
            // 
            grpRight.Controls.Add(lsvTable);
            grpRight.Location = new Point(345, 12);
            grpRight.Name = "grpRight";
            grpRight.Size = new Size(421, 178);
            grpRight.TabIndex = 1;
            grpRight.TabStop = false;
            grpRight.Text = "Danh sách bàn";
            // 
            // lsvTable
            // 
            lsvTable.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvTable.FullRowSelect = true;
            lsvTable.GridLines = true;
            lsvTable.Location = new Point(6, 22);
            lsvTable.Name = "lsvTable";
            lsvTable.Size = new Size(404, 144);
            lsvTable.TabIndex = 0;
            lsvTable.UseCompatibleStateImageBehavior = false;
            lsvTable.View = View.Details;
            lsvTable.Click += lsvTable_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên bàn";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Trạng thái";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Số chỗ";
            columnHeader4.Width = 100;
            // 
            // cmdExit
            // 
            cmdExit.Location = new Point(669, 196);
            cmdExit.Name = "cmdExit";
            cmdExit.Size = new Size(75, 23);
            cmdExit.TabIndex = 2;
            cmdExit.Text = "Thoát";
            cmdExit.UseVisualStyleBackColor = true;
            cmdExit.Click += cmdExit_Click;
            // 
            // lblStatistic
            // 
            lblStatistic.AutoSize = true;
            lblStatistic.Location = new Point(366, 200);
            lblStatistic.Name = "lblStatistic";
            lblStatistic.Size = new Size(57, 15);
            lblStatistic.TabIndex = 3;
            lblStatistic.Text = "Thống kê";
            // 
            // frmTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 228);
            Controls.Add(lblStatistic);
            Controls.Add(cmdExit);
            Controls.Add(grpRight);
            Controls.Add(grpLeft);
            Name = "frmTable";
            Text = "Quản lý bàn";
            Load += frmTable_Load;
            grpLeft.ResumeLayout(false);
            grpLeft.PerformLayout();
            grpRight.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpLeft;
        private Label label1;
        private GroupBox grpRight;
        private ComboBox cbbStatus;
        private TextBox txtCapacity;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Button cmdDelete;
        private Button cmdUpdate;
        private Button cmdAdd;
        private Button cmdClear;
        private ListView lsvTable;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button cmdExit;
        private Label lblStatistic;
    }
}