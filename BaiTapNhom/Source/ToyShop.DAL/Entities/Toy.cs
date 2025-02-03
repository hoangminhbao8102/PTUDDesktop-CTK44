using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop.DAL.Entities
{
    public class Toy
    {
        public int ToyID { get; set; }
        public string? ToyName { get; set; }
        public int CategoryID { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public decimal Discount { get; set; }

        public ToyCategory? ToyCategory { get; set; }
        public ICollection<InvoiceDetail>? InvoiceDetails { get; set; }
    }
}
