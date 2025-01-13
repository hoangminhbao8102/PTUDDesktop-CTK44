namespace Demo
{
    partial class FormMonAn
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
            txtMaMonAn = new TextBox();
            txtTenMonAn = new TextBox();
            txtDonViTinh = new TextBox();
            nudDonGia = new NumericUpDown();
            cbNhomMonAn = new ComboBox();
            btnLuu = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDonGia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên món ăn/uống";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Đơn vị tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Đơn giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 131);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 3;
            label4.Text = "Nhóm món ăn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 15);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 4;
            label5.Text = "Mã món ăn/uống";
            // 
            // txtMaMonAn
            // 
            txtMaMonAn.Location = new Point(121, 12);
            txtMaMonAn.Name = "txtMaMonAn";
            txtMaMonAn.ReadOnly = true;
            txtMaMonAn.Size = new Size(130, 23);
            txtMaMonAn.TabIndex = 5;
            // 
            // txtTenMonAn
            // 
            txtTenMonAn.Location = new Point(121, 41);
            txtTenMonAn.Name = "txtTenMonAn";
            txtTenMonAn.Size = new Size(130, 23);
            txtTenMonAn.TabIndex = 6;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Location = new Point(121, 70);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.Size = new Size(130, 23);
            txtDonViTinh.TabIndex = 7;
            // 
            // nudDonGia
            // 
            nudDonGia.Location = new Point(121, 99);
            nudDonGia.Name = "nudDonGia";
            nudDonGia.Size = new Size(130, 23);
            nudDonGia.TabIndex = 8;
            // 
            // cbNhomMonAn
            // 
            cbNhomMonAn.FormattingEnabled = true;
            cbNhomMonAn.Location = new Point(121, 128);
            cbNhomMonAn.Name = "cbNhomMonAn";
            cbNhomMonAn.Size = new Size(130, 23);
            cbNhomMonAn.TabIndex = 9;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(99, 157);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // FormMonAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 191);
            Controls.Add(btnLuu);
            Controls.Add(cbNhomMonAn);
            Controls.Add(nudDonGia);
            Controls.Add(txtDonViTinh);
            Controls.Add(txtTenMonAn);
            Controls.Add(txtMaMonAn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMonAn";
            Text = "Thông tin món ăn";
            ((System.ComponentModel.ISupportInitialize)nudDonGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaMonAn;
        private TextBox txtTenMonAn;
        private TextBox txtDonViTinh;
        private NumericUpDown nudDonGia;
        private ComboBox cbNhomMonAn;
        private Button btnLuu;
    }
}