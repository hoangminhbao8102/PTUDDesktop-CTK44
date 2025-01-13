using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De3
{
    public partial class FormThemLoai : Form
    {
        private string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=QLBanHang_De3;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
        public bool IsLoaiMatHangAdded { get; private set; } = false; // Để kiểm tra loại mặt hàng có được thêm không

        public FormThemLoai()
        {
            InitializeComponent();
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            string tenLoai = txtTenLoai.Text.Trim();

            if (string.IsNullOrEmpty(tenLoai))
            {
                MessageBox.Show("Vui lòng nhập tên loại mặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO LOAIMATHANG (TenLoai) VALUES (@TenLoai)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenLoai", tenLoai);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    IsLoaiMatHangAdded = true; // Đánh dấu đã thêm thành công
                    MessageBox.Show("Thêm loại mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi thêm thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form khi người dùng hủy
        }
    }
}
