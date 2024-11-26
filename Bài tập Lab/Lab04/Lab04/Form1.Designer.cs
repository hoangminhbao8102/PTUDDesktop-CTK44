namespace Lab04
{
    partial class frmQuanLySinhVien
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
            components = new System.ComponentModel.Container();
            pbHinh = new PictureBox();
            gboTTSV = new GroupBox();
            btnThoat = new Button();
            btnLuu = new Button();
            btnMacDinh = new Button();
            btnChonHinh = new Button();
            txtHinh = new TextBox();
            cboLop = new ComboBox();
            rdNu = new RadioButton();
            rdNam = new RadioButton();
            mtxtSoDienThoai = new MaskedTextBox();
            dtpNgaySinh = new DateTimePicker();
            txtDiaChi = new TextBox();
            label9 = new Label();
            txtEmail = new TextBox();
            txtHoTen = new TextBox();
            mtxtMSSV = new MaskedTextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gboDSSV = new GroupBox();
            lvSinhVien = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuXoa = new ToolStripMenuItem();
            contextMenuTaiLaiDanhSach = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbHinh).BeginInit();
            gboTTSV.SuspendLayout();
            gboDSSV.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pbHinh
            // 
            pbHinh.Location = new Point(12, 12);
            pbHinh.Name = "pbHinh";
            pbHinh.Size = new Size(140, 205);
            pbHinh.TabIndex = 0;
            pbHinh.TabStop = false;
            // 
            // gboTTSV
            // 
            gboTTSV.Controls.Add(btnThoat);
            gboTTSV.Controls.Add(btnLuu);
            gboTTSV.Controls.Add(btnMacDinh);
            gboTTSV.Controls.Add(btnChonHinh);
            gboTTSV.Controls.Add(txtHinh);
            gboTTSV.Controls.Add(cboLop);
            gboTTSV.Controls.Add(rdNu);
            gboTTSV.Controls.Add(rdNam);
            gboTTSV.Controls.Add(mtxtSoDienThoai);
            gboTTSV.Controls.Add(dtpNgaySinh);
            gboTTSV.Controls.Add(txtDiaChi);
            gboTTSV.Controls.Add(label9);
            gboTTSV.Controls.Add(txtEmail);
            gboTTSV.Controls.Add(txtHoTen);
            gboTTSV.Controls.Add(mtxtMSSV);
            gboTTSV.Controls.Add(label8);
            gboTTSV.Controls.Add(label7);
            gboTTSV.Controls.Add(label6);
            gboTTSV.Controls.Add(label5);
            gboTTSV.Controls.Add(label4);
            gboTTSV.Controls.Add(label3);
            gboTTSV.Controls.Add(label2);
            gboTTSV.Controls.Add(label1);
            gboTTSV.Location = new Point(158, 12);
            gboTTSV.Name = "gboTTSV";
            gboTTSV.Size = new Size(630, 205);
            gboTTSV.TabIndex = 1;
            gboTTSV.TabStop = false;
            gboTTSV.Text = "Thông tin sinh viên";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(549, 167);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 32);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(427, 167);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 32);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnMacDinh
            // 
            btnMacDinh.Location = new Point(300, 167);
            btnMacDinh.Name = "btnMacDinh";
            btnMacDinh.Size = new Size(75, 32);
            btnMacDinh.TabIndex = 10;
            btnMacDinh.Text = "Măc định";
            btnMacDinh.UseVisualStyleBackColor = true;
            btnMacDinh.Click += btnMacDinh_Click;
            // 
            // btnChonHinh
            // 
            btnChonHinh.Location = new Point(549, 138);
            btnChonHinh.Name = "btnChonHinh";
            btnChonHinh.Size = new Size(75, 23);
            btnChonHinh.TabIndex = 9;
            btnChonHinh.Text = "Chọn hình";
            btnChonHinh.UseVisualStyleBackColor = true;
            btnChonHinh.Click += btnChonHinh_Click;
            // 
            // txtHinh
            // 
            txtHinh.Location = new Point(94, 138);
            txtHinh.Name = "txtHinh";
            txtHinh.ReadOnly = true;
            txtHinh.Size = new Size(449, 23);
            txtHinh.TabIndex = 13;
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Items.AddRange(new object[] { "CTK43", "CTK44", "CTK45", "CTK46" });
            cboLop.Location = new Point(428, 80);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(121, 23);
            cboLop.TabIndex = 7;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(485, 52);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(41, 19);
            rdNu.TabIndex = 6;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Location = new Point(428, 52);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(51, 19);
            rdNam.TabIndex = 5;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // mtxtSoDienThoai
            // 
            mtxtSoDienThoai.Location = new Point(427, 109);
            mtxtSoDienThoai.Mask = "0000.000.000";
            mtxtSoDienThoai.Name = "mtxtSoDienThoai";
            mtxtSoDienThoai.Size = new Size(197, 23);
            mtxtSoDienThoai.TabIndex = 8;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(427, 22);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(197, 23);
            dtpNgaySinh.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(94, 109);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(207, 23);
            txtDiaChi.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 142);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 0;
            label9.Text = "Hình";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(94, 80);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(207, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(94, 51);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(207, 23);
            txtHoTen.TabIndex = 1;
            // 
            // mtxtMSSV
            // 
            mtxtMSSV.Location = new Point(94, 22);
            mtxtMSSV.Mask = "0000000";
            mtxtMSSV.Name = "mtxtMSSV";
            mtxtMSSV.Size = new Size(207, 23);
            mtxtMSSV.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(345, 112);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 0;
            label8.Text = "Số điện thoại";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(345, 54);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 0;
            label7.Text = "Phái";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 83);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 0;
            label6.Text = "Lớp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(345, 25);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 0;
            label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 112);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 0;
            label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 83);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 54);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "MSSV";
            // 
            // gboDSSV
            // 
            gboDSSV.Controls.Add(lvSinhVien);
            gboDSSV.Location = new Point(12, 223);
            gboDSSV.Name = "gboDSSV";
            gboDSSV.Size = new Size(776, 215);
            gboDSSV.TabIndex = 0;
            gboDSSV.TabStop = false;
            gboDSSV.Text = "Danh sách sinh viên";
            // 
            // lvSinhVien
            // 
            lvSinhVien.CheckBoxes = true;
            lvSinhVien.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            lvSinhVien.Dock = DockStyle.Fill;
            lvSinhVien.GridLines = true;
            lvSinhVien.Location = new Point(3, 19);
            lvSinhVien.Name = "lvSinhVien";
            lvSinhVien.Size = new Size(770, 193);
            lvSinhVien.TabIndex = 0;
            lvSinhVien.UseCompatibleStateImageBehavior = false;
            lvSinhVien.View = View.Details;
            lvSinhVien.SelectedIndexChanged += lvSinhVien_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "MSSV";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Họ và tên";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Phái";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ngày Sinh";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Lớp";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Số điện thoại";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Email";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Địa chỉ";
            columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Hình";
            columnHeader9.Width = 200;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { contextMenuXoa, contextMenuTaiLaiDanhSach });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(163, 48);
            // 
            // contextMenuXoa
            // 
            contextMenuXoa.Name = "contextMenuXoa";
            contextMenuXoa.Size = new Size(162, 22);
            contextMenuXoa.Text = "Xóa";
            contextMenuXoa.Click += contextMenuXoa_Click;
            // 
            // contextMenuTaiLaiDanhSach
            // 
            contextMenuTaiLaiDanhSach.Name = "contextMenuTaiLaiDanhSach";
            contextMenuTaiLaiDanhSach.Size = new Size(162, 22);
            contextMenuTaiLaiDanhSach.Text = "Tải lại danh sách";
            contextMenuTaiLaiDanhSach.Click += contextMenuTaiLaiDanhSach_Click;
            // 
            // frmQuanLySinhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gboDSSV);
            Controls.Add(gboTTSV);
            Controls.Add(pbHinh);
            Name = "frmQuanLySinhVien";
            Text = "Quản lý thông tin sinh viên khoa CNTT";
            FormClosing += frmQuanLySinhVien_FormClosing;
            Load += frmQuanLySinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)pbHinh).EndInit();
            gboTTSV.ResumeLayout(false);
            gboTTSV.PerformLayout();
            gboDSSV.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbHinh;
        private GroupBox gboTTSV;
        private GroupBox gboDSSV;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtHoTen;
        private MaskedTextBox mtxtMSSV;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtDiaChi;
        private Label label9;
        private ComboBox cboLop;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private MaskedTextBox mtxtSoDienThoai;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnMacDinh;
        private Button btnChonHinh;
        private TextBox txtHinh;
        private ListView lvSinhVien;
        public ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem contextMenuXoa;
        private ToolStripMenuItem contextMenuTaiLaiDanhSach;
    }
}
