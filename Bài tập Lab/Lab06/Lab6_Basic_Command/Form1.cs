﻿using System.Data;
using Microsoft.Data.SqlClient;

namespace Lab6_Basic_Command
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Tạo chuỗi kết nối tới cơ sở dữ liệu RestaurantManagement
            string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";

            // Tạo đối tượng kết nối
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            // Thiết lập lệnh truy vấn cho đối tượng Command
            string query = "SELECT ID, Name, Type FROM Category";
            sqlCommand.CommandText = query;

            // Mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();

            // Thực thi lệnh bằng phương thức ExecuteReader
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            // Gọi hàm hiển thị dữ liệu lên màn hình
            this.DisplayCategory(sqlDataReader);

            // Đóng kết nối
            sqlConnection.Close();
        }

        private void DisplayCategory(SqlDataReader reader)
        {
            // Xóa tất cả các dòng hiện tại
            lvCategory.Items.Clear();

            // Đọc một dòng dữ liệu
            while (reader.Read())
            {
                // Tạo một dòng mới trong ListView
                ListViewItem item = new ListViewItem(reader["ID"].ToString());

                // Thêm dòng mới vào ListView
                lvCategory.Items.Add(item);

                // Bổ sung các thông tin khác cho ListViewItem
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Tạo chuỗi kết nối tới cơ sở dữ liệu RestaurantManagement
            string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            // Thiết lập lệnh truy vấn cho đối tượng Command
            sqlCommand.CommandText = "INSERT INTO Category (Name, [Type]) VALUES (@Name, @Type)";

            // Thêm tham số
            sqlCommand.Parameters.AddWithValue("@Name", txtName.Text);
            sqlCommand.Parameters.AddWithValue("@Type", txtType.Text);

            // Mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();

            // Thực thi lệnh bằng phương thức ExcuteReader
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            // Đóng kết nối
            sqlConnection.Close();

            if (numOfRowsEffected == 1)
            {
                MessageBox.Show("Thêm món ăn thành công!");

                // Tải lại dữ liệu
                btnLoad.PerformClick();

                // Xóa các ô nhập
                txtName.Text = "";
                txtType.Text = "";
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại.");
            }
        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            // Lấy dòng được chọn trong ListView
            ListViewItem item = lvCategory.SelectedItems[0];

            // Hiển thị dữ liệu lên TextBox
            txtID.Text = item.Text;
            txtName.Text = item.SubItems[1].Text;
            txtType.Text = item.SubItems[1].Text == "0" ? "Thức uống" : "Đồ ăn";

            // Hiển thị cập nhật và xóa
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Tạo chuỗi kết nối tới cơ sở dữ liệu RestaurantManagement
            string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            // Thiết lập lệnh truy vấn cho đối tượng Command
            sqlCommand.CommandText = "UPDATE Category SET Name = N'" + txtName.Text + "', [Type] = " + txtType.Text + " WHERE ID = " + txtID.Text;

            // Mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();

            // Thực thi lệnh bằng phương thức ExcuteReader
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            // Đóng kết nối
            sqlConnection.Close();

            if (numOfRowsEffected == 1)
            {
                // Cập nhật lại dữ liệu trên ListView
                ListViewItem item = lvCategory.SelectedItems[0];

                item.SubItems[1].Text = txtName.Text;
                item.SubItems[2].Text = txtType.Text;

                // Xóa các ô nhập
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";

                // Disable các nút xóa và cập nhật
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                MessageBox.Show("Cập nhật món ăn thành công!");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Tạo chuỗi kết nối tới cơ sở dữ liệu RestaurantManagement
            string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            // Thiết lập lệnh truy vấn cho đối tượng Command
            sqlCommand.CommandText = "DELETE FROM Category WHERE ID = " + txtID.Text;

            // Mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();

            // Thực thi lệnh bằng phương thức ExcuteReader
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            // Đóng kết nối
            sqlConnection.Close();

            if (numOfRowsEffected == 1)
            {
                // Cập nhật lại dữ liệu trên ListView
                ListViewItem item = lvCategory.SelectedItems[0];
                lvCategory.Items.Remove(item);

                // Xóa các ô nhập
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";

                // Disable các nút xóa và cập nhật
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                MessageBox.Show("Xóa món ăn thành công!");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại.");
            }
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count > 0) 
            {
                btnDelete.PerformClick();
            }
        }

        private void tsmViewFood_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "") 
            {
                frmFood foodForm = new frmFood();
                foodForm.Show(this);
                foodForm.LoadFood(Convert.ToInt32(txtID.Text));
            }
        }
    }
}
