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
    public partial class frmBills : Form
    {
        // Danh sách toàn cục bảng Bills
        List<Bills> listBills = new List<Bills>();
        // Đối tượng Bills đang chọn hiện hành
        Bills billCurrent = new Bills();

        public frmBills()
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
            txtTableID.Text = "";
            txtAmount.Text = "0";
            txtDiscount.Text = "0";
            txtTax.Text = "0";
            txtAccount.Text = "";
            cbbStatus.SelectedIndex = 0; // Mặc định là "Chưa thanh toán"
            dtpCheckoutDate.Value = DateTime.Now;
        }

        private void LoadBillsDataToListView()
        {
            // Khởi tạo đối tượng BillsBL từ tầng BusinessLogic
            BillsBL billsBL = new BillsBL();

            // Lấy danh sách hóa đơn từ tầng BusinessLogic
            listBills = billsBL.GetAll();

            // Sắp xếp danh sách hóa đơn theo một tiêu chí (ví dụ: Tên hóa đơn)
            listBills = listBills.OrderBy(bill => bill.Name).ToList();

            // Biến số thứ tự cho từng dòng
            int count = 1;

            // Xóa dữ liệu cũ trong ListView
            lsvBills.Items.Clear();

            // Duyệt danh sách dữ liệu để hiển thị trong ListView
            foreach (var bill in listBills)
            {
                // Kiểm tra nếu dữ liệu hóa đơn là null
                if (bill == null)
                {
                    continue;
                }

                // Tạo một dòng trong ListView, bắt đầu bằng số thứ tự
                ListViewItem item = new ListViewItem(count.ToString());

                // Thêm các cột dữ liệu
                item.SubItems.Add(bill.Name ?? "N/A"); // Tên hóa đơn
                item.SubItems.Add(bill.TableID.ToString()); // Mã bàn
                item.SubItems.Add(bill.Amount.ToString("N0")); // Tổng tiền
                item.SubItems.Add(bill.Discount.ToString("P0")); // Chiết khấu
                item.SubItems.Add(bill.Status ? "Đã thanh toán" : "Chưa thanh toán"); // Trạng thái
                item.SubItems.Add(bill.Tax.ToString("P0")); // Thuế
                item.SubItems.Add(bill.CheckoutDate.ToString("dd/MM/yyyy")); // Ngày thanh toán
                item.SubItems.Add(bill.Account ?? "N/A"); // Người thanh toán

                // Thêm dòng vào ListView
                lsvBills.Items.Add(item);

                // Tăng số thứ tự
                count++;
            }
        }

        private void frmBills_Load(object sender, EventArgs e)
        {
            // Đổ dữ liệu ComboBox trạng thái
            cbbStatus.Items.Clear();
            cbbStatus.Items.Add("Chưa thanh toán");
            cbbStatus.Items.Add("Đã thanh toán");
            cbbStatus.SelectedIndex = 0; // Mặc định là "Chưa thanh toán"

            // Đổ dữ liệu vào ListView
            LoadBillsDataToListView();
        }



        public int InsertBill()
        {
            // Kiểm tra nếu các ô nhập khác rỗng
            if (string.IsNullOrEmpty(txtName?.Text) || string.IsNullOrEmpty(txtTableID?.Text))
            {
                MessageBox.Show("Vui lòng nhập tên hóa đơn và mã bàn.");
                return -1;
            }

            // Khai báo đối tượng Bills từ tầng DataAccess
            Bills bill = new Bills
            {
                Name = txtName.Text,
                Account = txtAccount.Text,
                TableID = int.TryParse(txtTableID.Text, out int tableId) ? tableId : 0,
                Amount = int.TryParse(txtAmount.Text, out int amount) ? amount : 0,
                Discount = float.TryParse(txtDiscount.Text, out float discount) ? discount : 0,
                Tax = float.TryParse(txtTax.Text, out float tax) ? tax : 0,
                CheckoutDate = dtpCheckoutDate.Value,
                Status = cbbStatus.SelectedIndex == 1 // Đã thanh toán nếu index = 1
            };

            BillsBL billsBL = new BillsBL();
            return billsBL.Insert(bill);
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Gọi phương thức thêm dữ liệu
                int result = InsertBill();

                if (result > 0)
                {
                    MessageBox.Show("Thêm hóa đơn thành công!");
                    LoadBillsDataToListView();
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn không thành công. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong quá trình thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra hóa đơn hiện tại
                if (billCurrent == null || billCurrent.ID <= 0)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn để xoá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận từ người dùng
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int result = new BillsBL().Delete(billCurrent);

                    // Kiểm tra kết quả
                    if (result > 0)
                    {
                        MessageBox.Show("Xoá hóa đơn thành công!");
                        LoadBillsDataToListView();
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công. Vui lòng thử lại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong quá trình xoá dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int UpdateBill()
        {
            try
            {
                // Kiểm tra nếu không có hóa đơn được chọn
                if (billCurrent == null)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn để cập nhật.");
                    return -1; // Trả về giá trị âm để báo lỗi
                }

                // Cập nhật các giá trị từ form vào đối tượng hóa đơn
                billCurrent.Name = txtName.Text ?? string.Empty;
                billCurrent.Account = txtAccount.Text ?? string.Empty;
                billCurrent.TableID = int.TryParse(txtTableID.Text, out int tableId) ? tableId : 0;
                billCurrent.Amount = int.TryParse(txtAmount.Text, out int amount) ? amount : 0;
                billCurrent.Discount = float.TryParse(txtDiscount.Text, out float discount) ? discount : 0;
                billCurrent.Tax = float.TryParse(txtTax.Text, out float tax) ? tax : 0;
                billCurrent.CheckoutDate = dtpCheckoutDate.Value;
                billCurrent.Status = cbbStatus.SelectedIndex == 1; // 1 là "Đã thanh toán"

                // Gọi tầng BusinessLogic để cập nhật dữ liệu
                BillsBL billsBL = new BillsBL();
                int result = billsBL.Update(billCurrent);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật hóa đơn thành công!");
                    LoadBillsDataToListView();
                    return result; // Trả về kết quả thành công
                }
                else
                {
                    MessageBox.Show("Cập nhật hóa đơn không thành công.");
                    return 0; // Trả về 0 nếu không thành công
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong quá trình cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Trả về giá trị âm nếu xảy ra lỗi
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Gọi phương thức cập nhật dữ liệu
                int result = UpdateBill();

                // Kiểm tra kết quả
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                    LoadBillsDataToListView();
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu không thành công. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong quá trình cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvBills_Click(object sender, EventArgs e)
        {
            // Duyệt toàn bộ dữ liệu trong ListView
            for (int i = 0; i < lsvBills.Items.Count; i++)
            {
                // Nếu có dòng được chọn thì lấy dòng đó
                if (lsvBills.Items[i].Selected)
                {
                    // Lấy các tham số và gán dữ liệu vào các ô
                    billCurrent = listBills[i];
                    txtName.Text = billCurrent.Name;
                    txtTableID.Text = billCurrent.TableID.ToString();
                    txtAmount.Text = billCurrent.Amount.ToString();
                    txtDiscount.Text = billCurrent.Discount.ToString();
                    txtTax.Text = billCurrent.Tax.ToString();
                    txtAccount.Text = billCurrent.Account;
                    dtpCheckoutDate.Value = billCurrent.CheckoutDate;
                    cbbStatus.SelectedIndex = billCurrent.Status ? 1 : 0;
                }
            }
        }
    }
}
