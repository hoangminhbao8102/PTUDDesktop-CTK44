using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.DAL.Entities;
using ToyShop.DAL.UnitOfWork;

namespace ToyShop.BLL.ToyCategoryService
{
    public class ToyCategoryService : IToyCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ToyCategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<ToyCategory> GetAllToyCategories() => _unitOfWork.ToyCategoryRepository.GetAll();

        public ToyCategory GetToyCategoryById(int id) => _unitOfWork.ToyCategoryRepository.GetById(id);

        public void CreateToyCategory(ToyCategory toyCategory)
        {
            _unitOfWork.ToyCategoryRepository.Insert(toyCategory);
            _unitOfWork.Save();
        }

        public void UpdateToyCategory(ToyCategory toyCategory)
        {
            _unitOfWork.ToyCategoryRepository.Update(toyCategory);
            _unitOfWork.Save();
        }

        public void DeleteToyCategory(int id)
        {
            _unitOfWork.ToyCategoryRepository.Delete(id);
            _unitOfWork.Save();
        }
    }
}
