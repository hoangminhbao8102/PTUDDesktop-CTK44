namespace RestaurantManagementProject
{
    partial class frmCategory
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
            groupBox1 = new GroupBox();
            cmdDelete = new Button();
            cmdUpdate = new Button();
            cmdAdd = new Button();
            cmdClear = new Button();
            cbbType = new ComboBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            grpRight = new GroupBox();
            lsvCategory = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            cmdExit = new Button();
            lblStatistic = new Label();
            groupBox1.SuspendLayout();
            grpRight.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmdDelete);
            groupBox1.Controls.Add(cmdUpdate);
            groupBox1.Controls.Add(cmdAdd);
            groupBox1.Controls.Add(cmdClear);
            groupBox1.Controls.Add(cbbType);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 187);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // cmdDelete
            // 
            cmdDelete.Location = new Point(248, 107);
            cmdDelete.Name = "cmdDelete";
            cmdDelete.Size = new Size(75, 23);
            cmdDelete.TabIndex = 7;
            cmdDelete.Text = "Xóa";
            cmdDelete.UseVisualStyleBackColor = true;
            cmdDelete.Click += cmdDelete_Click;
            // 
            // cmdUpdate
            // 
            cmdUpdate.Location = new Point(167, 107);
            cmdUpdate.Name = "cmdUpdate";
            cmdUpdate.Size = new Size(75, 23);
            cmdUpdate.TabIndex = 6;
            cmdUpdate.Text = "Sửa";
            cmdUpdate.UseVisualStyleBackColor = true;
            cmdUpdate.Click += cmdUpdate_Click;
            // 
            // cmdAdd
            // 
            cmdAdd.Location = new Point(86, 107);
            cmdAdd.Name = "cmdAdd";
            cmdAdd.Size = new Size(75, 23);
            cmdAdd.TabIndex = 5;
            cmdAdd.Text = "Thêm";
            cmdAdd.UseVisualStyleBackColor = true;
            cmdAdd.Click += cmdAdd_Click;
            // 
            // cmdClear
            // 
            cmdClear.Location = new Point(5, 107);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(75, 23);
            cmdClear.TabIndex = 4;
            cmdClear.Text = "Nhập lại";
            cmdClear.UseVisualStyleBackColor = true;
            cmdClear.Click += cmdClear_Click;
            // 
            // cbbType
            // 
            cbbType.FormattingEnabled = true;
            cbbType.Items.AddRange(new object[] { "0 - Đồ uống", "1 - Thức ăn" });
            cbbType.Location = new Point(109, 78);
            cbbType.Name = "cbbType";
            cbbType.Size = new Size(214, 23);
            cbbType.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(109, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(214, 23);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 81);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Loại danh mục:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 52);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên danh mục:";
            // 
            // grpRight
            // 
            grpRight.Controls.Add(lsvCategory);
            grpRight.Location = new Point(351, 12);
            grpRight.Name = "grpRight";
            grpRight.Size = new Size(421, 158);
            grpRight.TabIndex = 1;
            grpRight.TabStop = false;
            grpRight.Text = "Danh sách danh mục";
            // 
            // lsvCategory
            // 
            lsvCategory.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lsvCategory.FullRowSelect = true;
            lsvCategory.GridLines = true;
            lsvCategory.Location = new Point(6, 22);
            lsvCategory.Name = "lsvCategory";
            lsvCategory.Size = new Size(404, 118);
            lsvCategory.TabIndex = 0;
            lsvCategory.UseCompatibleStateImageBehavior = false;
            lsvCategory.View = View.Details;
            lsvCategory.Click += lsvCategory_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên danh mục";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Loại danh mục";
            columnHeader3.Width = 150;
            // 
            // cmdExit
            // 
            cmdExit.Location = new Point(676, 176);
            cmdExit.Name = "cmdExit";
            cmdExit.Size = new Size(75, 23);
            cmdExit.TabIndex = 8;
            cmdExit.Text = "Thoát";
            cmdExit.UseVisualStyleBackColor = true;
            cmdExit.Click += cmdExit_Click;
            // 
            // lblStatistic
            // 
            lblStatistic.AutoSize = true;
            lblStatistic.Location = new Point(357, 180);
            lblStatistic.Name = "lblStatistic";
            lblStatistic.Size = new Size(57, 15);
            lblStatistic.TabIndex = 9;
            lblStatistic.Text = "Thống kê";
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 211);
            Controls.Add(lblStatistic);
            Controls.Add(cmdExit);
            Controls.Add(grpRight);
            Controls.Add(groupBox1);
            Name = "frmCategory";
            Text = "QUẢN LÝ DANH MỤC";
            Load += frmCategory_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpRight.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button cmdDelete;
        private Button cmdUpdate;
        private Button cmdAdd;
        private Button cmdClear;
        private ComboBox cbbType;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private GroupBox grpRight;
        private Button cmdExit;
        private ListView lsvCategory;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label lblStatistic;
    }
}