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
    public partial class AccountManagementForm : Form
    {
        private RestaurantContext _context;

        public AccountManagementForm(RestaurantContext context)
        {
            InitializeComponent();
            _context = context;

            LoadAccounts();
        }

        private void LoadAccounts()
        {
            // Lấy danh sách tài khoản từ Database
            var accounts = _context.Accounts!.Select(a => new
            {
                a.AccountName,
                a.FullName,
                a.Email,
                a.Tell,
                DateCreated = a.DateCreated.HasValue ? a.DateCreated.Value.ToString("dd/MM/yyyy") : "N/A"
            }).ToList();

            // Gán dữ liệu vào ListView
            listViewAccounts.Items.Clear();
            foreach (var account in accounts)
            {
                var item = new ListViewItem(account.AccountName);
                item.SubItems.Add(account.FullName ?? "N/A");
                item.SubItems.Add(account.Email ?? "N/A");
                item.SubItems.Add(account.Tell ?? "N/A");
                item.SubItems.Add(account.DateCreated);
                listViewAccounts.Items.Add(item);
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            using (var addAccountForm = new AddAccountForm())
            {
                if (addAccountForm.ShowDialog() == DialogResult.OK)
                {
                    // Sau khi thêm tài khoản thành công, tải lại danh sách tài khoản
                    LoadAccounts();
                }
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            if (listViewAccounts.SelectedItems.Count > 0)
            {
                var selectedAccountName = listViewAccounts.SelectedItems[0].Text;

                using (var updateAccountForm = new UpdateAccountForm(selectedAccountName))
                {
                    if (updateAccountForm.ShowDialog() == DialogResult.OK)
                    {
                        // Sau khi cập nhật thành công, tải lại danh sách tài khoản
                        LoadAccounts();
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một tài khoản để chỉnh sửa!");
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            // Xóa tài khoản
            if (listViewAccounts.SelectedItems.Count > 0)
            {
                var selectedAccount = listViewAccounts.SelectedItems[0].Text;
                var account = _context.Accounts!.FirstOrDefault(a => a.AccountName == selectedAccount);

                if (account != null)
                {
                    _context.Accounts!.Remove(account);
                    _context.SaveChanges();
                    LoadAccounts();
                    MessageBox.Show("Xóa tài khoản thành công!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một tài khoản để xóa!");
            }
        }
    }
}
