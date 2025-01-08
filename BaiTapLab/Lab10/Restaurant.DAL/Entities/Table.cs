using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL.Entities
{
    public class Table
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public TableStatus Status { get; set; }

        public int Capacity { get; set; }

        public ICollection<Bill>? Bills { get; set; }
    }

    public enum TableStatus
    {
        Available,
        Busy
    }
}
