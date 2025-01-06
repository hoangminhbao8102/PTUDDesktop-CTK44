namespace Lab09_Entity_Framework
{
    partial class TableForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtStatus = new TextBox();
            txtCapacity = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label4 = new Label();
            lvTables = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsmiDeleteTable = new ToolStripMenuItem();
            tsmiViewBillDetails = new ToolStripMenuItem();
            tsmiViewSalesLog = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên bàn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 44);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 73);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Số lượng chỗ";
            // 
            // txtName
            // 
            txtName.Location = new Point(175, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(182, 23);
            txtName.TabIndex = 3;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(175, 41);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(182, 23);
            txtStatus.TabIndex = 4;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(175, 70);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(182, 23);
            txtCapacity.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(114, 99);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm bàn";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(195, 99);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(276, 99);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa bàn";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 125);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 9;
            label4.Text = "Danh sách bàn";
            // 
            // lvTables
            // 
            lvTables.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvTables.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvTables.ContextMenuStrip = contextMenuStrip1;
            lvTables.FullRowSelect = true;
            lvTables.GridLines = true;
            lvTables.Location = new Point(12, 143);
            lvTables.Name = "lvTables";
            lvTables.Size = new Size(408, 295);
            lvTables.TabIndex = 10;
            lvTables.UseCompatibleStateImageBehavior = false;
            lvTables.View = View.Details;
            lvTables.MouseClick += lvTables_MouseClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên bàn";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Trạng thái";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Số lượng";
            columnHeader4.Width = 100;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsmiDeleteTable, tsmiViewBillDetails, tsmiViewSalesLog });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(203, 92);
            // 
            // tsmiDeleteTable
            // 
            tsmiDeleteTable.Name = "tsmiDeleteTable";
            tsmiDeleteTable.Size = new Size(202, 22);
            tsmiDeleteTable.Text = "Xóa bàn";
            tsmiDeleteTable.Click += tsmiDeleteTable_Click;
            // 
            // tsmiViewBillDetails
            // 
            tsmiViewBillDetails.Name = "tsmiViewBillDetails";
            tsmiViewBillDetails.Size = new Size(202, 22);
            tsmiViewBillDetails.Text = "Xem danh mục hóa đơn";
            tsmiViewBillDetails.Click += tsmiViewBillDetails_Click;
            // 
            // tsmiViewSalesLog
            // 
            tsmiViewSalesLog.Name = "tsmiViewSalesLog";
            tsmiViewSalesLog.Size = new Size(202, 22);
            tsmiViewSalesLog.Text = "Xem nhật ký bán hàng";
            tsmiViewSalesLog.Click += tsmiViewSalesLog_Click;
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 450);
            Controls.Add(lvTables);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtCapacity);
            Controls.Add(txtStatus);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TableForm";
            Text = "Quản lý bàn";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtStatus;
        private TextBox txtCapacity;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label4;
        private ListView lvTables;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsmiDeleteTable;
        private ToolStripMenuItem tsmiViewBillDetails;
        private ToolStripMenuItem tsmiViewSalesLog;
    }
}