namespace Demo
{
    partial class MainForm
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
            cbNhomMonAn = new ComboBox();
            txtTimKiem = new TextBox();
            btnThem = new Button();
            dgvMonAn = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMonAn).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 15);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhóm món ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 1;
            label2.Text = "Danh sách món ăn";
            // 
            // cbNhomMonAn
            // 
            cbNhomMonAn.FormattingEnabled = true;
            cbNhomMonAn.Location = new Point(124, 12);
            cbNhomMonAn.Name = "cbNhomMonAn";
            cbNhomMonAn.Size = new Size(392, 23);
            cbNhomMonAn.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(228, 43);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(277, 23);
            txtTimKiem.TabIndex = 3;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(511, 41);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(25, 25);
            btnThem.TabIndex = 4;
            btnThem.Text = "+";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvMonAn
            // 
            dgvMonAn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonAn.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvMonAn.Location = new Point(12, 72);
            dgvMonAn.Name = "dgvMonAn";
            dgvMonAn.Size = new Size(543, 150);
            dgvMonAn.TabIndex = 5;
            dgvMonAn.CellDoubleClick += dgvMonAn_CellDoubleClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên món ăn";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Đơn vị tính";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Đơn giá";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Nhóm";
            Column5.Name = "Column5";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 234);
            Controls.Add(dgvMonAn);
            Controls.Add(btnThem);
            Controls.Add(txtTimKiem);
            Controls.Add(cbNhomMonAn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Quản lý";
            ((System.ComponentModel.ISupportInitialize)dgvMonAn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbNhomMonAn;
        private TextBox txtTimKiem;
        private Button btnThem;
        private DataGridView dgvMonAn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
