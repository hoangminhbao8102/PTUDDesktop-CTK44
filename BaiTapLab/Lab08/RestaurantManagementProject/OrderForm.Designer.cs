namespace RestaurantManagementProject
{
    partial class OrderForm
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
            grpLeft = new GroupBox();
            dgvFood = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            grpRight = new GroupBox();
            lvOrder = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label1 = new Label();
            nudQuantity = new NumericUpDown();
            btnAddFood = new Button();
            btnRemoveFood = new Button();
            btnSaveOrder = new Button();
            grpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
            grpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // grpLeft
            // 
            grpLeft.Controls.Add(dgvFood);
            grpLeft.Location = new Point(12, 12);
            grpLeft.Name = "grpLeft";
            grpLeft.Size = new Size(359, 182);
            grpLeft.TabIndex = 0;
            grpLeft.TabStop = false;
            grpLeft.Text = "Danh sách món ăn";
            // 
            // dgvFood
            // 
            dgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFood.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvFood.Location = new Point(6, 22);
            dgvFood.Name = "dgvFood";
            dgvFood.Size = new Size(343, 150);
            dgvFood.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên món";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Giá";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Ghi chú";
            Column3.Name = "Column3";
            // 
            // grpRight
            // 
            grpRight.Controls.Add(lvOrder);
            grpRight.Location = new Point(377, 12);
            grpRight.Name = "grpRight";
            grpRight.Size = new Size(270, 182);
            grpRight.TabIndex = 1;
            grpRight.TabStop = false;
            grpRight.Text = "Danh sách đã chọn";
            // 
            // lvOrder
            // 
            lvOrder.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvOrder.FullRowSelect = true;
            lvOrder.GridLines = true;
            lvOrder.Location = new Point(6, 22);
            lvOrder.Name = "lvOrder";
            lvOrder.Size = new Size(254, 150);
            lvOrder.TabIndex = 0;
            lvOrder.UseCompatibleStateImageBehavior = false;
            lvOrder.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Giá";
            columnHeader2.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 202);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Số lượng";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(285, 200);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 23);
            nudQuantity.TabIndex = 3;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(134, 229);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(75, 23);
            btnAddFood.TabIndex = 4;
            btnAddFood.Text = "Thêm món";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // btnRemoveFood
            // 
            btnRemoveFood.Location = new Point(298, 229);
            btnRemoveFood.Name = "btnRemoveFood";
            btnRemoveFood.Size = new Size(75, 23);
            btnRemoveFood.TabIndex = 5;
            btnRemoveFood.Text = "Xóa món";
            btnRemoveFood.UseVisualStyleBackColor = true;
            btnRemoveFood.Click += btnRemoveFood_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(457, 229);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(93, 23);
            btnSaveOrder.TabIndex = 6;
            btnSaveOrder.Text = "Lưu đơn hàng";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 262);
            Controls.Add(btnSaveOrder);
            Controls.Add(btnRemoveFood);
            Controls.Add(btnAddFood);
            Controls.Add(nudQuantity);
            Controls.Add(label1);
            Controls.Add(grpRight);
            Controls.Add(grpLeft);
            Name = "OrderForm";
            Text = "Đặt món ăn";
            grpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
            grpRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpLeft;
        private GroupBox grpRight;
        private DataGridView dgvFood;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private ListView lvOrder;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label1;
        private NumericUpDown nudQuantity;
        private Button btnAddFood;
        private Button btnRemoveFood;
        private Button btnSaveOrder;
    }
}