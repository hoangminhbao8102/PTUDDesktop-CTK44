using Restaurant.BLL.Security;
using Restaurant.DAL;
using Restaurant.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantDesktop
{
    public partial class AccountForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserService _userService;

        public AccountForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _userService = new UserService(_unitOfWork);

            InitializeComponent();
        }

        private void LoadAccounts()
        {
            lvAccounts.Items.Clear(); // `lvAccounts` là ListView hiển thị danh sách tài khoản
            var accounts = _userService.GetAllAccounts();

            foreach (var account in accounts)
            {
                var item = new ListViewItem(account.AccountName); // Cột Tên tài khoản
                item.SubItems.Add(account.Password ?? "");        // Cột Họ và tên
                item.SubItems.Add(account.FullName ?? "");        // Cột Họ và tên
                item.SubItems.Add(account.Email ?? "");           // Cột Email
                item.SubItems.Add(account.Tell ?? "");            // Cột Số điện thoại
                item.SubItems.Add(account.DateCreated?.ToString("yyyy-MM-dd") ?? ""); // Cột Ngày tạo
                lvAccounts.Items.Add(item);
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            var accountName = txtAccountName.Text; // TextBox nhập tên tài khoản
            var password = txtPassword.Text;       // TextBox nhập mật khẩu
            var fullName = txtFullName.Text;       // TextBox nhập họ và tên
            var email = txtEmail.Text;             // TextBox nhập email
            var tell = txtTell.Text;               // TextBox nhập số điện thoại

            if (string.IsNullOrEmpty(accountName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var account = new Account
            {
                AccountName = accountName,
                Password = password, // Nên mã hóa mật khẩu trong thực tế
                FullName = fullName,
                Email = email,
                Tell = tell,
                DateCreated = DateTime.Now
            };

            _userService.Insert(account);
            _unitOfWork.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

            LoadAccounts();
            MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            if (lvAccounts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var selectedItem = lvAccounts.SelectedItems[0];
            var accountName = selectedItem.Text; // Lấy tên tài khoản từ cột đầu tiên
            var account = _userService.GetAccountByUsername(accountName);

            if (account == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var password = txtPassword.Text;
            var fullName = txtFullName.Text;
            var email = txtEmail.Text;
            var tell = txtTell.Text;

            if (!string.IsNullOrEmpty(password)) account.Password = password; // Nên mã hóa mật khẩu
            account.FullName = fullName;
            account.Email = email;
            account.Tell = tell;

            _userService.Update(account);
            _unitOfWork.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

            LoadAccounts();
            MessageBox.Show("Cập nhật tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (lvAccounts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var selectedItem = lvAccounts.SelectedItems[0];
            var accountName = selectedItem.Text;

            var result = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var account = _userService.GetAccountByUsername(accountName);
                if (account != null)
                {
                    _userService.Delete(account);
                    _unitOfWork.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                }

                LoadAccounts();
                MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
