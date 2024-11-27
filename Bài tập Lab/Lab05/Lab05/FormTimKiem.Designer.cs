namespace Lab05
{
    partial class FormTimKiem
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
            cboTimKiem = new ComboBox();
            label2 = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            btnHuy = new Button();
            label3 = new Label();
            txtTen = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            rdCoBan = new RadioButton();
            rdNangCao = new RadioButton();
            gboCoBan = new GroupBox();
            gboNangCao = new GroupBox();
            cboLop = new ComboBox();
            mtxtMSSV = new MaskedTextBox();
            gboCoBan.SuspendLayout();
            gboNangCao.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 53);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập tìm kiếm";
            // 
            // cboTimKiem
            // 
            cboTimKiem.FormattingEnabled = true;
            cboTimKiem.Items.AddRange(new object[] { "MSSV", "Tên", "Lớp" });
            cboTimKiem.Location = new Point(141, 21);
            cboTimKiem.Name = "cboTimKiem";
            cboTimKiem.Size = new Size(168, 23);
            cboTimKiem.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 24);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 0;
            label2.Text = "Chọn (MSSV/Tên/Lớp)";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(69, 263);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(141, 50);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(168, 23);
            txtTimKiem.TabIndex = 2;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(218, 263);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 5;
            label3.Text = "Nhập tìm MSSV";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(138, 45);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(168, 23);
            txtTen.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 48);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 7;
            label4.Text = "Nhập tìm Tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 83);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 9;
            label5.Text = "Nhập tìm Lớp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 20);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 11;
            label6.Text = "Chọn loại tìm kiếm";
            // 
            // rdCoBan
            // 
            rdCoBan.AutoSize = true;
            rdCoBan.Location = new Point(174, 20);
            rdCoBan.Name = "rdCoBan";
            rdCoBan.Size = new Size(63, 19);
            rdCoBan.TabIndex = 12;
            rdCoBan.TabStop = true;
            rdCoBan.Text = "Cơ bản";
            rdCoBan.UseVisualStyleBackColor = true;
            rdCoBan.CheckedChanged += rdCoBan_CheckedChanged;
            // 
            // rdNangCao
            // 
            rdNangCao.AutoSize = true;
            rdNangCao.Location = new Point(243, 20);
            rdNangCao.Name = "rdNangCao";
            rdNangCao.Size = new Size(76, 19);
            rdNangCao.TabIndex = 13;
            rdNangCao.TabStop = true;
            rdNangCao.Text = "Nâng cao";
            rdNangCao.UseVisualStyleBackColor = true;
            rdNangCao.CheckedChanged += rdNangCao_CheckedChanged;
            // 
            // gboCoBan
            // 
            gboCoBan.Controls.Add(label2);
            gboCoBan.Controls.Add(label1);
            gboCoBan.Controls.Add(cboTimKiem);
            gboCoBan.Controls.Add(txtTimKiem);
            gboCoBan.Location = new Point(24, 49);
            gboCoBan.Name = "gboCoBan";
            gboCoBan.Size = new Size(318, 87);
            gboCoBan.TabIndex = 14;
            gboCoBan.TabStop = false;
            gboCoBan.Text = "Tìm kiếm cơ bản";
            // 
            // gboNangCao
            // 
            gboNangCao.Controls.Add(cboLop);
            gboNangCao.Controls.Add(mtxtMSSV);
            gboNangCao.Controls.Add(label3);
            gboNangCao.Controls.Add(label4);
            gboNangCao.Controls.Add(txtTen);
            gboNangCao.Controls.Add(label5);
            gboNangCao.Location = new Point(24, 142);
            gboNangCao.Name = "gboNangCao";
            gboNangCao.Size = new Size(318, 115);
            gboNangCao.TabIndex = 15;
            gboNangCao.TabStop = false;
            gboNangCao.Text = "Tìm kiếm nâng cao";
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Items.AddRange(new object[] { "CTK43", "CTK44", "CTK45", "CTK46" });
            cboLop.Location = new Point(138, 80);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(168, 23);
            cboLop.TabIndex = 12;
            // 
            // mtxtMSSV
            // 
            mtxtMSSV.Location = new Point(138, 16);
            mtxtMSSV.Mask = "0000000";
            mtxtMSSV.Name = "mtxtMSSV";
            mtxtMSSV.Size = new Size(168, 23);
            mtxtMSSV.TabIndex = 11;
            // 
            // FormTimKiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 311);
            Controls.Add(gboNangCao);
            Controls.Add(gboCoBan);
            Controls.Add(rdNangCao);
            Controls.Add(rdCoBan);
            Controls.Add(label6);
            Controls.Add(btnHuy);
            Controls.Add(btnTimKiem);
            Name = "FormTimKiem";
            Text = "Tìm kiếm";
            Load += FormTimKiem_Load;
            gboCoBan.ResumeLayout(false);
            gboCoBan.PerformLayout();
            gboNangCao.ResumeLayout(false);
            gboNangCao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboTimKiem;
        private Label label2;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Button btnHuy;
        private Label label3;
        private TextBox txtTen;
        private Label label4;
        private Label label5;
        private Label label6;
        private RadioButton rdCoBan;
        private RadioButton rdNangCao;
        private GroupBox gboCoBan;
        private GroupBox gboNangCao;
        private MaskedTextBox mtxtMSSV;
        private ComboBox cboLop;
    }
}