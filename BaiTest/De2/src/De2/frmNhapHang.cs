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

namespace De2
{
    public partial class frmNhapHang : Form
    {
        private string connectionString;

        public frmNhapHang()
        {
            connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=QLBanHang;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
            InitializeComponent();
            LoadNhaCungCap();
            LoadMatHang();
            dtpNgayNhap.Value = DateTime.Now;
            dtpNgayNhap.Enabled = false; // Ngày nhập chỉ hiển thị
        }

        private void LoadNhaCungCap()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaNCC, TenNhaCC FROM NhaCungCap";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cboNhaCungCap.DataSource = dt;
                cboNhaCungCap.DisplayMember = "TenNhaCC";
                cboNhaCungCap.ValueMember = "MaNCC";
            }
        }

        private void LoadMatHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaMatHang, TenMatHang, DonGia FROM MatHang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Kiểm tra cột "TenHang"
                if (dgvChiTietNhap.Columns["TenHang"] is DataGridViewComboBoxColumn tenHangColumn)
                {
                    tenHangColumn.DataSource = dt;
                    tenHangColumn.DisplayMember = "TenMatHang";
                    tenHangColumn.ValueMember = "MaMatHang";
                }
                else
                {
                    MessageBox.Show("Cột 'TenHang' không tồn tại hoặc không đúng kiểu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvChiTietNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra chỉ số hàng và cột hợp lệ
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Kiểm tra cột "TenHang"
            if (dgvChiTietNhap.Columns["TenHang"] != null && e.ColumnIndex == dgvChiTietNhap.Columns["TenHang"].Index)
            {
                // Kiểm tra giá trị trong ô không bị null
                var cellValue = dgvChiTietNhap.Rows[e.RowIndex].Cells["TenHang"].Value;
                if (cellValue != null)
                {
                    int maMatHang = Convert.ToInt32(cellValue);
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT DonGia FROM MatHang WHERE MaMatHang = @MaMatHang";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaMatHang", maMatHang);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            decimal donGia = Convert.ToDecimal(result);
                            dgvChiTietNhap.Rows[e.RowIndex].Cells["DonGiaNhap"].Value = donGia * 0.9m; // Đơn giá nhập = 90% * Đơn giá
                        }
                    }
                }
            }

            // Kiểm tra cột "SoLuong"
            if (dgvChiTietNhap.Columns["SoLuong"] != null && e.ColumnIndex == dgvChiTietNhap.Columns["SoLuong"].Index)
            {
                var soLuongValue = dgvChiTietNhap.Rows[e.RowIndex].Cells["SoLuong"].Value;
                var donGiaNhapValue = dgvChiTietNhap.Rows[e.RowIndex].Cells["DonGiaNhap"].Value;

                // Kiểm tra giá trị không bị null trước khi chuyển đổi
                decimal soLuong = Convert.ToDecimal(soLuongValue ?? 0);
                decimal donGiaNhap = Convert.ToDecimal(donGiaNhapValue ?? 0);

                dgvChiTietNhap.Rows[e.RowIndex].Cells["ThanhTien"].Value = soLuong * donGiaNhap;

                TinhTongTien(); // Cập nhật tổng tiền
            }
        }

        private void TinhTongTien()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgvChiTietNhap.Rows)
            {
                tongTien += Convert.ToDecimal(row.Cells["ThanhTien"].Value ?? 0);
            }

            txtTongTien.Text = tongTien.ToString("N0");
            TinhPhaiTra();
        }

        private void TinhPhaiTra()
        {
            decimal tongTien = Convert.ToDecimal(txtTongTien.Text ?? "0"); // Tổng tiền
            decimal giamGia = nudGiamGia.Value; // Giá trị giảm giá từ NumericUpDown
            txtPhaiTra.Text = (tongTien - (tongTien * giamGia / 100)).ToString("N0"); // Tính tiền phải trả
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frmNCC = new frmNhaCungCap();
            if (frmNCC.ShowDialog() == DialogResult.OK)
            {
                LoadNhaCungCap();
                cboNhaCungCap.SelectedValue = frmNCC.MaNhaCungCapMoi;
            }
        }

        private void nudGiamGia_ValueChanged(object sender, EventArgs e)
        {
            TinhPhaiTra();
        }
    }
}
