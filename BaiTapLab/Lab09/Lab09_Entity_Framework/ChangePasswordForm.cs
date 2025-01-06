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
    public partial class ChangePasswordForm : Form
    {
        private RestaurantContext _context;
        private string _accountName;

        public ChangePasswordForm(string accountName)
        {
            InitializeComponent();
            _context = new RestaurantContext();
            _accountName = accountName;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(newPassword) || newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới không khớp hoặc để trống.");
                return;
            }

            var account = _context.Accounts!.FirstOrDefault(a => a.AccountName == _accountName && a.Password == oldPassword);
            if (account != null)
            {
                account.Password = newPassword;
                _context.SaveChanges();
                MessageBox.Show("Thay đổi mật khẩu thành công!");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
