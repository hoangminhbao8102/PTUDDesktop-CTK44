﻿using Lab09_Entity_Framework.Models;

namespace Lab09_Entity_Framework
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<Category> GetCategories()
        {
            // Khởi tạo đối tượng context
            var dbContext = new RestaurantContext();

            // Lấy danh sách tất cả nhóm thức ăn, sắp xếp theo tên
            return dbContext.Categories!.OrderBy(x => x.Name).ToList();
        }

        private void ShowCategories()
        {
            // Xóa tất cả các nút hiện có trên cây
            tvwCategory.Nodes.Clear();

            // Tạo danh sách loại nhón thức ăn, đồ uống
            // Tên của các loại này được hiện thị trên các nút mức 2
            var cateMap = new Dictionary<CategoryType, string>()
            {
                [CategoryType.Food] = "Đồ ăn",
                [CategoryType.Drink] = "Thức uống"
            };

            // Tạo nút gốc của cây
            var rootNode = tvwCategory.Nodes.Add("Tất cả");

            // Lấy danh sách nhám đồ ăn, thức uống
            var categories = GetCategories();

            // Duyệt qua các loại nhóm thức ăn
            foreach (var cateType in cateMap)
            {
                // Tạo các nút tương ung81 với loại nhóm thức ăn
                var childNode = rootNode.Nodes.Add(cateType.Key.ToString(), cateType.Value);
                childNode.Tag = cateType.Key;

                // Duyệt qua các nhón thức ăn
                foreach (var category in categories)
                {
                    // Nếu nhóm đang xét không cùng loại thì bỏ qua
                    if (category.Type != cateType.Key)
                    {
                        continue;
                    }

                    // Ngược lại, tạo các nút tương ứng trên cây
                    var grantChildNode = childNode.Nodes.Add(category.Id.ToString(), category.Name);
                    grantChildNode.Tag = category;
                }
            }

            // Mở rộng các nhánh của cây để thấy hết tất cả các nhóm thức ăn
            tvwCategory.ExpandAll();

            // Đánh dấu nút gốc đang được chọn
            tvwCategory.SelectedNode = rootNode;
        }

        private List<FoodModel> GetFoodByCategory(int? categoryId)
        {
            // Khởi tạo đối tượng context
            var dbContext = new RestaurantContext();

            // Tạo truy vấn lấy danh sách món ăn
            var foods = dbContext.Foods!.AsQueryable();

            // Nếu mã nhóm món ăn khác null và hợp lệ
            if (categoryId != null && categoryId > 0)
            {
                // Thì tìm theo mã số nhóm thức ăn
                foods = foods.Where(x => x.FoodCategoryId == categoryId);
            }

            // Sắp xếp đồ ăn, thức uống theo tên và trả về danh sách chứa đầu đủ thông tin về món ăn
            return foods
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category!.Name
                })
                .ToList();
        }

        private List<FoodModel> GetFoodByCategoryType(CategoryType cateType)
        {
            var dbContext = new RestaurantContext();

            // Tìm các món ăn theo loại nhóm thức ăn (Category Type).
            // Sắp xếp đồ ăn, thức uống theo tên và trả về danh sách chứa đầu đủ thông tin về món ăn
            return dbContext.Foods!
                .Where(x => x.Category!.Type == cateType)
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category!.Name
                })
                .ToList();

        }

        private void ShowFoodsOnListView(List<FoodModel> foods)
        {
            // Duyệt qua từng phần tử của danh sách Food
            foreach (var foodItem in foods)
            {
                // Tạo item tương ứng trên ListView
                var item = lvwFood.Items.Add(foodItem.Id.ToString());

                // Và hiển thị các thông tin của món ăn
                item.SubItems.Add(foodItem.Name);
                item.SubItems.Add(foodItem.Unit);
                item.SubItems.Add(foodItem.Price.ToString("##,###"));
                item.SubItems.Add(foodItem.CategoryName);
                item.SubItems.Add(foodItem.Notes);
            }
        }

        private void ShowFoodForNode(TreeNode node)
        {
            // Xóa danh sách thực đơn hiện tại khỏi ListView
            lvwFood.Items.Clear();

            // Nếu node = null, không cần xử lý gì thêm
            if (node == null)
            {
                return;
            }

            // Tạo danh sách để chứa danh sách các món ăn tìm được
            List<FoodModel> foods = new List<FoodModel>();

            // Nếu nút được chọn trên TreeView tương ứng với loại nhóm thức ăn (Category Type) (mức thứ 2 trên cây)
            if (node.Level == 1)
            {
                // Thì lấy danh sách món ăn theo loại nhóm
                var categoryType = (CategoryType)node.Tag;
                foods = GetFoodByCategoryType(categoryType);
            }
            else
            {
                // Ngược lại, lấy danh sách món ăn theo thể loại
                // Nếu nút được chọn là 'Tất cả' thì lấy hết
                var category = node.Tag as Category;
                foods = GetFoodByCategory(category?.Id);
            }

            // Gọi hàm để hiện thị các món ăn lên ListView
            ShowFoodsOnListView(foods);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private void btnReloadCategory_Click(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private void tvwCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e?.Node != null)
            {
                ShowFoodForNode(e.Node);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateCategoryForm();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowCategories();
            }
        }

        private void tvwCategory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null || e.Node.Level < 2 || e.Node.Tag == null)
            {
                return;
            }

            var category = e.Node.Tag as Category;
            var dialog = new UpdateCategoryForm(category?.Id);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowCategories();
            }
        }

        private void btnReloadFood_Click(object sender, EventArgs e)
        {
            ShowFoodForNode(tvwCategory.SelectedNode);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Nếu không có món ăn nào được chọn, không cần làm gì cả
            if (lvwFood?.SelectedItems == null || lvwFood.SelectedItems.Count == 0)
            {
                return;
            }

            // Ngược lại, lấy mã số của món ăn được chọn
            var selectedItem = lvwFood.SelectedItems[0];
            if (selectedItem == null || string.IsNullOrWhiteSpace(selectedItem.Text))
            {
                return;
            }

            // Parse mã số món ăn
            if (!int.TryParse(selectedItem.Text, out int selectedFoodId))
            {
                MessageBox.Show("ID món ăn không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var dbContext = new RestaurantContext();

            // Truy vấn để lấy thông tin của món ăn đó
            var selectedFood = dbContext.Foods?.Find(selectedFoodId);

            // Nếu tìm thấy thông tin món ăn
            if (selectedFood != null)
            {
                // Thì xóa nó khỏi cơ sở dữ liệu
                dbContext.Foods!.Remove(selectedFood);
                dbContext.SaveChanges();

                // Và đồng thời xóa khỏi ListView
                lvwFood.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Không tìm thấy món ăn cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateFoodForm();
            if (dialog.ShowDialog(this) == DialogResult.OK) 
            {
                ShowFoodForNode(tvwCategory.SelectedNode);
            }
        }

        private void lvwFood_DoubleClick(object sender, EventArgs e)
        {
            if (lvwFood.SelectedItems.Count == 0) 
            {
                return;
            }

            var foodId = int.Parse(lvwFood.SelectedItems[0].Text);
            var dialog = new UpdateFoodForm(foodId);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowFoodForNode(tvwCategory.SelectedNode);
            }
        }
    }
}
