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
    public partial class TableForm : Form
    {
        private RestaurantContext _context;

        public TableForm()
        {
            InitializeComponent();
            _context = new RestaurantContext();
            LoadTables();
        }

        private void LoadTables()
        {
            // Xóa dữ liệu cũ trong ListView
            lvTables.Items.Clear();

            // Tải dữ liệu từ database và hiển thị trong ListView
            var tables = _context.Tables!.ToList();
            foreach (var table in tables)
            {
                // Tạo ListViewItem với các giá trị của table
                var item = new ListViewItem(table.Id.ToString());
                item.SubItems.Add(table.Name ?? "Unknown"); // Nếu Name là null, hiển thị "Unknown"
                item.SubItems.Add(table.Status.ToString()); // Chuyển đổi enum TableStatus thành chuỗi
                item.SubItems.Add(table.Capacity.ToString());

                // Thêm item vào ListView
                lvTables.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Chuyển đổi trạng thái từ string sang enum TableStatus
            if (!Enum.TryParse(txtStatus.Text, out TableStatus status))
            {
                MessageBox.Show("Trạng thái không hợp lệ. Vui lòng nhập 'Available', 'Reserved', hoặc 'Occupied'.");
                return;
            }

            // Tạo một đối tượng Table từ TableModel
            var table = new Table
            {
                Name = txtName.Text,
                Status = status, // Gán giá trị trạng thái
                Capacity = int.Parse(txtCapacity.Text)
            };

            // Thêm vào context và lưu vào cơ sở dữ liệu
            _context.Tables!.Add(table);
            _context.SaveChanges();
            LoadTables();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvTables.SelectedItems.Count > 0)
            {
                int id = int.Parse(lvTables.SelectedItems[0].Text);
                var table = _context.Tables!.Find(id);

                if (table != null)
                {
                    table.Name = txtName.Text;

                    // Chuyển đổi txtStatus.Text thành kiểu TableStatus
                    if (!Enum.TryParse(txtStatus.Text, out TableStatus status))
                    {
                        MessageBox.Show("Trạng thái không hợp lệ. Vui lòng nhập 'Available', 'Reserved', hoặc 'Occupied'.");
                        return;
                    }
                    table.Status = status;

                    table.Capacity = int.Parse(txtCapacity.Text);

                    _context.SaveChanges();
                    LoadTables();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bàn để cập nhật.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bàn để cập nhật.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvTables.SelectedItems.Count > 0)
            {
                int id = int.Parse(lvTables.SelectedItems[0].Text);
                var table = _context.Tables!.Find(id);

                _context.Tables.Remove(table);
                _context.SaveChanges();
                LoadTables();
            }
        }

        private void lvTables_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && lvTables.FocusedItem!.Bounds.Contains(e.Location))
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void tsmiDeleteTable_Click(object sender, EventArgs e)
        {
            btnDelete.PerformClick();
        }

        private void tsmiViewBillDetails_Click(object sender, EventArgs e)
        {
            if (lvTables.SelectedItems.Count > 0)
            {
                int id = int.Parse(lvTables.SelectedItems[0].Text);
                var billForm = new BillDetailsForm(id);
                billForm.ShowDialog();
            }
        }

        private void tsmiViewSalesLog_Click(object sender, EventArgs e)
        {
            var salesLogForm = new SalesLogForm();
            salesLogForm.ShowDialog();
        }
    }
}
