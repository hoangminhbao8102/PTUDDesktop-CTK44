namespace RestaurantManagementProject
{
    partial class TableManagerForm
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
            grpList = new GroupBox();
            lvTables = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnAddTable = new Button();
            btnEditTable = new Button();
            btnDeleteTable = new Button();
            btnSplitTable = new Button();
            btnMergeTable = new Button();
            grpList.SuspendLayout();
            SuspendLayout();
            // 
            // grpList
            // 
            grpList.Controls.Add(lvTables);
            grpList.Location = new Point(12, 12);
            grpList.Name = "grpList";
            grpList.Size = new Size(270, 258);
            grpList.TabIndex = 1;
            grpList.TabStop = false;
            grpList.Text = "Danh sách bàn";
            // 
            // lvTables
            // 
            lvTables.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvTables.FullRowSelect = true;
            lvTables.GridLines = true;
            lvTables.Location = new Point(6, 22);
            lvTables.Name = "lvTables";
            lvTables.Size = new Size(258, 230);
            lvTables.TabIndex = 0;
            lvTables.UseCompatibleStateImageBehavior = false;
            lvTables.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Bàn";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Trạng thái";
            columnHeader2.Width = 150;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(18, 287);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(75, 23);
            btnAddTable.TabIndex = 2;
            btnAddTable.Text = "Thêm bàn";
            btnAddTable.UseVisualStyleBackColor = true;
            btnAddTable.Click += btnAddTable_Click;
            // 
            // btnEditTable
            // 
            btnEditTable.Location = new Point(99, 287);
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(75, 23);
            btnEditTable.TabIndex = 3;
            btnEditTable.Text = "Sửa bàn";
            btnEditTable.UseVisualStyleBackColor = true;
            btnEditTable.Click += btnEditTable_Click;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(180, 287);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(75, 23);
            btnDeleteTable.TabIndex = 4;
            btnDeleteTable.Text = "Xóa bàn";
            btnDeleteTable.UseVisualStyleBackColor = true;
            btnDeleteTable.Click += btnDeleteTable_Click;
            // 
            // btnSplitTable
            // 
            btnSplitTable.Location = new Point(48, 328);
            btnSplitTable.Name = "btnSplitTable";
            btnSplitTable.Size = new Size(75, 23);
            btnSplitTable.TabIndex = 5;
            btnSplitTable.Text = "Tách bàn";
            btnSplitTable.UseVisualStyleBackColor = true;
            btnSplitTable.Click += btnSplitTable_Click;
            // 
            // btnMergeTable
            // 
            btnMergeTable.Location = new Point(151, 328);
            btnMergeTable.Name = "btnMergeTable";
            btnMergeTable.Size = new Size(75, 23);
            btnMergeTable.TabIndex = 6;
            btnMergeTable.Text = "Gộp bàn";
            btnMergeTable.UseVisualStyleBackColor = true;
            btnMergeTable.Click += btnMergeTable_Click;
            // 
            // TableManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 372);
            Controls.Add(btnMergeTable);
            Controls.Add(btnSplitTable);
            Controls.Add(btnDeleteTable);
            Controls.Add(btnEditTable);
            Controls.Add(btnAddTable);
            Controls.Add(grpList);
            Name = "TableManagerForm";
            Text = "Quản lý bàn";
            grpList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpList;
        private ListView lvTables;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btnAddTable;
        private Button btnEditTable;
        private Button btnDeleteTable;
        private Button btnSplitTable;
        private Button btnMergeTable;
    }
}