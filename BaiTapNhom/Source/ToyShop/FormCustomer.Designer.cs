namespace ToyShop
{
    partial class FormCustomer
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
            txtCustomerName = new TextBox();
            txtPhoneNumber = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnViewCustomers = new Button();
            listViewCustomer = new ListView();
            gbList = new GroupBox();
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
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "TÊN KHÁCH HÀNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "SỐ ĐIỆN THOẠI";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(128, 12);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(250, 23);
            txtCustomerName.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(128, 41);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(250, 23);
            txtPhoneNumber.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 70);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "THÊM";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(93, 70);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "CẬP NHẬT";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(174, 70);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "XÓA";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnViewCustomers
            // 
            btnViewCustomers.Location = new Point(255, 70);
            btnViewCustomers.Name = "btnViewCustomers";
            btnViewCustomers.Size = new Size(116, 23);
            btnViewCustomers.TabIndex = 7;
            btnViewCustomers.Text = "XEM DANH SÁCH";
            btnViewCustomers.UseVisualStyleBackColor = true;
            btnViewCustomers.Click += btnViewCustomers_Click;
            // 
            // listViewCustomer
            // 
            listViewCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewCustomer.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewCustomer.FullRowSelect = true;
            listViewCustomer.GridLines = true;
            listViewCustomer.Location = new Point(6, 22);
            listViewCustomer.Name = "listViewCustomer";
            listViewCustomer.Size = new Size(354, 107);
            listViewCustomer.TabIndex = 8;
            listViewCustomer.UseCompatibleStateImageBehavior = false;
            listViewCustomer.View = View.Details;
            // 
            // gbList
            // 
            gbList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbList.Controls.Add(listViewCustomer);
            gbList.Location = new Point(12, 99);
            gbList.Name = "gbList";
            gbList.Size = new Size(366, 135);
            gbList.TabIndex = 9;
            gbList.TabStop = false;
            gbList.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "TÊN KHÁCH HÀNG";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "SỐ ĐIỆN THOẠI";
            columnHeader3.Width = 100;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 246);
            Controls.Add(gbList);
            Controls.Add(btnViewCustomers);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtCustomerName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCustomer";
            Text = "Quản lý thông tin khách hàng";
            gbList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCustomerName;
        private TextBox txtPhoneNumber;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnViewCustomers;
        private ListView listViewCustomer;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private GroupBox gbList;
    }
}