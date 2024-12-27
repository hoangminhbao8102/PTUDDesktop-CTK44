namespace RestaurantManagementProject
{
    partial class PaymentForm
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
            grpList = new GroupBox();
            lvOrder = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtDiscount = new TextBox();
            txtTotal = new TextBox();
            txtFinalTotal = new TextBox();
            btnPay = new Button();
            btnCancel = new Button();
            grpList.SuspendLayout();
            SuspendLayout();
            // 
            // grpList
            // 
            grpList.Controls.Add(lvOrder);
            grpList.Location = new Point(12, 12);
            grpList.Name = "grpList";
            grpList.Size = new Size(518, 197);
            grpList.TabIndex = 0;
            grpList.TabStop = false;
            grpList.Text = "Danh sách món ăn";
            // 
            // lvOrder
            // 
            lvOrder.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvOrder.FullRowSelect = true;
            lvOrder.GridLines = true;
            lvOrder.Location = new Point(6, 22);
            lvOrder.Name = "lvOrder";
            lvOrder.Size = new Size(505, 169);
            lvOrder.TabIndex = 0;
            lvOrder.UseCompatibleStateImageBehavior = false;
            lvOrder.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Giá";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số lượng";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 247);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Giảm giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 277);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 2;
            label2.Text = "Tổng sau giảm giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 218);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 4;
            label4.Text = "Tổng cộng";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(236, 244);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(100, 23);
            txtDiscount.TabIndex = 5;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(236, 215);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 6;
            // 
            // txtFinalTotal
            // 
            txtFinalTotal.Location = new Point(236, 273);
            txtFinalTotal.Name = "txtFinalTotal";
            txtFinalTotal.Size = new Size(100, 23);
            txtFinalTotal.TabIndex = 7;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(90, 302);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(89, 23);
            btnPay.TabIndex = 8;
            btnPay.Text = "Thanh toán";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(306, 302);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 336);
            Controls.Add(btnCancel);
            Controls.Add(btnPay);
            Controls.Add(txtFinalTotal);
            Controls.Add(txtTotal);
            Controls.Add(txtDiscount);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grpList);
            Name = "PaymentForm";
            Text = "Thanh toán";
            grpList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpList;
        private ListView lvOrder;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtDiscount;
        private TextBox txtTotal;
        private TextBox txtFinalTotal;
        private Button btnPay;
        private Button btnCancel;
    }
}