namespace De3
{
    partial class FormMain
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
            gbThongTin = new GroupBox();
            btnCapNhat = new Button();
            btnThem = new Button();
            btnThemLoai = new Button();
            nudDonGia = new NumericUpDown();
            nudSoLuong = new NumericUpDown();
            cbLoaiMatHang = new ComboBox();
            txtTenMatHang = new TextBox();
            txtMaMatHang = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbDanhSach = new GroupBox();
            lvMatHang = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            gbDanhSach.SuspendLayout();
            SuspendLayout();
            // 
            // gbThongTin
            // 
            gbThongTin.Controls.Add(btnCapNhat);
            gbThongTin.Controls.Add(btnThem);
            gbThongTin.Controls.Add(btnThemLoai);
            gbThongTin.Controls.Add(nudDonGia);
            gbThongTin.Controls.Add(nudSoLuong);
            gbThongTin.Controls.Add(cbLoaiMatHang);
            gbThongTin.Controls.Add(txtTenMatHang);
            gbThongTin.Controls.Add(txtMaMatHang);
            gbThongTin.Controls.Add(label5);
            gbThongTin.Controls.Add(label4);
            gbThongTin.Controls.Add(label3);
            gbThongTin.Controls.Add(label2);
            gbThongTin.Controls.Add(label1);
            gbThongTin.Location = new Point(12, 12);
            gbThongTin.Name = "gbThongTin";
            gbThongTin.Size = new Size(517, 198);
            gbThongTin.TabIndex = 0;
            gbThongTin.TabStop = false;
            gbThongTin.Text = "Thông tin chi tiết mặt hàng";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(303, 167);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(75, 23);
            btnCapNhat.TabIndex = 12;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(162, 167);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnThemLoai
            // 
            btnThemLoai.Location = new Point(436, 80);
            btnThemLoai.Name = "btnThemLoai";
            btnThemLoai.Size = new Size(75, 23);
            btnThemLoai.TabIndex = 10;
            btnThemLoai.Text = "Thêm loại";
            btnThemLoai.UseVisualStyleBackColor = true;
            btnThemLoai.Click += btnThemLoai_Click;
            // 
            // nudDonGia
            // 
            nudDonGia.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nudDonGia.Location = new Point(95, 138);
            nudDonGia.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudDonGia.Minimum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudDonGia.Name = "nudDonGia";
            nudDonGia.Size = new Size(335, 23);
            nudDonGia.TabIndex = 9;
            nudDonGia.TextAlign = HorizontalAlignment.Right;
            nudDonGia.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(95, 109);
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(335, 23);
            nudSoLuong.TabIndex = 8;
            nudSoLuong.TextAlign = HorizontalAlignment.Right;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbLoaiMatHang
            // 
            cbLoaiMatHang.FormattingEnabled = true;
            cbLoaiMatHang.Location = new Point(95, 80);
            cbLoaiMatHang.Name = "cbLoaiMatHang";
            cbLoaiMatHang.Size = new Size(335, 23);
            cbLoaiMatHang.TabIndex = 7;
            // 
            // txtTenMatHang
            // 
            txtTenMatHang.Location = new Point(95, 51);
            txtTenMatHang.Name = "txtTenMatHang";
            txtTenMatHang.Size = new Size(335, 23);
            txtTenMatHang.TabIndex = 6;
            // 
            // txtMaMatHang
            // 
            txtMaMatHang.Location = new Point(95, 22);
            txtMaMatHang.Name = "txtMaMatHang";
            txtMaMatHang.ReadOnly = true;
            txtMaMatHang.Size = new Size(121, 23);
            txtMaMatHang.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 140);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 4;
            label5.Text = "Đơn giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 111);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "Loại mặt hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên mặt hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã mặt hàng";
            // 
            // gbDanhSach
            // 
            gbDanhSach.Controls.Add(lvMatHang);
            gbDanhSach.Location = new Point(12, 216);
            gbDanhSach.Name = "gbDanhSach";
            gbDanhSach.Size = new Size(517, 222);
            gbDanhSach.TabIndex = 1;
            gbDanhSach.TabStop = false;
            gbDanhSach.Text = "Danh sách mặt hàng";
            // 
            // lvMatHang
            // 
            lvMatHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvMatHang.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvMatHang.FullRowSelect = true;
            lvMatHang.GridLines = true;
            lvMatHang.Location = new Point(6, 22);
            lvMatHang.Name = "lvMatHang";
            lvMatHang.Size = new Size(505, 194);
            lvMatHang.TabIndex = 0;
            lvMatHang.UseCompatibleStateImageBehavior = false;
            lvMatHang.View = View.Details;
            lvMatHang.SelectedIndexChanged += lvMatHang_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã MH";
            columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên mặt hàng";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên loại mặt hàng";
            columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Số lượng còn";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Đơn giá";
            columnHeader5.Width = 100;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 450);
            Controls.Add(gbDanhSach);
            Controls.Add(gbThongTin);
            Name = "FormMain";
            Text = "Quản lý bàn hàng shop ABC";
            Load += FormMain_Load;
            gbThongTin.ResumeLayout(false);
            gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            gbDanhSach.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbThongTin;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gbDanhSach;
        private Button btnCapNhat;
        private Button btnThem;
        private Button btnThemLoai;
        private NumericUpDown nudDonGia;
        private NumericUpDown nudSoLuong;
        private ComboBox cbLoaiMatHang;
        private TextBox txtTenMatHang;
        private TextBox txtMaMatHang;
        private ListView lvMatHang;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}
