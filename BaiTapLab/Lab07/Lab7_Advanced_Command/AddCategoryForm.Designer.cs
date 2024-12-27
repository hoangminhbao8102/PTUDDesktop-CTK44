namespace Lab7_Advanced_Command
{
    partial class AddCategoryForm
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
            txtCategoryName = new TextBox();
            cbbCategoryType = new ComboBox();
            btnAddCategory = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên nhóm món ăn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Loại nhóm món ăn:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(129, 12);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(212, 23);
            txtCategoryName.TabIndex = 2;
            // 
            // cbbCategoryType
            // 
            cbbCategoryType.FormattingEnabled = true;
            cbbCategoryType.Location = new Point(129, 41);
            cbbCategoryType.Name = "cbbCategoryType";
            cbbCategoryType.Size = new Size(212, 23);
            cbbCategoryType.TabIndex = 3;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(113, 70);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(112, 23);
            btnAddCategory.TabIndex = 4;
            btnAddCategory.Text = "Thêm nhóm mới";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 107);
            Controls.Add(btnAddCategory);
            Controls.Add(cbbCategoryType);
            Controls.Add(txtCategoryName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddCategoryForm";
            Text = "AddCategoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCategoryName;
        private ComboBox cbbCategoryType;
        private Button btnAddCategory;
    }
}