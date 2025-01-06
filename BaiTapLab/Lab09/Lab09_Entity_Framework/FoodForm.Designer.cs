namespace Lab09_Entity_Framework
{
    partial class FoodForm
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
            txtName = new TextBox();
            txtUnit = new TextBox();
            txtPrice = new TextBox();
            txtNotes = new TextBox();
            label6 = new Label();
            cbCategory = new ComboBox();
            btnSearch = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnAddCategory = new Button();
            grpLeft = new GroupBox();
            txtId = new TextBox();
            label10 = new Label();
            grpRight = new GroupBox();
            txtCategoryType = new TextBox();
            txtCategoryName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            lvFood = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            txtSearch = new TextBox();
            label9 = new Label();
            grpLeft.SuspendLayout();
            grpRight.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 54);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên món ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 82);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Đơn vị tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 112);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Loại món ăn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 141);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 3;
            label4.Text = "Giá món ăn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 170);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 4;
            label5.Text = "Ghi chú";
            // 
            // txtName
            // 
            txtName.Location = new Point(85, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 23);
            txtName.TabIndex = 5;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(85, 80);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(239, 23);
            txtUnit.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(85, 138);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(239, 23);
            txtPrice.TabIndex = 7;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(85, 167);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(239, 23);
            txtNotes.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(284, 274);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 9;
            label6.Text = "Danh sách món ăn";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(85, 109);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(239, 23);
            cbCategory.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(502, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(70, 23);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(144, 196);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Lưu món ăn";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(235, 196);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(83, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Xóa món ăn";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(141, 138);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(130, 23);
            btnAddCategory.TabIndex = 14;
            btnAddCategory.Text = "Thêm nhóm món ăn";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // grpLeft
            // 
            grpLeft.Controls.Add(txtId);
            grpLeft.Controls.Add(label10);
            grpLeft.Controls.Add(label1);
            grpLeft.Controls.Add(label2);
            grpLeft.Controls.Add(label3);
            grpLeft.Controls.Add(btnDelete);
            grpLeft.Controls.Add(label4);
            grpLeft.Controls.Add(btnSave);
            grpLeft.Controls.Add(label5);
            grpLeft.Controls.Add(txtName);
            grpLeft.Controls.Add(cbCategory);
            grpLeft.Controls.Add(txtUnit);
            grpLeft.Controls.Add(txtPrice);
            grpLeft.Controls.Add(txtNotes);
            grpLeft.Location = new Point(12, 41);
            grpLeft.Name = "grpLeft";
            grpLeft.Size = new Size(330, 230);
            grpLeft.TabIndex = 15;
            grpLeft.TabStop = false;
            grpLeft.Text = "Tìm - Thêm - Sửa - Xóa món ăn";
            // 
            // txtId
            // 
            txtId.Location = new Point(85, 22);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 25);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 14;
            label10.Text = "Mã số";
            // 
            // grpRight
            // 
            grpRight.Controls.Add(txtCategoryType);
            grpRight.Controls.Add(txtCategoryName);
            grpRight.Controls.Add(label8);
            grpRight.Controls.Add(label7);
            grpRight.Controls.Add(btnAddCategory);
            grpRight.Location = new Point(348, 41);
            grpRight.Name = "grpRight";
            grpRight.Size = new Size(376, 230);
            grpRight.TabIndex = 16;
            grpRight.TabStop = false;
            grpRight.Text = "Thêm nhón món ăn";
            // 
            // txtCategoryType
            // 
            txtCategoryType.Location = new Point(120, 109);
            txtCategoryType.Name = "txtCategoryType";
            txtCategoryType.Size = new Size(250, 23);
            txtCategoryType.TabIndex = 16;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(120, 79);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(250, 23);
            txtCategoryName.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 112);
            label8.Name = "label8";
            label8.Size = new Size(108, 15);
            label8.TabIndex = 15;
            label8.Text = "Loại nhóm món ăn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 82);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 14;
            label7.Text = "Tên nhóm món ăn";
            // 
            // lvFood
            // 
            lvFood.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvFood.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lvFood.FullRowSelect = true;
            lvFood.GridLines = true;
            lvFood.Location = new Point(39, 292);
            lvFood.Name = "lvFood";
            lvFood.Size = new Size(663, 183);
            lvFood.TabIndex = 17;
            lvFood.UseCompatibleStateImageBehavior = false;
            lvFood.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên món ăn";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn vị tính";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Loại món ăn";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Giá";
            columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Ghi chú";
            columnHeader6.Width = 200;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(260, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(236, 23);
            txtSearch.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(131, 15);
            label9.Name = "label9";
            label9.Size = new Size(123, 15);
            label9.TabIndex = 19;
            label9.Text = "Nhập món ăn cần tìm";
            // 
            // FoodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 487);
            Controls.Add(label9);
            Controls.Add(txtSearch);
            Controls.Add(lvFood);
            Controls.Add(grpRight);
            Controls.Add(grpLeft);
            Controls.Add(label6);
            Controls.Add(btnSearch);
            Name = "FoodForm";
            Text = "Quản lý món ăn";
            grpLeft.ResumeLayout(false);
            grpLeft.PerformLayout();
            grpRight.ResumeLayout(false);
            grpRight.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtUnit;
        private TextBox txtPrice;
        private TextBox txtNotes;
        private Label label6;
        private ComboBox cbCategory;
        private Button btnSearch;
        private Button btnSave;
        private Button btnDelete;
        private Button btnAddCategory;
        private GroupBox grpLeft;
        private GroupBox grpRight;
        private TextBox txtCategoryType;
        private TextBox txtCategoryName;
        private Label label8;
        private Label label7;
        private ListView lvFood;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TextBox txtSearch;
        private Label label9;
        private TextBox txtId;
        private Label label10;
    }
}