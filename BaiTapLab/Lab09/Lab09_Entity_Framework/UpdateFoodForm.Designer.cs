namespace Lab09_Entity_Framework
{
    partial class UpdateFoodForm
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
            label6 = new Label();
            txtFoodId = new TextBox();
            txtFoodName = new TextBox();
            txtFoodUnit = new TextBox();
            cbbFoodCategory = new ComboBox();
            nudFoodPrice = new NumericUpDown();
            txtFoodNotes = new RichTextBox();
            btnCancel = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)nudFoodPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên món ăn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 2;
            label3.Text = "Thuộc danh mục";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 102);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "Đơn vị tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 130);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 4;
            label5.Text = "Đơn giá";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 160);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 5;
            label6.Text = "Ghi chú khác";
            // 
            // txtFoodId
            // 
            txtFoodId.Location = new Point(116, 12);
            txtFoodId.Name = "txtFoodId";
            txtFoodId.ReadOnly = true;
            txtFoodId.Size = new Size(100, 23);
            txtFoodId.TabIndex = 6;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(116, 41);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(189, 23);
            txtFoodName.TabIndex = 7;
            // 
            // txtFoodUnit
            // 
            txtFoodUnit.Location = new Point(116, 99);
            txtFoodUnit.Name = "txtFoodUnit";
            txtFoodUnit.Size = new Size(189, 23);
            txtFoodUnit.TabIndex = 8;
            // 
            // cbbFoodCategory
            // 
            cbbFoodCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbFoodCategory.FormattingEnabled = true;
            cbbFoodCategory.Location = new Point(116, 70);
            cbbFoodCategory.Name = "cbbFoodCategory";
            cbbFoodCategory.Size = new Size(189, 23);
            cbbFoodCategory.TabIndex = 9;
            // 
            // nudFoodPrice
            // 
            nudFoodPrice.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudFoodPrice.Location = new Point(116, 128);
            nudFoodPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudFoodPrice.Name = "nudFoodPrice";
            nudFoodPrice.Size = new Size(189, 23);
            nudFoodPrice.TabIndex = 10;
            nudFoodPrice.ThousandsSeparator = true;
            // 
            // txtFoodNotes
            // 
            txtFoodNotes.Location = new Point(116, 157);
            txtFoodNotes.Name = "txtFoodNotes";
            txtFoodNotes.Size = new Size(189, 96);
            txtFoodNotes.TabIndex = 11;
            txtFoodNotes.Text = "";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(230, 263);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "&Thoát";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(149, 263);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "&Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // UpdateFoodForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(317, 298);
            ControlBox = false;
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtFoodNotes);
            Controls.Add(nudFoodPrice);
            Controls.Add(cbbFoodCategory);
            Controls.Add(txtFoodUnit);
            Controls.Add(txtFoodName);
            Controls.Add(txtFoodId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateFoodForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm/cập nhật món ăn";
            Load += UpdateFoodForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudFoodPrice).EndInit();
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
        private TextBox txtFoodId;
        private TextBox txtFoodName;
        private TextBox txtFoodUnit;
        private ComboBox cbbFoodCategory;
        private NumericUpDown nudFoodPrice;
        private RichTextBox txtFoodNotes;
        private Button btnCancel;
        private Button btnSave;
    }
}