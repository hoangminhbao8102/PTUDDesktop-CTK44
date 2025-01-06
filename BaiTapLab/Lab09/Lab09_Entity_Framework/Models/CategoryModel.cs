using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Entity_Framework.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }

        public string? Name { get; set; } // Tên nhóm món ăn

        public string? Type { get; set; } // Loại nhóm, ví dụ "Food", "Drink"
    }
}
