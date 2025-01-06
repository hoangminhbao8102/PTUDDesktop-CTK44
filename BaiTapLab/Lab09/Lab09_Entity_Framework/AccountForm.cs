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
    public partial class AccountForm : Form
    {
        private RestaurantContext _context;

        public AccountForm()
        {
            InitializeComponent();
            _context = new RestaurantContext();
            LoadAccounts();
        }

        // Phương thức tải danh sách tài khoản vào ListView
        private void LoadAccounts(List<AccountModel>? accounts = null)
        {
            lvwAccount.Items.Clear();

            // Nếu accounts == null, lấy danh sách từ _context và chuyển đổi sang AccountModel
            if (accounts == null)
            {
                accounts = _context.Accounts!
                    .Select(acc => new AccountModel
                    {
                        AccountName = acc.AccountName,
                        FullName = acc.FullName,
                        Email = acc.Email,
                        Phone = acc.Tell, // Ánh xạ Tell từ Account sang Phone trong AccountModel
                        Password = acc.Password,
                        DateCreated = acc.DateCreated
                    })
                    .ToList();
            }

            // Thêm từng tài khoản vào ListView
            foreach (var account in accounts)
            {
                var item = new ListViewItem(account.AccountName);
                item.SubItems.Add(account.FullName ?? "");
                item.SubItems.Add(account.Email ?? "");
                item.SubItems.Add(account.Phone ?? "");
                item.SubItems.Add(account.Password ?? "");
                item.SubItems.Add(account.DateCreated?.ToString("dd/MM/yyyy") ?? "");

                lvwAccount.Items.Add(item);
            }
        }

        // a. Xem danh sách tài khoản (Tìm kiếm theo Role hoặc Tên người dùng)
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string roleName = txtSearchRole.Text.Trim();
            string userName = txtSearchUserName.Text.Trim();

            // Tạo truy vấn cơ bản từ bảng Accounts
            var query = _context.Accounts!.AsQueryable();

            // Lọc theo vai trò (RoleName)
            if (!string.IsNullOrEmpty(roleName))
            {
                query = query.Join(_context.RoleAccounts!,
                    acc => acc.AccountName,
                    roleAcc => roleAcc.AccountName,
                    (acc, roleAcc) => new { acc, roleAcc })
                    .Where(x => x.roleAcc.Role != null && x.roleAcc.Role.RoleName == roleName)
                    .Select(x => x.acc);
            }

            // Lọc theo tên người dùng
            if (!string.IsNullOrEmpty(userName))
            {
                query = query.Where(acc => acc.FullName != null && acc.FullName.Contains(userName));
            }

            // Chuyển đổi danh sách từ Account sang AccountModel
            var accountModels = query.Select(acc => new AccountModel
            {
                AccountName = acc.AccountName,
                FullName = acc.FullName,
                Email = acc.Email,
                Phone = acc.Tell,
                Password = acc.Password,
                DateCreated = acc.DateCreated
            }).ToList();

            // Tải danh sách tài khoản vào ListView
            LoadAccounts(accountModels);
        }

        // b. Thêm tài khoản mới
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            var addForm = new AddAccountForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadAccounts(); // Tải lại danh sách tài khoản sau khi thêm
            }
        }

        // c. Cập nhật thông tin tài khoản
        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            if (lvwAccount.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để cập nhật.");
                return;
            }

            string accountName = lvwAccount.SelectedItems[0].Text;
            var updateForm = new UpdateAccountForm(accountName);
            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                LoadAccounts(); // Tải lại danh sách tài khoản sau khi cập nhật
            }
        }

        // d. Reset mật khẩu
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (lvwAccount.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để reset mật khẩu.");
                return;
            }

            string accountName = lvwAccount.SelectedItems[0].Text;

            var account = _context.Accounts!.FirstOrDefault(a => a.AccountName == accountName);
            if (account != null)
            {
                account.Password = "123456"; // Reset mật khẩu về mặc định
                _context.SaveChanges();
                MessageBox.Show("Mật khẩu đã được reset về '123456'.");
            }
        }

        // e. Thay đổi mật khẩu
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (lvwAccount.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để thay đổi mật khẩu.");
                return;
            }

            string accountName = lvwAccount.SelectedItems[0].Text;
            var changePasswordForm = new ChangePasswordForm(accountName);
            if (changePasswordForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Mật khẩu đã được thay đổi.");
            }
        }

        // f. Menu chuột phải hiển thị "Xóa tài khoản" và "Xem danh sách vai trò"
        private void tsmDeleteAccount_Click(object sender, EventArgs e)
        {
            if (lvwAccount.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xóa.");
                return;
            }

            string accountName = lvwAccount.SelectedItems[0].Text;

            var account = _context.Accounts!.FirstOrDefault(a => a.AccountName == accountName);
            if (account != null)
            {
                account.Password = "DELETED"; // Gán giá trị mặc định
                _context.SaveChanges();
                MessageBox.Show("Tài khoản đã bị xóa.");
                LoadAccounts();
            }
        }

        private void tsmViewRoles_Click(object sender, EventArgs e)
        {
            if (lvwAccount.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xem vai trò.");
                return;
            }

            string accountName = lvwAccount.SelectedItems[0].Text;

            var roles = _context.RoleAccounts!
                .Where(ra => ra.AccountName == accountName && ra.Role != null)
                .Select(ra => ra.Role!.RoleName)
                .Where(roleName => !string.IsNullOrEmpty(roleName)) // Loại bỏ giá trị null hoặc chuỗi rỗng
                .ToList()!;

            var roleForm = new RoleForm(roles.Cast<string>().ToList()); // Ép kiểu về List<string>
            roleForm.ShowDialog();
        }
    }
}
