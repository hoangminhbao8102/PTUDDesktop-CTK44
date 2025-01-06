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
    public partial class BillDetailsForm : Form
    {
        private readonly RestaurantContext _context;
        private readonly int _tableId;

        public BillDetailsForm(int tableId)
        {
            InitializeComponent();
            _context = new RestaurantContext();
            _tableId = tableId;

            LoadBills();
        }

        private void LoadBills()
        {
            // Tìm bàn liên quan đến _tableId
            var table = _context.Tables!.FirstOrDefault(t => t.Id == _tableId);

            if (table == null)
            {
                MessageBox.Show("Không tìm thấy bàn.");
                return;
            }

            // Lấy danh sách hóa đơn liên quan đến tên bàn
            var bills = _context.Bills!
                .Where(b => b.Table!.Name == table.Name)
                .Select(b => new { b.Id, b.Name, b.Amount, b.CheckoutDate })
                .ToList();

            // Hiển thị danh sách hóa đơn vào ListBox
            lstBills.DataSource = bills;
            lstBills.DisplayMember = "Name";
            lstBills.ValueMember = "Id";
        }

        private void LoadBillDetails(int billId)
        {
            // Tải dữ liệu liên quan với Include
            var billDetails = _context.BillDetails!
                .Where(d => d.InvoiceId == billId)
                .Select(d => new
                {
                    d.Id,
                    FoodName = d.Food != null ? d.Food.Name : "Không xác định", // Lấy tên món ăn
                    d.Quantity
                }).ToList();

            // Hiển thị dữ liệu lên ListView
            lvBillDetails.Items.Clear();
            lvBillDetails.Columns.Clear();

            lvBillDetails.Columns.Add("Id", 50);
            lvBillDetails.Columns.Add("Tên món ăn", 150);
            lvBillDetails.Columns.Add("Số lượng", 100);

            foreach (var detail in billDetails)
            {
                var item = new ListViewItem(detail.Id.ToString());
                item.SubItems.Add(detail.FoodName);
                item.SubItems.Add(detail.Quantity.ToString());
                lvBillDetails.Items.Add(item);
            }
        }

        private void lstBills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBills.SelectedValue != null)
            {
                // Kiểm tra và chuyển đổi kiểu an toàn
                if (int.TryParse(lstBills.SelectedValue.ToString(), out int billId))
                {
                    LoadBillDetails(billId);
                }
                else
                {
                    MessageBox.Show("Không thể lấy ID hóa đơn. Vui lòng thử lại.");
                }
            }
        }
    }
}
