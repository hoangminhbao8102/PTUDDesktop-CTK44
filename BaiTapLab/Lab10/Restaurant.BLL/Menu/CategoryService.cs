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
    public class CategoryService : CrudService<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<Category> GetAllCategories()
        {
            return _repository.GetAll().ToList();
        }

        public Category GetCategoryById(int categoryId)
        {
            return _repository.GetFirst(x => x.Id == categoryId);
        }

        public Category GetCategoryByName(string name)
        {
            return _repository.GetFirst(x => x.Name == name);
        }

        public bool UpdateCategory(Category category)
        {
            _repository.Update(category);
            _unitOfWork.SaveChanges();
            return true;
        }

        public bool DeleteCategory(int categoryId)
        {
            var category = GetCategoryById(categoryId);
            if (category == null) return false;

            _repository.Delete(category);
            _unitOfWork.SaveChanges();
            return true;
        }
    }
}
