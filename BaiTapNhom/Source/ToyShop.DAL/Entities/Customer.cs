using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop.DAL.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? PhoneNumber { get; set; }

        // Thêm thuộc tính Invoices để phản ánh mối quan hệ 1-n với Invoice
        public ICollection<Invoice>? Invoices { get; set; }
    }
}
