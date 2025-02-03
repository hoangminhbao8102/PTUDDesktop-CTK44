using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop.DAL.Entities
{
    public class ToyCategory
    {
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public ICollection<Toy>? Toys { get; set; }
    }
}
