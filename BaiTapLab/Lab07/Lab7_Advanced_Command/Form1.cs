using System.Data;
using Microsoft.Data.SqlClient;

namespace Lab7_Advanced_Command
{
    public partial class Form1 : Form
    {
        private DataTable? foodTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadCategory();
        }

        private void LoadCategory()
        {
            string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, Name From Category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            // Mở kết nối
            conn.Open();

            // Lấy dữ liệu từ CSDL đưa vào DataTable
            adapter.Fill(dt);

            // Đóng kết nối và giải phóng bộ nhớ
            conn.Close();
            conn.Dispose();

            // Đưa dữ liệu vào Combo Box
            cbbCategory.DataSource = dt;

            // Hiển thị tên nhóm sản phẩm
            cbbCategory.DisplayMember = "Name";

            // Nhưng khi lấy giá trị thì lấy ID của nhóm
            cbbCategory.ValueMember = "ID";
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == -1 || cbbCategory.SelectedValue == null)
            {
                return;
            }

            string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * From Food Where FoodCategoryID = @categoryId";

                // Truyền tham số
                cmd.Parameters.Add("@categoryId", SqlDbType.Int);

                if (cbbCategory.SelectedValue is DataRowView rowView)
                {
                    cmd.Parameters["@categoryId"].Value = rowView["ID"] ?? DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@categoryId"].Value = cbbCategory.SelectedValue ?? DBNull.Value;
                }

                // Tạo bộ điều phiếu dữ liệu
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                foodTable = new DataTable();

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Lấy dữ liệu từ CSDL đưa vào DataTable
                    adapter.Fill(foodTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Kết nối sẽ tự động đóng nhờ `using`
                }

                // Đưa dữ liệu vào Data Grid View
                dgvFoodList.DataSource = foodTable;

                // Tính số lượng mẫu tin
                lblQuantity.Text = foodTable?.Rows.Count.ToString() ?? "0";
                lblCatName.Text = cbbCategory.Text ?? string.Empty;
            }
        }

        private void tsmCalculateQuantity_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT @numSaleFood = sum(Quantity) From BillDetails WHERE FoodID = @foodId";

                // Lấy thông tin sản phẩm được chọn
                if (dgvFoodList.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];

                    if (selectedRow.DataBoundItem is DataRowView rowView)
                    {
                        // Truyền tham số
                        cmd.Parameters.Add("@foodId", SqlDbType.Int);
                        cmd.Parameters["@foodId"].Value = rowView["ID"] ?? DBNull.Value;

                        cmd.Parameters.Add("@numSaleFood", SqlDbType.Int);
                        cmd.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

                        try
                        {
                            // Mở kết nối CSDL
                            conn.Open();

                            // Thực thi truy vấn và lấy dữ liệu từ tham số
                            cmd.ExecuteNonQuery();

                            string result = cmd.Parameters["@numSaleFood"].Value?.ToString() ?? "0";
                            string foodName = rowView["Name"]?.ToString() ?? "không xác định";
                            string foodUnit = rowView["Unit"]?.ToString() ?? "";

                            MessageBox.Show("Tổng số lượng món " + foodName + " đã bán là: " + result + " " + foodUnit, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể lấy thông tin hàng được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tsmAddFood_Click(object sender, EventArgs e)
        {
            FoodInfoForm foodForm = new FoodInfoForm();
            foodForm.FormClosed += new FormClosedEventHandler(foodForm_FormClosed);

            foodForm.Show(this);
        }

        private void foodForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            int index = cbbCategory.SelectedIndex;
            cbbCategory.SelectedIndex = -1;
            cbbCategory.SelectedIndex = index;
        }

        private void tsmUpdateFood_Click(object sender, EventArgs e)
        {
            if (dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView? rowView = selectedRow.DataBoundItem as DataRowView;

                if (rowView == null)
                {
                    MessageBox.Show("No valid data selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FoodInfoForm foodForm = new FoodInfoForm();
                foodForm.FormClosed += new FormClosedEventHandler(foodForm_FormClosed);

                foodForm.Show(this);

                // Chỉ gọi DisplayFoodInfo nếu rowView không null
                foodForm.DisplayFoodInfo(rowView);
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (foodTable == null) 
            {
                return;
            }

            // Create filter and sort expression
            string filterExpression = "Name LIKE '%" + txtSearchByName.Text + "%'";
            string sortExpression = "Price DESC";
            DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;

            // Create a data view object to view the data in foodTable data table
            // Filter by Name (contain 'ng') and sort descending by Price
            DataView foodView = new DataView(foodTable, filterExpression, sortExpression, rowStateFilter);

            // Assign foodTable as Data Source of data grid view
            dgvFoodList.DataSource = foodView;
        }
    }
}
