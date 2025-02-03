using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.DAL.Entities;

namespace ToyShop.BLL.ToyCategoryService
{
    public interface IToyCategoryService
    {
        IEnumerable<ToyCategory> GetAllToyCategories();
        ToyCategory GetToyCategoryById(int id);
        void CreateToyCategory(ToyCategory toyCategory);
        void UpdateToyCategory(ToyCategory toyCategory);
        void DeleteToyCategory(int id);
    }
}
