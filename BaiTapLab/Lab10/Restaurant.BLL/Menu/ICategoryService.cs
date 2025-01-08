using Restaurant.BLL.Common;
using Restaurant.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Menu
{
    public interface ICategoryService : ICrudService<Category>
    {
        List<Category> GetAllCategories();

        Category GetCategoryById(int categoryId);

        Category GetCategoryByName(string name);

        bool UpdateCategory(Category category);

        bool DeleteCategory(int categoryId);
    }
}
