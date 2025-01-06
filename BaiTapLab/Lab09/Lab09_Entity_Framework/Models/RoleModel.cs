using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Entity_Framework.Models
{
    public class RoleModel
    {
        public int Id { get; set; }

        public string? RoleName { get; set; } // Tên vai trò, ví dụ "Admin", "Staff"

        public string? Path { get; set; } // Đường dẫn quyền

        public string? Notes { get; set; } // Ghi chú
    }
}
