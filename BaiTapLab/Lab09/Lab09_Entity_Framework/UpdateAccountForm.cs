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
    public partial class UpdateAccountForm : Form
    {
        private RestaurantContext _context;
        private string _accountName;

        public UpdateAccountForm(string accountName)
        {
            InitializeComponent();
            _context = new RestaurantContext();
            _accountName = accountName;
            LoadAccountDetails();
        }

        private void LoadAccountDetails()
        {
            var account = _context.Accounts!.FirstOrDefault(a => a.AccountName == _accountName);
            if (account != null)
            {
                txtFullName.Text = account.FullName;
                txtEmail.Text = account.Email;
                txtPhone.Text = account.Tell;
            }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            var account = _context.Accounts!.FirstOrDefault(a => a.AccountName == _accountName);
            if (account != null)
            {
                account.FullName = txtFullName.Text.Trim();
                account.Email = txtEmail.Text.Trim();
                account.Tell = txtPhone.Text.Trim();

                _context.SaveChanges();
                MessageBox.Show("Cập nhật thông tin tài khoản thành công!");
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
