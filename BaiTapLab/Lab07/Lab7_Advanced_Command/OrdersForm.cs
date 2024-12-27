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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void btnLoadBills_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXECUTE GetBillsByDateRange @StartDate, @EndDate";
                    cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = dtpStartDate.Value;
                    cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = dtpEndDate.Value;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable billsTable = new DataTable();
                    conn.Open();
                    adapter.Fill(billsTable);

                    dgvBills.DataSource = billsTable;

                    // Tính tổng số liệu
                    decimal totalAmount = 0, totalDiscount = 0, netRevenue = 0;
                    foreach (DataRow row in billsTable.Rows)
                    {
                        totalAmount += Convert.ToDecimal(row["Amount"]);
                        totalDiscount += Convert.ToDecimal(row["Discount"]);
                        netRevenue += Convert.ToDecimal(row["NetAmount"]);
                    }

                    lblTotalAmount.Text = $"{totalAmount:C}";
                    lblTotalDiscount.Text = $"{totalDiscount:C}";
                    lblNetRevenue.Text = $"{netRevenue:C}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dgvBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có hàng nào được chọn không
            {
                int billID = (int)dgvBills.Rows[e.RowIndex].Cells["ID"].Value;
                OrderDetailsForm detailsForm = new OrderDetailsForm(billID);
                detailsForm.ShowDialog(this);
            }
        }
    }
}
