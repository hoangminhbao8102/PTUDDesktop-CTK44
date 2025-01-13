using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.Json;

namespace De2
{
    public partial class frmNhaCungCap : Form
    {
        private string connectionString;
        public int MaNhaCungCapMoi { get; private set; }

        public frmNhaCungCap()
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
                string query = "SELECT * FROM NhaCungCap";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvNhaCungCap.DataSource = dt;
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            mtxtSoDT.Clear();
            txtMoTa.Clear();
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhaCungCap.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                txtTenNCC.Text = row.Cells["TenNhaCC"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                mtxtSoDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                if (string.IsNullOrWhiteSpace(txtMaNCC.Text))
                {
                    // Thêm mới nhà cung cấp
                    conn.Open();
                    string query = "INSERT INTO NhaCungCap (TenNhaCC, DiaChi, SoDienThoai, MoTa) VALUES (@TenNhaCC, @DiaChi, @SoDienThoai, @MoTa); SELECT SCOPE_IDENTITY();";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenNhaCC", txtTenNCC.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@SoDienThoai", mtxtSoDT.Text);
                    cmd.Parameters.AddWithValue("@MoTa", txtMoTa.Text);

                    MaNhaCungCapMoi = Convert.ToInt32(cmd.ExecuteScalar());
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    // Cập nhật nhà cung cấp
                    string query = "UPDATE NhaCungCap SET TenNhaCC = @TenNCC, DiaChi = @DiaChi, SoDienThoai = @SoDT, MoTa = @MoTa WHERE MaNCC = @MaNCC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text);
                    cmd.Parameters.AddWithValue("@TenNCC", txtTenNCC.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@SoDT", mtxtSoDT.Text);
                    cmd.Parameters.AddWithValue("@MoTa", txtMoTa.Text);
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
                    query = "SELECT * FROM NhaCungCap WHERE TenNhaCC LIKE @Keyword";
                }
                else
                {
                    query = "SELECT * FROM NhaCungCap WHERE SoDienThoai LIKE @Keyword";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvNhaCungCap.DataSource = dt;
            }
        }

        private void btnXuatJson_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON Files|*.json";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var dt = (DataTable)dgvNhaCungCap.DataSource;
                    var list = dt.AsEnumerable().Select(row => new
                    {
                        MaNCC = row["MaNCC"],
                        TenNhaCC = row["TenNhaCC"],
                        DiaChi = row["DiaChi"],
                        SoDienThoai = row["SoDienThoai"],
                        MoTa = row["MoTa"]
                    }).ToList();

                    string json = JsonSerializer.Serialize(list);
                    File.WriteAllText(saveFileDialog.FileName, json);

                    MessageBox.Show("Dữ liệu đã được xuất ra file JSON!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
