using Restaurant.BLL.Common;
using Restaurant.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Menu
{
    public interface IFoodService : ICrudService<Food>
    {
        List<Food> GetFoodByCategory(int categoryId);

        Food GetFoodById(int foodId);

        List<Food> SearchFoods(string keyword);

        bool UpdateFood(Food food);

        bool DeleteFood(int foodId);
    }
}
