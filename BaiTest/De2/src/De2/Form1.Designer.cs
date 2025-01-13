namespace De2
{
    partial class frmNhaCungCap
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
            txtMaNCC = new TextBox();
            txtTenNCC = new TextBox();
            txtDiaChi = new TextBox();
            txtMoTa = new TextBox();
            mtxtSoDT = new MaskedTextBox();
            btnMacDinh = new Button();
            btnLuu = new Button();
            btnXuatJson = new Button();
            gbTimKiem = new GroupBox();
            txtTimKiem = new TextBox();
            rbtnTheoSDT = new RadioButton();
            rbtnTheoTen = new RadioButton();
            dgvNhaCungCap = new DataGridView();
            MaNCC = new DataGridViewTextBoxColumn();
            TenNhaCC = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            gbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã nhà cung cấp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 18);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 47);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "Mô tả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 175);
            label6.Name = "label6";
            label6.Size = new Size(137, 15);
            label6.TabIndex = 5;
            label6.Text = "Danh sách nhà cung cấp";
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(119, 12);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.ReadOnly = true;
            txtMaNCC.Size = new Size(267, 23);
            txtMaNCC.TabIndex = 6;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(119, 41);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(267, 23);
            txtTenNCC.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(119, 70);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(267, 23);
            txtDiaChi.TabIndex = 8;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(474, 44);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(285, 52);
            txtMoTa.TabIndex = 9;
            // 
            // mtxtSoDT
            // 
            mtxtSoDT.Location = new Point(474, 15);
            mtxtSoDT.Mask = "0000000000";
            mtxtSoDT.Name = "mtxtSoDT";
            mtxtSoDT.Size = new Size(100, 23);
            mtxtSoDT.TabIndex = 10;
            // 
            // btnMacDinh
            // 
            btnMacDinh.Location = new Point(324, 102);
            btnMacDinh.Name = "btnMacDinh";
            btnMacDinh.Size = new Size(75, 23);
            btnMacDinh.TabIndex = 11;
            btnMacDinh.Text = "Mặc định";
            btnMacDinh.UseVisualStyleBackColor = true;
            btnMacDinh.Click += btnMacDinh_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(445, 102);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXuatJson
            // 
            btnXuatJson.Location = new Point(666, 352);
            btnXuatJson.Name = "btnXuatJson";
            btnXuatJson.Size = new Size(75, 23);
            btnXuatJson.TabIndex = 13;
            btnXuatJson.Text = "Xuất JSON";
            btnXuatJson.UseVisualStyleBackColor = true;
            btnXuatJson.Click += btnXuatJson_Click;
            // 
            // gbTimKiem
            // 
            gbTimKiem.Controls.Add(txtTimKiem);
            gbTimKiem.Controls.Add(rbtnTheoSDT);
            gbTimKiem.Controls.Add(rbtnTheoTen);
            gbTimKiem.Location = new Point(372, 131);
            gbTimKiem.Name = "gbTimKiem";
            gbTimKiem.Size = new Size(324, 59);
            gbTimKiem.TabIndex = 14;
            gbTimKiem.TabStop = false;
            gbTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(166, 22);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(152, 23);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // rbtnTheoSDT
            // 
            rbtnTheoSDT.AutoSize = true;
            rbtnTheoSDT.Location = new Point(84, 23);
            rbtnTheoSDT.Name = "rbtnTheoSDT";
            rbtnTheoSDT.Size = new Size(76, 19);
            rbtnTheoSDT.TabIndex = 1;
            rbtnTheoSDT.Text = "Theo SĐT";
            rbtnTheoSDT.UseVisualStyleBackColor = true;
            // 
            // rbtnTheoTen
            // 
            rbtnTheoTen.AutoSize = true;
            rbtnTheoTen.Checked = true;
            rbtnTheoTen.Location = new Point(6, 22);
            rbtnTheoTen.Name = "rbtnTheoTen";
            rbtnTheoTen.Size = new Size(72, 19);
            rbtnTheoTen.TabIndex = 0;
            rbtnTheoTen.TabStop = true;
            rbtnTheoTen.Text = "Theo tên";
            rbtnTheoTen.UseVisualStyleBackColor = true;
            // 
            // dgvNhaCungCap
            // 
            dgvNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaCungCap.Columns.AddRange(new DataGridViewColumn[] { MaNCC, TenNhaCC, DiaChi, SoDienThoai, MoTa });
            dgvNhaCungCap.Location = new Point(12, 196);
            dgvNhaCungCap.Name = "dgvNhaCungCap";
            dgvNhaCungCap.Size = new Size(749, 150);
            dgvNhaCungCap.TabIndex = 15;
            dgvNhaCungCap.CellClick += dgvNhaCungCap_CellClick;
            // 
            // MaNCC
            // 
            MaNCC.HeaderText = "Mã nhà cc";
            MaNCC.Name = "MaNCC";
            // 
            // TenNhaCC
            // 
            TenNhaCC.HeaderText = "Tên nhà cung cấp";
            TenNhaCC.Name = "TenNhaCC";
            TenNhaCC.Width = 150;
            // 
            // DiaChi
            // 
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.Name = "DiaChi";
            // 
            // SoDienThoai
            // 
            SoDienThoai.HeaderText = "Số ĐT";
            SoDienThoai.Name = "SoDienThoai";
            // 
            // MoTa
            // 
            MoTa.HeaderText = "Mô tả";
            MoTa.Name = "MoTa";
            MoTa.Width = 250;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 385);
            Controls.Add(dgvNhaCungCap);
            Controls.Add(gbTimKiem);
            Controls.Add(btnXuatJson);
            Controls.Add(btnLuu);
            Controls.Add(btnMacDinh);
            Controls.Add(mtxtSoDT);
            Controls.Add(txtMoTa);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenNCC);
            Controls.Add(txtMaNCC);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNhaCungCap";
            Text = "Quản lý nhà cung cấp";
            gbTimKiem.ResumeLayout(false);
            gbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).EndInit();
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
        private TextBox txtMaNCC;
        private TextBox txtTenNCC;
        private TextBox txtDiaChi;
        private TextBox txtMoTa;
        private MaskedTextBox mtxtSoDT;
        private Button btnMacDinh;
        private Button btnLuu;
        private Button btnXuatJson;
        private GroupBox gbTimKiem;
        private TextBox txtTimKiem;
        private RadioButton rbtnTheoSDT;
        private RadioButton rbtnTheoTen;
        private DataGridView dgvNhaCungCap;
        private DataGridViewTextBoxColumn MaNCC;
        private DataGridViewTextBoxColumn TenNhaCC;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn MoTa;
    }
}
