namespace ToyShop
{
    partial class FormInvoice
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
            txtCustomerID = new TextBox();
            dtpInvoiceDate = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            gbList = new GroupBox();
            listViewInvoice = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            gbList.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "MÃ KHÁCH HÀNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 1;
            label2.Text = "NGÀY TẠO HÓA ĐƠN";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(141, 12);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(290, 23);
            txtCustomerID.TabIndex = 2;
            // 
            // dtpInvoiceDate
            // 
            dtpInvoiceDate.CustomFormat = "dd/MM/yyyy";
            dtpInvoiceDate.Format = DateTimePickerFormat.Custom;
            dtpInvoiceDate.Location = new Point(141, 41);
            dtpInvoiceDate.Name = "dtpInvoiceDate";
            dtpInvoiceDate.Size = new Size(290, 23);
            dtpInvoiceDate.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(87, 70);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "THÊM";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(197, 70);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "CẬP NHẬT";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(297, 70);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "XÓA";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // gbList
            // 
            gbList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbList.Controls.Add(listViewInvoice);
            gbList.Location = new Point(12, 99);
            gbList.Name = "gbList";
            gbList.Size = new Size(419, 127);
            gbList.TabIndex = 7;
            gbList.TabStop = false;
            gbList.Text = "DANH SÁCH MUA HÀNG";
            // 
            // listViewInvoice
            // 
            listViewInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewInvoice.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewInvoice.FullRowSelect = true;
            listViewInvoice.GridLines = true;
            listViewInvoice.Location = new Point(6, 22);
            listViewInvoice.Name = "listViewInvoice";
            listViewInvoice.Size = new Size(407, 99);
            listViewInvoice.TabIndex = 0;
            listViewInvoice.UseCompatibleStateImageBehavior = false;
            listViewInvoice.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "MÃ KHÁCH HÀNG";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "NGÀY TẠO HÓA ĐƠN";
            columnHeader3.Width = 150;
            // 
            // FormInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 238);
            Controls.Add(gbList);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dtpInvoiceDate);
            Controls.Add(txtCustomerID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormInvoice";
            Text = "Quản lý thông tin mua hàng";
            gbList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCustomerID;
        private DateTimePicker dtpInvoiceDate;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private GroupBox gbList;
        private ListView listViewInvoice;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}