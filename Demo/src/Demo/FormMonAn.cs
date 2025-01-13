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

namespace Demo
{
    public partial class FormMonAn : Form
    {
        private string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=QLMonAn;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
        private int? maMonAn; // Dùng để xác định trạng thái thêm mới hoặc cập nhật

        public FormMonAn(int? maMonAn = null)
        {
            InitializeComponent();
            this.maMonAn = maMonAn;
            LoadNhomMonAn();
            if (maMonAn.HasValue)
            {
                LoadThongTinMonAn();
            }
        }

        private void LoadNhomMonAn()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaNhom, TenNhom FROM NhomMonAn";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cbNhomMonAn.DataSource = dt;
                    cbNhomMonAn.DisplayMember = "TenNhom";
                    cbNhomMonAn.ValueMember = "MaNhom";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }

        private void LoadThongTinMonAn()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM MonAn WHERE MaMonAn = @maMonAn";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maMonAn", maMonAn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtTenMonAn.Text = reader["TenMonAn"].ToString();
                    txtDonViTinh.Text = reader["DonViTinh"].ToString();
                    nudDonGia.Value = Convert.ToDecimal(reader["DonGia"]);
                    cbNhomMonAn.SelectedValue = reader["Nhom"];
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query;
                if (maMonAn.HasValue)
                {
                    query = "UPDATE MonAn SET TenMonAn = @tenMonAn, DonViTinh = @donViTinh, DonGia = @donGia, Nhom = @nhom WHERE MaMonAn = @maMonAn";
                }
                else
                {
                    query = "INSERT INTO MonAn (TenMonAn, DonViTinh, DonGia, Nhom) VALUES (@tenMonAn, @donViTinh, @donGia, @nhom)";
                }
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tenMonAn", txtMaMonAn.Text);
                cmd.Parameters.AddWithValue("@donViTinh", txtTenMonAn.Text);
                cmd.Parameters.AddWithValue("@donGia", txtDonViTinh.Text);
                cmd.Parameters.AddWithValue("@nhom", cbNhomMonAn.SelectedValue);
                if (maMonAn.HasValue)
                {
                    cmd.Parameters.AddWithValue("@maMonAn", maMonAn);
                }
                cmd.ExecuteNonQuery();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
