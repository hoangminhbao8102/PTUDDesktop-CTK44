using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Entity_Framework.Models
{
    public class Bills
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int TableId { get; set; }

        public int Amount { get; set; }

        public float Discount { get; set; }

        public float Tax { get; set; }

        public bool Status { get; set; }

        public DateTime? CheckoutDate { get; set; }

        public string? Account { get; set; }

        public Table? Table { get; set; }

        public ICollection<BillDetails>? BillDetails { get; set; }
    }
}
