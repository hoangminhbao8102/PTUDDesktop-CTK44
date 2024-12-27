namespace Lab2_Demo
{
    partial class frmTrungTam
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
            cboMaHV = new ComboBox();
            label5 = new Label();
            rdNam = new RadioButton();
            rdNu = new RadioButton();
            txtHoTen = new TextBox();
            dtpNgayDangKy = new DateTimePicker();
            chkTinHocA = new CheckBox();
            chkTinHocB = new CheckBox();
            chkTiengAnhA = new CheckBox();
            chkTiengAnhB = new CheckBox();
            lblTienTHA = new Label();
            lblTienTHB = new Label();
            lblTienTAA = new Label();
            lblTienTAB = new Label();
            label6 = new Label();
            txtTongTien = new TextBox();
            btnTinhTien = new Button();
            btnExit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Size = new Size(462, 36);
            label1.TabIndex = 1;
            label1.Text = "TÍNH TIỀN HỌC TRUNG TÂM";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 84);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 2;
            label2.Text = "Mã Học Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 120);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 2;
            label3.Text = "Họ Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 161);
            label4.Name = "label4";
            label4.Size = new Size(109, 19);
            label4.TabIndex = 2;
            label4.Text = "Ngày Đăng Ký";
            // 
            // cboMaHV
            // 
            cboMaHV.FormattingEnabled = true;
            cboMaHV.Items.AddRange(new object[] { "001", "002", "003", "004", "005" });
            cboMaHV.Location = new Point(139, 80);
            cboMaHV.Name = "cboMaHV";
            cboMaHV.Size = new Size(121, 23);
            cboMaHV.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(278, 84);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 2;
            label5.Text = "Giới Tính";
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdNam.Location = new Point(356, 82);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(57, 23);
            rdNam.TabIndex = 1;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdNu.Location = new Point(419, 82);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(48, 23);
            rdNu.TabIndex = 2;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(139, 120);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(302, 23);
            txtHoTen.TabIndex = 3;
            // 
            // dtpNgayDangKy
            // 
            dtpNgayDangKy.Location = new Point(139, 158);
            dtpNgayDangKy.Name = "dtpNgayDangKy";
            dtpNgayDangKy.Size = new Size(200, 23);
            dtpNgayDangKy.TabIndex = 4;
            // 
            // chkTinHocA
            // 
            chkTinHocA.AutoSize = true;
            chkTinHocA.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTinHocA.Location = new Point(71, 207);
            chkTinHocA.Name = "chkTinHocA";
            chkTinHocA.Size = new Size(90, 23);
            chkTinHocA.TabIndex = 5;
            chkTinHocA.Text = "Tin Học A";
            chkTinHocA.UseVisualStyleBackColor = true;
            // 
            // chkTinHocB
            // 
            chkTinHocB.AutoSize = true;
            chkTinHocB.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTinHocB.Location = new Point(71, 243);
            chkTinHocB.Name = "chkTinHocB";
            chkTinHocB.Size = new Size(90, 23);
            chkTinHocB.TabIndex = 6;
            chkTinHocB.Text = "Tin Học B";
            chkTinHocB.UseVisualStyleBackColor = true;
            // 
            // chkTiengAnhA
            // 
            chkTiengAnhA.AutoSize = true;
            chkTiengAnhA.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTiengAnhA.Location = new Point(71, 281);
            chkTiengAnhA.Name = "chkTiengAnhA";
            chkTiengAnhA.Size = new Size(102, 23);
            chkTiengAnhA.TabIndex = 7;
            chkTiengAnhA.Text = "Tiếng Anh A";
            chkTiengAnhA.UseVisualStyleBackColor = true;
            // 
            // chkTiengAnhB
            // 
            chkTiengAnhB.AutoSize = true;
            chkTiengAnhB.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTiengAnhB.Location = new Point(71, 320);
            chkTiengAnhB.Name = "chkTiengAnhB";
            chkTiengAnhB.Size = new Size(102, 23);
            chkTiengAnhB.TabIndex = 8;
            chkTiengAnhB.Text = "Tiếng Anh B";
            chkTiengAnhB.UseVisualStyleBackColor = true;
            // 
            // lblTienTHA
            // 
            lblTienTHA.AutoSize = true;
            lblTienTHA.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTienTHA.Location = new Point(297, 208);
            lblTienTHA.Name = "lblTienTHA";
            lblTienTHA.Size = new Size(95, 19);
            lblTienTHA.TabIndex = 2;
            lblTienTHA.Text = "300.000 đồng";
            // 
            // lblTienTHB
            // 
            lblTienTHB.AutoSize = true;
            lblTienTHB.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTienTHB.Location = new Point(297, 244);
            lblTienTHB.Name = "lblTienTHB";
            lblTienTHB.Size = new Size(95, 19);
            lblTienTHB.TabIndex = 2;
            lblTienTHB.Text = "500.000 đồng";
            // 
            // lblTienTAA
            // 
            lblTienTAA.AutoSize = true;
            lblTienTAA.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTienTAA.Location = new Point(297, 282);
            lblTienTAA.Name = "lblTienTAA";
            lblTienTAA.Size = new Size(95, 19);
            lblTienTAA.TabIndex = 2;
            lblTienTAA.Text = "400.000 đồng";
            // 
            // lblTienTAB
            // 
            lblTienTAB.AutoSize = true;
            lblTienTAB.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTienTAB.Location = new Point(297, 321);
            lblTienTAB.Name = "lblTienTAB";
            lblTienTAB.Size = new Size(95, 19);
            lblTienTAB.TabIndex = 2;
            lblTienTAB.Text = "600.000 đồng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(101, 358);
            label6.Name = "label6";
            label6.Size = new Size(77, 19);
            label6.TabIndex = 2;
            label6.Text = "Tổng Tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Enabled = false;
            txtTongTien.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTongTien.Location = new Point(184, 355);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(208, 26);
            txtTongTien.TabIndex = 9;
            txtTongTien.TextAlign = HorizontalAlignment.Right;
            // 
            // btnTinhTien
            // 
            btnTinhTien.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTinhTien.ForeColor = Color.Blue;
            btnTinhTien.Location = new Point(67, 393);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(106, 35);
            btnTinhTien.TabIndex = 11;
            btnTinhTien.Text = "Tính Tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Blue;
            btnExit.Location = new Point(307, 393);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(106, 35);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(195, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 35);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmTrungTam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 458);
            Controls.Add(btnCancel);
            Controls.Add(btnExit);
            Controls.Add(btnTinhTien);
            Controls.Add(txtTongTien);
            Controls.Add(label6);
            Controls.Add(lblTienTAB);
            Controls.Add(lblTienTAA);
            Controls.Add(lblTienTHB);
            Controls.Add(lblTienTHA);
            Controls.Add(chkTiengAnhB);
            Controls.Add(chkTiengAnhA);
            Controls.Add(chkTinHocB);
            Controls.Add(chkTinHocA);
            Controls.Add(dtpNgayDangKy);
            Controls.Add(txtHoTen);
            Controls.Add(rdNu);
            Controls.Add(rdNam);
            Controls.Add(label5);
            Controls.Add(cboMaHV);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTrungTam";
            Text = "Simple Drawing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cboMaHV;
        private Label label5;
        private RadioButton rdNam;
        private RadioButton rdNu;
        private TextBox txtHoTen;
        private DateTimePicker dtpNgayDangKy;
        private CheckBox chkTinHocA;
        private CheckBox chkTinHocB;
        private CheckBox chkTiengAnhA;
        private CheckBox chkTiengAnhB;
        private Label lblTienTHA;
        private Label lblTienTHB;
        private Label lblTienTAA;
        private Label lblTienTAB;
        private Label label6;
        private TextBox txtTongTien;
        private Button btnTinhTien;
        private Button btnExit;
        private Button btnCancel;
    }
}
