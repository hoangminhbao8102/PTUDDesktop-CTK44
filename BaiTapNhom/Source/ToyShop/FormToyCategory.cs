using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyShop.BLL.ToyCategoryService;
using ToyShop.DAL.Entities;

namespace ToyShop
{
    public partial class FormToyCategory : Form
    {
        private readonly IToyCategoryService _toyCategoryService;

        public FormToyCategory(IToyCategoryService toyCategoryService)
        {
            InitializeComponent();
            _toyCategoryService = toyCategoryService;
            LoadToyCategories();
        }

        private void LoadToyCategories()
        {
            listViewToyCategory.Items.Clear();
            var categories = _toyCategoryService.GetAllToyCategories();
            foreach (var category in categories)
            {
                var item = new ListViewItem(category.CategoryID.ToString());
                item.SubItems.Add(category.CategoryName);
                listViewToyCategory.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var category = new ToyCategory
            {
                CategoryName = txtCategoryName.Text
            };
            _toyCategoryService.CreateToyCategory(category);
            LoadToyCategories();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listViewToyCategory.SelectedItems.Count > 0)
            {
                var selectedItem = listViewToyCategory.SelectedItems[0];
                var categoryId = int.Parse(selectedItem.Text);
                var category = _toyCategoryService.GetToyCategoryById(categoryId);
                category.CategoryName = txtCategoryName.Text;
                _toyCategoryService.UpdateToyCategory(category);
                LoadToyCategories();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewToyCategory.SelectedItems.Count > 0)
            {
                var selectedItem = listViewToyCategory.SelectedItems[0];
                var categoryId = int.Parse(selectedItem.Text);
                _toyCategoryService.DeleteToyCategory(categoryId);
                LoadToyCategories();
            }
        }
    }
}
