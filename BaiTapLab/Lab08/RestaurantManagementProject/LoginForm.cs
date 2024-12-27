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
    public partial class LoginForm : Form
    {
        private AccountBL accountBL = new AccountBL();
        public Account? LoggedInAccount { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Lấy thông tin tài khoản từ cơ sở dữ liệu
            var accounts = accountBL.GetAll();

            // Kiểm tra tài khoản và mật khẩu
            var account = accounts.FirstOrDefault(a =>
                a.AccountName == txtUsername.Text && a.Password == txtPassword.Text);

            if (account != null)
            {
                LoggedInAccount = account; // Gán tài khoản đăng nhập thành công
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Đăng nhập thất bại");
            }
        }
    }
}
