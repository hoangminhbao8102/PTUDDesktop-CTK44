using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Entity_Framework.Models
{
    public class TableModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Status { get; set; } // Có thể là trạng thái như "Available", "Occupied", "Reserved"

        public int Capacity { get; set; }
    }
}
