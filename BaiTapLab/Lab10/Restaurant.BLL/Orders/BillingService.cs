using PagedList.Core;
using Restaurant.BLL.Common;
using Restaurant.DAL;
using Restaurant.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Orders
{
    public class BillingService : CrudService<Bill>, IBillingService
    {
        private readonly IRepository<BillDetail> _billDetailRepo;

        public BillingService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _billDetailRepo = _unitOfWork.GetRepository<BillDetail>();
        }

        public BillDetail AddBillItem(int billId, Food food, int quantity)
        {
            var billItem = _billDetailRepo.GetFirst(x => x.Id == billId && x.FoodId == food.Id);

            if (billItem == null) 
            {
                billItem = new BillDetail
                {
                    FoodId = food.Id,
                    Quantity = quantity,
                    Unit = food.Unit,
                    Id = billId
                };

                _billDetailRepo.Insert(billItem);
            }
            else
            {
                billItem.Quantity += quantity;
                _billDetailRepo.Update(billItem);
            }

            _unitOfWork.SaveChanges();

            return billItem;
        }

        public void CreateOrder(Bill bill)
        {
            _repository.Insert(bill);
            _unitOfWork.SaveChanges();
        }

        public List<BillDetail> GetBillDetails(int billId)
        {
            return _billDetailRepo.Search(x => x.Id == billId).ToList();
        }

        public Bill GetCurrentBillForTable(int tableId)
        {
            var bill = _repository.GetFirst(x => x.TableId == tableId && x.Status == BillStatus.Pending);

            if (bill != null) 
            {
                bill.BillDetails = _billDetailRepo.Search(x => x.Id == bill.Id).ToList();
            }

            return bill!;
        }

        public bool MergeBill(int sourceTableId, int targetTableId)
        {
            var sourceBill = GetCurrentBillForTable(sourceTableId);
            var targetBill = GetCurrentBillForTable(targetTableId);

            if (sourceBill == null || sourceBill.Status != BillStatus.Pending || targetBill == null || targetBill.Status != BillStatus.Pending)
            {
                return false; // Một trong hai hóa đơn không hợp lệ.
            }

            // Lấy chi tiết hóa đơn từ bàn nguồn.
            var sourceBillDetails = GetBillDetails(sourceBill.Id);

            foreach (var detail in sourceBillDetails)
            {
                // Thêm từng món từ bàn nguồn vào bàn đích.
                AddBillItem(targetBill.Id, new Food { Id = detail.FoodId, Unit = detail.Unit }, detail.Quantity);
            }

            // Xóa hóa đơn nguồn sau khi đã gộp.
            Delete(sourceBill);

            _unitOfWork.SaveChanges();
            return true;
        }

        public IPagedList<Bill> Search(BillQuery condition, int page = 0, int pageSize = 50)
        {
            var query = _repository.GetAll();

            if (condition.FromDate != null) 
            {
                query = query.Where(x => x.CheckoutDate >= condition.FromDate);
            }

            if (condition.ToDate != null)
            {
                // Tóm tắt nếu bạn có DbFunctions.DiffDays(date1, date2)
                // và date1 > date2 kết quả sẽ là < 0
                // và date1 < date2 kết quả sẽ là > 0
                query = query.Where(x => DbFunctions.DiffDays(x.CheckoutDate, condition.ToDate) >= 0);
            }

            if (condition.TableId != null) 
            {
                query = query.Where(x => x.TableId == condition.TableId);
            }

            query = query.OrderByDescending(x => x.CheckoutDate);

            return new PagedList<Bill>(query, page, pageSize);
        }

        public bool TransferTable(int sourceTableId, int targetTableId)
        {
            var sourceBill = GetCurrentBillForTable(sourceTableId);
            var targetBill = GetCurrentBillForTable(targetTableId);

            if (sourceBill == null || sourceBill.Status != BillStatus.Pending)
            {
                return false; // Không có hóa đơn hợp lệ cho bàn nguồn.
            }

            if (targetBill != null)
            {
                // Nếu bàn đích đã có hóa đơn, gộp hóa đơn.
                MergeBill(sourceTableId, targetTableId);
            }
            else
            {
                // Chuyển hóa đơn từ bàn nguồn sang bàn đích.
                sourceBill.TableId = targetTableId;
                _repository.Update(sourceBill);
            }

            _unitOfWork.SaveChanges();
            return true;
        }

        public int GetSumAmount(BillQuery condition)
        {
            var query = _repository.GetAll();

            if (condition.FromDate != null) 
            {
                query = query.Where(x => x.CheckoutDate >= condition.FromDate);
            }

            if (condition.ToDate != null)
            {
                // Tóm tắt nếu bạn có DbFunctions.DiffDays(date1, date2)
                // và date1 > date2 kết quả sẽ là < 0
                // và date1 < date2 kết quả sẽ là > 0
                query = query.Where(x => DbFunctions.DiffDays(x.CheckoutDate, condition.ToDate) >= 0);
            }

            if (condition.TableId != null) 
            {
                query = query.Where(x => x.TableId == condition.TableId);
            }

            return query.Sum(x => x.Amount);
        }

        public override void Delete(Bill bill)
        {
            var items = GetBillDetails(bill.Id);

            foreach (var item in items)
            {
                _billDetailRepo.Delete(item);
            }

            base.Delete(bill);
        }
    }
}
