using BusinessLogic;
using DataAccess;
using Microsoft.Data.SqlClient;
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
    public partial class frmCategory : Form
    {
        // Danh sách toàn cục bảng Category
        List<Category> listCategory = new List<Category>();

        // Đối tượng Category hiện tại
        Category categoryCurrent = new Category();

        public frmCategory()
        {
            InitializeComponent();
        }

        private void LoadCategoryDataToListView()
        {
            // Khởi tạo đối tượng CategoryBL từ tầng BusinessLogic
            CategoryBL categoryBL = new CategoryBL();

            // Lấy danh sách danh mục từ tầng BusinessLogic
            listCategory = categoryBL.GetAll();

            // Biến số thứ tự cho từng dòng
            int count = 1;

            // Xóa dữ liệu cũ trong ListView
            lsvCategory.Items.Clear();

            // Duyệt danh sách dữ liệu để hiển thị trong ListView
            foreach (var category in listCategory)
            {
                // Kiểm tra nếu dữ liệu null
                if (category == null)
                {
                    continue;
                }

                // Tạo một dòng trong ListView, bắt đầu bằng số thứ tự
                ListViewItem item = new ListViewItem(count.ToString());

                // Thêm các cột dữ liệu
                item.SubItems.Add(category.Name ?? "N/A"); // Tên danh mục
                item.SubItems.Add(category.Type.ToString()); // Loại danh mục

                // Thêm dòng vào ListView
                lsvCategory.Items.Add(item);

                // Tăng số thứ tự
                count++;
            }

            lblStatistic.Text = $"Tổng số danh mục: {listCategory.Count}";
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu ComboBox cbbType
            cbbType.Items.Clear();
            cbbType.Items.Add("0 - Đồ uống");   // Ví dụ: Loại 1
            cbbType.Items.Add("1 - Thức ăn"); // Ví dụ: Loại 0
            cbbType.SelectedIndex = 0;

            // Đổ dữ liệu vào ListView
            LoadCategoryDataToListView();
        }

        private void lsvCategory_Click(object sender, EventArgs e)
        {
            // Duyệt toàn bộ dữ liệu trong ListView
            for (int i = 0; i < lsvCategory.Items.Count; i++)
            {
                // Nếu có dòng được chọn thì lấy dòng đó
                if (lsvCategory.Items[i].Selected)
                {
                    // Lấy các tham số và gán dữ liệu vào các ô
                    categoryCurrent = listCategory[i];
                    txtName.Text = categoryCurrent.Name;

                    // Chọn đúng giá trị trong ComboBox
                    cbbType.SelectedIndex = categoryCurrent.Type;
                }
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            // Gán các ô bằng giá trị mặc định
            txtName.Text = "";
            if (cbbType.Items.Count > 0)
            {
                cbbType.SelectedIndex = 0; // Đặt giá trị mặc định cho ComboBox
            }
        }

        private int InsertCategory()
        {
            if (string.IsNullOrEmpty(txtName?.Text))
            {
                MessageBox.Show("Chưa nhập tên danh mục, vui lòng nhập lại.");
                return -1;
            }

            Category category = new Category
            {
                Name = txtName.Text.Trim(),
                Type = cbbType.SelectedIndex
            };

            CategoryBL categoryBL = new CategoryBL();
            int result = categoryBL.Insert(category);

            if (result > 0)
            {
                MessageBox.Show("Thêm danh mục thành công!");
            }
            else
            {
                MessageBox.Show("Thêm danh mục không thành công. Vui lòng thử lại.");
            }

            return result;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int result = InsertCategory();

                if (result > 0)
                {
                    MessageBox.Show("Thêm danh mục thành công!");
                    LoadCategoryDataToListView();
                }
                else
                {
                    MessageBox.Show("Thêm danh mục không thành công. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong quá trình thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int UpdateCategory()
        {
            if (categoryCurrent == null || categoryCurrent.ID <= 0)
            {
                MessageBox.Show("Vui lòng chọn danh mục để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }

            categoryCurrent.Name = txtName.Text.Trim();
            categoryCurrent.Type = cbbType.SelectedIndex;

            CategoryBL categoryBL = new CategoryBL();
            int result = categoryBL.Update(categoryCurrent);

            if (result > 0)
            {
                MessageBox.Show("Cập nhật danh mục thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật danh mục không thành công. Vui lòng thử lại.");
            }

            return result;
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int result = UpdateCategory();

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật danh mục thành công!");
                    LoadCategoryDataToListView();
                }
                else
                {
                    MessageBox.Show("Cập nhật danh mục không thành công. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong quá trình cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoryCurrent == null || categoryCurrent.ID <= 0)
                {
                    MessageBox.Show("Vui lòng chọn danh mục để xoá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xoá danh mục này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int result = new CategoryBL().Delete(categoryCurrent.ID);

                    if (result > 0)
                    {
                        MessageBox.Show("Xoá danh mục thành công!");
                        LoadCategoryDataToListView();
                    }
                    else
                    {
                        MessageBox.Show("Xoá danh mục không thành công. Vui lòng thử lại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong quá trình xoá dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
