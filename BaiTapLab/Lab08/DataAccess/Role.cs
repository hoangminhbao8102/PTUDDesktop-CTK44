using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// Lớp ánh xạ bảng Role
    /// </summary>
    public class Role
    {
        // ID của vai trò, tự tăng trong CSDL
        public int ID { get; set; }

        // Tên vai trò (Admin, Staff, ...)
        public string? RoleName { get; set; }

        // Đường dẫn liên kết (nếu cần)
        public string? Path { get; set; }

        // Ghi chú
        public string? Notes { get; set; }
    }
}
