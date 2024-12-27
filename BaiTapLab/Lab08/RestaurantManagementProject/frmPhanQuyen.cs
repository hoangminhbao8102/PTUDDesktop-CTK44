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
    public partial class frmPhanQuyen : Form
    {
        // Danh sách toàn cục của các vai trò (Roles)
        List<Role> listRoles = new List<Role>();
        // Danh sách toàn cục của các quyền đã gán (RoleAccounts)
        List<RoleAccount> listRoleAccounts = new List<RoleAccount>();
        // Đối tượng RoleAccount đang chọn
        RoleAccount currentRoleAccount = new RoleAccount();

        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void LoadRoles()
        {
            // Khởi tạo đối tượng RoleBL từ tầng Business Logic
            RoleBL roleBL = new RoleBL();

            // Lấy danh sách Roles từ tầng Business Logic
            listRoles = roleBL.GetAll();

            // Gán dữ liệu vào ComboBox với ValueMember là ID và DisplayMember là RoleName
            cmbRoles.DataSource = listRoles;
            cmbRoles.ValueMember = "ID";
            cmbRoles.DisplayMember = "RoleName";
        }

        private void LoadRoleAccountsToListView()
        {
            // Khởi tạo đối tượng RoleAccountBL từ tầng Business Logic
            RoleAccountBL roleAccountBL = new RoleAccountBL();

            // Lấy danh sách RoleAccounts từ tầng Business Logic
            listRoleAccounts = roleAccountBL.GetAll();

            // Biến đếm để đánh số thứ tự
            int count = 1;

            // Xoá dữ liệu cũ trong ListView
            lsvUsers.Items.Clear();

            // Duyệt qua danh sách RoleAccounts để thêm vào ListView
            foreach (var roleAccount in listRoleAccounts)
            {
                if (roleAccount == null) continue;

                // Tạo một dòng mới trong ListView
                ListViewItem item = new ListViewItem(count.ToString());
                item.SubItems.Add(roleAccount.AccountName); // Tên tài khoản
                item.SubItems.Add(listRoles.Find(r => r.ID == roleAccount.RoleID)?.RoleName ?? "Unknown"); // Vai trò
                item.SubItems.Add(roleAccount.Actived ? "Hoạt động" : "Không hoạt động"); // Trạng thái

                // Thêm dòng vào ListView
                lsvUsers.Items.Add(item);
                count++;
            }

            // Hiển thị tổng số tài khoản trong Label
            lblStatistic.Text = $"Tổng số tài khoản: {listRoleAccounts.Count}";
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            // Đổ dữ liệu vào ComboBox và ListView khi Form được tải
            LoadRoles();
            LoadRoleAccountsToListView();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            // Thoát ứng dụng
            Application.Exit();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            // Reset các ô nhập liệu về giá trị mặc định
            txtAccountName.Text = "";
            chkActive.Checked = false;

            // Đặt ComboBox Role về vị trí đầu tiên
            if (cmbRoles.Items.Count > 0)
                cmbRoles.SelectedIndex = 0;
        }

        private void lsvUsers_Click(object sender, EventArgs e)
        {
            // Duyệt toàn bộ các dòng trong ListView
            for (int i = 0; i < lsvUsers.Items.Count; i++)
            {
                // Nếu dòng được chọn, lấy dữ liệu tương ứng
                if (lsvUsers.Items[i].Selected)
                {
                    currentRoleAccount = listRoleAccounts[i];
                    txtAccountName.Text = currentRoleAccount.AccountName;
                    chkActive.Checked = currentRoleAccount.Actived;
                    cmbRoles.SelectedIndex = listRoles.FindIndex(r => r.ID == currentRoleAccount.RoleID);
                }
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAccountName.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra giá trị SelectedValue của ComboBox trước khi unbox
                if (cmbRoles.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn một vai trò hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Sử dụng ép kiểu an toàn với null
                int roleId = cmbRoles.SelectedValue as int? ?? -1;
                if (roleId == -1)
                {
                    MessageBox.Show("Vai trò không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xem tài khoản có tồn tại không
                AccountBL accountBL = new AccountBL();
                bool isAccountExists = accountBL.CheckAccountExists(txtAccountName.Text.Trim());
                if (!isAccountExists)
                {
                    MessageBox.Show("Tài khoản không tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng RoleAccount và thêm mới
                RoleAccount roleAccount = new RoleAccount
                {
                    AccountName = txtAccountName.Text.Trim(),
                    RoleID = roleId,
                    Actived = chkActive.Checked
                };

                RoleAccountBL roleAccountBL = new RoleAccountBL();
                int result = roleAccountBL.Insert(roleAccount);

                if (result > 0)
                {
                    MessageBox.Show("Thêm quyền thành công!");
                    LoadRoleAccountsToListView();
                }
                else
                {
                    MessageBox.Show("Thêm quyền thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu RoleAccount hiện tại hoặc Tên tài khoản bị null hoặc trống
                if (currentRoleAccount == null || string.IsNullOrWhiteSpace(txtAccountName.Text))
                {
                    MessageBox.Show("Vui lòng chọn tài khoản để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra giá trị SelectedValue của ComboBox trước khi unbox
                if (cmbRoles.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn một vai trò hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Sử dụng ép kiểu an toàn với null
                int roleId = cmbRoles.SelectedValue as int? ?? -1;
                if (roleId == -1)
                {
                    MessageBox.Show("Vai trò không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật thông tin RoleAccount
                currentRoleAccount.AccountName = txtAccountName.Text.Trim();
                currentRoleAccount.RoleID = roleId;
                currentRoleAccount.Actived = chkActive.Checked;

                // Gọi Business Logic để cập nhật
                RoleAccountBL roleAccountBL = new RoleAccountBL();
                int result = roleAccountBL.Update(currentRoleAccount);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật quyền thành công!");
                    LoadRoleAccountsToListView();
                }
                else
                {
                    MessageBox.Show("Cập nhật quyền thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentRoleAccount == null)
                {
                    MessageBox.Show("Vui lòng chọn tài khoản để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                RoleAccountBL roleAccountBL = new RoleAccountBL();
                int result = roleAccountBL.Delete(currentRoleAccount);

                if (result > 0)
                {
                    MessageBox.Show("Xóa quyền thành công!");
                    LoadRoleAccountsToListView();
                }
                else
                {
                    MessageBox.Show("Xóa quyền thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void cmdAssign_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đầu vào: tên tài khoản không được để trống
                if (string.IsNullOrEmpty(txtAccountName.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra đầu vào: vai trò phải được chọn
                if (cmbRoles.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn vai trò!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy thông tin từ các ô nhập liệu
                RoleAccount roleAccount = new RoleAccount
                {
                    AccountName = txtAccountName.Text.Trim(),
                    RoleID = (int)cmbRoles.SelectedValue,
                    Actived = chkActive.Checked
                };

                // Gọi tầng Business Logic để gán quyền
                RoleAccountBL roleAccountBL = new RoleAccountBL();
                int result = roleAccountBL.AssignRole(roleAccount.AccountName, roleAccount.RoleID, roleAccount.Actived);

                // Kiểm tra kết quả
                if (result > 0)
                {
                    MessageBox.Show("Gán quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRoleAccountsToListView(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Gán quyền thất bại! Tài khoản có thể chưa tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
