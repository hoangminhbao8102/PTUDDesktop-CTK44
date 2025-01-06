namespace Lab09_Entity_Framework
{
    partial class BillDetailsForm
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
            lvBillDetails = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lstBills = new ListBox();
            SuspendLayout();
            // 
            // lvBillDetails
            // 
            lvBillDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvBillDetails.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvBillDetails.FullRowSelect = true;
            lvBillDetails.GridLines = true;
            lvBillDetails.Location = new Point(12, 12);
            lvBillDetails.Name = "lvBillDetails";
            lvBillDetails.Size = new Size(306, 363);
            lvBillDetails.TabIndex = 0;
            lvBillDetails.UseCompatibleStateImageBehavior = false;
            lvBillDetails.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên món ăn";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số lượng";
            columnHeader3.Width = 100;
            // 
            // lstBills
            // 
            lstBills.FormattingEnabled = true;
            lstBills.ItemHeight = 15;
            lstBills.Location = new Point(324, 12);
            lstBills.Name = "lstBills";
            lstBills.Size = new Size(390, 364);
            lstBills.TabIndex = 1;
            lstBills.SelectedIndexChanged += lstBills_SelectedIndexChanged;
            // 
            // BillDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 387);
            Controls.Add(lstBills);
            Controls.Add(lvBillDetails);
            Name = "BillDetailsForm";
            Text = "Chi tiết hóa đơn";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvBillDetails;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListBox lstBills;
    }
}