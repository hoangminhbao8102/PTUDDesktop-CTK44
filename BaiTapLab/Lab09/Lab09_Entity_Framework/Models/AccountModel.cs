using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Entity_Framework.Models
{
    public class AccountModel
    {
        public string? AccountName { get; set; } // Tên tài khoản

        public string? FullName { get; set; } // Họ và tên người dùng

        public string? Email { get; set; } // Email người dùng

        public string? Phone { get; set; } // Số điện thoại

        public string? Password { get; set; } // Mật khẩu (có thể được mã hóa)

        public DateTime? DateCreated { get; set; } // Ngày tạo tài khoản
    }
}
