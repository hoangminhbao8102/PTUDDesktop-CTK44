namespace Lab3_Demo
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            statusStripLabel = new StatusStrip();
            btnThoat = new Button();
            btnMacDinh = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            clbChuyenNganh = new CheckedListBox();
            rdNu = new RadioButton();
            rdNam = new RadioButton();
            pbHinh = new PictureBox();
            btnBrowse = new Button();
            txtHinh = new TextBox();
            cboLop = new ComboBox();
            txtDiaChi = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            txtHoTen = new TextBox();
            mtxtMaSo = new MaskedTextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lvSinhVien = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            OpenFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            OpenFileToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            AddToolStripMenuItem = new ToolStripMenuItem();
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            UpdateToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            listViewToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            TextColorToolStripMenuItem = new ToolStripMenuItem();
            SortToolStripMenuItem = new ToolStripMenuItem();
            FindToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            fontToolStripMenuItem1 = new ToolStripMenuItem();
            màuChữToolStripMenuItem1 = new ToolStripMenuItem();
            sắpXếpToolStripMenuItem1 = new ToolStripMenuItem();
            tìmKiếmToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHinh).BeginInit();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 27);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(800, 469);
            splitContainer1.SplitterDistance = 402;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(statusStripLabel);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnMacDinh);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(clbChuyenNganh);
            groupBox1.Controls.Add(rdNu);
            groupBox1.Controls.Add(rdNam);
            groupBox1.Controls.Add(pbHinh);
            groupBox1.Controls.Add(btnBrowse);
            groupBox1.Controls.Add(txtHinh);
            groupBox1.Controls.Add(cboLop);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(mtxtMaSo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(402, 469);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // statusStripLabel
            // 
            statusStripLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStripLabel.Location = new Point(3, 444);
            statusStripLabel.Name = "statusStripLabel";
            statusStripLabel.Size = new Size(396, 22);
            statusStripLabel.TabIndex = 16;
            statusStripLabel.Text = "statusStrip1";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.Blue;
            btnThoat.Location = new Point(313, 405);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(56, 33);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnMacDinh
            // 
            btnMacDinh.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMacDinh.ForeColor = Color.Blue;
            btnMacDinh.Location = new Point(214, 405);
            btnMacDinh.Name = "btnMacDinh";
            btnMacDinh.Size = new Size(93, 33);
            btnMacDinh.TabIndex = 12;
            btnMacDinh.Text = "Mặc Định";
            btnMacDinh.UseVisualStyleBackColor = true;
            btnMacDinh.Click += btnMacDinh_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.Blue;
            btnSua.Location = new Point(152, 405);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(56, 33);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Blue;
            btnXoa.Location = new Point(90, 405);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(56, 33);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Blue;
            btnThem.Location = new Point(28, 405);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(56, 33);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // clbChuyenNganh
            // 
            clbChuyenNganh.CheckOnClick = true;
            clbChuyenNganh.FormattingEnabled = true;
            clbChuyenNganh.Items.AddRange(new object[] { "Mạng truyền thông", "Công nghệ phần mềm", "Khoa học máy tính", "Trí tuệ nhân tạo", "Hệ thống thông tin", "Tin học ứng dụng" });
            clbChuyenNganh.Location = new Point(126, 255);
            clbChuyenNganh.Name = "clbChuyenNganh";
            clbChuyenNganh.Size = new Size(160, 130);
            clbChuyenNganh.TabIndex = 8;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(193, 226);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(48, 23);
            rdNu.TabIndex = 1;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Checked = true;
            rdNam.Location = new Point(126, 226);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(57, 23);
            rdNam.TabIndex = 0;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // pbHinh
            // 
            pbHinh.BorderStyle = BorderStyle.Fixed3D;
            pbHinh.Location = new Point(15, 25);
            pbHinh.Name = "pbHinh";
            pbHinh.Size = new Size(118, 164);
            pbHinh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHinh.TabIndex = 15;
            pbHinh.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(364, 195);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(32, 25);
            btnBrowse.TabIndex = 7;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtHinh
            // 
            txtHinh.Location = new Point(126, 195);
            txtHinh.Multiline = true;
            txtHinh.Name = "txtHinh";
            txtHinh.ReadOnly = true;
            txtHinh.Size = new Size(232, 25);
            txtHinh.TabIndex = 7;
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Items.AddRange(new object[] { "CTK31", "CTK32", "CTK33", "CTK34", "CTK32CD", "CTK33CD", "CTK34CD" });
            cboLop.Location = new Point(215, 162);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(121, 27);
            cboLop.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(215, 130);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(181, 26);
            txtDiaChi.TabIndex = 5;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(215, 95);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(120, 26);
            dtpNgaySinh.TabIndex = 4;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(215, 58);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(181, 26);
            txtHoTen.TabIndex = 3;
            // 
            // mtxtMaSo
            // 
            mtxtMaSo.Location = new Point(215, 25);
            mtxtMaSo.Mask = "SV.00000";
            mtxtMaSo.Name = "mtxtMaSo";
            mtxtMaSo.Size = new Size(109, 26);
            mtxtMaSo.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 255);
            label8.Name = "label8";
            label8.Size = new Size(108, 19);
            label8.TabIndex = 1;
            label8.Text = "Chuyên Ngành";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 230);
            label7.Name = "label7";
            label7.Size = new Size(72, 19);
            label7.TabIndex = 1;
            label7.Text = "Giới Tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 201);
            label6.Name = "label6";
            label6.Size = new Size(41, 19);
            label6.TabIndex = 1;
            label6.Text = "Hình";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(139, 167);
            label5.Name = "label5";
            label5.Size = new Size(36, 19);
            label5.TabIndex = 1;
            label5.Text = "Lớp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(139, 135);
            label4.Name = "label4";
            label4.Size = new Size(60, 19);
            label4.TabIndex = 1;
            label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(139, 98);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 1;
            label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(139, 62);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 29);
            label1.Name = "label1";
            label1.Size = new Size(52, 19);
            label1.TabIndex = 1;
            label1.Text = "Mã số";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lvSinhVien);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(394, 469);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sinh viên";
            // 
            // lvSinhVien
            // 
            lvSinhVien.CheckBoxes = true;
            lvSinhVien.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            lvSinhVien.Dock = DockStyle.Fill;
            lvSinhVien.GridLines = true;
            lvSinhVien.Location = new Point(3, 22);
            lvSinhVien.Name = "lvSinhVien";
            lvSinhVien.Size = new Size(388, 444);
            lvSinhVien.TabIndex = 0;
            lvSinhVien.UseCompatibleStateImageBehavior = false;
            lvSinhVien.View = View.Details;
            lvSinhVien.SelectedIndexChanged += lvSinhVien_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã số";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Họ tên";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ngày sinh";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Địa chỉ";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Lớp";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Phái";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Chuyên Ngành";
            columnHeader7.Width = 500;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Hình";
            columnHeader8.Width = 200;
            // 
            // OpenFileDialog1
            // 
            OpenFileDialog1.FileName = "openFileDialog1";
            OpenFileDialog1.Filter = "File GIF|*.Gif|File JPEG|*.Jpg";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 27);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenFileToolStripMenuItem, ExitToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(43, 23);
            fileToolStripMenuItem.Text = "File";
            // 
            // OpenFileToolStripMenuItem
            // 
            OpenFileToolStripMenuItem.Image = Properties.Resources._5994754;
            OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            OpenFileToolStripMenuItem.Size = new Size(126, 24);
            OpenFileToolStripMenuItem.Text = "Mở File";
            OpenFileToolStripMenuItem.Click += OpenFileToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Image = Properties.Resources.tải_xuống;
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(126, 24);
            ExitToolStripMenuItem.Text = "Thoát";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddToolStripMenuItem, DeleteToolStripMenuItem, UpdateToolStripMenuItem, toolStripSeparator1, listViewToolStripMenuItem });
            editToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(45, 23);
            editToolStripMenuItem.Text = "Edit";
            // 
            // AddToolStripMenuItem
            // 
            AddToolStripMenuItem.Image = Properties.Resources.tải_xuống__1_;
            AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            AddToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Alt+T";
            AddToolStripMenuItem.Size = new Size(189, 24);
            AddToolStripMenuItem.Text = "Thêm";
            AddToolStripMenuItem.Click += AddToolStripMenuItem_Click;
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Image = Properties.Resources.tải_xuống__1_1;
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Alt+Y";
            DeleteToolStripMenuItem.Size = new Size(189, 24);
            DeleteToolStripMenuItem.Text = "Xóa";
            DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // UpdateToolStripMenuItem
            // 
            UpdateToolStripMenuItem.Image = Properties.Resources.tải_xuống__2_;
            UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            UpdateToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Alt+S";
            UpdateToolStripMenuItem.Size = new Size(189, 24);
            UpdateToolStripMenuItem.Text = "Sửa";
            UpdateToolStripMenuItem.Click += UpdateToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(186, 6);
            // 
            // listViewToolStripMenuItem
            // 
            listViewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, TextColorToolStripMenuItem, SortToolStripMenuItem, FindToolStripMenuItem });
            listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            listViewToolStripMenuItem.Size = new Size(189, 24);
            listViewToolStripMenuItem.Text = "ListView";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(180, 24);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // TextColorToolStripMenuItem
            // 
            TextColorToolStripMenuItem.Name = "TextColorToolStripMenuItem";
            TextColorToolStripMenuItem.Size = new Size(180, 24);
            TextColorToolStripMenuItem.Text = "Màu chữ";
            TextColorToolStripMenuItem.Click += TextColorToolStripMenuItem_Click;
            // 
            // SortToolStripMenuItem
            // 
            SortToolStripMenuItem.Name = "SortToolStripMenuItem";
            SortToolStripMenuItem.Size = new Size(180, 24);
            SortToolStripMenuItem.Text = "Sắp Xếp";
            SortToolStripMenuItem.Click += SortToolStripMenuItem_Click;
            // 
            // FindToolStripMenuItem
            // 
            FindToolStripMenuItem.Name = "FindToolStripMenuItem";
            FindToolStripMenuItem.Size = new Size(180, 24);
            FindToolStripMenuItem.Text = "Tìm Kiếm";
            FindToolStripMenuItem.Click += FindToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { fontToolStripMenuItem1, màuChữToolStripMenuItem1, sắpXếpToolStripMenuItem1, tìmKiếmToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(135, 100);
            // 
            // fontToolStripMenuItem1
            // 
            fontToolStripMenuItem1.Image = Properties.Resources.tải_xuống__3_;
            fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            fontToolStripMenuItem1.Size = new Size(134, 24);
            fontToolStripMenuItem1.Text = "Font";
            // 
            // màuChữToolStripMenuItem1
            // 
            màuChữToolStripMenuItem1.Image = Properties.Resources.tải_xuống__2_1;
            màuChữToolStripMenuItem1.Name = "màuChữToolStripMenuItem1";
            màuChữToolStripMenuItem1.Size = new Size(134, 24);
            màuChữToolStripMenuItem1.Text = "Màu chữ";
            // 
            // sắpXếpToolStripMenuItem1
            // 
            sắpXếpToolStripMenuItem1.Image = Properties.Resources.tải_xuống__4_;
            sắpXếpToolStripMenuItem1.Name = "sắpXếpToolStripMenuItem1";
            sắpXếpToolStripMenuItem1.Size = new Size(134, 24);
            sắpXếpToolStripMenuItem1.Text = "Sắp xếp";
            // 
            // tìmKiếmToolStripMenuItem1
            // 
            tìmKiếmToolStripMenuItem1.Image = Properties.Resources.tải_xuống__3_1;
            tìmKiếmToolStripMenuItem1.Name = "tìmKiếmToolStripMenuItem1";
            tìmKiếmToolStripMenuItem1.Size = new Size(134, 24);
            tìmKiếmToolStripMenuItem1.Text = "Tìm kiếm";
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 496);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmSinhVien";
            Text = "Demo Sinh viên";
            Load += frmSinhVien_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHinh).EndInit();
            groupBox2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private OpenFileDialog OpenFileDialog1;
        private MaskedTextBox mtxtMaSo;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtHoTen;
        private TextBox txtDiaChi;
        private ComboBox cboLop;
        private TextBox txtHinh;
        private Button btnBrowse;
        private PictureBox pbHinh;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private CheckedListBox clbChuyenNganh;
        private Button btnThoat;
        private Button btnMacDinh;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private ListView lvSinhVien;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private StatusStrip statusStripLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem OpenFileToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem AddToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private ToolStripMenuItem UpdateToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem listViewToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem TextColorToolStripMenuItem;
        private ToolStripMenuItem SortToolStripMenuItem;
        private ToolStripMenuItem FindToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem fontToolStripMenuItem1;
        private ToolStripMenuItem màuChữToolStripMenuItem1;
        private ToolStripMenuItem sắpXếpToolStripMenuItem1;
        private ToolStripMenuItem tìmKiếmToolStripMenuItem1;
    }
}
