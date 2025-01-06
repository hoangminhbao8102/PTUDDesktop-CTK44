namespace Lab09_Entity_Framework
{
    partial class SalesLogForm
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
            listViewSalesLog = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // listViewSalesLog
            // 
            listViewSalesLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewSalesLog.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewSalesLog.FullRowSelect = true;
            listViewSalesLog.GridLines = true;
            listViewSalesLog.Location = new Point(12, 12);
            listViewSalesLog.Name = "listViewSalesLog";
            listViewSalesLog.Size = new Size(755, 426);
            listViewSalesLog.TabIndex = 0;
            listViewSalesLog.UseCompatibleStateImageBehavior = false;
            listViewSalesLog.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên hóa đơn";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ngày thanh toán";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên tài khoản";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Số tiền";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Giảm giá";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Thuế";
            columnHeader6.Width = 100;
            // 
            // SalesLogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 450);
            Controls.Add(listViewSalesLog);
            Name = "SalesLogForm";
            Text = "Xem nhật ký bán hàng";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewSalesLog;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}