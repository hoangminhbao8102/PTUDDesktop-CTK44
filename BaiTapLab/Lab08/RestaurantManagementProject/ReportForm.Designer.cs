namespace RestaurantManagementProject
{
    partial class ReportForm
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
            lblTotalRevenue = new Label();
            dtpFromDate = new DateTimePicker();
            dtpToDate = new DateTimePicker();
            btnExportToExcel = new Button();
            btnGenerateReport = new Button();
            grpList = new GroupBox();
            dgvReport = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 18);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Đến ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 234);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 2;
            label3.Text = "Tổng doanh thu:";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Location = new Point(120, 234);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(16, 15);
            lblTotalRevenue.TabIndex = 3;
            lblTotalRevenue.Text = "...";
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(68, 12);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(200, 23);
            dtpFromDate.TabIndex = 4;
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new Point(337, 12);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(200, 23);
            dtpToDate.TabIndex = 5;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.Location = new Point(507, 230);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(75, 23);
            btnExportToExcel.TabIndex = 6;
            btnExportToExcel.Text = "Xuất Excel";
            btnExportToExcel.UseVisualStyleBackColor = true;
            btnExportToExcel.Click += btnExportToExcel_Click;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(543, 12);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(89, 23);
            btnGenerateReport.TabIndex = 7;
            btnGenerateReport.Text = "Tạo báo cáo";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // grpList
            // 
            grpList.Controls.Add(dgvReport);
            grpList.Location = new Point(12, 41);
            grpList.Name = "grpList";
            grpList.Size = new Size(629, 183);
            grpList.TabIndex = 8;
            grpList.TabStop = false;
            grpList.Text = "Hiển thị báo cáo";
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvReport.Location = new Point(6, 22);
            dgvReport.Name = "dgvReport";
            dgvReport.Size = new Size(614, 150);
            dgvReport.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ngày";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Hóa đơn";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Tổng tiền";
            Column3.Name = "Column3";
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 266);
            Controls.Add(grpList);
            Controls.Add(btnGenerateReport);
            Controls.Add(btnExportToExcel);
            Controls.Add(dtpToDate);
            Controls.Add(dtpFromDate);
            Controls.Add(lblTotalRevenue);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReportForm";
            Text = "Báo cáo doanh thu";
            grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTotalRevenue;
        private DateTimePicker dtpFromDate;
        private DateTimePicker dtpToDate;
        private Button btnExportToExcel;
        private Button btnGenerateReport;
        private GroupBox grpList;
        private DataGridView dgvReport;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}