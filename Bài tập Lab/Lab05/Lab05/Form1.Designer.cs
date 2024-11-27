namespace Lab05
{
    partial class frmSinhVien
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            gboDSSV = new GroupBox();
            lvDanhSachSinhVien = new ListView();
            chMSSV = new ColumnHeader();
            chHoTenLot = new ColumnHeader();
            chTen = new ColumnHeader();
            chNgaySinh = new ColumnHeader();
            chLop = new ColumnHeader();
            chCMND = new ColumnHeader();
            chSoDT = new ColumnHeader();
            chDiaChi = new ColumnHeader();
            chGioiTinh = new ColumnHeader();
            chMonHoc = new ColumnHeader();
            mtxtMSSV = new MaskedTextBox();
            txtHoVaTenLot = new TextBox();
            rdNam = new RadioButton();
            rdNu = new RadioButton();
            txtTen = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            txtCMND = new TextBox();
            cboLop = new ComboBox();
            mtxtSoDienThoai = new MaskedTextBox();
            txtDiaChi = new TextBox();
            clbMonHocDangKy = new CheckedListBox();
            btnTimKiem = new Button();
            btnThemMoi = new Button();
            btnCapNhat = new Button();
            btnThoat = new Button();
            gboDSSV.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 15);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "MSSV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 44);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên lót";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 44);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 76);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 1;
            label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 102);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 1;
            label5.Text = "Số CMND";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 131);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 1;
            label6.Text = "Địa chỉ liên lạc";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 177);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 1;
            label7.Text = "Môn học đăng ký";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(350, 15);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 1;
            label8.Text = "Giới tính";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(350, 102);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 1;
            label9.Text = "Số điện thoại";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(350, 76);
            label10.Name = "label10";
            label10.Size = new Size(27, 15);
            label10.TabIndex = 1;
            label10.Text = "Lớp";
            // 
            // gboDSSV
            // 
            gboDSSV.Controls.Add(lvDanhSachSinhVien);
            gboDSSV.Location = new Point(12, 268);
            gboDSSV.Name = "gboDSSV";
            gboDSSV.Size = new Size(660, 170);
            gboDSSV.TabIndex = 0;
            gboDSSV.TabStop = false;
            gboDSSV.Text = "Danh sách sinh viên";
            // 
            // lvDanhSachSinhVien
            // 
            lvDanhSachSinhVien.CheckBoxes = true;
            lvDanhSachSinhVien.Columns.AddRange(new ColumnHeader[] { chMSSV, chHoTenLot, chTen, chNgaySinh, chLop, chCMND, chSoDT, chDiaChi, chGioiTinh, chMonHoc });
            lvDanhSachSinhVien.Dock = DockStyle.Fill;
            lvDanhSachSinhVien.GridLines = true;
            lvDanhSachSinhVien.Location = new Point(3, 19);
            lvDanhSachSinhVien.Name = "lvDanhSachSinhVien";
            lvDanhSachSinhVien.Size = new Size(654, 148);
            lvDanhSachSinhVien.TabIndex = 0;
            lvDanhSachSinhVien.UseCompatibleStateImageBehavior = false;
            lvDanhSachSinhVien.View = View.Details;
            lvDanhSachSinhVien.SelectedIndexChanged += lvDanhSachSinhVien_SelectedIndexChanged;
            // 
            // chMSSV
            // 
            chMSSV.Text = "MSSV";
            chMSSV.Width = 80;
            // 
            // chHoTenLot
            // 
            chHoTenLot.Text = "Họ và tên lót";
            chHoTenLot.Width = 150;
            // 
            // chTen
            // 
            chTen.Text = "Tên";
            chTen.Width = 100;
            // 
            // chNgaySinh
            // 
            chNgaySinh.Text = "Ngày sinh";
            chNgaySinh.Width = 100;
            // 
            // chLop
            // 
            chLop.Text = "Lớp";
            chLop.Width = 80;
            // 
            // chCMND
            // 
            chCMND.Text = "Số CMND";
            chCMND.Width = 100;
            // 
            // chSoDT
            // 
            chSoDT.Text = "Số ĐT";
            chSoDT.Width = 100;
            // 
            // chDiaChi
            // 
            chDiaChi.Text = "Địa chỉ liên lạc";
            chDiaChi.Width = 200;
            // 
            // chGioiTinh
            // 
            chGioiTinh.Text = "Giới tính";
            chGioiTinh.Width = 80;
            // 
            // chMonHoc
            // 
            chMonHoc.Text = "Môn học đăng ký";
            chMonHoc.Width = 300;
            // 
            // mtxtMSSV
            // 
            mtxtMSSV.Location = new Point(145, 12);
            mtxtMSSV.Mask = "0000000";
            mtxtMSSV.Name = "mtxtMSSV";
            mtxtMSSV.Size = new Size(199, 23);
            mtxtMSSV.TabIndex = 2;
            // 
            // txtHoVaTenLot
            // 
            txtHoVaTenLot.Location = new Point(145, 41);
            txtHoVaTenLot.Name = "txtHoVaTenLot";
            txtHoVaTenLot.Size = new Size(199, 23);
            txtHoVaTenLot.TabIndex = 5;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Location = new Point(432, 13);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(51, 19);
            rdNam.TabIndex = 3;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(489, 13);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(41, 19);
            rdNu.TabIndex = 4;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(432, 41);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(219, 23);
            txtTen.TabIndex = 6;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(145, 70);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(199, 23);
            dtpNgaySinh.TabIndex = 7;
            // 
            // txtCMND
            // 
            txtCMND.Location = new Point(145, 99);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(199, 23);
            txtCMND.TabIndex = 9;
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Items.AddRange(new object[] { "CTK43", "CTK44", "CTK45", "CTK46" });
            cboLop.Location = new Point(432, 70);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(219, 23);
            cboLop.TabIndex = 8;
            // 
            // mtxtSoDienThoai
            // 
            mtxtSoDienThoai.Location = new Point(432, 99);
            mtxtSoDienThoai.Mask = "0000.000.000";
            mtxtSoDienThoai.Name = "mtxtSoDienThoai";
            mtxtSoDienThoai.Size = new Size(219, 23);
            mtxtSoDienThoai.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(145, 128);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(506, 23);
            txtDiaChi.TabIndex = 11;
            // 
            // clbMonHocDangKy
            // 
            clbMonHocDangKy.CheckOnClick = true;
            clbMonHocDangKy.FormattingEnabled = true;
            clbMonHocDangKy.Items.AddRange(new object[] { "Mạng máy tính", "Hệ điều hành", "Lập trình CSDL", "Lập trình mạng", "Đồ án cơ sở", "Phương pháp NCKH", "Lập trình trên thiết bị di động", "An toàn và bảo mật hệ thống" });
            clbMonHocDangKy.Location = new Point(145, 157);
            clbMonHocDangKy.Name = "clbMonHocDangKy";
            clbMonHocDangKy.Size = new Size(506, 76);
            clbMonHocDangKy.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(321, 239);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Location = new Point(402, 239);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(75, 23);
            btnThemMoi.TabIndex = 14;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(483, 239);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(75, 23);
            btnCapNhat.TabIndex = 15;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(564, 239);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThemMoi);
            Controls.Add(btnTimKiem);
            Controls.Add(clbMonHocDangKy);
            Controls.Add(txtDiaChi);
            Controls.Add(mtxtSoDienThoai);
            Controls.Add(cboLop);
            Controls.Add(txtCMND);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtTen);
            Controls.Add(rdNu);
            Controls.Add(rdNam);
            Controls.Add(txtHoVaTenLot);
            Controls.Add(mtxtMSSV);
            Controls.Add(gboDSSV);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSinhVien";
            Text = "Nhập thông tin sinh viên";
            Load += frmSinhVien_Load;
            gboDSSV.ResumeLayout(false);
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
        private Label label9;
        private Label label10;
        private GroupBox gboDSSV;
        private MaskedTextBox mtxtMSSV;
        private TextBox txtHoVaTenLot;
        private RadioButton rdNam;
        private RadioButton rdNu;
        private TextBox txtTen;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtCMND;
        private ComboBox cboLop;
        private MaskedTextBox mtxtSoDienThoai;
        private TextBox txtDiaChi;
        private CheckedListBox clbMonHocDangKy;
        private Button btnTimKiem;
        private Button btnThemMoi;
        private Button btnCapNhat;
        private Button btnThoat;
        private ListView lvDanhSachSinhVien;
        private ColumnHeader chMSSV;
        private ColumnHeader chHoTenLot;
        private ColumnHeader chTen;
        private ColumnHeader chNgaySinh;
        private ColumnHeader chLop;
        private ColumnHeader chCMND;
        private ColumnHeader chSoDT;
        private ColumnHeader chDiaChi;
        private ColumnHeader chGioiTinh;
        private ColumnHeader chMonHoc;
    }
}
