using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop.DAL.Entities
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public DateTime InvoiceDate { get; set; }

        public Customer? Customer { get; set; }
        public ICollection<InvoiceDetail>? InvoiceDetails { get; set; }
    }
}
