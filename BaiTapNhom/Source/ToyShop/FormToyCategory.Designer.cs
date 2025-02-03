namespace ToyShop
{
    partial class FormToyCategory
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
            txtCategoryName = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            gbList = new GroupBox();
            listViewToyCategory = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            gbList.SuspendLayout();
            SuspendLayout();
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(128, 12);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(161, 23);
            txtCategoryName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 1;
            label1.Text = "TÊN LOẠI ĐỒ CHƠI";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(18, 41);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "THÊM";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(112, 41);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "CẬP NHẬT";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(208, 41);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "XÓA";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // gbList
            // 
            gbList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbList.Controls.Add(listViewToyCategory);
            gbList.Location = new Point(12, 70);
            gbList.Name = "gbList";
            gbList.Size = new Size(277, 137);
            gbList.TabIndex = 5;
            gbList.TabStop = false;
            gbList.Text = "DANH SÁCH LOẠI ĐỒ CHƠI";
            // 
            // listViewToyCategory
            // 
            listViewToyCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewToyCategory.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewToyCategory.FullRowSelect = true;
            listViewToyCategory.GridLines = true;
            listViewToyCategory.Location = new Point(6, 22);
            listViewToyCategory.Name = "listViewToyCategory";
            listViewToyCategory.Size = new Size(265, 109);
            listViewToyCategory.TabIndex = 0;
            listViewToyCategory.UseCompatibleStateImageBehavior = false;
            listViewToyCategory.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "TÊN LOẠI ĐỒ CHƠI";
            columnHeader2.Width = 150;
            // 
            // FormToyCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 219);
            Controls.Add(gbList);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(txtCategoryName);
            Name = "FormToyCategory";
            Text = "Quản lý thông tin loại đồ chơi";
            gbList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategoryName;
        private Label label1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private GroupBox gbList;
        private ListView listViewToyCategory;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}