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
    public partial class BillDetailsForm : Form
    {
        private int billID;
        private string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";

        public BillDetailsForm(int billID)
        {
            this.billID = billID;
            InitializeComponent();
            LoadBillDetails();
        }

        private void LoadBillDetails()
        {
            // DataGridView for bill details
            DataGridView dgvDetails = new DataGridView { Dock = DockStyle.Fill };
            this.Controls.Add(dgvDetails);

            string query = @"SELECT Food.Name AS ItemName, Quantity, Food.Price, (Quantity * Food.Price) AS Subtotal
                         FROM BillDetails
                         JOIN Food ON BillDetails.FoodID = Food.ID
                         WHERE BillDetails.InvoiceID = @BillID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BillID", billID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dtDetails = new DataTable();
                da.Fill(dtDetails);
                dgvDetails.DataSource = dtDetails;
            }
        }
    }
}
