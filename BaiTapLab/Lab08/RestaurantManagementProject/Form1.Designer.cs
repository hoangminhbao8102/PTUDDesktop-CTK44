namespace RestaurantManagementProject
{
    partial class frmFood
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpLeft = new GroupBox();
            cmdDelete = new Button();
            cmdUpdate = new Button();
            cmdAdd = new Button();
            cmdClear = new Button();
            txtNotes = new TextBox();
            cbbCategory = new ComboBox();
            txtPrice = new TextBox();
            txtUnit = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpRight = new GroupBox();
            lsvFood = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            cmdExit = new Button();
            lblStatistic = new Label();
            grpLeft.SuspendLayout();
            grpRight.SuspendLayout();
            SuspendLayout();
            // 
            // grpLeft
            // 
            grpLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpLeft.Controls.Add(cmdDelete);
            grpLeft.Controls.Add(cmdUpdate);
            grpLeft.Controls.Add(cmdAdd);
            grpLeft.Controls.Add(cmdClear);
            grpLeft.Controls.Add(txtNotes);
            grpLeft.Controls.Add(cbbCategory);
            grpLeft.Controls.Add(txtPrice);
            grpLeft.Controls.Add(txtUnit);
            grpLeft.Controls.Add(txtName);
            grpLeft.Controls.Add(label5);
            grpLeft.Controls.Add(label4);
            grpLeft.Controls.Add(label3);
            grpLeft.Controls.Add(label2);
            grpLeft.Controls.Add(label1);
            grpLeft.Location = new Point(12, 12);
            grpLeft.Name = "grpLeft";
            grpLeft.Size = new Size(330, 331);
            grpLeft.TabIndex = 0;
            grpLeft.TabStop = false;
            grpLeft.Text = "Chức năng";
            // 
            // cmdDelete
            // 
            cmdDelete.Anchor = AnchorStyles.Bottom;
            cmdDelete.Location = new Point(249, 296);
            cmdDelete.Name = "cmdDelete";
            cmdDelete.Size = new Size(75, 23);
            cmdDelete.TabIndex = 13;
            cmdDelete.Text = "Xóa";
            cmdDelete.UseVisualStyleBackColor = true;
            cmdDelete.Click += cmdDelete_Click;
            // 
            // cmdUpdate
            // 
            cmdUpdate.Anchor = AnchorStyles.Bottom;
            cmdUpdate.Location = new Point(168, 296);
            cmdUpdate.Name = "cmdUpdate";
            cmdUpdate.Size = new Size(75, 23);
            cmdUpdate.TabIndex = 12;
            cmdUpdate.Text = "Sửa";
            cmdUpdate.UseVisualStyleBackColor = true;
            cmdUpdate.Click += cmdUpdate_Click;
            // 
            // cmdAdd
            // 
            cmdAdd.Anchor = AnchorStyles.Bottom;
            cmdAdd.Location = new Point(87, 296);
            cmdAdd.Name = "cmdAdd";
            cmdAdd.Size = new Size(75, 23);
            cmdAdd.TabIndex = 11;
            cmdAdd.Text = "Thêm";
            cmdAdd.UseVisualStyleBackColor = true;
            cmdAdd.Click += cmdAdd_Click;
            // 
            // cmdClear
            // 
            cmdClear.Anchor = AnchorStyles.Bottom;
            cmdClear.Location = new Point(6, 296);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(75, 23);
            cmdClear.TabIndex = 10;
            cmdClear.Text = "Nhập lại";
            cmdClear.UseVisualStyleBackColor = true;
            cmdClear.Click += cmdClear_Click;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(99, 161);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(225, 129);
            txtNotes.TabIndex = 9;
            // 
            // cbbCategory
            // 
            cbbCategory.FormattingEnabled = true;
            cbbCategory.Location = new Point(168, 122);
            cbbCategory.Name = "cbbCategory";
            cbbCategory.Size = new Size(157, 23);
            cbbCategory.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(224, 88);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 7;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(224, 54);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(100, 23);
            txtUnit.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(122, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(202, 23);
            txtName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 164);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 4;
            label5.Text = "Ghi chú";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 125);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 3;
            label4.Text = "Loại thực phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Đơn giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 57);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Đơn vị tính";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên thực phẩm";
            // 
            // grpRight
            // 
            grpRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpRight.Controls.Add(lsvFood);
            grpRight.Location = new Point(348, 12);
            grpRight.Name = "grpRight";
            grpRight.Size = new Size(617, 302);
            grpRight.TabIndex = 1;
            grpRight.TabStop = false;
            grpRight.Text = "Danh mục thức ăn";
            // 
            // lsvFood
            // 
            lsvFood.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsvFood.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lsvFood.FullRowSelect = true;
            lsvFood.GridLines = true;
            lsvFood.Location = new Point(6, 22);
            lsvFood.MultiSelect = false;
            lsvFood.Name = "lsvFood";
            lsvFood.Size = new Size(605, 268);
            lsvFood.TabIndex = 0;
            lsvFood.UseCompatibleStateImageBehavior = false;
            lsvFood.View = View.Details;
            lsvFood.Click += lsvFood_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên thực phẩm";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ĐVT";
            columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Giá";
            columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Loại thực phẩm";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Ghi chú";
            columnHeader6.Width = 200;
            // 
            // cmdExit
            // 
            cmdExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cmdExit.Location = new Point(884, 320);
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
            lblStatistic.Location = new Point(354, 324);
            lblStatistic.Name = "lblStatistic";
            lblStatistic.Size = new Size(57, 15);
            lblStatistic.TabIndex = 3;
            lblStatistic.Text = "Thống kê";
            // 
            // frmFood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 355);
            Controls.Add(lblStatistic);
            Controls.Add(cmdExit);
            Controls.Add(grpRight);
            Controls.Add(grpLeft);
            Name = "frmFood";
            Text = "THÊM - XOÁ - SỬA BẢNG FOOD";
            Load += frmFood_Load;
            grpLeft.ResumeLayout(false);
            grpLeft.PerformLayout();
            grpRight.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpLeft;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grpRight;
        private Button cmdUpdate;
        private Button cmdAdd;
        private Button cmdClear;
        private TextBox txtNotes;
        private ComboBox cbbCategory;
        private TextBox txtPrice;
        private TextBox txtUnit;
        private TextBox txtName;
        private Button cmdDelete;
        private ListView lsvFood;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button cmdExit;
        private Label lblStatistic;
    }
}
