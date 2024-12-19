namespace Lab7_Advanced_Command
{
    partial class ActivityLogForm
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
            dgvActivityLogs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvActivityLogs).BeginInit();
            SuspendLayout();
            // 
            // dgvActivityLogs
            // 
            dgvActivityLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivityLogs.Location = new Point(12, 12);
            dgvActivityLogs.Name = "dgvActivityLogs";
            dgvActivityLogs.Size = new Size(560, 426);
            dgvActivityLogs.TabIndex = 0;
            // 
            // ActivityLogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 450);
            Controls.Add(dgvActivityLogs);
            Name = "ActivityLogForm";
            Text = "ActivityLogForm";
            ((System.ComponentModel.ISupportInitialize)dgvActivityLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvActivityLogs;
    }
}