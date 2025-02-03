namespace ToyShop
{
    partial class FormMain
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
            gbMenu = new GroupBox();
            btnToyCategory = new Button();
            btnToy = new Button();
            btnInvoice = new Button();
            btnCustomer = new Button();
            gbMenu.SuspendLayout();
            SuspendLayout();
            // 
            // gbMenu
            // 
            gbMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbMenu.Controls.Add(btnToyCategory);
            gbMenu.Controls.Add(btnToy);
            gbMenu.Controls.Add(btnInvoice);
            gbMenu.Controls.Add(btnCustomer);
            gbMenu.Location = new Point(12, 12);
            gbMenu.Name = "gbMenu";
            gbMenu.Size = new Size(334, 137);
            gbMenu.TabIndex = 0;
            gbMenu.TabStop = false;
            gbMenu.Text = "Chọn menu";
            // 
            // btnToyCategory
            // 
            btnToyCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnToyCategory.Location = new Point(172, 78);
            btnToyCategory.Name = "btnToyCategory";
            btnToyCategory.Size = new Size(156, 50);
            btnToyCategory.TabIndex = 3;
            btnToyCategory.Text = "LOẠI ĐỒ CHƠI";
            btnToyCategory.UseVisualStyleBackColor = true;
            btnToyCategory.Click += btnToyCategory_Click;
            // 
            // btnToy
            // 
            btnToy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnToy.Location = new Point(6, 78);
            btnToy.Name = "btnToy";
            btnToy.Size = new Size(160, 50);
            btnToy.TabIndex = 2;
            btnToy.Text = "MÓN ĐỒ CHƠI";
            btnToy.UseVisualStyleBackColor = true;
            btnToy.Click += btnToy_Click;
            // 
            // btnInvoice
            // 
            btnInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInvoice.Location = new Point(172, 22);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(156, 50);
            btnInvoice.TabIndex = 1;
            btnInvoice.Text = "HÓA ĐƠN";
            btnInvoice.UseVisualStyleBackColor = true;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCustomer.Location = new Point(6, 22);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(160, 50);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "KHÁCH HÀNG";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 161);
            Controls.Add(gbMenu);
            Name = "FormMain";
            Text = "Phần mềm Quản lý Shop đồ chơi trẻ em";
            gbMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbMenu;
        private Button btnToyCategory;
        private Button btnToy;
        private Button btnInvoice;
        private Button btnCustomer;
    }
}
