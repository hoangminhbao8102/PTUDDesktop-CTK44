namespace ToyShop
{
    partial class FormToy
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
            gbCrud = new GroupBox();
            gbFilterByCategory = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            gbSearch = new GroupBox();
            label7 = new Label();
            txtToyName = new TextBox();
            cbCategoryID = new ComboBox();
            nudPrice = new NumericUpDown();
            label8 = new Label();
            nudStockQuantity = new NumericUpDown();
            label9 = new Label();
            nudDiscount = new NumericUpDown();
            label10 = new Label();
            txtCategoryID = new TextBox();
            btnFilterByCategory = new Button();
            txtKeyword = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSortByAlphabet = new Button();
            gbList = new GroupBox();
            listViewToy = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            gbCrud.SuspendLayout();
            gbFilterByCategory.SuspendLayout();
            gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            gbList.SuspendLayout();
            SuspendLayout();
            // 
            // gbCrud
            // 
            gbCrud.Controls.Add(btnDelete);
            gbCrud.Controls.Add(btnUpdate);
            gbCrud.Controls.Add(btnAdd);
            gbCrud.Controls.Add(label10);
            gbCrud.Controls.Add(nudDiscount);
            gbCrud.Controls.Add(label9);
            gbCrud.Controls.Add(nudStockQuantity);
            gbCrud.Controls.Add(label8);
            gbCrud.Controls.Add(nudPrice);
            gbCrud.Controls.Add(cbCategoryID);
            gbCrud.Controls.Add(txtToyName);
            gbCrud.Controls.Add(label5);
            gbCrud.Controls.Add(label4);
            gbCrud.Controls.Add(label3);
            gbCrud.Controls.Add(label2);
            gbCrud.Controls.Add(label1);
            gbCrud.Location = new Point(12, 12);
            gbCrud.Name = "gbCrud";
            gbCrud.Size = new Size(279, 202);
            gbCrud.TabIndex = 0;
            gbCrud.TabStop = false;
            gbCrud.Text = "THÊM - XÓA - SỬA";
            // 
            // gbFilterByCategory
            // 
            gbFilterByCategory.Controls.Add(btnFilterByCategory);
            gbFilterByCategory.Controls.Add(txtCategoryID);
            gbFilterByCategory.Controls.Add(label6);
            gbFilterByCategory.Location = new Point(297, 15);
            gbFilterByCategory.Name = "gbFilterByCategory";
            gbFilterByCategory.Size = new Size(383, 59);
            gbFilterByCategory.TabIndex = 1;
            gbFilterByCategory.TabStop = false;
            gbFilterByCategory.Text = "LỌC THEO LOẠI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "TÊN ĐỒ CHƠI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 56);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "LOẠI ĐỒ CHƠI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 84);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "GIÁ BÁN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 115);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 3;
            label4.Text = "SỐ LƯỢNG TỒN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 142);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 4;
            label5.Text = "GIẢM GIÁ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 24);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 5;
            label6.Text = "NHẬP LOẠI CẦN LỌC";
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(txtKeyword);
            gbSearch.Controls.Add(label7);
            gbSearch.Location = new Point(297, 80);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(383, 54);
            gbSearch.TabIndex = 2;
            gbSearch.TabStop = false;
            gbSearch.Text = "TÌM KIẾM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 25);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 6;
            label7.Text = "NHẬP TÌM KIẾM";
            // 
            // txtToyName
            // 
            txtToyName.Location = new Point(105, 24);
            txtToyName.Name = "txtToyName";
            txtToyName.Size = new Size(168, 23);
            txtToyName.TabIndex = 5;
            // 
            // cbCategoryID
            // 
            cbCategoryID.FormattingEnabled = true;
            cbCategoryID.Location = new Point(105, 53);
            cbCategoryID.Name = "cbCategoryID";
            cbCategoryID.Size = new Size(168, 23);
            cbCategoryID.TabIndex = 6;
            // 
            // nudPrice
            // 
            nudPrice.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrice.Location = new Point(105, 82);
            nudPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudPrice.Minimum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(120, 23);
            nudPrice.TabIndex = 7;
            nudPrice.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(231, 84);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 8;
            label8.Text = "ĐỒNG";
            // 
            // nudStockQuantity
            // 
            nudStockQuantity.Location = new Point(105, 111);
            nudStockQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudStockQuantity.Name = "nudStockQuantity";
            nudStockQuantity.Size = new Size(120, 23);
            nudStockQuantity.TabIndex = 9;
            nudStockQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(231, 115);
            label9.Name = "label9";
            label9.Size = new Size(26, 15);
            label9.TabIndex = 10;
            label9.Text = "CÁI";
            // 
            // nudDiscount
            // 
            nudDiscount.Location = new Point(105, 140);
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(120, 23);
            nudDiscount.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(231, 142);
            label10.Name = "label10";
            label10.Size = new Size(17, 15);
            label10.TabIndex = 12;
            label10.Text = "%";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(135, 21);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(161, 23);
            txtCategoryID.TabIndex = 6;
            // 
            // btnFilterByCategory
            // 
            btnFilterByCategory.Location = new Point(302, 24);
            btnFilterByCategory.Name = "btnFilterByCategory";
            btnFilterByCategory.Size = new Size(75, 23);
            btnFilterByCategory.TabIndex = 7;
            btnFilterByCategory.Text = "LỌC";
            btnFilterByCategory.UseVisualStyleBackColor = true;
            btnFilterByCategory.Click += btnFilterByCategory_Click;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(106, 22);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(190, 23);
            txtKeyword.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(302, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "TÌM KIẾM";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 169);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "THÊM";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(104, 169);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "CẬP NHẬT";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(197, 169);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "XÓA";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSortByAlphabet
            // 
            btnSortByAlphabet.Location = new Point(447, 140);
            btnSortByAlphabet.Name = "btnSortByAlphabet";
            btnSortByAlphabet.Size = new Size(130, 64);
            btnSortByAlphabet.TabIndex = 3;
            btnSortByAlphabet.Text = "SẮP XẾP THEO ALPHABET";
            btnSortByAlphabet.UseVisualStyleBackColor = true;
            btnSortByAlphabet.Click += btnSortByAlphabet_Click;
            // 
            // gbList
            // 
            gbList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbList.Controls.Add(listViewToy);
            gbList.Location = new Point(12, 220);
            gbList.Name = "gbList";
            gbList.Size = new Size(668, 218);
            gbList.TabIndex = 4;
            gbList.TabStop = false;
            gbList.Text = "DANH SÁCH MÓN ĐỒ CHƠI";
            // 
            // listViewToy
            // 
            listViewToy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewToy.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewToy.FullRowSelect = true;
            listViewToy.GridLines = true;
            listViewToy.Location = new Point(6, 22);
            listViewToy.Name = "listViewToy";
            listViewToy.Size = new Size(656, 190);
            listViewToy.TabIndex = 0;
            listViewToy.UseCompatibleStateImageBehavior = false;
            listViewToy.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "TÊN ĐỒ CHƠI";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "LOẠI ĐỒ CHƠI";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "GIÁ BÁN";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "SỐ LƯỢNG TỒN";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "GIẢM GIÁ";
            columnHeader6.Width = 100;
            // 
            // FormToy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 450);
            Controls.Add(gbList);
            Controls.Add(btnSortByAlphabet);
            Controls.Add(gbSearch);
            Controls.Add(gbFilterByCategory);
            Controls.Add(gbCrud);
            Name = "FormToy";
            Text = "Quản lý thông tin từng đồ chơi";
            gbCrud.ResumeLayout(false);
            gbCrud.PerformLayout();
            gbFilterByCategory.ResumeLayout(false);
            gbFilterByCategory.PerformLayout();
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            gbList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCrud;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gbFilterByCategory;
        private Label label6;
        private GroupBox gbSearch;
        private Label label7;
        private Label label9;
        private NumericUpDown nudStockQuantity;
        private Label label8;
        private NumericUpDown nudPrice;
        private ComboBox cbCategoryID;
        private TextBox txtToyName;
        private Label label10;
        private NumericUpDown nudDiscount;
        private Button btnFilterByCategory;
        private TextBox txtCategoryID;
        private Button btnSearch;
        private TextBox txtKeyword;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSortByAlphabet;
        private GroupBox gbList;
        private ListView listViewToy;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}