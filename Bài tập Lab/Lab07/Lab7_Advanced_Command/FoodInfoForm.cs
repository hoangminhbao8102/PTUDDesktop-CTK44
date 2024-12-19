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

namespace Lab7_Advanced_Command
{
    public partial class FoodInfoForm : Form
    {
        public FoodInfoForm()
        {
            InitializeComponent();
        }

        private void FoodInfoForm_Load(object sender, EventArgs e)
        {
            this.InitValues();
        }

        private void InitValues()
        {
            string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, Name From Category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            // Mở kết nối
            conn.Open();

            // Lấy dữ liệu từ CSDL đưa vào DataTable
            adapter.Fill(ds, "Category");

            // Hiển thị nhóm món ăn
            cbbCatName.DataSource = ds.Tables["Category"];
            cbbCatName.DisplayMember = "Name";
            cbbCatName.ValueMember = "ID";

            // Đóng kết nối và giải phóng bộ nhớ
            conn.Close();
            conn.Dispose();
        }

        private new void ResetText()
        {
            txtFoodID.ResetText();
            txtName.ResetText();
            txtNotes.ResetText();
            txtUnit.ResetText();
            cbbCatName.ResetText();
            nudPrice.Value = 0; // Đặt giá trị mặc định cho NumericUpDown
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXECUTE Food_Insert @id OUTPUT, @name, @unit, @foodCategoryID, @price, @notes";

                    // Thêm tham số vào đối tượng Command
                    cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000).Value = txtName.Text ?? string.Empty;
                    cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100).Value = txtUnit.Text ?? string.Empty;

                    // Xử lý giá trị @foodCategoryID
                    if (int.TryParse(cbbCatName.SelectedValue?.ToString(), out int foodCategoryId))
                    {
                        cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int).Value = foodCategoryId;
                    }
                    else
                    {
                        MessageBox.Show("Invalid category selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Xử lý giá trị @price
                    if (int.TryParse(nudPrice.Text, out int price))
                    {
                        cmd.Parameters.Add("@price", SqlDbType.Int).Value = price;
                    }
                    else
                    {
                        MessageBox.Show("Invalid price entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000).Value = txtNotes.Text ?? string.Empty;

                    // Mở kết nối
                    conn.Open();

                    int numRowAffected = cmd.ExecuteNonQuery();

                    // Thông báo kết quả
                    if (numRowAffected > 0)
                    {
                        string foodID = cmd.Parameters["@id"].Value?.ToString() ?? "N/A";
                        MessageBox.Show("Successfully added new food. Food ID = " + foodID, "Message");
                        this.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Adding food failed.");
                    }
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL Error");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        public void DisplayFoodInfo(DataRowView rowView)
        {
            try
            {
                if (rowView == null)
                {
                    MessageBox.Show("No data to display.", "Warning");
                    return;
                }

                txtFoodID.Text = rowView["ID"]?.ToString() ?? string.Empty; // Xử lý null cho ID
                txtName.Text = rowView["Name"]?.ToString() ?? string.Empty; // Xử lý null cho Name
                txtUnit.Text = rowView["Unit"]?.ToString() ?? string.Empty; // Xử lý null cho Unit
                txtNotes.Text = rowView["Notes"]?.ToString() ?? string.Empty; // Xử lý null cho Notes
                nudPrice.Text = rowView["Price"]?.ToString() ?? "0"; // Giá trị mặc định cho Price

                cbbCatName.SelectedIndex = -1;

                // Duyệt qua các mục trong cbbCatName để chọn giá trị tương ứng
                for (int index = 0; index < cbbCatName.Items.Count; index++)
                {
                    DataRowView? cat = cbbCatName.Items[index] as DataRowView;

                    // So sánh ID từ cat và rowView
                    if (cat?["ID"]?.ToString() == rowView["FoodCategoryID"]?.ToString())
                    {
                        cbbCatName.SelectedIndex = index;
                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
                this.Close();
            }
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXECUTE Food_Update @id, @name, @unit, @foodCategoryID, @price, @notes";

                    // Thêm tham số vào đối tượng Command
                    cmd.Parameters.Add("@id", SqlDbType.Int);
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                    cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
                    cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int);
                    cmd.Parameters.Add("@price", SqlDbType.Int);
                    cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

                    // Truyền giá trị vào thủ tục qua tham số, xử lý null
                    if (int.TryParse(txtFoodID.Text, out int foodID))
                    {
                        cmd.Parameters["@id"].Value = foodID;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Food ID.", "Error");
                        return;
                    }

                    cmd.Parameters["@name"].Value = txtName.Text ?? string.Empty;
                    cmd.Parameters["@unit"].Value = txtUnit.Text ?? string.Empty;

                    if (int.TryParse(cbbCatName.SelectedValue?.ToString(), out int foodCategoryID))
                    {
                        cmd.Parameters["@foodCategoryID"].Value = foodCategoryID;
                    }
                    else
                    {
                        MessageBox.Show("Invalid category selected.", "Error");
                        return;
                    }

                    if (int.TryParse(nudPrice.Text, out int price))
                    {
                        cmd.Parameters["@price"].Value = price;
                    }
                    else
                    {
                        MessageBox.Show("Invalid price entered.", "Error");
                        return;
                    }

                    cmd.Parameters["@notes"].Value = txtNotes.Text ?? string.Empty;

                    // Mở kết nối
                    conn.Open();

                    int numRowAffected = cmd.ExecuteNonQuery();

                    // Thông báo kết quả
                    if (numRowAffected > 0)
                    {
                        MessageBox.Show("Successfully updated food.", "Message");
                        this.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Updating food failed.");
                    }
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL Error");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            if (addCategoryForm.ShowDialog(this) == DialogResult.OK)
            {
                // Nếu nhóm món ăn mới được thêm, cập nhật ComboBox
                this.InitValues();

                if (addCategoryForm.NewCategoryID.HasValue)
                {
                    // Chọn nhóm món ăn vừa thêm
                    cbbCatName.SelectedValue = addCategoryForm.NewCategoryID.Value;
                }
            }
        }
    }
}
