namespace Lab3_Demo
{
    partial class frmTuyChon
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
            gboTuyChon = new GroupBox();
            rdNgaySinh = new RadioButton();
            rdHoTen = new RadioButton();
            rdMaSV = new RadioButton();
            gboTim = new GroupBox();
            txtTim = new TextBox();
            btnTim = new Button();
            label1 = new Label();
            btnSapXep = new Button();
            Thoát = new Button();
            gboTuyChon.SuspendLayout();
            gboTim.SuspendLayout();
            SuspendLayout();
            // 
            // gboTuyChon
            // 
            gboTuyChon.Controls.Add(rdNgaySinh);
            gboTuyChon.Controls.Add(rdHoTen);
            gboTuyChon.Controls.Add(rdMaSV);
            gboTuyChon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gboTuyChon.Location = new Point(54, 26);
            gboTuyChon.Name = "gboTuyChon";
            gboTuyChon.Size = new Size(379, 52);
            gboTuyChon.TabIndex = 0;
            gboTuyChon.TabStop = false;
            // 
            // rdNgaySinh
            // 
            rdNgaySinh.AutoSize = true;
            rdNgaySinh.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdNgaySinh.ForeColor = Color.Blue;
            rdNgaySinh.Location = new Point(262, 20);
            rdNgaySinh.Name = "rdNgaySinh";
            rdNgaySinh.Size = new Size(96, 23);
            rdNgaySinh.TabIndex = 2;
            rdNgaySinh.Text = "Ngày Sinh";
            rdNgaySinh.UseVisualStyleBackColor = true;
            // 
            // rdHoTen
            // 
            rdHoTen.AutoSize = true;
            rdHoTen.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdHoTen.ForeColor = Color.Blue;
            rdHoTen.Location = new Point(148, 20);
            rdHoTen.Name = "rdHoTen";
            rdHoTen.Size = new Size(77, 23);
            rdHoTen.TabIndex = 1;
            rdHoTen.Text = "Họ Tên";
            rdHoTen.UseVisualStyleBackColor = true;
            // 
            // rdMaSV
            // 
            rdMaSV.AutoSize = true;
            rdMaSV.Checked = true;
            rdMaSV.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdMaSV.ForeColor = Color.Blue;
            rdMaSV.Location = new Point(20, 20);
            rdMaSV.Name = "rdMaSV";
            rdMaSV.Size = new Size(75, 23);
            rdMaSV.TabIndex = 0;
            rdMaSV.TabStop = true;
            rdMaSV.Text = "Mã SV";
            rdMaSV.UseVisualStyleBackColor = true;
            // 
            // gboTim
            // 
            gboTim.Controls.Add(txtTim);
            gboTim.Controls.Add(btnTim);
            gboTim.Controls.Add(label1);
            gboTim.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gboTim.Location = new Point(38, 97);
            gboTim.Name = "gboTim";
            gboTim.Size = new Size(413, 75);
            gboTim.TabIndex = 1;
            gboTim.TabStop = false;
            // 
            // txtTim
            // 
            txtTim.Location = new Point(110, 30);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(216, 26);
            txtTim.TabIndex = 1;
            // 
            // btnTim
            // 
            btnTim.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTim.ForeColor = Color.Purple;
            btnTim.Location = new Point(332, 25);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(75, 34);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(98, 19);
            label1.TabIndex = 0;
            label1.Text = "Nhập thông tin";
            // 
            // btnSapXep
            // 
            btnSapXep.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSapXep.ForeColor = Color.Purple;
            btnSapXep.Location = new Point(91, 183);
            btnSapXep.Name = "btnSapXep";
            btnSapXep.Size = new Size(75, 38);
            btnSapXep.TabIndex = 2;
            btnSapXep.Text = "Sắp Xếp";
            btnSapXep.UseVisualStyleBackColor = true;
            // 
            // Thoát
            // 
            Thoát.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Thoát.ForeColor = Color.Purple;
            Thoát.Location = new Point(304, 183);
            Thoát.Name = "Thoát";
            Thoát.Size = new Size(75, 38);
            Thoát.TabIndex = 3;
            Thoát.Text = "Thoát";
            Thoát.UseVisualStyleBackColor = true;
            // 
            // frmTuyChon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 248);
            Controls.Add(Thoát);
            Controls.Add(btnSapXep);
            Controls.Add(gboTim);
            Controls.Add(gboTuyChon);
            Name = "frmTuyChon";
            Text = "Tùy chọn";
            Load += frmTuyChon_Load;
            gboTuyChon.ResumeLayout(false);
            gboTuyChon.PerformLayout();
            gboTim.ResumeLayout(false);
            gboTim.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboTuyChon;
        public RadioButton rdNgaySinh;
        public RadioButton rdHoTen;
        public RadioButton rdMaSV;
        public GroupBox gboTim;
        public TextBox txtTim;
        public Button btnTim;
        private Label label1;
        public Button btnSapXep;
        private Button Thoát;
    }
}