using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Entity_Framework.Models
{
    public class RoleAccountModel
    {
        public int RoleId { get; set; } // ID vai trò

        public string? RoleName { get; set; } // Tên vai trò

        public string? AccountName { get; set; } // Tên tài khoản được gán vai trò này

        public bool Actived { get; set; } // Trạng thái kích hoạt của vai trò

        public string? Notes { get; set; } // Ghi chú
    }
}
