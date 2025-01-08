using Restaurant.BLL.Common;
using Restaurant.DAL.Entities;
using Restaurant.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Menu
{
    public class FoodService : CrudService<Food>, IFoodService
    {
        public FoodService(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<Food> GetFoodByCategory(int categoryId)
        {
            return _repository.Search(x => x.Category!.Id == categoryId).ToList();
        }

        public Food GetFoodById(int foodId)
        {
            return _repository.GetFirst(x => x.Id == foodId);
        }

        public List<Food> SearchFoods(string keyword)
        {
            return _repository.Search(x => x.Name!.Contains(keyword)).ToList();
        }

        public bool UpdateFood(Food food)
        {
            _repository.Update(food);
            _unitOfWork.SaveChanges();
            return true;
        }

        public bool DeleteFood(int foodId)
        {
            var food = GetFoodById(foodId);
            if (food == null) return false;

            _repository.Delete(food);
            _unitOfWork.SaveChanges();
            return true;
        }
    }
}
