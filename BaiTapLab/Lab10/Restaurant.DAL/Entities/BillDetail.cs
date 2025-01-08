using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL.Entities
{
    public class BillDetail
    {
        public int Id { get; set; }

        public int InvoiceId { get; set; }

        public int FoodId { get; set; }

        public string? Unit { get; set; }

        public int Quantity { get; set; }

        public int Amount { get; set; }

        public Food? Food { get; set; }

        public Bill? Bill { get; set; }
    }
}
