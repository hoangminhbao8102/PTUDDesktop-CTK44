namespace Lab2_BaiTap
{
    partial class frmTBGiaoVien
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
            lblThongBao = new Label();
            SuspendLayout();
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblThongBao.ForeColor = Color.Purple;
            lblThongBao.Location = new Point(60, 75);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(70, 27);
            lblThongBao.TabIndex = 0;
            lblThongBao.Text = "label1";
            // 
            // frmTBGiaoVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblThongBao);
            Name = "frmTBGiaoVien";
            Text = "Thông tin giáo viên nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThongBao;
    }
}