using Microsoft.Data.SqlClient;
using System.Data;

namespace De3
{
    public partial class FormMain : Form
    {
        string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=QLBanHang_De3;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadProductList();
            LoadProductTypes();
        }

        private void LoadProductList()
        {
            lvMatHang.Items.Clear(); // Xóa dữ liệu cũ trong ListView
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MATHANG.MaMatHang, MATHANG.TenMatHang, LOAIMATHANG.TenLoai, MATHANG.SoLuongTon, MATHANG.DonGia " +
                               "FROM MATHANG INNER JOIN LOAIMATHANG ON MATHANG.LoaiMatHang = LOAIMATHANG.MaLoai";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["MaMatHang"].ToString());
                    item.SubItems.Add(reader["TenMatHang"].ToString());
                    item.SubItems.Add(reader["TenLoai"].ToString());
                    item.SubItems.Add(reader["SoLuongTon"].ToString());
                    item.SubItems.Add(reader["DonGia"].ToString());
                    lvMatHang.Items.Add(item);
                }
            }
        }

        private void LoadProductTypes()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM LOAIMATHANG";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cbLoaiMatHang.DataSource = dataTable;
                cbLoaiMatHang.DisplayMember = "TenLoai";
                cbLoaiMatHang.ValueMember = "MaLoai";
            }
        }

        private void lvMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMatHang.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvMatHang.SelectedItems[0];
                txtMaMatHang.Text = selectedItem.SubItems[0].Text; // Mã mặt hàng
                txtTenMatHang.Text = selectedItem.SubItems[1].Text; // Tên mặt hàng
                cbLoaiMatHang.Text = selectedItem.SubItems[2].Text; // Loại mặt hàng
                nudSoLuong.Value = Convert.ToInt32(selectedItem.SubItems[3].Text); // Số lượng
                nudDonGia.Value = Convert.ToInt32(selectedItem.SubItems[4].Text); // Đơn giá
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "EXEC ThemMatHang @TenMatHang, @LoaiMatHang, @SoLuongTon, @DonGia";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenMatHang", txtTenMatHang.Text);
                cmd.Parameters.AddWithValue("@LoaiMatHang", cbLoaiMatHang.SelectedValue);
                cmd.Parameters.AddWithValue("@SoLuongTon", nudSoLuong.Value);
                cmd.Parameters.AddWithValue("@DonGia", nudDonGia.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
                LoadProductList(); // Làm mới ListView
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "EXEC CapNhatMatHang @MaMatHang, @TenMatHang, @LoaiMatHang, @SoLuongTon, @DonGia";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaMatHang", txtMaMatHang.Text);
                cmd.Parameters.AddWithValue("@TenMatHang", txtTenMatHang.Text);
                cmd.Parameters.AddWithValue("@LoaiMatHang", cbLoaiMatHang.SelectedValue);
                cmd.Parameters.AddWithValue("@SoLuongTon", nudSoLuong.Value);
                cmd.Parameters.AddWithValue("@DonGia", nudDonGia.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
                LoadProductList(); // Làm mới ListView
            }
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            using (FormThemLoai formThemLoai = new FormThemLoai())
            {
                formThemLoai.ShowDialog(); // Hiển thị FormThemLoai dưới dạng modal
                if (formThemLoai.IsLoaiMatHangAdded) // Kiểm tra nếu loại mặt hàng đã được thêm
                {
                    LoadProductTypes(); // Gọi hàm cập nhật danh sách loại mặt hàng
                }
            }
        }
    }
}
