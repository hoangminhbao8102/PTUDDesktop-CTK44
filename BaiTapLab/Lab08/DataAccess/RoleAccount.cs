using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// Lớp ánh xạ bảng RoleAccount
    /// </summary>
    public class RoleAccount
    {
        // ID của vai trò
        public int RoleID { get; set; }

        // Tên tài khoản liên kết
        public string? AccountName { get; set; }

        // Trạng thái kích hoạt (true: kích hoạt, false: chưa kích hoạt)
        public bool Actived { get; set; }

        // Ghi chú
        public string? Notes { get; set; }
    }
}
