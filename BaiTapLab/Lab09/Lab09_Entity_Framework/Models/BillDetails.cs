using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Entity_Framework.Models
{
    public class BillDetails
    {
        public int Id { get; set; }

        public int InvoiceId { get; set; }

        public int FoodId { get; set; }

        public int Quantity { get; set; }

        public Food? Food { get; set; }

        public Bills? Bill { get; set; }
    }
}
