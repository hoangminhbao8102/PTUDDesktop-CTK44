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

namespace De1
{
    public partial class frmBanHang : Form
    {
        private string connectionString;

        public frmBanHang()
        {
            connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=QLBanHang;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
            InitializeComponent();
            LoadData();
            dtpNgayXuat.Value = DateTime.Now;
            dtpNgayXuat.Enabled = false; // Ngày nhập chỉ hiển thị
        }

        private void LoadData()
        {
            LoadKhachHang();
            LoadMatHang();
        }

        private void LoadKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaKH, TenKH FROM KhachHang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cboKhachHang.DataSource = dt;
                cboKhachHang.DisplayMember = "TenKH";
                cboKhachHang.ValueMember = "MaKH";
            }
        }

        private void LoadMatHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TenMatHang, DonGia FROM MatHang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                var tenHangColumn = dgvChiTietBanHang.Columns["TenHang"] as DataGridViewComboBoxColumn;
                if (tenHangColumn != null)
                {
                    tenHangColumn.DataSource = dt;
                    tenHangColumn.DisplayMember = "TenMatHang";
                    tenHangColumn.ValueMember = "TenMatHang";
                }
            }
        }

        private void dgvChiTietBanHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvChiTietBanHang.Columns[e.ColumnIndex].Name == "TenHang")
            {
                string tenHang = dgvChiTietBanHang.Rows[e.RowIndex].Cells["TenHang"].Value?.ToString()!;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT DonGia FROM MatHang WHERE TenMatHang = @TenMatHang";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenMatHang", tenHang);

                    var donGia = cmd.ExecuteScalar();
                    if (donGia != null)
                    {
                        dgvChiTietBanHang.Rows[e.RowIndex].Cells["DonGia"].Value = donGia.ToString();
                    }
                }
            }

            if (e.RowIndex >= 0 && dgvChiTietBanHang.Columns[e.ColumnIndex].Name == "SoLuong")
            {
                TinhThanhTien(e.RowIndex);
            }
        }

        private void TinhThanhTien(int rowIndex)
        {
            var soLuongCell = dgvChiTietBanHang.Rows[rowIndex].Cells["SoLuong"];
            var donGiaCell = dgvChiTietBanHang.Rows[rowIndex].Cells["DonGia"];
            var thanhTienCell = dgvChiTietBanHang.Rows[rowIndex].Cells["ThanhTien"];

            if (soLuongCell.Value != null && donGiaCell.Value != null)
            {
                int soLuong = int.Parse(soLuongCell.Value.ToString()!);
                decimal donGia = decimal.Parse(donGiaCell.Value.ToString()!);
                thanhTienCell.Value = soLuong * donGia;

                TinhTongTien();
            }
        }

        private void TinhTongTien()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgvChiTietBanHang.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    tongTien += decimal.Parse(row.Cells["ThanhTien"].Value.ToString()!);
                }
            }

            txtTongTien.Text = tongTien.ToString("N0");
            TinhPhaiTra();
        }

        private void TinhPhaiTra()
        {
            if (decimal.TryParse(txtTongTien.Text, out decimal tongTien) && decimal.TryParse(nudGiamGia.Text, out decimal giamGia))
            {
                decimal phaiTra = tongTien - (tongTien * giamGia / 100);
                txtPhaiTra.Text = phaiTra.ToString("N0");
            }
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            TinhPhaiTra();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Thêm hóa đơn mới vào cơ sở dữ liệu
                string query = "INSERT INTO HoaDon (NgayXuat, MaKH, TongTien, GiamGia, PhaiTra) VALUES (@NgayXuat, @MaKH, @TongTien, @GiamGia, @PhaiTra)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NgayXuat", DateTime.Now);
                cmd.Parameters.AddWithValue("@MaKH", cboKhachHang.SelectedValue);
                cmd.Parameters.AddWithValue("@TongTien", txtTongTien.Text);
                cmd.Parameters.AddWithValue("@GiamGia", nudGiamGia.Value);
                cmd.Parameters.AddWithValue("@PhaiTra", txtPhaiTra.Text);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Hóa đơn đã được lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang formKhachHang = new frmKhachHang();
            formKhachHang.ShowDialog();
            LoadKhachHang();
        }
    }
}
