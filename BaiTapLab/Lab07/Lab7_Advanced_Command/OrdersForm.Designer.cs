namespace Lab7_Advanced_Command
{
    partial class OrdersForm
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
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            dgvBills = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblTotalAmount = new Label();
            lblTotalDiscount = new Label();
            lblNetRevenue = new Label();
            btnLoadBills = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBills).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 22);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "Ngày kết thúc:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(110, 16);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(406, 16);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 3;
            // 
            // dgvBills
            // 
            dgvBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBills.Location = new Point(12, 45);
            dgvBills.Name = "dgvBills";
            dgvBills.Size = new Size(749, 150);
            dgvBills.TabIndex = 4;
            dgvBills.CellDoubleClick += dgvBills_CellDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 210);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 5;
            label3.Text = "Tổng số tiền:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(570, 210);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 6;
            label4.Text = "Doanh thu ròng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(298, 210);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 7;
            label5.Text = "Tổng giảm giá:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(132, 210);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(16, 15);
            lblTotalAmount.TabIndex = 8;
            lblTotalAmount.Text = "...";
            // 
            // lblTotalDiscount
            // 
            lblTotalDiscount.AutoSize = true;
            lblTotalDiscount.Location = new Point(391, 210);
            lblTotalDiscount.Name = "lblTotalDiscount";
            lblTotalDiscount.Size = new Size(16, 15);
            lblTotalDiscount.TabIndex = 9;
            lblTotalDiscount.Text = "...";
            // 
            // lblNetRevenue
            // 
            lblNetRevenue.AutoSize = true;
            lblNetRevenue.Location = new Point(670, 210);
            lblNetRevenue.Name = "lblNetRevenue";
            lblNetRevenue.Size = new Size(16, 15);
            lblNetRevenue.TabIndex = 10;
            lblNetRevenue.Text = "...";
            // 
            // btnLoadBills
            // 
            btnLoadBills.Location = new Point(612, 16);
            btnLoadBills.Name = "btnLoadBills";
            btnLoadBills.Size = new Size(136, 23);
            btnLoadBills.TabIndex = 11;
            btnLoadBills.Text = "Tải danh sách hóa đơn";
            btnLoadBills.UseVisualStyleBackColor = true;
            btnLoadBills.Click += btnLoadBills_Click;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 263);
            Controls.Add(btnLoadBills);
            Controls.Add(lblNetRevenue);
            Controls.Add(lblTotalDiscount);
            Controls.Add(lblTotalAmount);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvBills);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrdersForm";
            Text = "OrdersForm";
            ((System.ComponentModel.ISupportInitialize)dgvBills).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private DataGridView dgvBills;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblTotalAmount;
        private Label lblTotalDiscount;
        private Label lblNetRevenue;
        private Button btnLoadBills;
    }
}