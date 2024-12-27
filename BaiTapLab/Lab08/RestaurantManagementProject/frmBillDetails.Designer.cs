namespace RestaurantManagementProject
{
    partial class frmBillDetails
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
            cbbFood = new ComboBox();
            cbbInvoice = new ComboBox();
            cmdDelete = new Button();
            cmdUpdate = new Button();
            cmdAdd = new Button();
            cmdClear = new Button();
            txtQuantity = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpRight = new GroupBox();
            lsvBillDetails = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            cmdExit = new Button();
            lblStatistic = new Label();
            grpLeft.SuspendLayout();
            grpRight.SuspendLayout();
            SuspendLayout();
            // 
            // grpLeft
            // 
            grpLeft.Controls.Add(cbbFood);
            grpLeft.Controls.Add(cbbInvoice);
            grpLeft.Controls.Add(cmdDelete);
            grpLeft.Controls.Add(cmdUpdate);
            grpLeft.Controls.Add(cmdAdd);
            grpLeft.Controls.Add(cmdClear);
            grpLeft.Controls.Add(txtQuantity);
            grpLeft.Controls.Add(label3);
            grpLeft.Controls.Add(label2);
            grpLeft.Controls.Add(label1);
            grpLeft.Location = new Point(12, 12);
            grpLeft.Name = "grpLeft";
            grpLeft.Size = new Size(334, 161);
            grpLeft.TabIndex = 0;
            grpLeft.TabStop = false;
            grpLeft.Text = "Chức năng";
            // 
            // cbbFood
            // 
            cbbFood.FormattingEnabled = true;
            cbbFood.Location = new Point(83, 58);
            cbbFood.Name = "cbbFood";
            cbbFood.Size = new Size(241, 23);
            cbbFood.TabIndex = 25;
            // 
            // cbbInvoice
            // 
            cbbInvoice.FormattingEnabled = true;
            cbbInvoice.Location = new Point(83, 29);
            cbbInvoice.Name = "cbbInvoice";
            cbbInvoice.Size = new Size(241, 23);
            cbbInvoice.TabIndex = 24;
            // 
            // cmdDelete
            // 
            cmdDelete.Location = new Point(249, 116);
            cmdDelete.Name = "cmdDelete";
            cmdDelete.Size = new Size(75, 23);
            cmdDelete.TabIndex = 23;
            cmdDelete.Text = "Xóa";
            cmdDelete.UseVisualStyleBackColor = true;
            cmdDelete.Click += cmdDelete_Click;
            // 
            // cmdUpdate
            // 
            cmdUpdate.Location = new Point(168, 116);
            cmdUpdate.Name = "cmdUpdate";
            cmdUpdate.Size = new Size(75, 23);
            cmdUpdate.TabIndex = 22;
            cmdUpdate.Text = "Sửa";
            cmdUpdate.UseVisualStyleBackColor = true;
            cmdUpdate.Click += cmdUpdate_Click;
            // 
            // cmdAdd
            // 
            cmdAdd.Location = new Point(87, 116);
            cmdAdd.Name = "cmdAdd";
            cmdAdd.Size = new Size(75, 23);
            cmdAdd.TabIndex = 21;
            cmdAdd.Text = "Thêm";
            cmdAdd.UseVisualStyleBackColor = true;
            cmdAdd.Click += cmdAdd_Click;
            // 
            // cmdClear
            // 
            cmdClear.Location = new Point(6, 116);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(75, 23);
            cmdClear.TabIndex = 20;
            cmdClear.Text = "Nhập lại";
            cmdClear.UseVisualStyleBackColor = true;
            cmdClear.Click += cmdClear_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(83, 87);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(241, 23);
            txtQuantity.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 90);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã món ăn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn";
            // 
            // grpRight
            // 
            grpRight.Controls.Add(lsvBillDetails);
            grpRight.Location = new Point(352, 12);
            grpRight.Name = "grpRight";
            grpRight.Size = new Size(374, 132);
            grpRight.TabIndex = 1;
            grpRight.TabStop = false;
            grpRight.Text = "Danh sách chi tiết hóa đơn";
            // 
            // lsvBillDetails
            // 
            lsvBillDetails.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBillDetails.FullRowSelect = true;
            lsvBillDetails.GridLines = true;
            lsvBillDetails.Location = new Point(6, 22);
            lsvBillDetails.Name = "lsvBillDetails";
            lsvBillDetails.Size = new Size(355, 97);
            lsvBillDetails.TabIndex = 0;
            lsvBillDetails.UseCompatibleStateImageBehavior = false;
            lsvBillDetails.View = View.Details;
            lsvBillDetails.Click += lsvBillDetails_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã hóa đơn";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mã món ăn";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Số lượng";
            columnHeader4.Width = 100;
            // 
            // cmdExit
            // 
            cmdExit.Location = new Point(638, 150);
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
            lblStatistic.Location = new Point(368, 154);
            lblStatistic.Name = "lblStatistic";
            lblStatistic.Size = new Size(57, 15);
            lblStatistic.TabIndex = 3;
            lblStatistic.Text = "Thống kê";
            // 
            // frmBillDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 184);
            Controls.Add(lblStatistic);
            Controls.Add(cmdExit);
            Controls.Add(grpRight);
            Controls.Add(grpLeft);
            Name = "frmBillDetails";
            Text = "Chi tiết hóa đơn";
            Load += frmBillDetails_Load;
            grpLeft.ResumeLayout(false);
            grpLeft.PerformLayout();
            grpRight.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpLeft;
        private GroupBox grpRight;
        private TextBox txtQuantity;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button cmdDelete;
        private Button cmdUpdate;
        private Button cmdAdd;
        private Button cmdClear;
        private Button cmdExit;
        private ListView lsvBillDetails;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label lblStatistic;
        private ComboBox cbbFood;
        private ComboBox cbbInvoice;
    }
}