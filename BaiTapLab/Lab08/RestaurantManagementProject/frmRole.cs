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
    public partial class frmRole : Form
    {
        // Danh sách toàn cục bảng Role
        List<Role> listRole = new List<Role>();
        // Đối tượng Role đang chọn hiện hành
        Role roleCurrent = new Role();

        public frmRole()
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
            txtRoleName.Text = "";
            txtPath.Text = "";
            txtNotes.Text = "";
        }

        private void LoadRoleDataToListView()
        {
            // Khởi tạo đối tượng RoleBL từ tầng BusinessLogic
            RoleBL roleBL = new RoleBL();

            // Lấy danh sách Role từ tầng BusinessLogic
            listRole = roleBL.GetAll();

            // Biến số thứ tự cho từng dòng
            int count = 1;

            // Xoá dữ liệu cũ trong ListView
            lsvRole.Items.Clear();

            // Duyệt danh sách dữ liệu để hiển thị trong ListView
            foreach (var role in listRole)
            {
                // Kiểm tra nếu dữ liệu Role là null
                if (role == null)
                {
                    continue;
                }

                // Tạo một dòng trong ListView, bắt đầu bằng số thứ tự
                ListViewItem item = new ListViewItem(count.ToString());

                // Thêm các cột dữ liệu
                item.SubItems.Add(role.RoleName ?? "N/A"); // Tên Role (hoặc "N/A" nếu null)
                item.SubItems.Add(role.Path ?? "N/A");    // Path (hoặc "N/A" nếu null)
                item.SubItems.Add(role.Notes ?? "No notes"); // Ghi chú (hoặc "No notes" nếu null)

                // Thêm dòng vào ListView
                lsvRole.Items.Add(item);

                // Tăng số thứ tự
                count++;
            }
        }

        private void frmRole_Load(object sender, EventArgs e)
        {
            // Đổ dữ liệu vào ListView
            LoadRoleDataToListView();
        }

        private void lsvRole_Click(object sender, EventArgs e)
        {
            // Duyệt toàn bộ dữ liệu trong ListView
            for (int i = 0; i < lsvRole.Items.Count; i++)
            {
                // Nếu có dòng được chọn thì lấy dòng đó
                if (lsvRole.Items[i].Selected)
                {
                    // Lấy các tham số và gán dữ liệu vào các ô
                    roleCurrent = listRole[i];
                    txtRoleName.Text = roleCurrent.RoleName;
                    txtPath.Text = roleCurrent.Path;
                    txtNotes.Text = roleCurrent.Notes;
                }
            }
        }

        /// <summary>
        /// Phương thức thêm dữ liệu cho bảng Role
        /// </summary>
        /// <returns>Trả về số dương nếu thành công, ngược lại trả về số âm</returns>
        public int InsertRole()
        {
            // Khai báo đối tượng Role từ tầng DataAccess
            Role role = new Role();
            role.ID = 0;

            // Kiểm tra nếu các ô nhập khác rỗng
            if (string.IsNullOrEmpty(txtRoleName?.Text) || string.IsNullOrEmpty(txtPath?.Text))
            {
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            }
            else
            {
                // Nhận giá trị RoleName, Path, và Notes từ người dùng nhập vào
                role.RoleName = txtRoleName?.Text ?? string.Empty;
                role.Path = txtPath?.Text ?? string.Empty;
                role.Notes = txtNotes?.Text ?? string.Empty;

                // Khai báo đối tượng RoleBL từ tầng Business
                RoleBL roleBL = new RoleBL();
                // Chèn dữ liệu vào bảng
                return roleBL.Insert(role);
            }
            return -1;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra giá trị của txtRoleName
                if (string.IsNullOrWhiteSpace(txtRoleName.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên Role.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng Role từ dữ liệu nhập
                Role role = new Role
                {
                    RoleName = txtRoleName.Text.Trim(),
                    Path = txtPath.Text.Trim(),
                    Notes = txtNotes.Text.Trim()
                };

                // Gọi phương thức thêm dữ liệu
                int result = new RoleBL().Insert(role);

                // Kiểm tra kết quả
                if (result > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!");
                    LoadRoleDataToListView();
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong quá trình thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra Role hiện tại
                if (roleCurrent == null || roleCurrent.ID <= 0)
                {
                    MessageBox.Show("Vui lòng chọn Role để xoá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận từ người dùng
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá Role này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int result = new RoleBL().Delete(roleCurrent);

                    // Kiểm tra kết quả
                    if (result > 0)
                    {
                        MessageBox.Show("Xoá Role thành công!");
                        LoadRoleDataToListView();
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công. Vui lòng thử lại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong quá trình xoá dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int UpdateRole()
        {
            // Kiểm tra nếu đối tượng Role hiện hành có giá trị
            if (roleCurrent == null)
            {
                MessageBox.Show("Không có dữ liệu Role hiện hành để cập nhật.");
                return -1;
            }

            // Khai báo đối tượng Role và lấy đối tượng hiện hành
            Role role = roleCurrent;

            // Kiểm tra nếu các ô nhập khác rỗng
            if (string.IsNullOrEmpty(txtRoleName?.Text) || string.IsNullOrEmpty(txtPath?.Text))
            {
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            }
            else
            {
                // Nhận giá trị RoleName, Path, và Notes khi người dùng sửa
                role.RoleName = txtRoleName?.Text ?? string.Empty;
                role.Path = txtPath?.Text ?? string.Empty;
                role.Notes = txtNotes?.Text ?? string.Empty;

                // Khai báo đối tượng RoleBL từ tầng Business
                RoleBL roleBL = new RoleBL();

                // Cập nhật dữ liệu trong bảng
                return roleBL.Update(role);
            }

            return -1;
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra Role hiện tại
                if (roleCurrent == null || roleCurrent.ID <= 0)
                {
                    MessageBox.Show("Vui lòng chọn Role để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng Role từ dữ liệu nhập
                Role role = new Role
                {
                    ID = roleCurrent.ID,
                    RoleName = txtRoleName.Text.Trim(),
                    Path = txtPath.Text.Trim(),
                    Notes = txtNotes.Text.Trim()
                };

                // Gọi phương thức cập nhật dữ liệu
                int result = new RoleBL().Update(role);

                // Kiểm tra kết quả
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                    LoadRoleDataToListView();
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu không thành công. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong quá trình cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
