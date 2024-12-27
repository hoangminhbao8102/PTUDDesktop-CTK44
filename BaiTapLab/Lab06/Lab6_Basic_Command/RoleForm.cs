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

namespace Lab6_Basic_Command
{
    public partial class RoleForm : Form
    {
        private string accountName;
        private string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";

        public RoleForm(string accountName)
        {
            this.accountName = accountName;
            InitializeComponent();
            LoadRoles();
        }

        private void LoadRoles()
        {
            DataGridView dgvRoles = new DataGridView { Dock = DockStyle.Fill };
            this.Controls.Add(dgvRoles);

            string query = @"SELECT r.RoleName, ra.Actived 
                         FROM RoleAccount ra 
                         JOIN Role r ON ra.RoleID = r.ID 
                         WHERE ra.AccountName = @AccountName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountName", accountName);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRoles.DataSource = dt;
            }
        }
    }
}
