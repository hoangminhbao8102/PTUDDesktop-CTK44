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
    public partial class MainForm : Form
    {
        private string connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
        private DataGridView dgvTables = new DataGridView();

        public MainForm()
        {
            InitializeComponent();
            InitializeControls();
            LoadTableData();
        }

        private void InitializeControls()
        {
            // DataGridView to display tables
            dgvTables = new DataGridView
            {
                Location = new System.Drawing.Point(20, 60),
                Size = new System.Drawing.Size(750, 300),
                Name = "dgvTables",
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            dgvTables.CellMouseClick += new DataGridViewCellMouseEventHandler(DgvTables_CellMouseClick!);
            this.Controls.Add(dgvTables);

            // Buttons for actions
            Button btnAdd = new Button { Text = "Add Table", Location = new System.Drawing.Point(20, 20) };
            btnAdd.Click += new EventHandler(BtnAdd_Click!);
            this.Controls.Add(btnAdd);

            Button btnUpdate = new Button { Text = "Update Table", Location = new System.Drawing.Point(120, 20) };
            btnUpdate.Click += new EventHandler(BtnUpdate_Click!);
            this.Controls.Add(btnUpdate);

            Button btnDelete = new Button { Text = "Delete Table", Location = new System.Drawing.Point(240, 20) };
            btnDelete.Click += new EventHandler(BtnDelete_Click!);
            this.Controls.Add(btnDelete);
        }

        private void LoadTableData()
        {
            string query = "SELECT ID, Name, Status, Capacity FROM [Table]";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTables.DataSource = dt;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string tableName = ShowDialog("Enter Table Name:", "Add Table");
            string capacity = ShowDialog("Enter Capacity:", "Add Table");

            if (string.IsNullOrWhiteSpace(tableName) || string.IsNullOrWhiteSpace(capacity))
            {
                MessageBox.Show("Table name and capacity cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO [Table] (Name, Status, Capacity) VALUES (@Name, 1, @Capacity)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", tableName);
                cmd.Parameters.AddWithValue("@Capacity", capacity);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Table added successfully!");
            }
            LoadTableData();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count > 0)
            {
                int tableID = Convert.ToInt32(dgvTables.SelectedRows[0].Cells["ID"].Value);
                string tableName = ShowDialog("Enter New Table Name:", "Update Table");
                string capacity = ShowDialog("Enter New Capacity:", "Update Table");

                string query = "UPDATE [Table] SET Name = @Name, Capacity = @Capacity WHERE ID = @ID";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", tableName);
                    cmd.Parameters.AddWithValue("@Capacity", capacity);
                    cmd.Parameters.AddWithValue("@ID", tableID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Table updated successfully!");
                }
                LoadTableData();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count > 0)
            {
                int tableID = Convert.ToInt32(dgvTables.SelectedRows[0].Cells["ID"].Value);

                string query = "DELETE FROM [Table] WHERE ID = @ID";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", tableID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Table deleted successfully!");
                }
                LoadTableData();
            }
        }

        private void DgvTables_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvTables.ClearSelection();
                dgvTables.Rows[e.RowIndex].Selected = true;

                ContextMenuStrip menu = new ContextMenuStrip();
                menu.Items.Add("Delete Table", null, new EventHandler(BtnDelete_Click!));
                menu.Items.Add("View Bills", null, new EventHandler(ViewBills_Click!));
                menu.Items.Add("View Purchase Log", null, new EventHandler(ViewPurchaseLog_Click!));
                menu.Show(Cursor.Position);
            }
        }

        private void ViewBills_Click(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count > 0)
            {
                int tableID = Convert.ToInt32(dgvTables.SelectedRows[0].Cells["ID"].Value);
                BillsForm billsForm = new BillsForm(tableID);
                billsForm.ShowDialog();
            }
        }

        private void ViewPurchaseLog_Click(object sender, EventArgs e)
        {
            PurchaseLogForm logForm = new PurchaseLogForm();
            logForm.ShowDialog();
        }

        private string ShowDialog(string text, string caption)
        {
            Form prompt = new Form { Width = 400, Height = 200, Text = caption };
            Label lbl = new Label() { Left = 20, Top = 20, Text = text, Width = 350 };
            TextBox txtInput = new TextBox() { Left = 20, Top = 50, Width = 350 };
            Button btnOk = new Button() { Text = "OK", Left = 280, Width = 90, Top = 100, DialogResult = DialogResult.OK };

            prompt.Controls.Add(lbl);
            prompt.Controls.Add(txtInput);
            prompt.Controls.Add(btnOk);
            prompt.AcceptButton = btnOk;

            return prompt.ShowDialog() == DialogResult.OK ? txtInput.Text : string.Empty;
        }
    }
}
