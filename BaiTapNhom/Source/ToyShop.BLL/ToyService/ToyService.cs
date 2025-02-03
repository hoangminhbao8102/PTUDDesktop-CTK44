using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.DAL.Entities;
using ToyShop.DAL.UnitOfWork;

namespace ToyShop.BLL.ToyService
{
    public class ToyService : IToyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ToyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Toy> GetAllToys() => _unitOfWork.ToyRepository.GetAll();

        public Toy GetToyById(int id) => _unitOfWork.ToyRepository.GetById(id);

        public void CreateToy(Toy toy)
        {
            _unitOfWork.ToyRepository.Insert(toy);
            _unitOfWork.Save();
        }

        public void UpdateToy(Toy toy)
        {
            _unitOfWork.ToyRepository.Update(toy);
            _unitOfWork.Save();
        }

        public void DeleteToy(int id)
        {
            _unitOfWork.ToyRepository.Delete(id);
            _unitOfWork.Save();
        }

        public IEnumerable<Toy> GetToysByCategory(int categoryID)
        {
            return _unitOfWork.ToyRepository.GetAll().Where(toy => toy.CategoryID == categoryID);
        }

        public IEnumerable<Toy> GetToysSortedByName()
        {
            return _unitOfWork.ToyRepository.GetAll().OrderBy(toy => toy.ToyName);
        }

        public IEnumerable<Toy> SearchToys(string keyword)
        {
            return _unitOfWork.ToyRepository.GetAll().Where(toy =>
                toy.ToyName!.Contains(keyword) ||
                toy.Price.ToString().Contains(keyword) ||
                toy.StockQuantity.ToString().Contains(keyword) ||
                toy.Discount.ToString().Contains(keyword));
        }
    }

}
