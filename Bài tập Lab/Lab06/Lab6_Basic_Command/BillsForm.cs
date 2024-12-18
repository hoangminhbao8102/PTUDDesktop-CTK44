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
    public partial class BillsForm : Form
    {
        private string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
        private DataTable billsTable = new DataTable();
        private int? tableID; // Optional tableID for filtering by table

        public BillsForm(int? tableID = null) // Optional parameter
        {
            this.tableID = tableID;
            InitializeComponent();
            InitializeControls();
            if (tableID.HasValue)
            {
                LoadBillsByTable();
            }
        }

        private void InitializeControls()
        {
            // DateTimePicker controls for date filtering
            DateTimePicker dtpFrom = new DateTimePicker
            {
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(150, 25),
                Name = "dtpFrom"
            };
            DateTimePicker dtpTo = new DateTimePicker
            {
                Location = new System.Drawing.Point(200, 20),
                Size = new System.Drawing.Size(150, 25),
                Name = "dtpTo"
            };
            this.Controls.Add(dtpFrom);
            this.Controls.Add(dtpTo);

            // Fetch button
            Button btnFetch = new Button
            {
                Text = "Fetch Bills",
                Location = new System.Drawing.Point(370, 20),
                Size = new System.Drawing.Size(100, 25)
            };
            btnFetch.Click += new EventHandler(BtnFetch_Click!);
            this.Controls.Add(btnFetch);

            // DataGridView to display bills
            DataGridView dgvBills = new DataGridView
            {
                Name = "dgvBills",
                Location = new System.Drawing.Point(20, 60),
                Size = new System.Drawing.Size(750, 300)
            };
            dgvBills.CellDoubleClick += new DataGridViewCellEventHandler(DgvBills_CellDoubleClick!);
            this.Controls.Add(dgvBills);

            // Labels for totals
            Label lblTotal = new Label
            {
                Text = "Total Amount: 0",
                Location = new System.Drawing.Point(20, 380),
                Size = new System.Drawing.Size(200, 25),
                Name = "lblTotal"
            };
            Label lblDiscount = new Label
            {
                Text = "Total Discount: 0",
                Location = new System.Drawing.Point(250, 380),
                Size = new System.Drawing.Size(200, 25),
                Name = "lblDiscount"
            };
            Label lblFinal = new Label
            {
                Text = "Actual Revenue: 0",
                Location = new System.Drawing.Point(480, 380),
                Size = new System.Drawing.Size(200, 25),
                Name = "lblFinal"
            };
            this.Controls.Add(lblTotal);
            this.Controls.Add(lblDiscount);
            this.Controls.Add(lblFinal);
        }

        private void BtnFetch_Click(object sender, EventArgs e)
        {
            var dtpFrom = this.Controls["dtpFrom"] as DateTimePicker;
            var dtpTo = this.Controls["dtpTo"] as DateTimePicker;
            var dgvBills = this.Controls["dgvBills"] as DataGridView;

            if (dtpFrom == null || dtpTo == null || dgvBills == null)
            {
                MessageBox.Show("Some controls are missing. Please check your form design.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"SELECT ID, CheckoutDate, Amount AS TotalAmount, Discount, Tax, (Amount - Discount) AS FinalAmount 
                         FROM Bills 
                         WHERE CheckoutDate BETWEEN @FromDate AND @ToDate";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FromDate", dtpFrom.Value.Date);
                cmd.Parameters.AddWithValue("@ToDate", dtpTo.Value.Date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                billsTable = new DataTable();
                da.Fill(billsTable);
                dgvBills.DataSource = billsTable;

                CalculateTotals(billsTable);
            }
        }

        private void LoadBillsByTable()
        {
            var dgvBills = this.Controls["dgvBills"] as DataGridView;
            if (dgvBills == null)
            {
                MessageBox.Show("DataGridView is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!tableID.HasValue)
            {
                MessageBox.Show("Table ID is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT ID, CheckoutDate, Amount AS TotalAmount, Discount, Tax, (Amount - Discount) AS FinalAmount FROM Bills WHERE TableID = @TableID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TableID", tableID.Value);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                billsTable = new DataTable();
                da.Fill(billsTable);
                dgvBills.DataSource = billsTable;

                CalculateTotals(billsTable);
            }
        }

        private void CalculateTotals(DataTable table)
        {
            var lblTotal = this.Controls["lblTotal"] as Label;
            var lblDiscount = this.Controls["lblDiscount"] as Label;
            var lblFinal = this.Controls["lblFinal"] as Label;

            if (lblTotal == null || lblDiscount == null || lblFinal == null)
            {
                MessageBox.Show("Some label controls are missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal total = 0, discount = 0, final = 0;
            foreach (DataRow row in table.Rows)
            {
                total += row["TotalAmount"] != DBNull.Value ? Convert.ToDecimal(row["TotalAmount"]) : 0;
                discount += row["Discount"] != DBNull.Value ? Convert.ToDecimal(row["Discount"]) : 0;
                final += row["FinalAmount"] != DBNull.Value ? Convert.ToDecimal(row["FinalAmount"]) : 0;
            }

            lblTotal.Text = $"Total Amount: {total:C}";
            lblDiscount.Text = $"Total Discount: {discount:C}";
            lblFinal.Text = $"Actual Revenue: {final:C}";
        }

        private void DgvBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var dgvBills = sender as DataGridView;
                if (dgvBills == null || dgvBills.Rows[e.RowIndex].Cells["ID"].Value == null)
                {
                    MessageBox.Show("Unable to retrieve bill details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int billID = Convert.ToInt32(dgvBills.Rows[e.RowIndex].Cells["ID"].Value);

                // Open BillDetailsForm
                BillDetailsForm detailsForm = new BillDetailsForm(billID);
                detailsForm.ShowDialog();
            }
        }
    }
}
