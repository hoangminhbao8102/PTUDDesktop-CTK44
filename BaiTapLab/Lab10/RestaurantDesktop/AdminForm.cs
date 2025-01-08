using Restaurant.BLL.Menu;
using Restaurant.DAL;
using Restaurant.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantDesktop
{
    public partial class AdminForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICategoryService _categoryService;
        private readonly IFoodService _foodService;

        public AdminForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _categoryService = new CategoryService(_unitOfWork);
            _foodService = new FoodService(_unitOfWork);

            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            lvCategories.Items.Clear(); // `lvCategories` là ListView hiển thị danh mục
            var categories = _categoryService.GetAllCategories();

            foreach (var category in categories)
            {
                var item = new ListViewItem(category.Id.ToString()); // Cột ID
                item.SubItems.Add(category.Name ?? "");              // Cột Tên danh mục
                item.SubItems.Add(category.Type.ToString());         // Cột Loại danh mục
                lvCategories.Items.Add(item);
            }
        }

        private void LoadFoods(int categoryId)
        {
            lvFoods.Items.Clear(); // `lvFoods` là ListView hiển thị món ăn
            var foods = _foodService.GetFoodByCategory(categoryId);

            foreach (var food in foods)
            {
                var item = new ListViewItem(food.Id.ToString());    // Cột ID món ăn
                item.SubItems.Add(food.Name ?? "");                // Cột Tên món ăn
                item.SubItems.Add(food.Unit ?? "");                // Cột Đơn vị
                item.SubItems.Add(food.Price.ToString());          // Cột Giá
                item.SubItems.Add(food.Notes ?? "");               // Cột Ghi chú
                lvFoods.Items.Add(item);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var name = txtCategoryName.Text; // TextBox nhập tên danh mục
            var type = (CategoryType)cbbCategoryType.SelectedItem!; // ComboBox chọn loại danh mục

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var category = new Category { Name = name, Type = type };
            _categoryService.Insert(category);
            _unitOfWork.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

            LoadCategories();
            MessageBox.Show("Thêm danh mục thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (lvCategories.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn danh mục cần sửa", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var selectedItem = lvCategories.SelectedItems[0];
            var categoryId = int.Parse(selectedItem.Text); // Lấy ID từ cột đầu tiên
            var category = _categoryService.GetCategoryById(categoryId);

            var name = txtCategoryName.Text;
            var type = (CategoryType)cbbCategoryType.SelectedItem!;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            category.Name = name;
            category.Type = type;
            _categoryService.Update(category);
            _unitOfWork.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

            LoadCategories();
            MessageBox.Show("Cập nhật danh mục thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (lvCategories.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn danh mục cần xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var selectedItem = lvCategories.SelectedItems[0];
            var categoryId = int.Parse(selectedItem.Text);

            var result = MessageBox.Show("Bạn có chắc muốn xóa danh mục này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _categoryService.DeleteCategory(categoryId);
                _unitOfWork.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                LoadCategories();
                MessageBox.Show("Xóa danh mục thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var name = txtFoodName.Text;          // TextBox nhập tên món ăn
            var unit = txtUnit.Text;              // TextBox nhập đơn vị
            var price = int.Parse(txtPrice.Text); // TextBox nhập giá
            var notes = txtNotes.Text;            // TextBox nhập ghi chú
            var categoryId = (int)cbbCategory.SelectedValue!; // ComboBox chọn danh mục món ăn

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var food = new Food
            {
                Name = name,
                Unit = unit,
                Price = price,
                Notes = notes,
                FoodCategoryId = categoryId
            };

            _foodService.Insert(food);
            _unitOfWork.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

            LoadFoods(categoryId);
            MessageBox.Show("Thêm món ăn thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            if (lvFoods.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần sửa", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var selectedItem = lvFoods.SelectedItems[0];
            var foodId = int.Parse(selectedItem.Text); // Lấy ID từ cột đầu tiên
            var food = _foodService.GetFoodById(foodId);

            var name = txtFoodName.Text;
            var unit = txtUnit.Text;
            var price = int.Parse(txtPrice.Text);
            var notes = txtNotes.Text;
            var categoryId = (int)cbbCategory.SelectedValue!;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            food.Name = name;
            food.Unit = unit;
            food.Price = price;
            food.Notes = notes;
            food.FoodCategoryId = categoryId;

            _foodService.Update(food);
            _unitOfWork.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

            LoadFoods(categoryId);
            MessageBox.Show("Cập nhật món ăn thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (lvFoods.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var selectedItem = lvFoods.SelectedItems[0];
            var foodId = int.Parse(selectedItem.Text);

            var result = MessageBox.Show("Bạn có chắc muốn xóa món ăn này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _foodService.DeleteFood(foodId);
                _unitOfWork.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                var categoryId = (int)cbbCategory.SelectedValue!;
                LoadFoods(categoryId);

                MessageBox.Show("Xóa món ăn thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
