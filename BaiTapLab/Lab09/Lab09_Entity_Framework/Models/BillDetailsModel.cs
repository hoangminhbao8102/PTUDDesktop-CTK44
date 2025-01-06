using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Entity_Framework.Models
{
    public class BillDetailsModel
    {
        public int Id { get; set; }

        public int InvoiceId { get; set; }

        public string? FoodName { get; set; } // Tên món ăn liên quan đến chi tiết hóa đơn

        public int Quantity { get; set; }
    }
}
