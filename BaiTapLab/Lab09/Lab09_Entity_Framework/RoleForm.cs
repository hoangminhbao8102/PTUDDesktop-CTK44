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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Lab09_Entity_Framework
{
    public partial class RoleForm : Form
    {
        private RestaurantContext _context;

        public RoleForm()
        {
            InitializeComponent();
            _context = new RestaurantContext();
        }

        // Constructor mới để nhận danh sách vai trò
        public RoleForm(List<string> roles) : this()
        {
            InitializeComponent();
            LoadRoles(roles);
        }

        // Tải danh sách vai trò được truyền vào
        private void LoadRoles(List<string> roles)
        {
            lvRoles.Items.Clear(); // Xóa dữ liệu cũ

            foreach (var roleName in roles)
            {
                var item = new ListViewItem(roleName);
                lvRoles.Items.Add(item);
            }
        }

        // a.Hiển thị danh sách các nhóm(hay vai trò) người dùng
        private void LoadRoles()
        {
            lvRoles.Items.Clear(); // Xóa dữ liệu cũ

            var roles = _context.Roles!.Select(r => new RoleModel
            {
                Id = r.Id,
                RoleName = r.RoleName,
                Path = r.Path,
                Notes = r.Notes
            }).ToList();

            foreach (var role in roles)
            {
                var item = new ListViewItem(role.Id.ToString());
                item.SubItems.Add(role.RoleName);
                item.SubItems.Add(role.Path);
                item.SubItems.Add(role.Notes);

                lvRoles.Items.Add(item);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadRoles();
        }

        // b.Thêm role mới, cập nhật một role đã có.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Chuyển đổi từ RoleModel sang Role
            var newRole = new Role
            {
                RoleName = txtRoleName.Text,
                Path = txtPath.Text,
                Notes = txtNotes.Text
            };

            _context.Roles!.Add(newRole); // Thêm đối tượng Role vào DbSet
            _context.SaveChanges();       // Lưu thay đổi vào database
            MessageBox.Show("Thêm vai trò mới thành công!");
            LoadRoles();                  // Tải lại danh sách vai trò
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvRoles.SelectedItems.Count > 0)
            {
                var selectedItem = lvRoles.SelectedItems[0];
                int roleId = int.Parse(selectedItem.Text);

                var role = _context.Roles!.FirstOrDefault(r => r.Id == roleId);

                if (role != null)
                {
                    role.RoleName = txtRoleName.Text;
                    role.Path = txtPath.Text;
                    role.Notes = txtNotes.Text;

                    _context.SaveChanges();
                    MessageBox.Show("Cập nhật vai trò thành công!");
                    LoadRoles();
                }
            }
        }

        // c.Xem danh sách người dùng thuộc role được chọn
        private void btnViewAccounts_Click(object sender, EventArgs e)
        {
            if (lvRoles.SelectedItems.Count > 0)
            {
                var selectedItem = lvRoles.SelectedItems[0];
                int roleId = int.Parse(selectedItem.Text);

                var accounts = _context.RoleAccounts!
                    .Where(ra => ra.RoleId == roleId && ra.Actived)
                    .Join(_context.Accounts!,
                        ra => ra.AccountName,
                        acc => acc.AccountName,
                        (ra, acc) => new AccountModel
                        {
                            AccountName = acc.AccountName,
                            FullName = acc.FullName,
                            Email = acc.Email,
                            Phone = acc.Tell,
                            DateCreated = acc.DateCreated
                        })
                    .ToList();

                lvAccounts.Items.Clear(); // Xóa dữ liệu cũ

                foreach (var account in accounts)
                {
                    var item = new ListViewItem(account.AccountName);
                    item.SubItems.Add(account.FullName);
                    item.SubItems.Add(account.Email);
                    item.SubItems.Add(account.Phone);
                    item.SubItems.Add(account.DateCreated.HasValue
                        ? account.DateCreated.Value.ToString("yyyy-MM-dd")
                        : "N/A");

                    lvAccounts.Items.Add(item);
                }
            }
        }
    }
}
