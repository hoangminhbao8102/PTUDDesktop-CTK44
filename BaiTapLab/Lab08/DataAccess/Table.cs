using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// Lớp ánh xạ bảng Table
    /// </summary>
    public class Table
    {
        // ID của bảng, tự tăng trong CSDL
        public int ID { get; set; }

        // Tên của bàn
        public string? Name { get; set; }

        // Trạng thái của bàn (0: trống, 1: có người)
        public int Status { get; set; }

        // Số lượng người tối đa mà bàn có thể chứa
        public int Capacity { get; set; }
    }
}
