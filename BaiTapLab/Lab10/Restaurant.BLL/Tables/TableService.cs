using Restaurant.BLL.Common;
using Restaurant.DAL.Entities;
using Restaurant.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Tables
{
    public class TableService : CrudService<Table>, ITableService
    {
        public TableService(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public void ChangeStatus(Table table, TableStatus status)
        {
            table.Status = status;
            _repository.Update(table);
            _unitOfWork.SaveChanges();
        }

        public List<Table> GetAvailableTables()
        {
            return _repository.Search(x => x.Status == TableStatus.Available).ToList();
        }

        public Table GetTableById(int tableId)
        {
            return _repository.GetFirst(x => x.Id == tableId);
        }

        public List<Table> GetTablesByStatus(TableStatus status)
        {
            return _repository.Search(x => x.Status == status).ToList();
        }

        public bool TransferTable(int sourceTableId, int targetTableId)
        {
            var sourceTable = GetTableById(sourceTableId);
            var targetTable = GetTableById(targetTableId);

            if (sourceTable == null || sourceTable.Status != TableStatus.Busy)
            {
                return false;
            }

            sourceTable.Status = TableStatus.Available;
            targetTable.Status = TableStatus.Busy;

            _repository.Update(sourceTable);
            _repository.Update(targetTable);
            _unitOfWork.SaveChanges();
            return true;
        }

        public bool MergeTables(int sourceTableId, int targetTableId)
        {
            // Lấy thông tin hai bàn
            var sourceTable = GetTableById(sourceTableId);
            var targetTable = GetTableById(targetTableId);

            // Kiểm tra xem bàn nguồn và bàn đích có tồn tại không
            if (sourceTable == null || targetTable == null)
            {
                return false; // Không thể gộp nếu một trong hai bàn không tồn tại
            }

            // Kiểm tra trạng thái của bàn nguồn và bàn đích
            if (sourceTable.Status != TableStatus.Busy || targetTable.Status != TableStatus.Busy)
            {
                return false; // Chỉ có thể gộp nếu cả hai bàn đang "Busy" (đang sử dụng)
            }

            // Lấy hóa đơn của hai bàn (nếu có)
            var sourceBill = _unitOfWork.GetRepository<Bill>().GetFirst(x => x.TableId == sourceTableId && x.Status == BillStatus.Pending);
            var targetBill = _unitOfWork.GetRepository<Bill>().GetFirst(x => x.TableId == targetTableId && x.Status == BillStatus.Pending);

            // Nếu không có hóa đơn của bàn nguồn, không cần gộp
            if (sourceBill == null)
            {
                return false;
            }

            // Nếu bàn đích không có hóa đơn, chuyển hóa đơn từ bàn nguồn sang bàn đích
            if (targetBill == null)
            {
                sourceBill.TableId = targetTableId;
                _unitOfWork.GetRepository<Bill>().Update(sourceBill);
            }
            else
            {
                // Nếu bàn đích đã có hóa đơn, gộp chi tiết hóa đơn từ bàn nguồn sang bàn đích
                var billDetailRepo = _unitOfWork.GetRepository<BillDetail>();
                var sourceBillDetails = billDetailRepo.Search(x => x.Id == sourceBill.Id).ToList();

                foreach (var detail in sourceBillDetails)
                {
                    // Tìm chi tiết hóa đơn tương ứng trong hóa đơn bàn đích
                    var targetBillDetail = billDetailRepo.GetFirst(x => x.Id == targetBill.Id && x.FoodId == detail.FoodId);

                    if (targetBillDetail == null)
                    {
                        // Nếu món ăn không tồn tại trong hóa đơn bàn đích, thêm mới
                        targetBillDetail = new BillDetail
                        {
                            Id = targetBill.Id,
                            FoodId = detail.FoodId,
                            Quantity = detail.Quantity,
                            Unit = detail.Unit
                        };

                        billDetailRepo.Insert(targetBillDetail);
                    }
                    else
                    {
                        // Nếu món ăn đã tồn tại, cộng số lượng
                        targetBillDetail.Quantity += detail.Quantity;
                        billDetailRepo.Update(targetBillDetail);
                    }
                }

                // Xóa hóa đơn của bàn nguồn sau khi đã gộp
                _unitOfWork.GetRepository<Bill>().Delete(sourceBill);
            }

            // Đặt trạng thái bàn nguồn về "Trống"
            sourceTable.Status = TableStatus.Available;
            _repository.Update(sourceTable);

            // Đặt trạng thái bàn đích là "Busy"
            targetTable.Status = TableStatus.Busy;
            _repository.Update(targetTable);

            // Lưu các thay đổi vào cơ sở dữ liệu
            _unitOfWork.SaveChanges();

            return true; // Gộp thành công
        }

        public List<Table> GetAllTables()
        {
            return _repository.GetAll().ToList();
        }
    }
}
