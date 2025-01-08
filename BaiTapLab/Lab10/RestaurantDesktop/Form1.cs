using Restaurant.BLL.Common;
using Restaurant.BLL.Menu;
using Restaurant.BLL.Orders;
using Restaurant.BLL.Tables;
using Restaurant.DAL;
using Restaurant.DAL.Entities;

namespace RestaurantDesktop
{
    public partial class MainForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITableService _tableService;
        private readonly ICategoryService _categoryService;
        private readonly IFoodService _foodService;
        private readonly IBillingService _billingService;
        private readonly ILocalizationService _localizationSevice;

        // Dependency Injection (Đảo ngược phụ thuộc) = DI / Inversion of Control (Đảo ngược điều khiển) = IoC
        public MainForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _tableService = new TableService(_unitOfWork);
            _categoryService = new CategoryService(_unitOfWork);
            _foodService = new FoodService(_unitOfWork);
            _billingService = new BillingService(_unitOfWork);
            _localizationSevice = new VietnamLocalizationSevice();

            InitializeComponent();
            LoadInfo();
        }

        private void LoadInfo()
        {
            // Tải danh sách bàn
            LoadTableToPanel();

            // Tải danh sách danh mục
            var categories = _categoryService.GetAllCategories();
            cbbCategory.DataSource = categories;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "Id";

            // Tải món ăn mặc định (nếu cần)
            if (categories.Count > 0)
            {
                LoadFoodListByCategory(categories.First().Id);
            }

            // Tải bàn đích (nếu cần)
            LoadTargetTables();

            // Khởi tạo các giá trị khác
            txtAmount.Text = "0";
            nudQuantity.Value = 1;
            nudDiscount.Value = 0;
        }

        private void LoadFoodListByCategory(int categoryId)
        {
            // Lấy danh sách món ăn theo danh mục
            var foods = _foodService.GetFoodByCategory(categoryId).ToList();

            // Gán dữ liệu vào ComboBox
            cbbFood.DataSource = foods;
            cbbFood.DisplayMember = "Name";
            cbbFood.ValueMember = "Id";
        }

        private void LoadBillItemByTable(int tableId)
        {
            lvBillDetail.Items.Clear();
            var bill = _billingService.GetCurrentBillForTable(tableId);

            if (bill == null || bill.BillDetails!.Count == 0)
            {
                return;
            }

            foreach (var item in bill.BillDetails)
            {
                var row = lvBillDetail.Items.Add(item.Food!.Name);

                row.SubItems.Add(item.Food.Unit);
                row.SubItems.Add(item.Quantity.ToString());
                row.SubItems.Add(item.Unit!.ToString());
                row.SubItems.Add(item.Amount.ToString());
            }

            bill.Amount = bill.BillDetails.Sum(x => x.Amount);
            // _unitOfWork.SaveChanges();

            txtAmount.Text = _localizationSevice.FormatCurrency(bill.Amount);
        }

        private void LoadTableToPanel()
        {
            pnlTable.Controls.Clear();
            var tables = _tableService.GetAllTables();

            foreach (var table in tables)
            {
                Button btnTable = new Button()
                {
                    Width = 100,
                    Height = 100,
                    Text = table.Name + Environment.NewLine + table.Status,
                    BackColor = table.Status == TableStatus.Available ? Color.LightGreen : Color.Yellow,
                    Tag = table
                };

                btnTable.Click += btnTable_Click!;
                pnlTable.Controls.Add(btnTable);
            }
        }

        private void LoadTargetTables()
        {
            var availableTables = _tableService.GetAvailableTables();
            cbbTargetTable.DataSource = availableTables;
            cbbTargetTable.DisplayMember = "Name";
            cbbTargetTable.ValueMember = "Id";
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            var btnTable = sender as Button;
            if (btnTable == null) return;

            var table = btnTable.Tag as Table;
            if (table == null) return;

            // Gắn bảng được chọn vào một control để sử dụng sau này (ví dụ: ListView)
            lvBillDetail.Tag = table;

            // Tải thông tin hóa đơn của bàn (nếu cần)
            LoadBillItemByTable(table.Id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            // Lấy món ăn được chọn
            var selectedFood = cbbFood.SelectedItem as Food;
            var quantity = (int)nudQuantity.Value;
            var table = lvBillDetail.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thêm món", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (selectedFood == null)
            {
                MessageBox.Show("Vui lòng chọn món ăn", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            // Lấy hóa đơn hiện tại của bàn
            var bill = _billingService.GetCurrentBillForTable(table.Id);

            // Nếu bàn chưa có hóa đơn, tạo hóa đơn mới
            if (bill == null)
            {
                bill = new Bill
                {
                    TableId = table.Id,
                    Status = BillStatus.Pending,
                    CheckoutDate = DateTime.Now
                };

                _billingService.CreateOrder(bill);
                _tableService.ChangeStatus(table, TableStatus.Busy);

                LoadTableToPanel();
            }

            // Thêm món ăn vào hóa đơn
            _billingService.AddBillItem(bill.Id, selectedFood, quantity);

            // Cập nhật danh sách món ăn trong hóa đơn
            LoadBillItemByTable(table.Id);

            MessageBox.Show($"Đã thêm {quantity} {selectedFood.Name} vào bàn {table.Name}.", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var table = lvBillDetail.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var bill = _billingService.GetCurrentBillForTable(table.Id);
            if (bill == null)
            {
                MessageBox.Show("Bạn chua có hóa đơn", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var sumAmount = bill.BillDetails!.Sum(x => x.Amount);
            var disCount = (int)nudDiscount.Value;
            var mustPay = sumAmount - sumAmount * disCount / 100;

            if (MessageBox.Show(String.Format("Bạn có chắc muốn thanh toán hóa đơn cho {0}?" + "\n Số tiền phải trả = {1} - {1} * {2} / 100 = {3}", table.Name, sumAmount, disCount, mustPay), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                _tableService.ChangeStatus(table, TableStatus.Available);

                bill.Amount = mustPay;
                bill.Status = BillStatus.Billed;
                bill.CheckoutDate = DateTime.Now;
                bill.Discount = disCount;
                _billingService.Update(bill);

                nudDiscount.ResetText();
                LoadTableToPanel();
                LoadBillItemByTable(table.Id);
            }
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedValue is int categoryId)
            {
                // Gọi hàm LoadFoodListByCategory để tải danh sách món ăn
                LoadFoodListByCategory(categoryId);
            }
        }

        private void btnTransferOrMerge_Click(object sender, EventArgs e)
        {
            var sourceTable = lvBillDetail.Tag as Table;
            if (sourceTable == null)
            {
                MessageBox.Show("Vui lòng chọn bàn cần chuyển hoặc gộp", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var targetTableId = (int)cbbTargetTable.SelectedValue!; // Lấy ID bàn đích từ ComboBox
            var targetTable = _tableService.GetTableById(targetTableId);

            if (targetTable == null || targetTable.Status != TableStatus.Available)
            {
                MessageBox.Show("Bàn đích không hợp lệ hoặc không trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn chuyển/gộp từ bàn {sourceTable.Name} sang bàn {targetTable.Name}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var success = _tableService.MergeTables(sourceTable.Id, targetTable.Id);

                if (success)
                {
                    LoadTableToPanel();
                    MessageBox.Show("Chuyển/Gộp bàn thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không thể chuyển/gộp bàn", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            var table = lvBillDetail.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi áp dụng giảm giá", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var bill = _billingService.GetCurrentBillForTable(table.Id);
            if (bill == null)
            {
                MessageBox.Show("Bàn chưa có hóa đơn để giảm giá", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var discount = (int)nudDiscount.Value;
            bill.Discount = discount;

            _billingService.Update(bill);
            LoadBillItemByTable(table.Id);

            MessageBox.Show($"Đã áp dụng giảm giá {discount}% cho hóa đơn bàn {table.Name}.", "Thông báo", MessageBoxButtons.OK);
        }

        private void tsmAdmin_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminForm(_unitOfWork); // Giả sử AdminForm nhận IUnitOfWork
            adminForm.ShowDialog();
            LoadInfo(); // Tải lại thông tin sau khi thay đổi
        }

        private void tsmAccount_Click(object sender, EventArgs e)
        {
            var accountForm = new AccountForm(_unitOfWork); // Giả sử AccountForm nhận IUnitOfWork
            accountForm.ShowDialog();
        }
    }
}
