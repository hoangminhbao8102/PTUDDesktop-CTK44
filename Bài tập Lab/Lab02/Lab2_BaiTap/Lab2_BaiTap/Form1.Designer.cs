namespace Lab2_BaiTap
{
    partial class frmGiaoVien
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
            label11 = new Label();
            cboMaSo = new ComboBox();
            rdNam = new CheckBox();
            rdNu = new CheckBox();
            txtHoTen = new TextBox();
            mtxtSoDT = new MaskedTextBox();
            dtpNgaySinh = new DateTimePicker();
            txtMail = new TextBox();
            chklbNgoaiNgu = new CheckedListBox();
            lbDanhSachMH = new ListBox();
            lbMonHocDay = new ListBox();
            btnChon = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnTim = new Button();
            btnThem = new Button();
            btnExit = new Button();
            btnCancel = new Button();
            linklbLienHe = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(46, 37);
            label1.Name = "label1";
            label1.Size = new Size(572, 36);
            label1.TabIndex = 1;
            label1.Text = "THÔNG TIN GIÁO VIÊN KHOA CNTT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 106);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 2;
            label2.Text = "Mã Số";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(363, 106);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 2;
            label3.Text = "Giới Tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 142);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 2;
            label4.Text = "Họ Tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(363, 142);
            label5.Name = "label5";
            label5.Size = new Size(52, 19);
            label5.TabIndex = 4;
            label5.Text = "Số ĐT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(36, 187);
            label6.Name = "label6";
            label6.Size = new Size(78, 19);
            label6.TabIndex = 5;
            label6.Text = "Ngày Sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(363, 181);
            label7.Name = "label7";
            label7.Size = new Size(98, 19);
            label7.TabIndex = 6;
            label7.Text = "Địa chỉ Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(36, 224);
            label8.Name = "label8";
            label8.Size = new Size(83, 19);
            label8.TabIndex = 7;
            label8.Text = "Ngoại Ngữ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(125, 315);
            label9.Name = "label9";
            label9.Size = new Size(138, 19);
            label9.TabIndex = 8;
            label9.Text = "Danh sách môn học";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(376, 315);
            label10.Name = "label10";
            label10.Size = new Size(160, 19);
            label10.TabIndex = 9;
            label10.Text = "Môn học giáo viên dạy";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(449, 582);
            label11.Name = "label11";
            label11.Size = new Size(63, 19);
            label11.TabIndex = 10;
            label11.Text = "Website";
            // 
            // cboMaSo
            // 
            cboMaSo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMaSo.FormattingEnabled = true;
            cboMaSo.Items.AddRange(new object[] { "001", "002", "003", "004" });
            cboMaSo.Location = new Point(125, 102);
            cboMaSo.Name = "cboMaSo";
            cboMaSo.Size = new Size(121, 27);
            cboMaSo.TabIndex = 0;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Checked = true;
            rdNam.CheckState = CheckState.Checked;
            rdNam.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdNam.Location = new Point(467, 102);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(58, 23);
            rdNam.TabIndex = 1;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdNu.Location = new Point(540, 102);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(49, 23);
            rdNu.TabIndex = 13;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoTen.Location = new Point(126, 139);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(231, 26);
            txtHoTen.TabIndex = 14;
            // 
            // mtxtSoDT
            // 
            mtxtSoDT.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtSoDT.Location = new Point(467, 139);
            mtxtSoDT.Mask = "(\\02633).000.000";
            mtxtSoDT.Name = "mtxtSoDT";
            mtxtSoDT.Size = new Size(124, 26);
            mtxtSoDT.TabIndex = 15;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(126, 181);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(231, 26);
            dtpNgaySinh.TabIndex = 16;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMail.Location = new Point(467, 178);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(170, 26);
            txtMail.TabIndex = 17;
            // 
            // chklbNgoaiNgu
            // 
            chklbNgoaiNgu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chklbNgoaiNgu.FormattingEnabled = true;
            chklbNgoaiNgu.Items.AddRange(new object[] { "Tiếng Anh", "Tiếng Pháp", "Tiếng Nhật", "Tiếng Nga" });
            chklbNgoaiNgu.Location = new Point(125, 224);
            chklbNgoaiNgu.Name = "chklbNgoaiNgu";
            chklbNgoaiNgu.Size = new Size(120, 88);
            chklbNgoaiNgu.TabIndex = 18;
            // 
            // lbDanhSachMH
            // 
            lbDanhSachMH.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDanhSachMH.FormattingEnabled = true;
            lbDanhSachMH.ItemHeight = 19;
            lbDanhSachMH.Items.AddRange(new object[] { "Tin học cơ sở", "Lập trình cấu trúc C/C++", "Cơ sở dữ liệu", "Tiếng Anh B1", "Tiếng Anh B2", "Lập trình hướng đối tượng", "Mạng máy tính", "Công nghệ phần mềm", "Phân tích TKHDT" });
            lbDanhSachMH.Location = new Point(125, 337);
            lbDanhSachMH.Name = "lbDanhSachMH";
            lbDanhSachMH.SelectionMode = SelectionMode.MultiExtended;
            lbDanhSachMH.Size = new Size(168, 175);
            lbDanhSachMH.TabIndex = 19;
            // 
            // lbMonHocDay
            // 
            lbMonHocDay.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMonHocDay.FormattingEnabled = true;
            lbMonHocDay.ItemHeight = 19;
            lbMonHocDay.Location = new Point(376, 337);
            lbMonHocDay.Name = "lbMonHocDay";
            lbMonHocDay.Size = new Size(167, 175);
            lbMonHocDay.TabIndex = 20;
            // 
            // btnChon
            // 
            btnChon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChon.Location = new Point(310, 364);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(47, 33);
            btnChon.TabIndex = 21;
            btnChon.Text = ">>";
            btnChon.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(310, 424);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(47, 33);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "<<";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(295, 526);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(47, 33);
            btnLuu.TabIndex = 23;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            btnTim.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTim.ForeColor = Color.Blue;
            btnTim.Location = new Point(126, 526);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(47, 33);
            btnTim.TabIndex = 24;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Blue;
            btnThem.Location = new Point(198, 526);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(65, 33);
            btnThem.TabIndex = 25;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Blue;
            btnExit.Location = new Point(471, 526);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(47, 33);
            btnExit.TabIndex = 26;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(381, 526);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(65, 33);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // linklbLienHe
            // 
            linklbLienHe.AutoSize = true;
            linklbLienHe.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linklbLienHe.Location = new Point(536, 582);
            linklbLienHe.Name = "linklbLienHe";
            linklbLienHe.Size = new Size(53, 19);
            linklbLienHe.TabIndex = 28;
            linklbLienHe.TabStop = true;
            linklbLienHe.Text = "Liên hệ";
            // 
            // frmGiaoVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 634);
            Controls.Add(linklbLienHe);
            Controls.Add(btnCancel);
            Controls.Add(btnExit);
            Controls.Add(btnThem);
            Controls.Add(btnTim);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnChon);
            Controls.Add(lbMonHocDay);
            Controls.Add(lbDanhSachMH);
            Controls.Add(chklbNgoaiNgu);
            Controls.Add(txtMail);
            Controls.Add(dtpNgaySinh);
            Controls.Add(mtxtSoDT);
            Controls.Add(txtHoTen);
            Controls.Add(rdNu);
            Controls.Add(rdNam);
            Controls.Add(cboMaSo);
            Controls.Add(label11);
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
            Name = "frmGiaoVien";
            Text = "Giáo Viên";
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
        private Label label11;
        private ComboBox cboMaSo;
        private CheckBox rdNam;
        private CheckBox rdNu;
        private TextBox txtHoTen;
        private MaskedTextBox mtxtSoDT;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtMail;
        private CheckedListBox chklbNgoaiNgu;
        private ListBox lbDanhSachMH;
        private ListBox lbMonHocDay;
        private Button btnChon;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnTim;
        private Button btnThem;
        private Button btnExit;
        private Button btnCancel;
        private LinkLabel linklbLienHe;
    }
}
