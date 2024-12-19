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
    public partial class OrderDetailsForm : Form
    {
        private int _billID;

        public OrderDetailsForm(int billID)
        {
            _billID = billID;
            InitializeComponent();
        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXECUTE GetBillDetails @BillID";
                    cmd.Parameters.Add("@BillID", SqlDbType.Int).Value = _billID;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable billDetailsTable = new DataTable();
                    conn.Open();
                    adapter.Fill(billDetailsTable);

                    dgvBillDetails.DataSource = billDetailsTable;

                    lblBillID.Text = $"{_billID}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
