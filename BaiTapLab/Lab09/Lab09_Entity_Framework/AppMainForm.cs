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
    public partial class AppMainForm : Form
    {
        private RestaurantContext _context;
        private AccountModel _loggedInAccount;

        public AppMainForm(RestaurantContext context, AccountModel loggedInAccount)
        {
            InitializeComponent();
            _context = context;
            _loggedInAccount = loggedInAccount;

            LoadTables();
            ConfigureMenuBasedOnRole();
            LoadFoods();
        }

        private void LoadTables()
        {
            listViewTables.Items.Clear();

            var tables = _context.Tables!.ToList();
            foreach (var table in tables)
            {
                var item = new ListViewItem(table.Id.ToString());
                item.SubItems.Add(table.Name);
                item.SubItems.Add(table.Status.ToString());
                item.SubItems.Add(table.Capacity.ToString());

                listViewTables.Items.Add(item);
            }
        }

        private void ConfigureMenuBasedOnRole()
        {
            var roleAccount = _context.RoleAccounts!
                .FirstOrDefault(r => r.AccountName == _loggedInAccount.AccountName);

            // Kiểm tra nếu roleAccount hoặc role là null
            if (roleAccount == null || roleAccount.Role == null)
            {
                MessageBox.Show("Không tìm thấy vai trò của tài khoản này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                menuAdminManagement.Visible = false;
                return;
            }

            var role = roleAccount.Role.RoleName;
            menuAdminManagement.Visible = role == "Admin";
        }

        private void LoadFoods()
        {
            comboBoxFoods.Items.Clear();

            var foods = _context.Foods!.ToList();
            comboBoxFoods.DisplayMember = "Name";
            comboBoxFoods.ValueMember = "Id";
            comboBoxFoods.DataSource = foods;
        }

        private void AddFoodToBill(int tableId, int foodId, int quantity)
        {
            var table = _context.Tables!.FirstOrDefault(t => t.Id == tableId);
            if (table == null || table.Status == TableStatus.Available)
            {
                MessageBox.Show("Không thể đặt món cho bàn này.");
                return;
            }

            var food = _context.Foods!.FirstOrDefault(f => f.Id == foodId);
            if (food == null)
            {
                MessageBox.Show("Món ăn không tồn tại.");
                return;
            }

            var bill = _context.Bills!.FirstOrDefault(b => b.Table != null && b.Table.Name == table.Name && !b.Status);
            if (bill == null)
            {
                bill = new Bills
                {
                    Table = table,
                    Name = $"Hóa đơn cho {table.Name}", // Gán giá trị cho thuộc tính Name
                    Amount = 0,
                    Status = false,
                    CheckoutDate = null,
                    Account = _loggedInAccount.AccountName // Gán giá trị cho Account (người tạo hóa đơn)
                };
                _context.Bills!.Add(bill);
                _context.SaveChanges();
            }

            var billDetail = new BillDetails
            {
                InvoiceId = bill.Id,
                FoodId = food.Id,
                Quantity = quantity,
                Food = food,
                Bill = bill
            };
            _context.BillDetails!.Add(billDetail);
            bill.Amount += food.Price * quantity;
            _context.SaveChanges();
        }

        private void LoadBillDetails(int tableId)
        {
            listViewBillDetails.Items.Clear();

            var table = _context.Tables!.FirstOrDefault(t => t.Id == tableId);
            var bill = _context.Bills!.FirstOrDefault(b => b.Table!.Name == table!.Name && !b.Status);

            if (bill != null)
            {
                var billDetails = _context.BillDetails!.Where(bd => bd.InvoiceId == bill.Id).ToList();
                foreach (var detail in billDetails)
                {
                    var item = new ListViewItem(detail.Food!.Name);
                    item.SubItems.Add(detail.Quantity.ToString());
                    listViewBillDetails.Items.Add(item);
                }
            }
        }

        private void CheckoutTable(int tableId)
        {
            var table = _context.Tables!.FirstOrDefault(t => t.Id == tableId);
            var bill = _context.Bills!.FirstOrDefault(b => b.Table != null && b.Table.Name == table!.Name && !b.Status);

            if (bill == null)
            {
                MessageBox.Show("Không có hóa đơn cần thanh toán.");
                return;
            }

            bill.Status = true;
            bill.CheckoutDate = DateTime.Now;
            _context.SaveChanges();

            MessageBox.Show("Thanh toán thành công.");
            PrintBill(MapToBillsModel(bill));
        }

        private BillsModel MapToBillsModel(Bills bill)
        {
            return new BillsModel
            {
                Id = bill.Id,
                Name = bill.Name,
                TableName = bill.Table?.Name,
                Amount = bill.Amount,
                Discount = bill.Discount, // Không cần ép kiểu
                Tax = bill.Tax,           // Không cần ép kiểu
                Status = bill.Status,
                CheckoutDate = bill.CheckoutDate,
                AccountName = bill.Account
            };
        }

        private void PrintBill(BillsModel bill)
        {
            MessageBox.Show($"In hóa đơn cho bàn: {bill.TableName}\nTổng tiền: {bill.Amount}");
        }

        private void btnAddFoodToBill_Click(object sender, EventArgs e)
        {
            if (listViewTables.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn.");
                return;
            }

            if (comboBoxFoods.SelectedValue == null || numericUpDownQuantity.Value <= 0)
            {
                MessageBox.Show("Vui lòng chọn món và số lượng hợp lệ.");
                return;
            }

            var tableId = int.Parse(listViewTables.SelectedItems[0].Text);
            var foodId = (int)comboBoxFoods.SelectedValue;
            var quantity = (int)numericUpDownQuantity.Value;

            AddFoodToBill(tableId, foodId, quantity);
            LoadBillDetails(tableId);
        }

        private void btnCheckoutTable_Click(object sender, EventArgs e)
        {
            if (listViewTables.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn.");
                return;
            }

            var tableId = int.Parse(listViewTables.SelectedItems[0].Text);
            CheckoutTable(tableId);
            LoadTables();
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            if (listViewTables.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn.");
                return;
            }

            var tableId = int.Parse(listViewTables.SelectedItems[0].Text);
            var table = _context.Tables!.FirstOrDefault(t => t.Id == tableId);
            if (table == null)
            {
                MessageBox.Show("Không tìm thấy bàn.");
                return;
            }

            var bill = _context.Bills!.FirstOrDefault(b => b.Table!.Name == table.Name && b.Status);
            if (bill == null)
            {
                MessageBox.Show("Không có hóa đơn để in.");
                return;
            }

            PrintBill(MapToBillsModel(bill));
        }

        private void menuAdminManagement_Click(object sender, EventArgs e)
        {
            // Lấy vai trò của tài khoản đăng nhập
            var role = _context.RoleAccounts!
                .FirstOrDefault(r => r.AccountName == _loggedInAccount.AccountName && r.Actived)?.Role!.RoleName;

            if (role == "Admin")
            {
                var form = new AccountManagementForm(_context);
                form.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.");
            }
        }

        private void menuViewAccount_Click(object sender, EventArgs e)
        {
            var form = new AccountDetailsForm(_loggedInAccount);
            form.Show();
        }
    }
}
