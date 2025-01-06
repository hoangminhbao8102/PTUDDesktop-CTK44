using Lab09_Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09_Entity_Framework
{
    public partial class SalesLogForm : Form
    {
        private RestaurantContext _context;

        public SalesLogForm()
        {
            InitializeComponent();
            _context = new RestaurantContext();
            LoadSalesLog();
        }

        private void LoadSalesLog()
        {
            // Lấy dữ liệu từ database
            var logs = _context.Bills!
                .Select(b => new
                {
                    b.Id,
                    b.Name,
                    b.CheckoutDate,
                    b.Account,
                    b.Amount,
                    Discount = (double)b.Discount, // Chuyển đổi từ float sang double
                    Tax = (double)b.Tax // Chuyển đổi từ float sang double
                })
                .ToList();

            // Xóa dữ liệu cũ trong ListView
            listViewSalesLog.Items.Clear();

            // Thêm dữ liệu mới vào ListView
            foreach (var log in logs)
            {
                var item = new ListViewItem(log.Name ?? "N/A"); // Xử lý null cho Name
                item.SubItems.Add(log.CheckoutDate.HasValue
                    ? log.CheckoutDate.Value.ToString("dd/MM/yyyy")
                    : "N/A"); // Xử lý null cho CheckoutDate
                item.SubItems.Add(log.Account ?? "Unknown"); // Xử lý null cho Account
                item.SubItems.Add(log.Amount.ToString("C")); // Hiển thị số tiền theo định dạng tiền tệ
                item.SubItems.Add(log.Discount.ToString("P")); // Hiển thị phần trăm giảm giá
                item.SubItems.Add(log.Tax.ToString("P")); // Hiển thị phần trăm thuế

                listViewSalesLog.Items.Add(item);
            }
        }
    }
}
