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
    public partial class frmTable : Form
    {
        // Danh sách toàn cục bảng Table
        List<Table> listTable = new List<Table>();
        // Đối tượng Table đang chọn hiện hành
        Table tableCurrent = new Table();

        public frmTable()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            // Gán các ô bằng giá trị mặc định
            txtName.Text = "";
            txtCapacity.Text = "0";
            if (cbbStatus.Items.Count > 0)
            {
                cbbStatus.SelectedIndex = 0; // Đặt trạng thái mặc định
            }
        }

        private void LoadTableDataToListView()
        {
            // Khởi tạo đối tượng TableBL từ tầng BusinessLogic
            TableBL tableBL = new TableBL();

            // Lấy danh sách bàn từ tầng BusinessLogic
            listTable = tableBL.GetAll();

            // Biến số thứ tự cho từng dòng
            int count = 1;

            // Xóa dữ liệu cũ trong ListView
            lsvTable.Items.Clear();

            // Duyệt danh sách dữ liệu để hiển thị trong ListView
            foreach (var table in listTable)
            {
                // Kiểm tra nếu dữ liệu bàn là null
                if (table == null)
                {
                    continue;
                }

                // Tạo một dòng trong ListView, bắt đầu bằng số thứ tự
                ListViewItem item = new ListViewItem(count.ToString());

                // Thêm các cột dữ liệu
                item.SubItems.Add(table.Name ?? "N/A"); // Tên bàn
                item.SubItems.Add(GetStatusText(table.Status)); // Trạng thái (hiển thị dạng text)
                item.SubItems.Add(table.Capacity.ToString()); // Sức chứa

                // Thêm dòng vào ListView
                lsvTable.Items.Add(item);

                // Tăng số thứ tự
                count++;
            }
        }

        private string GetStatusText(int status)
        {
            // Chuyển đổi trạng thái từ số sang dạng text
            switch (status)
            {
                case 0:
                    return "Trống";
                case 1:
                    return "Đang sử dụng";
                case 2:
                    return "Đã đặt trước";
                default:
                    return "Không xác định";
            }
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu trạng thái vào ComboBox
            cbbStatus.Items.Clear();
            cbbStatus.Items.Add("0 - Trống");
            cbbStatus.Items.Add("1 - Đang sử dụng");
            cbbStatus.Items.Add("2 - Đã đặt trước");
            cbbStatus.SelectedIndex = 0;

            // Đổ dữ liệu vào ListView
            LoadTableDataToListView();
        }

        private void lsvTable_Click(object sender, EventArgs e)
        {
            // Duyệt toàn bộ dữ liệu trong ListView
            for (int i = 0; i < lsvTable.Items.Count; i++)
            {
                // Nếu có dòng được chọn thì lấy dòng đó
                if (lsvTable.Items[i].Selected)
                {
                    // Lấy các tham số và gán dữ liệu vào các ô
                    tableCurrent = listTable[i];
                    txtName.Text = tableCurrent.Name;
                    cbbStatus.SelectedIndex = tableCurrent.Status; // Chọn trạng thái tương ứng
                    txtCapacity.Text = tableCurrent.Capacity.ToString();
                }
            }
        }

        public int InsertTable()
        {
            // Khai báo đối tượng Table từ tầng DataAccess
            Table table = new Table();
            table.ID = 0;

            // Kiểm tra nếu các ô nhập khác rỗng
            if (string.IsNullOrEmpty(txtName?.Text) || string.IsNullOrEmpty(txtCapacity?.Text))
            {
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại.");
                return -1;
            }

            // Nhận giá trị từ người dùng nhập vào
            table.Name = txtName?.Text ?? string.Empty;
            table.Status = cbbStatus.SelectedIndex; // Lấy trạng thái từ ComboBox

            // Giá trị Capacity là số, kiểm tra lỗi
            if (!int.TryParse(txtCapacity?.Text, out int capacity))
            {
                capacity = 0; // Nếu không thể chuyển đổi, gán giá trị mặc định
            }
            table.Capacity = capacity;

            // Khai báo đối tượng TableBL từ tầng Business
            TableBL tableBL = new TableBL();
            return tableBL.Insert(table);
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int result = InsertTable();

                if (result > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!");
                    LoadTableDataToListView();
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong quá trình thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int UpdateTable()
        {
            if (tableCurrent == null || tableCurrent.ID <= 0)
            {
                MessageBox.Show("Vui lòng chọn bàn để cập nhật.");
                return -1;
            }

            // Cập nhật thông tin từ người dùng nhập vào
            tableCurrent.Name = txtName?.Text ?? string.Empty;
            tableCurrent.Status = cbbStatus.SelectedIndex; // Lấy trạng thái từ ComboBox

            if (!int.TryParse(txtCapacity?.Text, out int capacity))
            {
                capacity = 0; // Nếu không thể chuyển đổi, gán giá trị mặc định
            }
            tableCurrent.Capacity = capacity;

            // Cập nhật vào cơ sở dữ liệu
            TableBL tableBL = new TableBL();
            return tableBL.Update(tableCurrent);
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int result = UpdateTable();

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                    LoadTableDataToListView();
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu không thành công. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong quá trình cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableCurrent == null || tableCurrent.ID <= 0)
                {
                    MessageBox.Show("Vui lòng chọn bàn để xóa.");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa bàn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int result = new TableBL().Delete(tableCurrent.ID);

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");
                        LoadTableDataToListView();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công. Vui lòng thử lại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong quá trình xóa dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
