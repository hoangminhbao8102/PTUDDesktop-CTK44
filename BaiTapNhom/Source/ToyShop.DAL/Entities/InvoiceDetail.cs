using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop.DAL.Entities
{
    public class InvoiceDetail
    {
        public int InvoiceDetailID { get; set; }
        public int InvoiceID { get; set; }
        public int ToyID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Invoice? Invoice { get; set; }
        public Toy? Toy { get; set; }
    }
}
