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
    public partial class PurchaseLogForm : Form
    {
        private string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";

        public PurchaseLogForm()
        {
            InitializeComponent();
            LoadPurchaseLog();
        }

        private void LoadPurchaseLog()
        {
            DataGridView dgvLog = new DataGridView { Dock = DockStyle.Fill };
            this.Controls.Add(dgvLog);

            string query = @"SELECT COUNT(ID) AS TotalBills, SUM(Amount) AS TotalAmount, SUM(Tax) AS TotalTax, 
                         SUM(Discount) AS TotalDiscount, Account AS CreatedBy, CheckoutDate
                         FROM Bills GROUP BY Account, CheckoutDate";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLog.DataSource = dt;
            }
        }
    }
}
