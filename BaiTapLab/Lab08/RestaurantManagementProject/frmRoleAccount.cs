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
    public partial class frmRoleAccount : Form
    {
        // Danh sách toàn cục bảng Role
        List<Role> listRole = new List<Role>();
        // Danh sách toàn cục bảng RoleAccount
        List<RoleAccount> listRoleAccount = new List<RoleAccount>();
        // Đối tượng RoleAccount hiện hành
        RoleAccount currentRoleAccount = new RoleAccount();

        public frmRoleAccount()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            // Gán các ô bằng giá trị mặc định
            txtAccountName.Text = "";
            chkActivatedYes.Checked = false;
            txtNotes.Text = "";

            // Thiết lập index = 0 cho ComboBox
            if (cbbRole.Items.Count > 0)
                cbbRole.SelectedIndex = 0;
        }

        private void LoadRoles()
        {
            // Khởi tạo đối tượng RoleBL từ tầng BusinessLogic
            RoleBL roleBL = new RoleBL();

            // Lấy danh sách vai trò từ tầng BusinessLogic
            listRole = roleBL.GetAll();

            // Gán dữ liệu vào ComboBox với ValueMember là ID và DisplayMember là RoleName
            cbbRole.DataSource = listRole;
            cbbRole.ValueMember = "ID";
            cbbRole.DisplayMember = "RoleName";
        }

        private void LoadRoleAccountDataToListView()
        {
            // Khởi tạo đối tượng RoleAccountBL từ tầng BusinessLogic
            RoleAccountBL roleAccountBL = new RoleAccountBL();

            // Lấy danh sách RoleAccount từ tầng BusinessLogic
            listRoleAccount = roleAccountBL.GetAll();

            // Biến số thứ tự cho từng dòng
            int count = 1;

            // Xoá dữ liệu cũ trong ListView
            lsvRoleAccount.Items.Clear();

            // Duyệt danh sách dữ liệu để hiển thị trong ListView
            foreach (var roleAccount in listRoleAccount)
            {
                if (roleAccount == null)
                    continue;

                // Tạo một dòng trong ListView, bắt đầu bằng số thứ tự
                ListViewItem item = new ListViewItem(count.ToString());

                // Thêm các cột dữ liệu
                item.SubItems.Add(roleAccount.AccountName ?? "N/A"); // Tên tài khoản
                item.SubItems.Add(roleAccount.Actived ? "Yes" : "No"); // Trạng thái kích hoạt
                var role = listRole.Find(x => x.ID == roleAccount.RoleID);
                item.SubItems.Add(role?.RoleName ?? "Unknown Role");
                item.SubItems.Add(roleAccount.Notes ?? "No notes");

                // Thêm dòng vào ListView
                lsvRoleAccount.Items.Add(item);
                count++;
            }
        }

        private void frmRoleAccount_Load(object sender, EventArgs e)
        {
            // Đổ dữ liệu vào ComboBox
            LoadRoles();
            // Đổ dữ liệu vào ListView
            LoadRoleAccountDataToListView();
        }

        private void lsvRoleAccount_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsvRoleAccount.Items.Count; i++)
            {
                if (lsvRoleAccount.Items[i].Selected)
                {
                    // Lấy dữ liệu và gán vào các ô
                    currentRoleAccount = listRoleAccount[i];
                    txtAccountName.Text = currentRoleAccount.AccountName;
                    chkActivatedYes.Checked = currentRoleAccount.Actived;
                    cbbRole.SelectedIndex = listRole.FindIndex(x => x.ID == currentRoleAccount.RoleID);
                    txtNotes.Text = currentRoleAccount.Notes;
                }
            }
        }

        public int InsertRoleAccount()
        {
            RoleAccount roleAccount = new RoleAccount();

            if (string.IsNullOrEmpty(txtAccountName?.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản.");
                return -1;
            }

            roleAccount.AccountName = txtAccountName?.Text ?? string.Empty;
            roleAccount.Actived = chkActivatedYes?.Checked ?? false;
            roleAccount.Notes = txtNotes?.Text ?? string.Empty;

            if (cbbRole?.SelectedValue != null && int.TryParse(cbbRole.SelectedValue.ToString(), out int roleId))
                roleAccount.RoleID = roleId;
            else
            {
                MessageBox.Show("Vui lòng chọn vai trò hợp lệ.");
                return -1;
            }

            RoleAccountBL roleAccountBL = new RoleAccountBL();
            return roleAccountBL.Insert(roleAccount);
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (InsertRoleAccount() > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
                LoadRoleAccountDataToListView();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không thành công.");
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (currentRoleAccount == null || string.IsNullOrEmpty(currentRoleAccount.AccountName))
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xoá.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xoá tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RoleAccountBL roleAccountBL = new RoleAccountBL();
                if (roleAccountBL.Delete(currentRoleAccount) > 0)
                {
                    MessageBox.Show("Xoá thành công!");
                    LoadRoleAccountDataToListView();
                }
                else
                {
                    MessageBox.Show("Xoá không thành công.");
                }
            }
        }

        public int UpdateRoleAccount()
        {
            if (currentRoleAccount == null)
            {
                MessageBox.Show("Không có tài khoản hiện hành để cập nhật.");
                return -1;
            }

            currentRoleAccount.AccountName = txtAccountName?.Text ?? string.Empty;
            currentRoleAccount.Actived = chkActivatedYes?.Checked ?? false;
            currentRoleAccount.Notes = txtNotes?.Text ?? string.Empty;

            if (cbbRole?.SelectedValue != null && int.TryParse(cbbRole.SelectedValue.ToString(), out int roleId))
                currentRoleAccount.RoleID = roleId;
            else
            {
                MessageBox.Show("Vui lòng chọn vai trò hợp lệ.");
                return -1;
            }

            RoleAccountBL roleAccountBL = new RoleAccountBL();
            return roleAccountBL.Update(currentRoleAccount);
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (UpdateRoleAccount() > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadRoleAccountDataToListView();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công.");
            }
        }
    }
}
