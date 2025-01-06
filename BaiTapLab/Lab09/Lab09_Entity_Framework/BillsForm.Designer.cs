namespace Lab09_Entity_Framework
{
    partial class BillsForm
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
            dtpFromDate = new DateTimePicker();
            dtpToDate = new DateTimePicker();
            btnFilter = new Button();
            label6 = new Label();
            txtTotalAmount = new Label();
            txtTotalDiscount = new Label();
            txtActualAmount = new Label();
            lvBills = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 18);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(429, 18);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Đến ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 338);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "Tổng số tiền:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 338);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 3;
            label4.Text = "Tổng giảm giá:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 338);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 4;
            label5.Text = "Tiền thực thu:";
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(223, 12);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(200, 23);
            dtpFromDate.TabIndex = 5;
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new Point(492, 12);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(200, 23);
            dtpToDate.TabIndex = 6;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(698, 12);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(84, 23);
            btnFilter.TabIndex = 7;
            btnFilter.Text = "Lọc hóa đơn";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 38);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 8;
            label6.Text = "Danh sách hóa đơn";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.AutoSize = true;
            txtTotalAmount.Location = new Point(163, 338);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(16, 15);
            txtTotalAmount.TabIndex = 9;
            txtTotalAmount.Text = "...";
            // 
            // txtTotalDiscount
            // 
            txtTotalDiscount.AutoSize = true;
            txtTotalDiscount.Location = new Point(337, 338);
            txtTotalDiscount.Name = "txtTotalDiscount";
            txtTotalDiscount.Size = new Size(16, 15);
            txtTotalDiscount.TabIndex = 10;
            txtTotalDiscount.Text = "...";
            // 
            // txtActualAmount
            // 
            txtActualAmount.AutoSize = true;
            txtActualAmount.Location = new Point(495, 338);
            txtActualAmount.Name = "txtActualAmount";
            txtActualAmount.Size = new Size(16, 15);
            txtActualAmount.TabIndex = 11;
            txtActualAmount.Text = "...";
            // 
            // lvBills
            // 
            lvBills.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvBills.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            lvBills.FullRowSelect = true;
            lvBills.GridLines = true;
            lvBills.Location = new Point(12, 56);
            lvBills.Name = "lvBills";
            lvBills.Size = new Size(957, 279);
            lvBills.TabIndex = 12;
            lvBills.UseCompatibleStateImageBehavior = false;
            lvBills.View = View.Details;
            lvBills.DoubleClick += lvBills_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên hóa đơn";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên bàn";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tổng tiền";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Giảm giá";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Thực thu";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Ngày thanh toán";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Nhân viên";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Trạng thái";
            columnHeader9.Width = 100;
            // 
            // BillsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 365);
            Controls.Add(lvBills);
            Controls.Add(txtActualAmount);
            Controls.Add(txtTotalDiscount);
            Controls.Add(txtTotalAmount);
            Controls.Add(label6);
            Controls.Add(btnFilter);
            Controls.Add(dtpToDate);
            Controls.Add(dtpFromDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BillsForm";
            Text = "Quản lý hóa đơn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpFromDate;
        private DateTimePicker dtpToDate;
        private Button btnFilter;
        private Label label6;
        private Label txtTotalAmount;
        private Label txtTotalDiscount;
        private Label txtActualAmount;
        private ListView lvBills;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
    }
}