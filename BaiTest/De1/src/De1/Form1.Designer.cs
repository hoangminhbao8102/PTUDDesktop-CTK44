namespace De1
{
    partial class frmKhachHang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMaKH = new TextBox();
            txtTenKH = new TextBox();
            mtxtSoDT = new MaskedTextBox();
            label5 = new Label();
            txtDiaChi = new TextBox();
            btnMacDinh = new Button();
            btnLuu = new Button();
            grbTimKiem = new GroupBox();
            txtTimKiem = new TextBox();
            rbtnTheoSDT = new RadioButton();
            rbtnTheoTen = new RadioButton();
            dgvKhachHang = new DataGridView();
            MaKH = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            DiaChiGH = new DataGridViewTextBoxColumn();
            btnXuatExcel = new Button();
            grbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 73);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 15);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ giao hàng";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(110, 12);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new Size(140, 23);
            txtMaKH.TabIndex = 4;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(110, 41);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(140, 23);
            txtTenKH.TabIndex = 5;
            // 
            // mtxtSoDT
            // 
            mtxtSoDT.Location = new Point(110, 70);
            mtxtSoDT.Mask = "0000000000";
            mtxtSoDT.Name = "mtxtSoDT";
            mtxtSoDT.Size = new Size(140, 23);
            mtxtSoDT.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 172);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 7;
            label5.Text = "Danh sách khách hàng";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(256, 44);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(304, 49);
            txtDiaChi.TabIndex = 8;
            // 
            // btnMacDinh
            // 
            btnMacDinh.Location = new Point(155, 99);
            btnMacDinh.Name = "btnMacDinh";
            btnMacDinh.Size = new Size(75, 23);
            btnMacDinh.TabIndex = 9;
            btnMacDinh.Text = "Mặc định";
            btnMacDinh.UseVisualStyleBackColor = true;
            btnMacDinh.Click += btnMacDinh_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(293, 99);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // grbTimKiem
            // 
            grbTimKiem.Controls.Add(txtTimKiem);
            grbTimKiem.Controls.Add(rbtnTheoSDT);
            grbTimKiem.Controls.Add(rbtnTheoTen);
            grbTimKiem.Location = new Point(185, 128);
            grbTimKiem.Name = "grbTimKiem";
            grbTimKiem.Size = new Size(375, 59);
            grbTimKiem.TabIndex = 11;
            grbTimKiem.TabStop = false;
            grbTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(165, 22);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(204, 23);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // rbtnTheoSDT
            // 
            rbtnTheoSDT.AutoSize = true;
            rbtnTheoSDT.Location = new Point(84, 23);
            rbtnTheoSDT.Name = "rbtnTheoSDT";
            rbtnTheoSDT.Size = new Size(75, 19);
            rbtnTheoSDT.TabIndex = 1;
            rbtnTheoSDT.Text = "Theo SDT";
            rbtnTheoSDT.UseVisualStyleBackColor = true;
            // 
            // rbtnTheoTen
            // 
            rbtnTheoTen.AutoSize = true;
            rbtnTheoTen.Checked = true;
            rbtnTheoTen.Location = new Point(6, 23);
            rbtnTheoTen.Name = "rbtnTheoTen";
            rbtnTheoTen.Size = new Size(72, 19);
            rbtnTheoTen.TabIndex = 0;
            rbtnTheoTen.TabStop = true;
            rbtnTheoTen.Text = "Theo tên";
            rbtnTheoTen.UseVisualStyleBackColor = true;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKH, TenKH, SoDienThoai, DiaChiGH });
            dgvKhachHang.Location = new Point(12, 190);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.Size = new Size(548, 150);
            dgvKhachHang.TabIndex = 12;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // MaKH
            // 
            MaKH.HeaderText = "Mã KH";
            MaKH.Name = "MaKH";
            // 
            // TenKH
            // 
            TenKH.HeaderText = "Tên khách hàng";
            TenKH.Name = "TenKH";
            TenKH.Width = 150;
            // 
            // SoDienThoai
            // 
            SoDienThoai.HeaderText = "Số ĐT";
            SoDienThoai.Name = "SoDienThoai";
            // 
            // DiaChiGH
            // 
            DiaChiGH.HeaderText = "Địa chỉ giao hàng";
            DiaChiGH.Name = "DiaChiGH";
            DiaChiGH.Width = 150;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(467, 346);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(75, 23);
            btnXuatExcel.TabIndex = 13;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 378);
            Controls.Add(btnXuatExcel);
            Controls.Add(dgvKhachHang);
            Controls.Add(grbTimKiem);
            Controls.Add(btnLuu);
            Controls.Add(btnMacDinh);
            Controls.Add(txtDiaChi);
            Controls.Add(label5);
            Controls.Add(mtxtSoDT);
            Controls.Add(txtTenKH);
            Controls.Add(txtMaKH);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmKhachHang";
            Text = "Quản lý khách hàng";
            grbTimKiem.ResumeLayout(false);
            grbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMaKH;
        private TextBox txtTenKH;
        private MaskedTextBox mtxtSoDT;
        private Label label5;
        private TextBox txtDiaChi;
        private Button btnMacDinh;
        private Button btnLuu;
        private GroupBox grbTimKiem;
        private RadioButton rbtnTheoSDT;
        private RadioButton rbtnTheoTen;
        private TextBox txtTimKiem;
        private DataGridView dgvKhachHang;
        private Button btnXuatExcel;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn DiaChiGH;
    }
}
