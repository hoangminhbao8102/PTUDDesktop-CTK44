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
    public partial class AccountForm : Form
    {
        private string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";

        public AccountForm()
        {
            InitializeComponent();
            LoadAccounts();
        }

        // a. Hiển thị danh sách tài khoản
        private void LoadAccounts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("EXECUTE _GetAll 'Account'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adapter.Fill(data);

                dgvAccounts.DataSource = data; // dgvAccounts là DataGridView hiển thị danh sách tài khoản
            }
        }

        // b. Thêm một tài khoản mới
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXECUTE Account_Insert @AccountName, @Password, @FullName, @Email, @Tell, @DateCreated";

                    cmd.Parameters.AddWithValue("@AccountName", txtAccountName.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Tell", txtTell.Text);
                    cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Account added successfully!", "Message");
                        LoadAccounts(); // Reload danh sách tài khoản
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // c. Cập nhật thông tin tài khoản
        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXECUTE Account_Update @AccountName, @Password, @FullName, @Email, @Tell, @DateCreated";

                    cmd.Parameters.AddWithValue("@AccountName", txtAccountName.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Tell", txtTell.Text);
                    cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Account updated successfully!", "Message");
                        LoadAccounts();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // d. Reset mật khẩu cho tài khoản
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "UPDATE Account SET Password = '123456' WHERE AccountName = @AccountName";
                    cmd.Parameters.AddWithValue("@AccountName", txtAccountName.Text);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Password reset to default successfully!", "Message");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // e. Hiển thị menu khi nhấn chuột phải
        private void dgvAccounts_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                menu.Items.Add("Xem danh sách các vai trò", null, ViewRoles_Click);
                menu.Items.Add("Xem nhật ký hoạt động", null, ViewActivityLogs_Click);
                menu.Show(dgvAccounts, new Point(e.X, e.Y));
            }
        }

        // Xem danh sách các vai trò
        private void ViewRoles_Click(object? sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xem vai trò.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvAccounts.SelectedRows[0];
            object? accountNameValue = selectedRow.Cells["AccountName"]?.Value;

            if (accountNameValue == null || string.IsNullOrWhiteSpace(accountNameValue.ToString()))
            {
                MessageBox.Show("Tên tài khoản không hợp lệ hoặc trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string accountName = accountNameValue.ToString()!; // Dùng `!` vì giá trị đã được kiểm tra không null

            RolesForm rolesForm = new RolesForm(accountName); // Truyền AccountName vào RolesForm
            rolesForm.ShowDialog();
        }

        // Xem nhật ký hoạt động
        private void ViewActivityLogs_Click(object? sender, EventArgs e)
        {
            // Kiểm tra nếu không có hàng nào được chọn
            if (dgvAccounts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xem nhật ký hoạt động.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvAccounts.SelectedRows[0];
            object? accountNameValue = selectedRow.Cells["AccountName"]?.Value;

            // Kiểm tra nếu giá trị AccountName bị null hoặc rỗng
            if (accountNameValue == null || string.IsNullOrWhiteSpace(accountNameValue.ToString()))
            {
                MessageBox.Show("Tên tài khoản không hợp lệ hoặc trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string accountName = accountNameValue.ToString()!; // Dùng `!` vì đã kiểm tra null

            ActivityLogForm logForm = new ActivityLogForm(accountName); // Truyền AccountName vào ActivityLogForm
            logForm.ShowDialog();
        }
    }
}
