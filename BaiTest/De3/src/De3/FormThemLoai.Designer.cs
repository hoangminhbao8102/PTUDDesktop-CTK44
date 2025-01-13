namespace De3
{
    partial class FormThemLoai
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
            txtTenLoai = new TextBox();
            btnThemLoai = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên loại mặt hàng";
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(120, 12);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(167, 23);
            txtTenLoai.TabIndex = 1;
            // 
            // btnThemLoai
            // 
            btnThemLoai.Location = new Point(53, 41);
            btnThemLoai.Name = "btnThemLoai";
            btnThemLoai.Size = new Size(75, 23);
            btnThemLoai.TabIndex = 2;
            btnThemLoai.Text = "Thêm loại";
            btnThemLoai.UseVisualStyleBackColor = true;
            btnThemLoai.Click += btnThemLoai_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(172, 41);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormThemLoai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 72);
            Controls.Add(btnHuy);
            Controls.Add(btnThemLoai);
            Controls.Add(txtTenLoai);
            Controls.Add(label1);
            Name = "FormThemLoai";
            Text = "Thêm loại mặt hàng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTenLoai;
        private Button btnThemLoai;
        private Button btnHuy;
    }
}