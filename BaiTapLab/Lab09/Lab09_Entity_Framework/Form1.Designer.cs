namespace Lab09_Entity_Framework
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            btnReloadCategory = new Button();
            btnAddCategory = new Button();
            btnAddFood = new Button();
            toolTip1 = new ToolTip(components);
            btnReloadFood = new Button();
            btnDelete = new Button();
            tvwCategory = new TreeView();
            lvwFood = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Danh mục";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 20);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Thực đơn";
            // 
            // btnReloadCategory
            // 
            btnReloadCategory.Location = new Point(222, 12);
            btnReloadCategory.Name = "btnReloadCategory";
            btnReloadCategory.Size = new Size(30, 30);
            btnReloadCategory.TabIndex = 2;
            btnReloadCategory.Text = "R";
            toolTip1.SetToolTip(btnReloadCategory, "Tải lại danh mục");
            btnReloadCategory.UseVisualStyleBackColor = true;
            btnReloadCategory.Click += btnReloadCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(258, 12);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(30, 30);
            btnAddCategory.TabIndex = 3;
            btnAddCategory.Text = "+";
            toolTip1.SetToolTip(btnAddCategory, "Thêm danh mục mới");
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddFood.Location = new Point(871, 12);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(30, 30);
            btnAddFood.TabIndex = 4;
            btnAddFood.Text = "+";
            toolTip1.SetToolTip(btnAddFood, "Thêm món ăn mới");
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // btnReloadFood
            // 
            btnReloadFood.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReloadFood.Location = new Point(799, 12);
            btnReloadFood.Name = "btnReloadFood";
            btnReloadFood.Size = new Size(30, 30);
            btnReloadFood.TabIndex = 5;
            btnReloadFood.Text = "R";
            toolTip1.SetToolTip(btnReloadFood, "Tải lại danh sách món ăn");
            btnReloadFood.UseVisualStyleBackColor = true;
            btnReloadFood.Click += btnReloadFood_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(835, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(30, 30);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "--";
            toolTip1.SetToolTip(btnDelete, "Xóa món ăn được chọn");
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tvwCategory
            // 
            tvwCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tvwCategory.Location = new Point(12, 48);
            tvwCategory.Name = "tvwCategory";
            tvwCategory.Size = new Size(285, 390);
            tvwCategory.TabIndex = 7;
            tvwCategory.AfterSelect += tvwCategory_AfterSelect;
            tvwCategory.NodeMouseDoubleClick += tvwCategory_NodeMouseDoubleClick;
            // 
            // lvwFood
            // 
            lvwFood.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwFood.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lvwFood.FullRowSelect = true;
            lvwFood.GridLines = true;
            lvwFood.Location = new Point(303, 48);
            lvwFood.MultiSelect = false;
            lvwFood.Name = "lvwFood";
            lvwFood.Size = new Size(607, 390);
            lvwFood.TabIndex = 8;
            lvwFood.UseCompatibleStateImageBehavior = false;
            lvwFood.View = View.Details;
            lvwFood.DoubleClick += lvwFood_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã số";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên đồ ăn/thức uống";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ĐV Tính";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Giá bán";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nhóm mặt hàng";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Ghi chú";
            columnHeader6.Width = 100;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 450);
            Controls.Add(lvwFood);
            Controls.Add(tvwCategory);
            Controls.Add(btnDelete);
            Controls.Add(btnReloadFood);
            Controls.Add(btnAddFood);
            Controls.Add(btnAddCategory);
            Controls.Add(btnReloadCategory);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhà hàng";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnReloadCategory;
        private Button btnAddCategory;
        private Button btnAddFood;
        private ToolTip toolTip1;
        private Button btnReloadFood;
        private Button btnDelete;
        private TreeView tvwCategory;
        private ListView lvwFood;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}
