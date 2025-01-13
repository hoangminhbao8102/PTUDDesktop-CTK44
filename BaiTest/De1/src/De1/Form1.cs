using Microsoft.Data.SqlClient;
using System.Data;

namespace De1
{
    public partial class frmKhachHang : Form
    {
        private string connectionString;

        public frmKhachHang()
        {
            connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=QLBanHang;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM KhachHang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvKhachHang.DataSource = dt;
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            mtxtSoDT.Clear();
            txtDiaChi.Clear();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                mtxtSoDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChiGH"].Value.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                if (string.IsNullOrWhiteSpace(txtMaKH.Text))
                {
                    // Thêm khách hàng mới
                    string query = "INSERT INTO KhachHang (TenKH, SoDienThoai, DiaChiGH) VALUES (@TenKH, @SoDienThoai, @DiaChiGH)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                    cmd.Parameters.AddWithValue("@SoDienThoai", mtxtSoDT.Text);
                    cmd.Parameters.AddWithValue("@DiaChiGH", txtDiaChi.Text);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    // Cập nhật khách hàng
                    string query = "UPDATE KhachHang SET TenKH = @TenKH, SoDienThoai = @SoDienThoai, DiaChiGH = @DiaChiGH WHERE MaKH = @MaKH";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                    cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                    cmd.Parameters.AddWithValue("@SoDienThoai", mtxtSoDT.Text);
                    cmd.Parameters.AddWithValue("@DiaChiGH", txtDiaChi.Text);
                    cmd.ExecuteNonQuery();
                }

                LoadData();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string keyword = txtTimKiem.Text;
                string query;

                if (rbtnTheoTen.Checked)
                {
                    query = "SELECT * FROM KhachHang WHERE TenKH LIKE @Keyword";
                }
                else
                {
                    query = "SELECT * FROM KhachHang WHERE SoDienThoai LIKE @Keyword";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvKhachHang.DataSource = dt;
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var dt = (DataTable)dgvKhachHang.DataSource;

                    using (var package = new OfficeOpenXml.ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add("DanhSachKhachHang");
                        worksheet.Cells["A1"].LoadFromDataTable(dt, true);
                        package.SaveAs(new FileInfo(saveFileDialog.FileName));
                    }

                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
