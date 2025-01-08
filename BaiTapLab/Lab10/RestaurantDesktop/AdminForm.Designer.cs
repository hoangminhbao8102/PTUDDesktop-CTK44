namespace RestaurantDesktop
{
    partial class AdminForm
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
            grpCategory = new GroupBox();
            btnDeleteCategory = new Button();
            btnEditCategory = new Button();
            btnAddCategory = new Button();
            cbbCategoryType = new ComboBox();
            txtCategoryName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            grpFood = new GroupBox();
            cbbCategory = new ComboBox();
            txtNotes = new TextBox();
            txtPrice = new TextBox();
            txtUnit = new TextBox();
            txtFoodName = new TextBox();
            btnDeleteFood = new Button();
            label7 = new Label();
            btnEditFood = new Button();
            label6 = new Label();
            btnAddFood = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            label9 = new Label();
            lvCategories = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lvFoods = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            grpCategory.SuspendLayout();
            grpFood.SuspendLayout();
            SuspendLayout();
            // 
            // grpCategory
            // 
            grpCategory.Controls.Add(btnDeleteCategory);
            grpCategory.Controls.Add(btnEditCategory);
            grpCategory.Controls.Add(btnAddCategory);
            grpCategory.Controls.Add(cbbCategoryType);
            grpCategory.Controls.Add(txtCategoryName);
            grpCategory.Controls.Add(label2);
            grpCategory.Controls.Add(label1);
            grpCategory.Location = new Point(12, 12);
            grpCategory.Name = "grpCategory";
            grpCategory.Size = new Size(304, 207);
            grpCategory.TabIndex = 0;
            grpCategory.TabStop = false;
            grpCategory.Text = "Danh mục";
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(199, 115);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(47, 23);
            btnDeleteCategory.TabIndex = 6;
            btnDeleteCategory.Text = "Xóa";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(134, 115);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(47, 23);
            btnEditCategory.TabIndex = 5;
            btnEditCategory.Text = "Sửa";
            btnEditCategory.UseVisualStyleBackColor = true;
            btnEditCategory.Click += btnEditCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(68, 115);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(47, 23);
            btnAddCategory.TabIndex = 4;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // cbbCategoryType
            // 
            cbbCategoryType.FormattingEnabled = true;
            cbbCategoryType.Location = new Point(98, 86);
            cbbCategoryType.Name = "cbbCategoryType";
            cbbCategoryType.Size = new Size(200, 23);
            cbbCategoryType.TabIndex = 3;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(98, 57);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(200, 23);
            txtCategoryName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 89);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Loại danh mục";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 60);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên danh mục";
            // 
            // grpFood
            // 
            grpFood.Controls.Add(cbbCategory);
            grpFood.Controls.Add(txtNotes);
            grpFood.Controls.Add(txtPrice);
            grpFood.Controls.Add(txtUnit);
            grpFood.Controls.Add(txtFoodName);
            grpFood.Controls.Add(btnDeleteFood);
            grpFood.Controls.Add(label7);
            grpFood.Controls.Add(btnEditFood);
            grpFood.Controls.Add(label6);
            grpFood.Controls.Add(btnAddFood);
            grpFood.Controls.Add(label5);
            grpFood.Controls.Add(label4);
            grpFood.Controls.Add(label3);
            grpFood.Location = new Point(322, 12);
            grpFood.Name = "grpFood";
            grpFood.Size = new Size(406, 207);
            grpFood.TabIndex = 1;
            grpFood.TabStop = false;
            grpFood.Text = "Món ăn";
            // 
            // cbbCategory
            // 
            cbbCategory.FormattingEnabled = true;
            cbbCategory.Location = new Point(105, 109);
            cbbCategory.Name = "cbbCategory";
            cbbCategory.Size = new Size(295, 23);
            cbbCategory.TabIndex = 14;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(105, 138);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(295, 23);
            txtNotes.TabIndex = 13;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(105, 80);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(295, 23);
            txtPrice.TabIndex = 12;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(105, 51);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(295, 23);
            txtUnit.TabIndex = 11;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(105, 22);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(295, 23);
            txtFoodName.TabIndex = 10;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(253, 167);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(47, 23);
            btnDeleteFood.TabIndex = 9;
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.UseVisualStyleBackColor = true;
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 141);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 4;
            label7.Text = "Ghi chú";
            // 
            // btnEditFood
            // 
            btnEditFood.Location = new Point(189, 167);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(47, 23);
            btnEditFood.TabIndex = 8;
            btnEditFood.Text = "Sửa";
            btnEditFood.UseVisualStyleBackColor = true;
            btnEditFood.Click += btnEditFood_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 84);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 3;
            label6.Text = "Giá món ăn";
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(123, 167);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(47, 23);
            btnAddFood.TabIndex = 7;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 112);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 2;
            label5.Text = "Chọn danh mục";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 54);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 1;
            label4.Text = "Đơn vị tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 25);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 0;
            label3.Text = "Tên món ăn";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 222);
            label8.Name = "label8";
            label8.Size = new Size(119, 15);
            label8.TabIndex = 2;
            label8.Text = "Danh sách danh mục";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(328, 222);
            label9.Name = "label9";
            label9.Size = new Size(106, 15);
            label9.TabIndex = 3;
            label9.Text = "Danh sách món ăn";
            // 
            // lvCategories
            // 
            lvCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lvCategories.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvCategories.FullRowSelect = true;
            lvCategories.GridLines = true;
            lvCategories.Location = new Point(12, 240);
            lvCategories.Name = "lvCategories";
            lvCategories.Size = new Size(304, 198);
            lvCategories.TabIndex = 4;
            lvCategories.UseCompatibleStateImageBehavior = false;
            lvCategories.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên danh mục";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Loại danh mục";
            columnHeader3.Width = 100;
            // 
            // lvFoods
            // 
            lvFoods.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvFoods.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            lvFoods.FullRowSelect = true;
            lvFoods.GridLines = true;
            lvFoods.Location = new Point(322, 240);
            lvFoods.Name = "lvFoods";
            lvFoods.Size = new Size(406, 198);
            lvFoods.TabIndex = 5;
            lvFoods.UseCompatibleStateImageBehavior = false;
            lvFoods.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ID";
            columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tên món ăn";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Đơn vị";
            columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Giá";
            columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Ghi chú";
            columnHeader8.Width = 150;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 450);
            Controls.Add(lvFoods);
            Controls.Add(lvCategories);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(grpFood);
            Controls.Add(grpCategory);
            Name = "AdminForm";
            Text = "Quản lý danh mục và món ăn";
            grpCategory.ResumeLayout(false);
            grpCategory.PerformLayout();
            grpFood.ResumeLayout(false);
            grpFood.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpCategory;
        private ComboBox cbbCategoryType;
        private TextBox txtCategoryName;
        private Label label2;
        private Label label1;
        private GroupBox grpFood;
        private Button btnDeleteCategory;
        private Button btnEditCategory;
        private Button btnAddCategory;
        private Button btnDeleteFood;
        private Label label7;
        private Button btnEditFood;
        private Label label6;
        private Button btnAddFood;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cbbCategory;
        private TextBox txtNotes;
        private TextBox txtPrice;
        private TextBox txtUnit;
        private TextBox txtFoodName;
        private Label label8;
        private Label label9;
        private ListView lvCategories;
        private ListView lvFoods;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
    }
}