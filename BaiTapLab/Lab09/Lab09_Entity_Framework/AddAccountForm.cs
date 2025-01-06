using Lab09_Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09_Entity_Framework
{
    public partial class AddAccountForm : Form
    {
        private RestaurantContext _context;

        public AddAccountForm()
        {
            InitializeComponent();
            _context = new RestaurantContext();
            LoadRoles();
        }

        // Tải danh sách vai trò vào ComboBox
        private void LoadRoles()
        {
            var roles = _context.Roles!
                .Select(r => new RoleModel
                {
                    Id = r.Id,
                    RoleName = r.RoleName
                })
                .ToList();

            comboRole.DataSource = roles;
            comboRole.DisplayMember = "RoleName";
            comboRole.ValueMember = "Id";
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string accountName = txtAccountName.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Kiểm tra giá trị SelectedValue của comboRole
            if (comboRole.SelectedValue == null || !int.TryParse(comboRole.SelectedValue.ToString(), out int roleId))
            {
                MessageBox.Show("Vui lòng chọn vai trò hợp lệ.");
                return;
            }

            if (string.IsNullOrEmpty(accountName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Tên tài khoản và mật khẩu không được để trống.");
                return;
            }

            var newAccount = new Account
            {
                AccountName = accountName,
                FullName = fullName,
                Email = email,
                Tell = phone,
                Password = password,
                DateCreated = DateTime.Now
            };

            _context.Accounts!.Add(newAccount);
            _context.RoleAccounts!.Add(new RoleAccount
            {
                AccountName = accountName,
                RoleId = roleId,
                Actived = true
            });

            _context.SaveChanges();
            MessageBox.Show("Thêm tài khoản mới thành công!");
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
