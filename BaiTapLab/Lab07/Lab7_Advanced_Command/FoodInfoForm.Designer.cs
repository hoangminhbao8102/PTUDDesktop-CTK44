namespace Lab7_Advanced_Command
{
    partial class FoodInfoForm
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
            txtFoodID = new TextBox();
            txtName = new TextBox();
            txtUnit = new TextBox();
            cbbCatName = new ComboBox();
            nudPrice = new NumericUpDown();
            txtNotes = new TextBox();
            btnAddNew = new Button();
            btnAddFood = new Button();
            btnUpdateFood = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 15);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "FoodID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 41);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 73);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Unit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 102);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 3;
            label4.Text = "CategoryName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 130);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 4;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 160);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "Notes";
            // 
            // txtFoodID
            // 
            txtFoodID.Location = new Point(137, 12);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.ReadOnly = true;
            txtFoodID.Size = new Size(100, 23);
            txtFoodID.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(137, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(237, 23);
            txtName.TabIndex = 7;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(137, 70);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(237, 23);
            txtUnit.TabIndex = 8;
            // 
            // cbbCatName
            // 
            cbbCatName.FormattingEnabled = true;
            cbbCatName.Location = new Point(137, 99);
            cbbCatName.Name = "cbbCatName";
            cbbCatName.Size = new Size(156, 23);
            cbbCatName.TabIndex = 9;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(137, 128);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(237, 23);
            nudPrice.TabIndex = 10;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(137, 157);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(237, 23);
            txtNotes.TabIndex = 11;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(299, 99);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(75, 23);
            btnAddNew.TabIndex = 12;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(137, 186);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(75, 23);
            btnAddFood.TabIndex = 13;
            btnAddFood.Text = "Add";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // btnUpdateFood
            // 
            btnUpdateFood.Location = new Point(218, 186);
            btnUpdateFood.Name = "btnUpdateFood";
            btnUpdateFood.Size = new Size(75, 23);
            btnUpdateFood.TabIndex = 14;
            btnUpdateFood.Text = "Update";
            btnUpdateFood.UseVisualStyleBackColor = true;
            btnUpdateFood.Click += btnUpdateFood_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(299, 186);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FoodInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 229);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdateFood);
            Controls.Add(btnAddFood);
            Controls.Add(btnAddNew);
            Controls.Add(txtNotes);
            Controls.Add(nudPrice);
            Controls.Add(cbbCatName);
            Controls.Add(txtUnit);
            Controls.Add(txtName);
            Controls.Add(txtFoodID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FoodInfoForm";
            Text = "FoodInfoForm";
            Load += FoodInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
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
        private TextBox txtFoodID;
        private TextBox txtName;
        private TextBox txtUnit;
        private ComboBox cbbCatName;
        private NumericUpDown nudPrice;
        private TextBox txtNotes;
        private Button btnAddNew;
        private Button btnAddFood;
        private Button btnUpdateFood;
        private Button btnCancel;
    }
}