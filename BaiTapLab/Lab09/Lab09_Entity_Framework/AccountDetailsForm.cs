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
    public partial class AccountDetailsForm : Form
    {
        private AccountModel _loggedInAccount;

        public AccountDetailsForm(AccountModel loggedInAccount)
        {
            InitializeComponent();
            _loggedInAccount = loggedInAccount;

            LoadAccountDetails();
        }

        private void LoadAccountDetails()
        {
            // Hiển thị thông tin tài khoản lên các TextBox
            txtAccountName.Text = _loggedInAccount.AccountName;
            txtFullName.Text = _loggedInAccount.FullName;
            txtEmail.Text = _loggedInAccount.Email;
            txtPhone.Text = _loggedInAccount.Phone;
            txtDateCreated.Text = _loggedInAccount.DateCreated?.ToString("dd/MM/yyyy");
        }
    }
}
