﻿using Lab09_Entity_Framework.Models;
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
    public partial class UpdateCategoryForm : Form
    {
        private RestaurantContext _dbContext;
        private int _categoryId;

        private Category? GetCategoryById(int categoryId)
        {
            // Nếu ID được truyền vào là hợp lệ, tìm thông tin theo ID
            // Ngược lại, trả về null
            return categoryId > 0 ? _dbContext.Categories!.Find(categoryId) : null;
        }

        private void ShowCategory()
        {
            // Lấy thông tin của nhóm thức ăn
            var category = GetCategoryById(_categoryId);

            // Nếu không tìm thấy thông tin, không cần làm gì cả
            if (category == null)
            {
                return;
            }

            // Ngược lại, nếu tìm thấy, hiển thị lên form
            txtCategoryId.Text = category.Id.ToString();
            txtCategoryName.Text = category.Name;
            cbbCategoryType.SelectedIndex = (int)category.Type;
        }

        private Category GetUpdatedCategory()
        {
            // Tạo đối tượng Category với thông tin đã nhập
            var category = new Category()
            {
                Name = txtCategoryName.Text.Trim(),
                Type = (CategoryType)cbbCategoryType.SelectedIndex
            };

            // Gán giá trị của ID ban đầu (nếu đang cập nhật)
            if (_categoryId > 0)
            {
                category.Id = _categoryId;
            }

            return category;
        }

        private bool ValidateUserInput()
        {
            // Kiểm tra tên nhóm thức ăn đã được nhập hay chưa
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Tên nhám thức ăn không được để trống", "Thông báo");
                return false;
            }

            // Kiểm tra loại nhón thức ăn đã chong hay chưa
            if (cbbCategoryType.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn loại nhóm thức ăn", "Thông báo");
                return false;
            }

            return true;
        }

        public UpdateCategoryForm(int? categoryId = null)
        {
            InitializeComponent();

            _dbContext = new RestaurantContext();
            _categoryId = categoryId ?? 0;
        }

        private void UpdateCategoryForm_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin nhóm thức ăn lên form
            ShowCategory();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu dữ liệu nhập vào là hợp lệ
            if (ValidateUserInput())
            {
                // Thì lấy thông tin người dùng nhập vào
                var newCategory = GetUpdatedCategory();

                // Và thử tìm xem đã có nhóm thức ăn trong CSDL chưa
                var oldCategory = GetCategoryById(_categoryId);

                // Nếu chưa có (chưa tồn tại)
                if (oldCategory == null)
                {
                    // Thì thêm nhóm thức ăn mới
                    _dbContext.Categories!.Add(newCategory);
                }
                else
                {
                    // Ngược lại, ta chỉ cần cập nhật thông tin cần thiết
                    oldCategory.Name = newCategory.Name;
                    oldCategory.Type = newCategory.Type;
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
