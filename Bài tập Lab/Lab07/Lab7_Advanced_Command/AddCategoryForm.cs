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
    public partial class AddCategoryForm : Form
    {
        public int? NewCategoryID { get; private set; } // Lưu ID của nhóm món ăn mới được thêm

        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();
            int categoryType = cbbCategoryType.SelectedIndex; // 0 hoặc 1

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please enter a category name.", "Warning");
                return;
            }

            try
            {
                string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXECUTE AddCategory @Name, @Type";

                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 1000).Value = categoryName;
                    cmd.Parameters.Add("@Type", SqlDbType.Int).Value = categoryType;

                    conn.Open();

                    // Thực thi và lấy ID nhóm món ăn vừa thêm
                    object result = cmd.ExecuteScalar();
                    NewCategoryID = result != null ? Convert.ToInt32(result) : (int?)null;

                    MessageBox.Show("Category added successfully.", "Message");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
