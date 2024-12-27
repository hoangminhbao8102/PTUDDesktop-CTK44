namespace RestaurantManagementProject
{
    partial class frmBills
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
            cbbStatus = new ComboBox();
            label6 = new Label();
            txtTableID = new TextBox();
            label2 = new Label();
            cmdDelete = new Button();
            cmdUpdate = new Button();
            cmdAdd = new Button();
            cmdClear = new Button();
            dtpCheckoutDate = new DateTimePicker();
            txtAccount = new TextBox();
            txtAmount = new TextBox();
            txtDiscount = new TextBox();
            txtTax = new TextBox();
            txtName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            grpRight = new GroupBox();
            lsvBills = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            lblStatistic = new Label();
            cmdExit = new Button();
            grpLeft.SuspendLayout();
            grpRight.SuspendLayout();
            SuspendLayout();
            // 
            // grpLeft
            // 
            grpLeft.Controls.Add(cbbStatus);
            grpLeft.Controls.Add(label6);
            grpLeft.Controls.Add(txtTableID);
            grpLeft.Controls.Add(label2);
            grpLeft.Controls.Add(cmdDelete);
            grpLeft.Controls.Add(cmdUpdate);
            grpLeft.Controls.Add(cmdAdd);
            grpLeft.Controls.Add(cmdClear);
            grpLeft.Controls.Add(dtpCheckoutDate);
            grpLeft.Controls.Add(txtAccount);
            grpLeft.Controls.Add(txtAmount);
            grpLeft.Controls.Add(txtDiscount);
            grpLeft.Controls.Add(txtTax);
            grpLeft.Controls.Add(txtName);
            grpLeft.Controls.Add(label8);
            grpLeft.Controls.Add(label7);
            grpLeft.Controls.Add(label5);
            grpLeft.Controls.Add(label4);
            grpLeft.Controls.Add(label3);
            grpLeft.Controls.Add(label1);
            grpLeft.Location = new Point(12, 12);
            grpLeft.Name = "grpLeft";
            grpLeft.Size = new Size(332, 287);
            grpLeft.TabIndex = 0;
            grpLeft.TabStop = false;
            grpLeft.Text = "Chức năng";
            // 
            // cbbStatus
            // 
            cbbStatus.FormattingEnabled = true;
            cbbStatus.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán" });
            cbbStatus.Location = new Point(112, 167);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.Size = new Size(214, 23);
            cbbStatus.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 170);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 22;
            label6.Text = "Trạng thái";
            // 
            // txtTableID
            // 
            txtTableID.Location = new Point(112, 51);
            txtTableID.Name = "txtTableID";
            txtTableID.Size = new Size(214, 23);
            txtTableID.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 20;
            label2.Text = "Mã bàn";
            // 
            // cmdDelete
            // 
            cmdDelete.Location = new Point(249, 254);
            cmdDelete.Name = "cmdDelete";
            cmdDelete.Size = new Size(75, 23);
            cmdDelete.TabIndex = 19;
            cmdDelete.Text = "Xóa";
            cmdDelete.UseVisualStyleBackColor = true;
            cmdDelete.Click += cmdDelete_Click;
            // 
            // cmdUpdate
            // 
            cmdUpdate.Location = new Point(168, 254);
            cmdUpdate.Name = "cmdUpdate";
            cmdUpdate.Size = new Size(75, 23);
            cmdUpdate.TabIndex = 18;
            cmdUpdate.Text = "Sửa";
            cmdUpdate.UseVisualStyleBackColor = true;
            cmdUpdate.Click += cmdUpdate_Click;
            // 
            // cmdAdd
            // 
            cmdAdd.Location = new Point(87, 254);
            cmdAdd.Name = "cmdAdd";
            cmdAdd.Size = new Size(75, 23);
            cmdAdd.TabIndex = 17;
            cmdAdd.Text = "Thêm";
            cmdAdd.UseVisualStyleBackColor = true;
            cmdAdd.Click += cmdAdd_Click;
            // 
            // cmdClear
            // 
            cmdClear.Location = new Point(5, 254);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(75, 23);
            cmdClear.TabIndex = 16;
            cmdClear.Text = "Nhập lại";
            cmdClear.UseVisualStyleBackColor = true;
            cmdClear.Click += cmdClear_Click;
            // 
            // dtpCheckoutDate
            // 
            dtpCheckoutDate.Location = new Point(112, 196);
            dtpCheckoutDate.Name = "dtpCheckoutDate";
            dtpCheckoutDate.Size = new Size(214, 23);
            dtpCheckoutDate.TabIndex = 15;
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(112, 225);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(214, 23);
            txtAccount.TabIndex = 13;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(112, 80);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(214, 23);
            txtAmount.TabIndex = 12;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(113, 109);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(213, 23);
            txtDiscount.TabIndex = 11;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(112, 138);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(214, 23);
            txtTax.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(214, 23);
            txtName.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 228);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 7;
            label8.Text = "Người thanh toán";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 202);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 6;
            label7.Text = "Ngày thanh toán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 141);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 4;
            label5.Text = "Thuế";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 112);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Giảm giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Tổng tiền";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên hóa đơn";
            // 
            // grpRight
            // 
            grpRight.Controls.Add(lsvBills);
            grpRight.Location = new Point(350, 12);
            grpRight.Name = "grpRight";
            grpRight.Size = new Size(1072, 248);
            grpRight.TabIndex = 1;
            grpRight.TabStop = false;
            grpRight.Text = "Danh sách hóa đơn";
            // 
            // lsvBills
            // 
            lsvBills.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsvBills.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader7, columnHeader6, columnHeader8, columnHeader9 });
            lsvBills.FullRowSelect = true;
            lsvBills.GridLines = true;
            lsvBills.Location = new Point(6, 22);
            lsvBills.Name = "lsvBills";
            lsvBills.Size = new Size(1060, 220);
            lsvBills.TabIndex = 0;
            lsvBills.UseCompatibleStateImageBehavior = false;
            lsvBills.View = View.Details;
            lsvBills.Click += lsvBills_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên hóa đơn";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mã bàn";
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
            // columnHeader7
            // 
            columnHeader7.DisplayIndex = 6;
            columnHeader7.Text = "Trạng thái";
            columnHeader7.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.DisplayIndex = 5;
            columnHeader6.Text = "Thuế";
            columnHeader6.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Ngày thanh toán";
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Người thanh toán";
            columnHeader9.Width = 150;
            // 
            // lblStatistic
            // 
            lblStatistic.AutoSize = true;
            lblStatistic.Location = new Point(367, 270);
            lblStatistic.Name = "lblStatistic";
            lblStatistic.Size = new Size(57, 15);
            lblStatistic.TabIndex = 8;
            lblStatistic.Text = "Thống kê";
            // 
            // cmdExit
            // 
            cmdExit.Location = new Point(1341, 266);
            cmdExit.Name = "cmdExit";
            cmdExit.Size = new Size(75, 23);
            cmdExit.TabIndex = 9;
            cmdExit.Text = "Thoát";
            cmdExit.UseVisualStyleBackColor = true;
            cmdExit.Click += cmdExit_Click;
            // 
            // frmBills
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 306);
            Controls.Add(cmdExit);
            Controls.Add(lblStatistic);
            Controls.Add(grpRight);
            Controls.Add(grpLeft);
            Name = "frmBills";
            Text = "Quản lý hóa đơn";
            Load += frmBills_Load;
            grpLeft.ResumeLayout(false);
            grpLeft.PerformLayout();
            grpRight.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpLeft;
        private GroupBox grpRight;
        private TextBox txtAccount;
        private TextBox txtAmount;
        private TextBox txtDiscount;
        private TextBox txtTax;
        private TextBox txtName;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label lblStatistic;
        private DateTimePicker dtpCheckoutDate;
        private Button cmdDelete;
        private Button cmdUpdate;
        private Button cmdAdd;
        private Button cmdClear;
        private Button cmdExit;
        private ComboBox cbbStatus;
        private Label label6;
        private TextBox txtTableID;
        private Label label2;
        private ListView lsvBills;
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