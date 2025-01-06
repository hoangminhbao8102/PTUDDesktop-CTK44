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
    public partial class LoginForm : Form
    {
        private readonly RestaurantContext _context;
        public AccountModel? LoggedInAccount { get; private set; } // Tài khoản đã đăng nhập

        public LoginForm(RestaurantContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private bool VerifyPassword(string inputPassword, string storedPassword)
        {
            // Logic xác minh mật khẩu (ví dụ: so sánh mật khẩu mã hóa)
            return inputPassword == storedPassword; // Thay bằng mã hóa và so sánh trong thực tế
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string accountName = txtAccountName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(accountName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Tên tài khoản và mật khẩu không được để trống.");
                return;
            }

            // Tìm tài khoản trong cơ sở dữ liệu
            var account = _context.Accounts!
                .FirstOrDefault(a => a.AccountName == accountName);

            if (account == null || !VerifyPassword(password, account.Password))
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng.");
                return;
            }

            // Đăng nhập thành công
            LoggedInAccount = new AccountModel
            {
                AccountName = account.AccountName,
                FullName = account.FullName,
                Email = account.Email,
                Phone = account.Tell,
                Password = account.Password,
                DateCreated = account.DateCreated
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
