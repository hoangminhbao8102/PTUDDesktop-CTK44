namespace Lab2_BaiTap
{
    partial class frmTimThongTin
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
            gboTimTheo = new GroupBox();
            rdSoDT = new RadioButton();
            rdHoTen = new RadioButton();
            rdMaGV = new RadioButton();
            txtTimKiem = new TextBox();
            btnOK = new Button();
            lbTimTheo = new Label();
            gboTimTheo.SuspendLayout();
            SuspendLayout();
            // 
            // gboTimTheo
            // 
            gboTimTheo.Controls.Add(rdSoDT);
            gboTimTheo.Controls.Add(rdHoTen);
            gboTimTheo.Controls.Add(rdMaGV);
            gboTimTheo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gboTimTheo.Location = new Point(28, 28);
            gboTimTheo.Name = "gboTimTheo";
            gboTimTheo.Size = new Size(398, 105);
            gboTimTheo.TabIndex = 0;
            gboTimTheo.TabStop = false;
            gboTimTheo.Text = "Tìm theo";
            // 
            // rdSoDT
            // 
            rdSoDT.AutoSize = true;
            rdSoDT.Location = new Point(276, 46);
            rdSoDT.Name = "rdSoDT";
            rdSoDT.Size = new Size(106, 23);
            rdSoDT.TabIndex = 2;
            rdSoDT.Text = "Số điện thoại";
            rdSoDT.UseVisualStyleBackColor = true;
            rdSoDT.CheckedChanged += rdSoDT_CheckedChanged;
            // 
            // rdHoTen
            // 
            rdHoTen.AutoSize = true;
            rdHoTen.Location = new Point(148, 46);
            rdHoTen.Name = "rdHoTen";
            rdHoTen.Size = new Size(73, 23);
            rdHoTen.TabIndex = 1;
            rdHoTen.Text = "Họ Tên";
            rdHoTen.UseVisualStyleBackColor = true;
            rdHoTen.CheckedChanged += rdHoTen_CheckedChanged;
            // 
            // rdMaGV
            // 
            rdMaGV.AutoSize = true;
            rdMaGV.Checked = true;
            rdMaGV.Location = new Point(29, 46);
            rdMaGV.Name = "rdMaGV";
            rdMaGV.Size = new Size(74, 23);
            rdMaGV.TabIndex = 0;
            rdMaGV.TabStop = true;
            rdMaGV.Text = "Mã GV";
            rdMaGV.UseVisualStyleBackColor = true;
            rdMaGV.CheckedChanged += rdMaGV_CheckedChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(135, 145);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(194, 26);
            txtTimKiem.TabIndex = 2;
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(335, 139);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 41);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lbTimTheo
            // 
            lbTimTheo.AutoSize = true;
            lbTimTheo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTimTheo.Location = new Point(44, 148);
            lbTimTheo.Name = "lbTimTheo";
            lbTimTheo.Size = new Size(45, 19);
            lbTimTheo.TabIndex = 1;
            lbTimTheo.Text = "label1";
            // 
            // frmTimThongTin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 192);
            Controls.Add(lbTimTheo);
            Controls.Add(btnOK);
            Controls.Add(txtTimKiem);
            Controls.Add(gboTimTheo);
            Name = "frmTimThongTin";
            Text = "Tìm thông tin Giáo Viên";
            gboTimTheo.ResumeLayout(false);
            gboTimTheo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gboTimTheo;
        private RadioButton rdSoDT;
        private RadioButton rdHoTen;
        private RadioButton rdMaGV;
        private TextBox txtTimKiem;
        private Button btnOK;
        private Label lbTimTheo;
    }
}