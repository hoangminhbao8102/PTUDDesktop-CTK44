using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Entity_Framework.Models
{
    public class BillsModel
    {
        public int Id { get; set; }

        public string? Name { get; set; } // Tên hóa đơn

        public string? TableName { get; set; } // Tên bàn liên quan đến hóa đơn

        public int Amount { get; set; } // Tổng tiền

        public float Discount { get; set; } // Phần trăm giảm giá

        public float Tax { get; set; } // Thuế

        public bool Status { get; set; } // Trạng thái thanh toán: true = đã thanh toán, false = chưa thanh toán

        public DateTime? CheckoutDate { get; set; } // Ngày thanh toán

        public string? AccountName { get; set; } // Tài khoản nhân viên lập hóa đơn
    }
}
