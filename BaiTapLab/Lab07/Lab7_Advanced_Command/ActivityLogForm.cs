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
    public partial class ActivityLogForm : Form
    {
        private string accountName;
        private string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";

        public ActivityLogForm(string accountName)
        {
            InitializeComponent();
            this.accountName = accountName;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Bills WHERE Account = @Account", conn);
                cmd.Parameters.AddWithValue("@Account", accountName);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adapter.Fill(data);

                dgvActivityLogs.DataSource = data; // dgvActivityLogs hiển thị nhật ký hoạt động
            }
        }
    }
}
