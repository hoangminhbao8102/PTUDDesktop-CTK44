namespace Lab7_Advanced_Command
{
    partial class OrderDetailsForm
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
            lblBillID = new Label();
            dgvBillDetails = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBillDetails).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã số hóa đơn:";
            // 
            // lblBillID
            // 
            lblBillID.AutoSize = true;
            lblBillID.Location = new Point(164, 9);
            lblBillID.Name = "lblBillID";
            lblBillID.Size = new Size(16, 15);
            lblBillID.TabIndex = 1;
            lblBillID.Text = "...";
            // 
            // dgvBillDetails
            // 
            dgvBillDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillDetails.Location = new Point(12, 27);
            dgvBillDetails.Name = "dgvBillDetails";
            dgvBillDetails.Size = new Size(553, 298);
            dgvBillDetails.TabIndex = 2;
            // 
            // OrderDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 346);
            Controls.Add(dgvBillDetails);
            Controls.Add(lblBillID);
            Controls.Add(label1);
            Name = "OrderDetailsForm";
            Text = "OrderDetailsForm";
            Load += OrderDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBillDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblBillID;
        private DataGridView dgvBillDetails;
    }
}