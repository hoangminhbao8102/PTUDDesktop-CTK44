namespace Lab09_Entity_Framework
{
    partial class MenuForm
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
            comboBoxCategory = new ComboBox();
            label1 = new Label();
            buttonShowAll = new Button();
            buttonPrintMenu = new Button();
            listViewFoods = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            SuspendLayout();
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(178, 12);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(343, 23);
            comboBoxCategory.TabIndex = 0;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 16);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 1;
            label1.Text = "Chọn nhóm món ăn:";
            // 
            // buttonShowAll
            // 
            buttonShowAll.Location = new Point(527, 12);
            buttonShowAll.Name = "buttonShowAll";
            buttonShowAll.Size = new Size(75, 23);
            buttonShowAll.TabIndex = 2;
            buttonShowAll.Text = "Xem tất cả";
            buttonShowAll.UseVisualStyleBackColor = true;
            buttonShowAll.Click += buttonShowAll_Click;
            // 
            // buttonPrintMenu
            // 
            buttonPrintMenu.Location = new Point(608, 12);
            buttonPrintMenu.Name = "buttonPrintMenu";
            buttonPrintMenu.Size = new Size(81, 23);
            buttonPrintMenu.TabIndex = 3;
            buttonPrintMenu.Text = "In thực đơn";
            buttonPrintMenu.UseVisualStyleBackColor = true;
            buttonPrintMenu.Click += buttonPrintMenu_Click;
            // 
            // listViewFoods
            // 
            listViewFoods.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewFoods.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewFoods.FullRowSelect = true;
            listViewFoods.GridLines = true;
            listViewFoods.Location = new Point(12, 41);
            listViewFoods.Name = "listViewFoods";
            listViewFoods.Size = new Size(776, 397);
            listViewFoods.TabIndex = 4;
            listViewFoods.UseCompatibleStateImageBehavior = false;
            listViewFoods.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Đơn vị";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Nhóm món";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Giá";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Ghi chú";
            columnHeader5.Width = 200;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewFoods);
            Controls.Add(buttonPrintMenu);
            Controls.Add(buttonShowAll);
            Controls.Add(label1);
            Controls.Add(comboBoxCategory);
            Name = "MenuForm";
            Text = "Quản lý thực đơn";
            Load += MenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCategory;
        private Label label1;
        private Button buttonShowAll;
        private Button buttonPrintMenu;
        private ListView listViewFoods;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}