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
    public partial class MainForm : Form
    {
        private TableBL tableBL;
        private Account loggedInUser;
        private BillsBL billsBL;
        private int tableId;

        public MainForm(Account account)
        {
            InitializeComponent();
            tableBL = new TableBL();
            billsBL = new BillsBL();
            LoadTables();

            // Gán giá trị mặc định cho tableId, ví dụ là bàn đầu tiên
            tableId = GetDefaultTableId();

            loggedInUser = account; // Gán tài khoản đăng nhập
            LoadBills(tableId);
        }

        // Phương thức để lấy ID bàn mặc định
        private int GetDefaultTableId()
        {
            var tables = tableBL.GetAll(); // Lấy danh sách tất cả các bàn
            return tables.Count > 0 ? tables[0].ID : -1; // Trả về ID bàn đầu tiên hoặc -1 nếu không có bàn nào
        }

        private void LoadTables()
        {
            var tables = tableBL.GetAll(); // Lấy danh sách bàn từ tầng BLL
            lvTables.Items.Clear();

            foreach (var table in tables)
            {
                // Kiểm tra giá trị của table.Status
                string status = table.Status == 1 ? "Đang sử dụng" : "Trống";

                // Đảm bảo table.Name không phải null
                string tableName = table.Name ?? "Không tên";

                var item = new ListViewItem(new[] { tableName, status });
                lvTables.Items.Add(item);
            }
        }

        private void LoadBills(int tableId)
        {
            lvBills.Items.Clear();

            var bills = billsBL.GetAll(); // Lấy danh sách hóa đơn từ BillsBL
            foreach (var bill in bills)
            {
                var item = new ListViewItem(bill.ID.ToString());
                item.SubItems.Add(bill.Name);
                item.SubItems.Add(bill.Date.ToString("dd/MM/yyyy"));
                item.SubItems.Add(bill.Total.ToString("C")); // Hiển thị tổng tiền
                item.Tag = bill.ID; // Lưu billId vào Tag để sử dụng sau
                lvBills.Items.Add(item);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var orderForm = new OrderForm(loggedInUser); // Truyền tài khoản vào OrderForm
            orderForm.Show();
        }

        private int GetSelectedBillId()
        {
            if (lvBills.SelectedItems.Count > 0)
            {
                return Convert.ToInt32(lvBills.SelectedItems[0].Tag); // Lấy ID từ Tag của ListViewItem
            }

            return -1; // Trả về -1 nếu không có mục nào được chọn
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            int selectedBillId = GetSelectedBillId(); // Lấy ID hóa đơn từ giao diện

            if (selectedBillId > 0)
            {
                var paymentForm = new PaymentForm(selectedBillId);
                paymentForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTableManager_Click(object sender, EventArgs e)
        {
            var tableManagerForm = new TableManagerForm();
            tableManagerForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportForm();
            reportForm.ShowDialog();
        }
    }
}
