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
using System.Xml.Linq;

namespace Lab6_Basic_Command
{
    public partial class frmFood : Form
    {
        private string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
        private DataTable dt = new DataTable();
        private SqlDataAdapter da = new SqlDataAdapter();

        public frmFood()
        {
            InitializeComponent();
        }

        public void LoadFood(int categoryID)
        {
            // Tạo đối tượng kết nối
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            // Thiết lập lệnh truy vấn cho đối tượng Command
            sqlCommand.CommandText = "SELECT Name FROM Category WHERE ID = " + categoryID;

            // Mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();

            // Gán tên nhóm sản phẩm cho tiêu đề
            object result = sqlCommand.ExecuteScalar();
            string categoryName = result?.ToString() ?? "Không xác định"; // Kiểm tra null
            this.Text = "Danh sách các món ăn thuộc nhóm: " + categoryName;

            sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + categoryID;

            // Tạo đối tượng DataAdapter
            da = new SqlDataAdapter(sqlCommand);

            // Tạo DataTable để chứa dữ liệu
            dt = new DataTable("Food");
            da.Fill(dt);

            // Hiển thị danh sách món ăn lên Form
            dgvFood.DataSource = dt;

            // Đóng kết nối và giải phóng bộ nhớ
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Cập nhật dữ liệu vào Database
                da.Update(dt);
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFood.CurrentRow != null)
            {
                try
                {
                    // Xóa dòng được chọn khỏi DataTable
                    dgvFood.Rows.RemoveAt(dgvFood.CurrentRow.Index);
                    // Cập nhật thay đổi vào Database
                    da.Update(dt);
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
