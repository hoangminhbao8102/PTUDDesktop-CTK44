namespace Lab09_Entity_Framework
{
    partial class AppMainForm
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
            listViewTables = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            comboBoxFoods = new ComboBox();
            label3 = new Label();
            numericUpDownQuantity = new NumericUpDown();
            label4 = new Label();
            btnAddFoodToBill = new Button();
            listViewBillDetails = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            btnCheckoutTable = new Button();
            btnPrintBill = new Button();
            menuStripMain = new MenuStrip();
            menuAdminManagement = new ToolStripMenuItem();
            menuViewAccount = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 24);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Danh sách bàn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Chi tiết hóa đơn";
            // 
            // listViewTables
            // 
            listViewTables.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewTables.FullRowSelect = true;
            listViewTables.GridLines = true;
            listViewTables.Location = new Point(332, 42);
            listViewTables.Name = "listViewTables";
            listViewTables.Size = new Size(308, 309);
            listViewTables.TabIndex = 2;
            listViewTables.UseCompatibleStateImageBehavior = false;
            listViewTables.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 25;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên bàn";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Trạng thái";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Số lượng";
            columnHeader4.Width = 75;
            // 
            // comboBoxFoods
            // 
            comboBoxFoods.FormattingEnabled = true;
            comboBoxFoods.Location = new Point(439, 357);
            comboBoxFoods.Name = "comboBoxFoods";
            comboBoxFoods.Size = new Size(188, 23);
            comboBoxFoods.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 360);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 4;
            label3.Text = "Chọn món ăn";
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(439, 386);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(188, 23);
            numericUpDownQuantity.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 388);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 6;
            label4.Text = "Nhập số lượng";
            // 
            // btnAddFoodToBill
            // 
            btnAddFoodToBill.Location = new Point(452, 415);
            btnAddFoodToBill.Name = "btnAddFoodToBill";
            btnAddFoodToBill.Size = new Size(94, 23);
            btnAddFoodToBill.TabIndex = 7;
            btnAddFoodToBill.Text = "Thêm món ăn";
            btnAddFoodToBill.UseVisualStyleBackColor = true;
            btnAddFoodToBill.Click += btnAddFoodToBill_Click;
            // 
            // listViewBillDetails
            // 
            listViewBillDetails.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6 });
            listViewBillDetails.FullRowSelect = true;
            listViewBillDetails.GridLines = true;
            listViewBillDetails.Location = new Point(12, 42);
            listViewBillDetails.Name = "listViewBillDetails";
            listViewBillDetails.Size = new Size(314, 367);
            listViewBillDetails.TabIndex = 8;
            listViewBillDetails.UseCompatibleStateImageBehavior = false;
            listViewBillDetails.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tên món";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Số lượng";
            columnHeader6.Width = 100;
            // 
            // btnCheckoutTable
            // 
            btnCheckoutTable.Location = new Point(43, 415);
            btnCheckoutTable.Name = "btnCheckoutTable";
            btnCheckoutTable.Size = new Size(94, 23);
            btnCheckoutTable.TabIndex = 9;
            btnCheckoutTable.Text = "Thanh toán";
            btnCheckoutTable.UseVisualStyleBackColor = true;
            btnCheckoutTable.Click += btnCheckoutTable_Click;
            // 
            // btnPrintBill
            // 
            btnPrintBill.Location = new Point(169, 415);
            btnPrintBill.Name = "btnPrintBill";
            btnPrintBill.Size = new Size(94, 23);
            btnPrintBill.TabIndex = 10;
            btnPrintBill.Text = "In hóa đơn";
            btnPrintBill.UseVisualStyleBackColor = true;
            btnPrintBill.Click += btnPrintBill_Click;
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new ToolStripItem[] { menuAdminManagement, menuViewAccount });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(652, 24);
            menuStripMain.TabIndex = 11;
            menuStripMain.Text = "Menu quản trị hệ thống";
            // 
            // menuAdminManagement
            // 
            menuAdminManagement.Name = "menuAdminManagement";
            menuAdminManagement.Size = new Size(143, 20);
            menuAdminManagement.Text = "Form quản trị tài khoản";
            menuAdminManagement.Click += menuAdminManagement_Click;
            // 
            // menuViewAccount
            // 
            menuViewAccount.Name = "menuViewAccount";
            menuViewAccount.Size = new Size(147, 20);
            menuViewAccount.Text = "Xem thông tin tài khoản";
            menuViewAccount.Click += menuViewAccount_Click;
            // 
            // AppMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 450);
            Controls.Add(btnPrintBill);
            Controls.Add(btnCheckoutTable);
            Controls.Add(listViewBillDetails);
            Controls.Add(btnAddFoodToBill);
            Controls.Add(label4);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(label3);
            Controls.Add(comboBoxFoods);
            Controls.Add(listViewTables);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            Name = "AppMainForm";
            Text = "Quản lý nhà hàng";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView listViewTables;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ComboBox comboBoxFoods;
        private Label label3;
        private NumericUpDown numericUpDownQuantity;
        private Label label4;
        private Button btnAddFoodToBill;
        private ListView listViewBillDetails;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnCheckoutTable;
        private Button btnPrintBill;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem menuAdminManagement;
        private ToolStripMenuItem menuViewAccount;
    }
}