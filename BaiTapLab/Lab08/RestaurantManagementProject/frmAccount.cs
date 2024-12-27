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
    public partial class frmAccount : Form
    {
        // Danh sách toàn cục bảng Account
        List<Account> listAccount = new List<Account>();
        // Đối tượng Account đang chọn hiện hành
        Account accountCurrent = new Account();

        public frmAccount()
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
            txtAccountName.Text = "";
            txtPassword.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }

        private void LoadAccountDataToListView()
        {
            // Khởi tạo đối tượng AccountBL từ tầng BusinessLogic
            AccountBL accountBL = new AccountBL();

            // Lấy danh sách tài khoản từ tầng BusinessLogic
            listAccount = accountBL.GetAll();

            // Biến số thứ tự cho từng dòng
            int count = 1;

            // Xoá dữ liệu cũ trong ListView
            lsvAccount.Items.Clear();

            // Duyệt danh sách dữ liệu để hiển thị trong ListView
            foreach (var account in listAccount)
            {
                // Kiểm tra nếu dữ liệu tài khoản là null
                if (account == null)
                {
                    continue;
                }

                // Tạo một dòng trong ListView, bắt đầu bằng số thứ tự
                ListViewItem item = new ListViewItem(count.ToString());

                // Thêm các cột dữ liệu
                item.SubItems.Add(account.AccountName ?? "N/A");
                item.SubItems.Add(account.Password ?? "N/A");
                item.SubItems.Add(account.FullName ?? "N/A");
                item.SubItems.Add(account.Email ?? "N/A");
                item.SubItems.Add(account.Tell ?? "N/A");
                item.SubItems.Add(account.DateCreated.ToString("dd/MM/yyyy"));

                // Thêm dòng vào ListView
                lsvAccount.Items.Add(item);

                // Tăng số thứ tự
                count++;
            }
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            // Đổ dữ liệu vào ListView
            LoadAccountDataToListView();
        }

        private void lsvAccount_Click(object sender, EventArgs e)
        {
            // Duyệt toàn bộ dữ liệu trong ListView
            for (int i = 0; i < lsvAccount.Items.Count; i++)
            {
                // Nếu có dòng được chọn thì lấy dòng đó
                if (lsvAccount.Items[i].Selected)
                {
                    // Lấy các tham số và gán dữ liệu vào các ô
                    accountCurrent = listAccount[i];
                    txtAccountName.Text = accountCurrent.AccountName;
                    txtPassword.Text = accountCurrent.Password;
                    txtFullName.Text = accountCurrent.FullName;
                    txtEmail.Text = accountCurrent.Email;
                    txtPhone.Text = accountCurrent.Tell;
                }
            }
        }

        public int InsertAccount()
        {
            // Khai báo đối tượng Account từ tầng DataAccess
            Account account = new Account();
            account.AccountName = "";

            // Kiểm tra nếu các ô nhập khác rỗng
            if (string.IsNullOrEmpty(txtAccountName?.Text) || string.IsNullOrEmpty(txtPassword?.Text))
            {
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            }
            else
            {
                // Nhận giá trị từ người dùng nhập vào
                account.AccountName = txtAccountName?.Text ?? string.Empty;
                account.Password = txtPassword?.Text ?? string.Empty;
                account.FullName = txtFullName?.Text ?? string.Empty;
                account.Email = txtEmail?.Text ?? string.Empty;
                account.Tell = txtPhone?.Text ?? string.Empty;
                account.DateCreated = DateTime.Now;

                // Khai báo đối tượng AccountBL từ tầng Business
                AccountBL accountBL = new AccountBL();

                // Chèn dữ liệu vào bảng
                return accountBL.Insert(account);
            }
            return -1;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra giá trị của txtAccountName
                if (string.IsNullOrWhiteSpace(txtAccountName.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng Account từ dữ liệu nhập
                Account account = new Account
                {
                    AccountName = txtAccountName.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    FullName = txtFullName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Tell = txtPhone.Text.Trim(),
                    DateCreated = DateTime.Now
                };

                // Gọi phương thức thêm dữ liệu
                int result = new AccountBL().Insert(account);

                // Kiểm tra kết quả
                if (result > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!");
                    LoadAccountDataToListView();
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng kiểm tra lại.");
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
                // Kiểm tra tài khoản hiện tại
                if (accountCurrent == null || accountCurrent.AccountName == "")
                {
                    MessageBox.Show("Vui lòng chọn tài khoản để xoá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận từ người dùng
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int result = new AccountBL().Delete(accountCurrent);

                    // Kiểm tra kết quả
                    if (result > 0)
                    {
                        MessageBox.Show("Xoá tài khoản thành công!");
                        LoadAccountDataToListView();
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

        public int UpdateAccount()
        {
            // Kiểm tra nếu đối tượng Account hiện hành có giá trị
            if (accountCurrent == null)
            {
                MessageBox.Show("Không có dữ liệu tài khoản hiện hành để cập nhật.");
                return -1;
            }

            // Gán dữ liệu chỉnh sửa
            accountCurrent.AccountName = txtAccountName?.Text ?? string.Empty;
            accountCurrent.Password = txtPassword?.Text ?? string.Empty;
            accountCurrent.FullName = txtFullName?.Text ?? string.Empty;
            accountCurrent.Email = txtEmail?.Text ?? string.Empty;
            accountCurrent.Tell = txtPhone?.Text ?? string.Empty;

            // Cập nhật dữ liệu qua tầng Business
            return new AccountBL().Update(accountCurrent);
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra tài khoản hiện tại
                if (accountCurrent == null || accountCurrent.AccountName == "")
                {
                    MessageBox.Show("Vui lòng chọn tài khoản để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi phương thức cập nhật dữ liệu
                int result = UpdateAccount();

                // Kiểm tra kết quả
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                    LoadAccountDataToListView();
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
    }
}
