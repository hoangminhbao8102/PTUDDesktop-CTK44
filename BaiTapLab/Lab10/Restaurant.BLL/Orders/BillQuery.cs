using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Orders
{
    public class BillQuery
    {
        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public int? TableId { get; set; }
    }
}
