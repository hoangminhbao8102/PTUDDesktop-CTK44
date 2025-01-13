using Microsoft.Data.SqlClient;
using System.Data;

namespace Demo
{
    public partial class MainForm : Form
    {
        private string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=QLMonAn;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";

        public MainForm()
        {
            InitializeComponent();
            LoadNhomMonAn();
            LoadDanhSachMonAn();
        }

        private void LoadNhomMonAn()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM NhomMonAn";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbNhomMonAn.DisplayMember = "TenNhom";
                cbNhomMonAn.ValueMember = "MaNhom";
                cbNhomMonAn.DataSource = dt;
            }
        }

        private void LoadDanhSachMonAn(string search = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaMonAn, TenMonAn, DonViTinh, DonGia, Nhom FROM MonAn";
                if (!string.IsNullOrWhiteSpace(search))
                {
                    query += " WHERE TenMonAn LIKE @search";
                }
                SqlCommand cmd = new SqlCommand(query, conn);
                if (!string.IsNullOrWhiteSpace(search))
                {
                    cmd.Parameters.AddWithValue("@search", $"%{search}%");
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvMonAn.DataSource = dt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormMonAn form = new FormMonAn();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachMonAn();
            }
        }

        private void dgvMonAn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maMonAn = Convert.ToInt32(dgvMonAn.Rows[e.RowIndex].Cells["MaMonAn"].Value);
                FormMonAn form = new FormMonAn(maMonAn);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadDanhSachMonAn();
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDanhSachMonAn(txtTimKiem.Text);
        }
    }
}
