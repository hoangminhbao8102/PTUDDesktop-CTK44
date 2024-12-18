using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Basic_Command
{
    public partial class AccountManagerForm : Form
    {
        private string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
        private DataGridView dgvAccounts = new DataGridView();

        public AccountManagerForm()
        {
            InitializeComponent();
            InitializeControls();
            LoadAccounts();
        }

        private void InitializeControls()
        {
            // DataGridView for accounts
            dgvAccounts = new DataGridView
            {
                Location = new System.Drawing.Point(20, 60),
                Size = new System.Drawing.Size(750, 300),
                Name = "dgvAccounts",
                ReadOnly = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            dgvAccounts.CellMouseClick += new DataGridViewCellMouseEventHandler(DgvAccounts_CellMouseClick!);
            this.Controls.Add(dgvAccounts);

            // Add buttons for actions
            Button btnAdd = new Button { Text = "Add Account", Location = new System.Drawing.Point(20, 20) };
            btnAdd.Click += new EventHandler(BtnAdd_Click!);
            this.Controls.Add(btnAdd);

            Button btnUpdate = new Button { Text = "Update Account", Location = new System.Drawing.Point(120, 20) };
            btnUpdate.Click += new EventHandler(BtnUpdate_Click!);
            this.Controls.Add(btnUpdate);

            Button btnResetPassword = new Button { Text = "Reset Password", Location = new System.Drawing.Point(240, 20) };
            btnResetPassword.Click += new EventHandler(BtnResetPassword_Click!);
            this.Controls.Add(btnResetPassword);
        }

        private void LoadAccounts()
        {
            string query = @"SELECT AccountName, FullName, Email, Tell, DateCreated FROM Account";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAccounts.DataSource = dt;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Add new account
            string accountName = ShowDialog("Enter Account Name:", "Add Account");
            if (string.IsNullOrWhiteSpace(accountName))
            {
                MessageBox.Show("Account name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fullName = ShowDialog("Enter Full Name:", "Add Account");
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Full Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string password = "123456"; // Default password
            string query = @"INSERT INTO Account (AccountName, Password, FullName, DateCreated) VALUES (@AccountName, @Password, @FullName, GETDATE())";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountName", accountName);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@FullName", fullName);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account added successfully!");
            }
            LoadAccounts();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Update selected account
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                string? accountName = dgvAccounts.SelectedRows[0].Cells["AccountName"].Value?.ToString();
                if (string.IsNullOrEmpty(accountName))
                {
                    MessageBox.Show("Account name cannot be null or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fullName = ShowDialog("Enter Full Name:", "Update Account") ?? string.Empty;
                string email = ShowDialog("Enter Email:", "Update Account") ?? string.Empty;

                if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Full name and email cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"UPDATE Account SET FullName = @FullName, Email = @Email WHERE AccountName = @AccountName";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@AccountName", accountName);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account updated successfully!");
                }
                LoadAccounts();
            }
            else
            {
                MessageBox.Show("No account selected for update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add missing ShowDialog method
        private string ShowDialog(string text, string caption)
        {
            Form prompt = new Form
            {
                Width = 400,
                Height = 200,
                Text = caption
            };
            Label lbl = new Label() { Left = 20, Top = 20, Text = text, Width = 350 };
            TextBox txtInput = new TextBox() { Left = 20, Top = 50, Width = 350 };
            Button btnOk = new Button() { Text = "OK", Left = 280, Width = 90, Top = 100, DialogResult = DialogResult.OK };

            prompt.Controls.Add(lbl);
            prompt.Controls.Add(txtInput);
            prompt.Controls.Add(btnOk);
            prompt.AcceptButton = btnOk;

            return prompt.ShowDialog() == DialogResult.OK ? txtInput.Text : string.Empty;
        }

        private void BtnResetPassword_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                string? accountName = dgvAccounts.SelectedRows[0].Cells["AccountName"].Value?.ToString();
                if (string.IsNullOrEmpty(accountName))
                {
                    MessageBox.Show("Account name cannot be null or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"UPDATE Account SET Password = '123456' WHERE AccountName = @AccountName";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AccountName", accountName);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password has been reset to '123456'.");
                }
            }
            else
            {
                MessageBox.Show("No account selected for password reset.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvAccounts_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvAccounts.ClearSelection();
                dgvAccounts.Rows[e.RowIndex].Selected = true;

                ContextMenuStrip menu = new ContextMenuStrip();
                menu.Items.Add("Delete Account", null, new EventHandler(DeleteAccount_Click!));
                menu.Items.Add("View Roles", null, new EventHandler(ViewRoles_Click!));
                menu.Show(Cursor.Position);
            }
        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                string? accountName = dgvAccounts.SelectedRows[0].Cells["AccountName"].Value?.ToString();
                if (string.IsNullOrEmpty(accountName))
                {
                    MessageBox.Show("Account name cannot be null or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"UPDATE RoleAccount SET Actived = 0 WHERE AccountName = @AccountName";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AccountName", accountName);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("All roles for this account have been deactivated.");
                }
                LoadAccounts();
            }
            else
            {
                MessageBox.Show("No account selected for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewRoles_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                string? accountName = dgvAccounts.SelectedRows[0].Cells["AccountName"].Value?.ToString();
                if (string.IsNullOrEmpty(accountName))
                {
                    MessageBox.Show("Account name cannot be null or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                RoleForm roleForm = new RoleForm(accountName);
                roleForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No account selected to view roles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
