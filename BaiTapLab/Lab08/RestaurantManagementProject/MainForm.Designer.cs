namespace RestaurantManagementProject
{
    partial class MainForm
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
            lvTables = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnOrder = new Button();
            btnPayment = new Button();
            btnTableManager = new Button();
            btnReports = new Button();
            grpRight = new GroupBox();
            lvBills = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            grpLeft.SuspendLayout();
            grpRight.SuspendLayout();
            SuspendLayout();
            // 
            // grpLeft
            // 
            grpLeft.Controls.Add(lvTables);
            grpLeft.Location = new Point(12, 12);
            grpLeft.Name = "grpLeft";
            grpLeft.Size = new Size(270, 258);
            grpLeft.TabIndex = 0;
            grpLeft.TabStop = false;
            grpLeft.Text = "Danh sách bàn";
            // 
            // lvTables
            // 
            lvTables.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvTables.FullRowSelect = true;
            lvTables.GridLines = true;
            lvTables.Location = new Point(6, 22);
            lvTables.Name = "lvTables";
            lvTables.Size = new Size(258, 230);
            lvTables.TabIndex = 0;
            lvTables.UseCompatibleStateImageBehavior = false;
            lvTables.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Bàn";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Trạng thái";
            columnHeader2.Width = 150;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(106, 276);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(75, 23);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "Đặt món";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(233, 276);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(87, 23);
            btnPayment.TabIndex = 2;
            btnPayment.Text = "Thanh toán";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnTableManager
            // 
            btnTableManager.Location = new Point(367, 276);
            btnTableManager.Name = "btnTableManager";
            btnTableManager.Size = new Size(89, 23);
            btnTableManager.TabIndex = 3;
            btnTableManager.Text = "Quản lý bàn";
            btnTableManager.UseVisualStyleBackColor = true;
            btnTableManager.Click += btnTableManager_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(511, 276);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(117, 23);
            btnReports.TabIndex = 4;
            btnReports.Text = "Báo cáo doanh thu";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // grpRight
            // 
            grpRight.Controls.Add(lvBills);
            grpRight.Location = new Point(288, 12);
            grpRight.Name = "grpRight";
            grpRight.Size = new Size(470, 258);
            grpRight.TabIndex = 5;
            grpRight.TabStop = false;
            grpRight.Text = "groupBox1";
            // 
            // lvBills
            // 
            lvBills.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lvBills.FullRowSelect = true;
            lvBills.GridLines = true;
            lvBills.Location = new Point(6, 22);
            lvBills.Name = "lvBills";
            lvBills.Size = new Size(456, 230);
            lvBills.TabIndex = 0;
            lvBills.UseCompatibleStateImageBehavior = false;
            lvBills.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ID";
            columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tên hóa đơn";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Ngày tạo";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tổng tiền";
            columnHeader6.Width = 100;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 313);
            Controls.Add(grpRight);
            Controls.Add(btnReports);
            Controls.Add(btnTableManager);
            Controls.Add(btnPayment);
            Controls.Add(btnOrder);
            Controls.Add(grpLeft);
            Name = "MainForm";
            Text = "Quản lý Nhà hàng";
            grpLeft.ResumeLayout(false);
            grpRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpLeft;
        private ListView lvTables;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btnOrder;
        private Button btnPayment;
        private Button btnTableManager;
        private Button btnReports;
        private GroupBox grpRight;
        private ListView lvBills;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}