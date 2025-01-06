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
    public partial class FoodForm : Form
    {
        private RestaurantContext dbContext;

        public FoodForm()
        {
            InitializeComponent();
            dbContext = new RestaurantContext();
            LoadCategories();
            LoadFood();
        }

        // a.Hiển thị món ăn theo nhóm món ăn
        // Load Categories into ComboBox
        private void LoadCategories()
        {
            var categories = dbContext.Categories!.Select(c => new { c.Id, c.Name }).ToList();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
        }

        // Load Food into ListView
        private void LoadFood()
        {
            lvFood.Items.Clear(); // Clear previous items
            var foods = dbContext.Foods!.Select(f => new
            {
                f.Id,
                f.Name,
                f.Unit,
                CategoryName = f.Category!.Name,
                f.Price,
                f.Notes
            }).ToList();

            foreach (var food in foods)
            {
                var item = new ListViewItem(food.Id.ToString());
                item.SubItems.Add(food.Name);
                item.SubItems.Add(food.Unit);
                item.SubItems.Add(food.CategoryName);
                item.SubItems.Add(food.Price.ToString());
                item.SubItems.Add(food.Notes);
                lvFood.Items.Add(item);
            }
        }

        // b.Tìm kiếm món ăn theo tên
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text.Trim();
            var foods = dbContext.Foods!
                .Where(f => f.Name!.Contains(searchName))
                .Select(f => new
                {
                    f.Id,
                    f.Name,
                    f.Unit,
                    CategoryName = f.Category!.Name,
                    f.Price,
                    f.Notes
                }).ToList();

            lvFood.Items.Clear(); // Clear previous items
            foreach (var food in foods)
            {
                var item = new ListViewItem(food.Id.ToString());
                item.SubItems.Add(food.Name);
                item.SubItems.Add(food.Unit);
                item.SubItems.Add(food.CategoryName);
                item.SubItems.Add(food.Price.ToString());
                item.SubItems.Add(food.Notes);
                lvFood.Items.Add(item);
            }
        }

        // c.Thêm, sửa món ăn
        private void btnSave_Click(object sender, EventArgs e)
        {
            int categoryId = (int)cbCategory.SelectedValue!;
            var food = new Food
            {
                Name = txtName.Text,
                Unit = txtUnit.Text,
                FoodCategoryId = categoryId,
                Price = int.Parse(txtPrice.Text),
                Notes = txtNotes.Text
            };

            if (string.IsNullOrEmpty(txtId.Text))
            {
                dbContext.Foods!.Add(food);
            }
            else
            {
                int foodId = int.Parse(txtId.Text);
                var existingFood = dbContext.Foods!.Find(foodId);
                if (existingFood != null)
                {
                    existingFood.Name = food.Name;
                    existingFood.Unit = food.Unit;
                    existingFood.FoodCategoryId = food.FoodCategoryId;
                    existingFood.Price = food.Price;
                    existingFood.Notes = food.Notes;
                }
            }

            dbContext.SaveChanges();
            LoadFood();
        }

        // d.Xóa các món ăn đã chọn từ danh sách
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvFood.CheckedItems)
            {
                int foodId = int.Parse(item.Text); // First column contains Id
                var food = dbContext.Foods!.Find(foodId);
                if (food != null)
                {
                    dbContext.Foods.Remove(food);
                }
            }

            dbContext.SaveChanges();
            LoadFood();
        }

        // e.Thêm nhóm món ăn
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            // Chuyển đổi chuỗi thành CategoryType
            if (Enum.TryParse(txtCategoryType.Text, out CategoryType categoryType))
            {
                var category = new Category
                {
                    Name = txtCategoryName.Text,
                    Type = categoryType // Gán giá trị enum
                };

                dbContext.Categories!.Add(category);
                dbContext.SaveChanges();
                LoadCategories();
            }
            else
            {
                // Hiển thị thông báo lỗi nếu loại không hợp lệ
                MessageBox.Show("Loại nhóm món ăn không hợp lệ. Vui lòng nhập 'Drink' hoặc 'Food'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
