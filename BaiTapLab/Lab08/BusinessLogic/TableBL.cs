using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class TableBL
    {
        // Đối tượng TableDA từ DataAccess
        TableDA tableDA = new TableDA();

        // Phương thức lấy hết dữ liệu
        public List<Table> GetAll()
        {
            return tableDA.GetAll();
        }

        // Phương thức thêm dữ liệu
        public int Insert(Table table)
        {
            return tableDA.InsertUpdateDelete(table, 0); // Action = 0: Insert
        }

        // Phương thức cập nhật dữ liệu
        public int Update(Table table)
        {
            return tableDA.InsertUpdateDelete(table, 1); // Action = 1: Update
        }

        // Phương thức xóa dữ liệu
        public int Delete(int tableId)
        {
            Table table = new Table { ID = tableId };
            return tableDA.InsertUpdateDelete(table, 2); // Action = 2: Delete
        }
    }
}
