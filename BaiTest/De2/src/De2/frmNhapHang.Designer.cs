namespace De2
{
    partial class frmNhapHang
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
            label8 = new Label();
            dtpNgayNhap = new DateTimePicker();
            cboNhaCungCap = new ComboBox();
            btnThemNCC = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            button4 = new Button();
            dgvChiTietNhap = new DataGridView();
            txtTongTien = new TextBox();
            txtPhaiTra = new TextBox();
            nudGiamGia = new NumericUpDown();
            TenHang = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGiaNhap = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGiamGia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 9);
            label1.Name = "label1";
            label1.Size = new Size(341, 40);
            label1.TabIndex = 0;
            label1.Text = "HÓA ĐƠN NHẬP HÀNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Ngày nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 55);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Nhà cung cấp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 78);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 3;
            label4.Text = "Chi tiết hàng nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 255);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Tổng tiền";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(247, 255);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 5;
            label6.Text = "% Giảm giá";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(392, 255);
            label7.Name = "label7";
            label7.Size = new Size(17, 15);
            label7.TabIndex = 6;
            label7.Text = "%";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(471, 255);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 7;
            label8.Text = "Phải trả";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.Location = new Point(83, 52);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(200, 23);
            dtpNgayNhap.TabIndex = 8;
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(440, 52);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(121, 23);
            cboNhaCungCap.TabIndex = 9;
            // 
            // btnThemNCC
            // 
            btnThemNCC.Location = new Point(567, 51);
            btnThemNCC.Name = "btnThemNCC";
            btnThemNCC.Size = new Size(75, 23);
            btnThemNCC.TabIndex = 10;
            btnThemNCC.Text = "+";
            btnThemNCC.UseVisualStyleBackColor = true;
            btnThemNCC.Click += btnThemNCC_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(258, 281);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(357, 281);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(86, 23);
            btnHuy.TabIndex = 12;
            btnHuy.Text = "Hủy hóa đơn";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(462, 281);
            button4.Name = "button4";
            button4.Size = new Size(99, 23);
            button4.TabIndex = 13;
            button4.Text = "Chọn HĐ nhập";
            button4.UseVisualStyleBackColor = true;
            // 
            // dgvChiTietNhap
            // 
            dgvChiTietNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietNhap.Columns.AddRange(new DataGridViewColumn[] { TenHang, SoLuong, DonGiaNhap, ThanhTien });
            dgvChiTietNhap.Location = new Point(12, 96);
            dgvChiTietNhap.Name = "dgvChiTietNhap";
            dgvChiTietNhap.Size = new Size(651, 150);
            dgvChiTietNhap.TabIndex = 14;
            dgvChiTietNhap.CellValueChanged += dgvChiTietNhap_CellValueChanged;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(117, 252);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(100, 23);
            txtTongTien.TabIndex = 15;
            // 
            // txtPhaiTra
            // 
            txtPhaiTra.Location = new Point(524, 252);
            txtPhaiTra.Name = "txtPhaiTra";
            txtPhaiTra.ReadOnly = true;
            txtPhaiTra.Size = new Size(100, 23);
            txtPhaiTra.TabIndex = 16;
            // 
            // nudGiamGia
            // 
            nudGiamGia.Location = new Point(320, 252);
            nudGiamGia.Name = "nudGiamGia";
            nudGiamGia.Size = new Size(66, 23);
            nudGiamGia.TabIndex = 17;
            nudGiamGia.ValueChanged += nudGiamGia_ValueChanged;
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
            // DonGiaNhap
            // 
            DonGiaNhap.HeaderText = "Đơn giá nhập";
            DonGiaNhap.Name = "DonGiaNhap";
            DonGiaNhap.Width = 150;
            // 
            // ThanhTien
            // 
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.Name = "ThanhTien";
            ThanhTien.Width = 150;
            // 
            // frmNhapHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 314);
            Controls.Add(nudGiamGia);
            Controls.Add(txtPhaiTra);
            Controls.Add(txtTongTien);
            Controls.Add(dgvChiTietNhap);
            Controls.Add(button4);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnThemNCC);
            Controls.Add(cboNhaCungCap);
            Controls.Add(dtpNgayNhap);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNhapHang";
            Text = "Quản lý nhập hàng";
            ((System.ComponentModel.ISupportInitialize)dgvChiTietNhap).EndInit();
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
        private Label label8;
        private DateTimePicker dtpNgayNhap;
        private ComboBox cboNhaCungCap;
        private Button btnThemNCC;
        private Button btnLuu;
        private Button btnHuy;
        private Button button4;
        private DataGridView dgvChiTietNhap;
        private TextBox txtTongTien;
        private TextBox txtPhaiTra;
        private NumericUpDown nudGiamGia;
        private DataGridViewTextBoxColumn TenHang;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGiaNhap;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}