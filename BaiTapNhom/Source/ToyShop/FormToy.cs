using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyShop.BLL.ToyService;
using ToyShop.DAL.Entities;

namespace ToyShop
{
    public partial class FormToy : Form
    {
        private readonly IToyService _toyService;

        public FormToy(IToyService toyService)
        {
            InitializeComponent();
            _toyService = toyService;
            LoadToys();
        }

        private void LoadToys()
        {
            listViewToy.Items.Clear();
            var toys = _toyService.GetAllToys();
            foreach (var toy in toys)
            {
                var item = new ListViewItem(toy.ToyID.ToString());
                item.SubItems.Add(toy.ToyName);
                item.SubItems.Add(toy.CategoryID.ToString());
                item.SubItems.Add(toy.Price.ToString());
                item.SubItems.Add(toy.StockQuantity.ToString());
                item.SubItems.Add(toy.Discount.ToString());
                listViewToy.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var toy = new Toy
            {
                ToyName = txtToyName.Text,
                CategoryID = int.Parse(cbCategoryID.Text),
                Price = decimal.Parse(nudPrice.Text),
                StockQuantity = int.Parse(nudStockQuantity.Text),
                Discount = decimal.Parse(nudDiscount.Text)
            };
            _toyService.CreateToy(toy);
            LoadToys();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listViewToy.SelectedItems.Count > 0)
            {
                var selectedItem = listViewToy.SelectedItems[0];
                var toyId = int.Parse(selectedItem.Text);
                var toy = _toyService.GetToyById(toyId);
                toy.ToyName = txtToyName.Text;
                toy.CategoryID = int.Parse(cbCategoryID.Text);
                toy.Price = decimal.Parse(nudPrice.Text);
                toy.StockQuantity = int.Parse(nudStockQuantity.Text);
                toy.Discount = decimal.Parse(nudDiscount.Text);
                _toyService.UpdateToy(toy);
                LoadToys();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewToy.SelectedItems.Count > 0)
            {
                var selectedItem = listViewToy.SelectedItems[0];
                var toyId = int.Parse(selectedItem.Text);
                _toyService.DeleteToy(toyId);
                LoadToys();
            }
        }

        private void btnFilterByCategory_Click(object sender, EventArgs e)
        {
            var categoryID = int.Parse(txtCategoryID.Text);
            var filteredToys = _toyService.GetToysByCategory(categoryID);
            listViewToy.Items.Clear();
            foreach (var toy in filteredToys)
            {
                var item = new ListViewItem(toy.ToyID.ToString());
                item.SubItems.Add(toy.ToyName);
                item.SubItems.Add(toy.CategoryID.ToString());
                item.SubItems.Add(toy.Price.ToString());
                item.SubItems.Add(toy.StockQuantity.ToString());
                item.SubItems.Add(toy.Discount.ToString());
                listViewToy.Items.Add(item);
            }
        }

        private void btnSortByAlphabet_Click(object sender, EventArgs e)
        {
            var sortedToys = _toyService.GetToysSortedByName();
            listViewToy.Items.Clear();
            foreach (var toy in sortedToys)
            {
                var item = new ListViewItem(toy.ToyID.ToString());
                item.SubItems.Add(toy.ToyName);
                item.SubItems.Add(toy.CategoryID.ToString());
                item.SubItems.Add(toy.Price.ToString());
                item.SubItems.Add(toy.StockQuantity.ToString());
                item.SubItems.Add(toy.Discount.ToString());
                listViewToy.Items.Add(item);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var keyword = txtKeyword.Text;
            var results = _toyService.SearchToys(keyword);
            listViewToy.Items.Clear();
            foreach (var toy in results)
            {
                var item = new ListViewItem(toy.ToyID.ToString());
                item.SubItems.Add(toy.ToyName);
                item.SubItems.Add(toy.CategoryID.ToString());
                item.SubItems.Add(toy.Price.ToString());
                item.SubItems.Add(toy.StockQuantity.ToString());
                item.SubItems.Add(toy.Discount.ToString());
                listViewToy.Items.Add(item);
            }
        }
    }
}
