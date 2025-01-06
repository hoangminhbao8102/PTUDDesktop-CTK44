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
    public partial class MenuForm : Form
    {
        private RestaurantContext _context;

        public MenuForm()
        {
            InitializeComponent();
            _context = new RestaurantContext();
        }

        private void LoadCategories()
        {
            // Lấy danh sách nhóm món ăn từ CategoryModel
            var categories = _context.Categories!
                .Select(c => new { c.Id, Name = c.Name ?? string.Empty }) // Đảm bảo Name không null
                .ToList();

            categories.Insert(0, new { Id = 0, Name = "Tất cả" }); // Thêm tùy chọn "Tất cả"
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";
        }

        private void LoadFoodsToListView(int categoryId = 0)
        {
            // Xóa tất cả các mục trước khi nạp lại
            listViewFoods.Items.Clear();

            // Lấy danh sách món ăn từ FoodModel
            var foods = _context.Foods!
                .Where(f => categoryId == 0 || f.Category!.Id == categoryId)
                .Select(f => new FoodModel
                {
                    Id = f.Id,
                    Name = f.Name,
                    Unit = f.Unit,
                    CategoryName = f.Category!.Name,
                    Price = f.Price,
                    Notes = f.Notes
                })
                .ToList();

            // Duyệt qua danh sách món ăn và thêm vào ListView
            foreach (var food in foods)
            {
                var item = new ListViewItem(food.Name);
                item.SubItems.Add(food.Unit);
                item.SubItems.Add(food.CategoryName);
                item.SubItems.Add(food.Price.ToString());
                item.SubItems.Add(food.Notes);
                listViewFoods.Items.Add(item);
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedValue is int selectedCategoryId)
            {
                LoadFoodsToListView(selectedCategoryId);
            }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            LoadFoodsToListView();
        }

        private void buttonPrintMenu_Click(object sender, EventArgs e)
        {
            // Tạo danh sách thực đơn từ ListView
            var menuItems = new List<string>();

            foreach (ListViewItem item in listViewFoods.Items)
            {
                var name = item.Text;
                var unit = item.SubItems[1].Text;
                var category = item.SubItems[2].Text;
                var price = item.SubItems[3].Text;
                var notes = item.SubItems[4].Text;

                menuItems.Add($"Tên món: {name}, Đơn vị: {unit}, Nhóm: {category}, Giá: {price}, Ghi chú: {notes}");
            }

            // Hiển thị danh sách thực đơn dưới dạng hộp thoại hoặc xử lý in
            var menuContent = string.Join(Environment.NewLine, menuItems);
            MessageBox.Show(menuContent, "Thực đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
