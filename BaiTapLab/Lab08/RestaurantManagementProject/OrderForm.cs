using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementProject
{
    public partial class OrderForm : Form
    {
        private FoodBL foodBL;
        private BillDetailsBL billDetailsBL;
        private BillsBL billsBL; // Đối tượng để thao tác với Bills
        private Account loggedInUser;

        public OrderForm(Account account)
        {
            InitializeComponent();
            foodBL = new FoodBL();
            billDetailsBL = new BillDetailsBL();
            LoadFoodMenu();
            billsBL = new BillsBL(); // Khởi tạo BillsBL
            loggedInUser = account;
        }

        private void LoadFoodMenu()
        {
            var foods = foodBL.GetAll();
            dgvFood.Rows.Clear();
            foreach (var food in foods)
            {
                dgvFood.Rows.Add(food.Name, food.Price, food.Notes);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvFood.SelectedRows)
                {
                    // Kiểm tra và xử lý giá trị null
                    string foodName = row.Cells[0].Value?.ToString() ?? "Không xác định"; // Đảm bảo không null
                    decimal price = row.Cells[1].Value != null ? Convert.ToDecimal(row.Cells[1].Value) : 0;

                    // Đảm bảo mảng truyền vào không chứa giá trị null
                    lvOrder.Items.Add(new ListViewItem(new[] { foodName, price.ToString("C") }));
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveFood_Click(object sender, EventArgs e)
        {
            if (lvOrder.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvOrder.SelectedItems)
                {
                    lvOrder.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int CreateInvoice()
        {
            var bill = new Bills
            {
                Name = "Hóa đơn của " + loggedInUser.FullName,
                Account = loggedInUser.AccountName,
                Date = DateTime.Now,
                Total = 0
            };

            return billsBL.Insert(bill);
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (lvOrder.Items.Count == 0)
            {
                MessageBox.Show("Không có món ăn nào trong đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo một hóa đơn mới và lấy ID của hóa đơn
            int invoiceID = CreateInvoice();

            // Lưu các món ăn vào cơ sở dữ liệu
            foreach (ListViewItem item in lvOrder.Items)
            {
                string foodName = item.SubItems[0].Text; // Tên món
                decimal price = decimal.Parse(item.SubItems[1].Text, System.Globalization.NumberStyles.Currency); // Giá

                // Lấy FoodID thông qua FoodBL
                var food = foodBL.GetByName(foodName);
                if (food != null)
                {
                    // Tạo đối tượng BillDetails
                    var billDetail = new BillDetails
                    {
                        InvoiceID = invoiceID, // Gán InvoiceID từ hóa đơn mới tạo
                        FoodID = food.ID,
                        Quantity = 1 // Số lượng mặc định là 1 (có thể thay đổi)
                    };

                    // Gọi hàm thêm vào bảng BillDetails
                    billDetailsBL.Insert(billDetail);
                }
            }

            MessageBox.Show("Đơn hàng đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
