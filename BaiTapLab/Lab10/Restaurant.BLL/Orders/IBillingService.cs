using PagedList.Core;
using Restaurant.BLL.Common;
using Restaurant.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Orders
{
    public interface IBillingService : ICrudService<Bill>
    {
        void CreateOrder(Bill bill);

        BillDetail AddBillItem(int billId, Food food, int quantity);

        Bill GetCurrentBillForTable(int tableId);

        List<BillDetail> GetBillDetails(int billId);

        IPagedList<Bill> Search(BillQuery condition, int page = 0, int pageSize = 50);

        bool TransferTable(int sourceTableId, int targetTableId);

        bool MergeBill(int sourceTableId, int targetTableId);
    }
}
