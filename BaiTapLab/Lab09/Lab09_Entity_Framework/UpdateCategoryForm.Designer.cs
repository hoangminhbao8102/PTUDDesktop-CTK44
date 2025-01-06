namespace Lab09_Entity_Framework
{
    partial class UpdateCategoryForm
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
            txtCategoryId = new TextBox();
            txtCategoryName = new TextBox();
            cbbCategoryType = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
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
            label2.Size = new Size(104, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên nhóm thức ăn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Loại";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(122, 12);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.ReadOnly = true;
            txtCategoryId.Size = new Size(100, 23);
            txtCategoryId.TabIndex = 3;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(122, 41);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(278, 23);
            txtCategoryName.TabIndex = 4;
            // 
            // cbbCategoryType
            // 
            cbbCategoryType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCategoryType.FormattingEnabled = true;
            cbbCategoryType.Items.AddRange(new object[] { "Đồ uống", "Thức ăn" });
            cbbCategoryType.Location = new Point(122, 70);
            cbbCategoryType.Name = "cbbCategoryType";
            cbbCategoryType.Size = new Size(278, 23);
            cbbCategoryType.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(244, 99);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "&Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(325, 99);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "&Thoát";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // UpdateCategoryForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(412, 134);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cbbCategoryType);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateCategoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm/cập nhật nhóm thức ăn";
            Load += UpdateCategoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCategoryId;
        private TextBox txtCategoryName;
        private ComboBox cbbCategoryType;
        private Button btnSave;
        private Button btnCancel;
    }
}