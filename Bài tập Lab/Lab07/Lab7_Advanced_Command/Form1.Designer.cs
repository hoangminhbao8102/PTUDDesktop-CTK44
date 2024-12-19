namespace Lab7_Advanced_Command
{
    partial class Form1
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
            label1 = new Label();
            cbbCategory = new ComboBox();
            dgvFoodList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsmCalculateQuantity = new ToolStripMenuItem();
            tsmAddFood = new ToolStripMenuItem();
            tsmUpdateFood = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            lblQuantity = new Label();
            lblCatName = new Label();
            label4 = new Label();
            txtSearchByName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFoodList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Chọn nhóm món ăn:";
            // 
            // cbbCategory
            // 
            cbbCategory.FormattingEnabled = true;
            cbbCategory.Location = new Point(144, 12);
            cbbCategory.Name = "cbbCategory";
            cbbCategory.Size = new Size(197, 23);
            cbbCategory.TabIndex = 1;
            cbbCategory.SelectedIndexChanged += cbbCategory_SelectedIndexChanged;
            // 
            // dgvFoodList
            // 
            dgvFoodList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodList.ContextMenuStrip = contextMenuStrip1;
            dgvFoodList.Location = new Point(12, 41);
            dgvFoodList.MultiSelect = false;
            dgvFoodList.Name = "dgvFoodList";
            dgvFoodList.Size = new Size(645, 293);
            dgvFoodList.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsmCalculateQuantity, tsmAddFood, tsmUpdateFood });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(219, 70);
            // 
            // tsmCalculateQuantity
            // 
            tsmCalculateQuantity.Name = "tsmCalculateQuantity";
            tsmCalculateQuantity.Size = new Size(218, 22);
            tsmCalculateQuantity.Text = "Tính số lượng đã bán";
            tsmCalculateQuantity.Click += tsmCalculateQuantity_Click;
            // 
            // tsmAddFood
            // 
            tsmAddFood.Name = "tsmAddFood";
            tsmAddFood.Size = new Size(218, 22);
            tsmAddFood.Text = "Thêm mới";
            tsmAddFood.Click += tsmAddFood_Click;
            // 
            // tsmUpdateFood
            // 
            tsmUpdateFood.Name = "tsmUpdateFood";
            tsmUpdateFood.Size = new Size(218, 22);
            tsmUpdateFood.Text = "Cập nhật thông tin món ăn";
            tsmUpdateFood.Click += tsmUpdateFood_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 347);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Có tất cả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 347);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 4;
            label3.Text = "món ăn thuộc nhóm";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(102, 347);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(16, 15);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "...";
            // 
            // lblCatName
            // 
            lblCatName.AutoSize = true;
            lblCatName.Location = new Point(247, 347);
            lblCatName.Name = "lblCatName";
            lblCatName.Size = new Size(16, 15);
            lblCatName.TabIndex = 6;
            lblCatName.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 15);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 7;
            label4.Text = "Tìm kiếm theo tên:";
            // 
            // txtSearchByName
            // 
            txtSearchByName.Location = new Point(460, 12);
            txtSearchByName.Name = "txtSearchByName";
            txtSearchByName.Size = new Size(190, 23);
            txtSearchByName.TabIndex = 8;
            txtSearchByName.TextChanged += txtSearchByName_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 377);
            Controls.Add(txtSearchByName);
            Controls.Add(label4);
            Controls.Add(lblCatName);
            Controls.Add(lblQuantity);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvFoodList);
            Controls.Add(cbbCategory);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFoodList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbbCategory;
        private DataGridView dgvFoodList;
        private Label label2;
        private Label label3;
        private Label lblQuantity;
        private Label lblCatName;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsmCalculateQuantity;
        private ToolStripMenuItem tsmAddFood;
        private ToolStripMenuItem tsmUpdateFood;
        private Label label4;
        private TextBox txtSearchByName;
    }
}
