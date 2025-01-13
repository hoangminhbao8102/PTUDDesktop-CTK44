namespace De1
{
    partial class frmBanHang
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpNgayXuat = new DateTimePicker();
            cboKhachHang = new ComboBox();
            btnThemKhachHang = new Button();
            dgvChiTietBanHang = new DataGridView();
            txtTongTien = new TextBox();
            nudGiamGia = new NumericUpDown();
            label8 = new Label();
            txtPhaiTra = new TextBox();
            btnLuu = new Button();
            btnHuy = new Button();
            btnChon = new Button();
            TenHang = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietBanHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGiamGia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 9);
            label1.Name = "label1";
            label1.Size = new Size(320, 40);
            label1.TabIndex = 0;
            label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Ngày xuất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 55);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 78);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 3;
            label4.Text = "Chi tiết bán hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 255);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Tổng tiền";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(223, 255);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 5;
            label6.Text = "% Giảm giá";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(393, 255);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 6;
            label7.Text = "Phải trả";
            // 
            // dtpNgayXuat
            // 
            dtpNgayXuat.CustomFormat = "dd/MM/yyyy";
            dtpNgayXuat.Format = DateTimePickerFormat.Custom;
            dtpNgayXuat.Location = new Point(78, 52);
            dtpNgayXuat.Name = "dtpNgayXuat";
            dtpNgayXuat.Size = new Size(200, 23);
            dtpNgayXuat.TabIndex = 7;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(360, 52);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(121, 23);
            cboKhachHang.TabIndex = 8;
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.Location = new Point(487, 51);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new Size(75, 23);
            btnThemKhachHang.TabIndex = 9;
            btnThemKhachHang.Text = "+";
            btnThemKhachHang.UseVisualStyleBackColor = true;
            btnThemKhachHang.Click += btnThemKhachHang_Click;
            // 
            // dgvChiTietBanHang
            // 
            dgvChiTietBanHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietBanHang.Columns.AddRange(new DataGridViewColumn[] { TenHang, SoLuong, DonGia, ThanhTien });
            dgvChiTietBanHang.Location = new Point(12, 96);
            dgvChiTietBanHang.Name = "dgvChiTietBanHang";
            dgvChiTietBanHang.Size = new Size(554, 150);
            dgvChiTietBanHang.TabIndex = 10;
            dgvChiTietBanHang.CellValueChanged += dgvChiTietBanHang_CellValueChanged;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(90, 252);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(100, 23);
            txtTongTien.TabIndex = 11;
            txtTongTien.TextChanged += txtTongTien_TextChanged;
            // 
            // nudGiamGia
            // 
            nudGiamGia.Location = new Point(296, 252);
            nudGiamGia.Name = "nudGiamGia";
            nudGiamGia.Size = new Size(48, 23);
            nudGiamGia.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(350, 255);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 13;
            label8.Text = "%";
            // 
            // txtPhaiTra
            // 
            txtPhaiTra.Location = new Point(446, 252);
            txtPhaiTra.Name = "txtPhaiTra";
            txtPhaiTra.ReadOnly = true;
            txtPhaiTra.Size = new Size(100, 23);
            txtPhaiTra.TabIndex = 14;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(203, 281);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(310, 281);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(89, 23);
            btnHuy.TabIndex = 16;
            btnHuy.Text = "Hủy hóa đơn";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnChon
            // 
            btnChon.Location = new Point(430, 281);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(107, 23);
            btnChon.TabIndex = 17;
            btnChon.Text = "Chọn HĐ để bán";
            btnChon.UseVisualStyleBackColor = true;
            // 
            // TenHang
            // 
            TenHang.HeaderText = "Tên hàng";
            TenHang.Name = "TenHang";
            TenHang.Width = 200;
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số lượng";
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.HeaderText = "Đơn giá";
            DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.Name = "ThanhTien";
            // 
            // frmBanHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 312);
            Controls.Add(btnChon);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtPhaiTra);
            Controls.Add(label8);
            Controls.Add(nudGiamGia);
            Controls.Add(txtTongTien);
            Controls.Add(dgvChiTietBanHang);
            Controls.Add(btnThemKhachHang);
            Controls.Add(cboKhachHang);
            Controls.Add(dtpNgayXuat);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBanHang";
            Text = "Quản lý bán hàng";
            ((System.ComponentModel.ISupportInitialize)dgvChiTietBanHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGiamGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpNgayXuat;
        private ComboBox cboKhachHang;
        private Button btnThemKhachHang;
        private DataGridView dgvChiTietBanHang;
        private TextBox txtTongTien;
        private NumericUpDown nudGiamGia;
        private Label label8;
        private TextBox txtPhaiTra;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnChon;
        private DataGridViewTextBoxColumn TenHang;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}