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
    public partial class UpdateFoodForm : Form
    {
        private RestaurantContext _dbContext;
        private int _foodId;

        public UpdateFoodForm(int? foodId = null)
        {
            InitializeComponent();

            _dbContext = new RestaurantContext();
            _foodId = foodId ?? 0;
        }

        private void LoadCategoriesToComboBox()
        {
            // Lấy tất cả danh mục thức ăn, sắp tăng theo tên
            var categories = _dbContext.Categories!.OrderBy(x => x.Name).ToList();

            // Nạp danh mục và ComboBox, hiển thị tên cho người dùng xem nhưng khi chọn thì lấy giá trị là ID
            cbbFoodCategory.DisplayMember = "Name";
            cbbFoodCategory.ValueMember = "Id";
            cbbFoodCategory.DataSource = categories;
        }

        private Food? GetFoodById(int foodId)
        {
            // Tìm món ăn theo mã số
            return foodId > 0 ? _dbContext.Foods!.Find(foodId) : null;
        }

        private void ShowFoodInformation()
        {
            // Tìm món ăn theo mã số đã được truyền vào Form
            var food = GetFoodById(_foodId);

            // Nếu không tìm thấy, không cần làm gì cả
            if (food == null)
            {
                return;
            }

            // Ngược lại, hiển thị thông tin món ăn lên Form
            txtFoodId.Text = food.Id.ToString();
            txtFoodName.Text = food.Name;
            cbbFoodCategory.SelectedValue = food.FoodCategoryId;
            txtFoodUnit.Text = food.Unit;
            nudFoodPrice.Value = food.Price;
            txtFoodNotes.Text = food.Notes;
        }

        private bool ValidateUserInput()
        {
            // Kiểm tra tên món ăn đã được nhập hay chưa
            if (string.IsNullOrWhiteSpace(txtFoodName.Text))
            {
                MessageBox.Show("Tên món ăn, đồ uống không được để trống", "Thông báo");
                return false;
            }

            // Kiểm tra đơn vị tính đã được nhập hay chưa
            if (string.IsNullOrWhiteSpace(txtFoodUnit.Text))
            {
                MessageBox.Show("Đơn vị tính không được để trống", "Thông báo");
                return false;
            }

            // Kiểm tra giá món ăn đã được nhập hay chưa
            if (nudFoodPrice.Value.Equals(0))
            {
                MessageBox.Show("Giá của thức ăn phải lớn hơn 0", "Thông báo");
                return false;
            }

            // Kiểm tra nhóm món ăn đã chọn nhập hay chưa
            if (cbbFoodCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn nhóm thức ăn", "Thông báo");
                return false;
            }

            return true;
        }

        private Food GetUpdatedFood()
        {
            // Kiểm tra và lấy giá trị của SelectedValue an toàn
            var selectedCategoryValue = cbbFoodCategory.SelectedValue;
            int foodCategoryId = selectedCategoryValue is int ? (int)selectedCategoryValue : 0;

            // Lấy giá trị của nudFoodPrice.Value an toàn
            decimal foodPriceValue = nudFoodPrice.Value;
            int price = (int)Math.Round(foodPriceValue);

            // Tạo đối tượng Food với thông tin được lấy từ các điều kiện trên Form
            var food = new Food()
            {
                Name = txtFoodName.Text.Trim(),
                FoodCategoryId = foodCategoryId,
                Unit = txtFoodUnit.Text.Trim(),
                Price = price,
                Notes = txtFoodNotes.Text.Trim()
            };

            // Gán giá trị của ID ban đầu (nếu đang cập nhật)
            if (_foodId > 0)
            {
                food.Id = _foodId;
            }

            return food;
        }

        private void UpdateFoodForm_Load(object sender, EventArgs e)
        {
            // Nạp danh sách nhóm thức ăn vào ComboBox
            LoadCategoriesToComboBox();

            // Hiển thị thông tin món ăn lên Form
            ShowFoodInformation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra nuế dữ liệu nhập vào là hợp lệ
            if (ValidateUserInput())
            {
                // Thì lấy thông tin người dùng nhập vào
                var newFood = GetUpdatedFood();

                // Và thử tìm xem đã có món ăn tron CSDL chưa
                var oldFood = GetFoodById(_foodId);

                // Nếu chưa có (chưa tồn tại)
                if (oldFood == null)
                {
                    // Thì thêm món ăn mới
                    _dbContext.Foods!.Add(newFood);
                }
                else
                {
                    // Ngược lại, cập nhật thông tin món ăn
                    oldFood.Name = newFood.Name;
                    oldFood.FoodCategoryId = newFood.FoodCategoryId;
                    oldFood.Unit = newFood.Unit;
                    oldFood.Price = newFood.Price;
                    oldFood.Notes = newFood.Notes;
                }

                // Lưu các thay đổi xuống CSDL
                _dbContext.SaveChanges();

                // Đóng hộp thoại
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
