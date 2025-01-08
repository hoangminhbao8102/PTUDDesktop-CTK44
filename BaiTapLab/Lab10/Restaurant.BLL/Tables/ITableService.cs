using Restaurant.BLL.Common;
using Restaurant.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Tables
{
    public interface ITableService : ICrudService<Table>
    {
        List<Table> GetAllTables(); // Thêm phương thức này

        void ChangeStatus(Table table, TableStatus status);

        List<Table> GetAvailableTables();

        Table GetTableById(int tableId);

        List<Table> GetTablesByStatus(TableStatus status);

        bool TransferTable(int sourceTableId, int targetTableId);

        bool MergeTables(int sourceTableId, int targetTableId);
    }
}
