namespace RestaurantDesktop
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
            cbbFood = new ComboBox();
            menuStrip1 = new MenuStrip();
            tsmAdmin = new ToolStripMenuItem();
            tsmAccount = new ToolStripMenuItem();
            nudQuantity = new NumericUpDown();
            lvBillDetail = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnAddFood = new Button();
            cbbCategory = new ComboBox();
            btnDiscount = new Button();
            btnTransferOrMerge = new Button();
            btnCheckOut = new Button();
            nudDiscount = new NumericUpDown();
            txtAmount = new TextBox();
            cbbTargetTable = new ComboBox();
            pnlTable = new Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            SuspendLayout();
            // 
            // cbbFood
            // 
            cbbFood.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbFood.FormattingEnabled = true;
            cbbFood.Location = new Point(384, 56);
            cbbFood.Name = "cbbFood";
            cbbFood.Size = new Size(278, 23);
            cbbFood.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmAdmin, tsmAccount });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmAdmin
            // 
            tsmAdmin.Name = "tsmAdmin";
            tsmAdmin.Size = new Size(55, 20);
            tsmAdmin.Text = "Admin";
            tsmAdmin.Click += tsmAdmin_Click;
            // 
            // tsmAccount
            // 
            tsmAccount.Name = "tsmAccount";
            tsmAccount.Size = new Size(70, 20);
            tsmAccount.Text = "Tài khoản";
            tsmAccount.Click += tsmAccount_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudQuantity.Location = new Point(668, 27);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 23);
            nudQuantity.TabIndex = 2;
            // 
            // lvBillDetail
            // 
            lvBillDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvBillDetail.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvBillDetail.FullRowSelect = true;
            lvBillDetail.GridLines = true;
            lvBillDetail.Location = new Point(384, 85);
            lvBillDetail.Name = "lvBillDetail";
            lvBillDetail.Size = new Size(404, 295);
            lvBillDetail.TabIndex = 3;
            lvBillDetail.UseCompatibleStateImageBehavior = false;
            lvBillDetail.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ĐVT";
            columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số lượng";
            columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Đơn giá";
            columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Thành tiền";
            columnHeader5.Width = 75;
            // 
            // btnAddFood
            // 
            btnAddFood.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddFood.Location = new Point(668, 56);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(120, 23);
            btnAddFood.TabIndex = 4;
            btnAddFood.Text = "Thêm món";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // cbbCategory
            // 
            cbbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbCategory.FormattingEnabled = true;
            cbbCategory.Location = new Point(384, 27);
            cbbCategory.Name = "cbbCategory";
            cbbCategory.Size = new Size(278, 23);
            cbbCategory.TabIndex = 5;
            cbbCategory.SelectedIndexChanged += cbbCategory_SelectedIndexChanged;
            // 
            // btnDiscount
            // 
            btnDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDiscount.Location = new Point(549, 413);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(79, 23);
            btnDiscount.TabIndex = 6;
            btnDiscount.Text = "% Giảm giá";
            btnDiscount.UseVisualStyleBackColor = true;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // btnTransferOrMerge
            // 
            btnTransferOrMerge.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnTransferOrMerge.Location = new Point(384, 386);
            btnTransferOrMerge.Name = "btnTransferOrMerge";
            btnTransferOrMerge.Size = new Size(121, 23);
            btnTransferOrMerge.TabIndex = 7;
            btnTransferOrMerge.Text = "Chuyển/Gộp bàn";
            btnTransferOrMerge.UseVisualStyleBackColor = true;
            btnTransferOrMerge.Click += btnTransferOrMerge_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCheckOut.Location = new Point(702, 386);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(86, 52);
            btnCheckOut.TabIndex = 8;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // nudDiscount
            // 
            nudDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudDiscount.Location = new Point(634, 415);
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(62, 23);
            nudDiscount.TabIndex = 9;
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAmount.Location = new Point(549, 386);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(147, 23);
            txtAmount.TabIndex = 10;
            // 
            // cbbTargetTable
            // 
            cbbTargetTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbTargetTable.FormattingEnabled = true;
            cbbTargetTable.Location = new Point(384, 415);
            cbbTargetTable.Name = "cbbTargetTable";
            cbbTargetTable.Size = new Size(121, 23);
            cbbTargetTable.TabIndex = 11;
            // 
            // pnlTable
            // 
            pnlTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlTable.Location = new Point(12, 27);
            pnlTable.Name = "pnlTable";
            pnlTable.Size = new Size(366, 411);
            pnlTable.TabIndex = 12;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlTable);
            Controls.Add(cbbTargetTable);
            Controls.Add(txtAmount);
            Controls.Add(nudDiscount);
            Controls.Add(btnCheckOut);
            Controls.Add(btnTransferOrMerge);
            Controls.Add(btnDiscount);
            Controls.Add(cbbCategory);
            Controls.Add(btnAddFood);
            Controls.Add(lvBillDetail);
            Controls.Add(nudQuantity);
            Controls.Add(cbbFood);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Phần mềm Quản lý nhà hàng";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbFood;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmAdmin;
        private ToolStripMenuItem tsmAccount;
        private NumericUpDown nudQuantity;
        private ListView lvBillDetail;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnAddFood;
        private ComboBox cbbCategory;
        private Button btnDiscount;
        private Button btnTransferOrMerge;
        private Button btnCheckOut;
        private NumericUpDown nudDiscount;
        private TextBox txtAmount;
        private ComboBox cbbTargetTable;
        private Panel pnlTable;
    }
}
