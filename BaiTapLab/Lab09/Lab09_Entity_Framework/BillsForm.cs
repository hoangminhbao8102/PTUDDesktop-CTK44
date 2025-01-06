using Lab09_Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09_Entity_Framework
{
    public partial class BillsForm : Form
    {
        private readonly RestaurantContext _context;

        public BillsForm()
        {
            InitializeComponent();
            _context = new RestaurantContext();
            LoadBills();
        }

        private void LoadBills(DateTime? fromDate = null, DateTime? toDate = null)
        {
            lvBills.Items.Clear(); // Xóa dữ liệu cũ
            lvBills.Columns.Clear(); // Xóa các cột cũ

            // Thêm các cột vào ListView
            lvBills.Columns.Add("Id", 50);
            lvBills.Columns.Add("Tên hóa đơn", 150);
            lvBills.Columns.Add("Tên bàn", 100);
            lvBills.Columns.Add("Tổng tiền", 100);
            lvBills.Columns.Add("Giảm giá", 100);
            lvBills.Columns.Add("Thực thu", 100);
            lvBills.Columns.Add("Ngày thanh toán", 150);
            lvBills.Columns.Add("Nhân viên", 120);
            lvBills.Columns.Add("Trạng thái", 100);

            var query = _context.Bills!.AsQueryable();

            if (fromDate.HasValue && toDate.HasValue)
            {
                query = query.Where(b => b.CheckoutDate >= fromDate && b.CheckoutDate <= toDate);
            }

            // Tải dữ liệu liên quan (Include)
            var bills = query
                .Include(b => b.Table)
                .Select(b => new
                {
                    b.Id,
                    b.Name,
                    TableName = b.Table != null ? b.Table.Name : "Không xác định",
                    TotalAmount = b.Amount,
                    DiscountAmount = b.Amount * ((double)b.Discount / 100), // Chuyển float sang double
                    ActualAmount = b.Amount - (b.Amount * ((double)b.Discount / 100)), // Chuyển float sang double
                    b.CheckoutDate,
                    AccountName = b.Account ?? "Không xác định",
                    b.Status
                }).ToList();

            // Thêm dữ liệu vào ListView
            foreach (var bill in bills)
            {
                var item = new ListViewItem(bill.Id.ToString());
                item.SubItems.Add(bill.Name ?? "");
                item.SubItems.Add(bill.TableName);
                item.SubItems.Add(bill.TotalAmount.ToString("N0"));
                item.SubItems.Add(bill.DiscountAmount.ToString("N0"));
                item.SubItems.Add(bill.ActualAmount.ToString("N0"));
                item.SubItems.Add(bill.CheckoutDate?.ToString("dd/MM/yyyy HH:mm") ?? "");
                item.SubItems.Add(bill.AccountName);
                item.SubItems.Add(bill.Status ? "Đã thanh toán" : "Chưa thanh toán");
                item.Tag = bill.Id;

                lvBills.Items.Add(item);
            }

            // Tính tổng
            var totalAmount = bills.Sum(b => b.TotalAmount);
            var totalDiscount = bills.Sum(b => b.DiscountAmount);
            var actualAmount = bills.Sum(b => b.ActualAmount);

            txtTotalAmount.Text = totalAmount.ToString("N0");
            txtTotalDiscount.Text = totalDiscount.ToString("N0");
            txtActualAmount.Text = actualAmount.ToString("N0");
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var fromDate = dtpFromDate.Value.Date;
            var toDate = dtpToDate.Value.Date.AddDays(1).AddSeconds(-1); // Đến cuối ngày
            LoadBills(fromDate, toDate);
        }

        private void lvBills_DoubleClick(object sender, EventArgs e)
        {
            if (lvBills.SelectedItems.Count > 0)
            {
                var selectedItem = lvBills.SelectedItems[0];

                // Kiểm tra null trước khi ép kiểu
                if (selectedItem.Tag is int billId)
                {
                    var billDetailsForm = new BillDetailsForm(billId);
                    billDetailsForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ID hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
