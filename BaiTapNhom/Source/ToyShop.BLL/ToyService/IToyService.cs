using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.DAL.Entities;

namespace ToyShop.BLL.ToyService
{
    public interface IToyService
    {
        IEnumerable<Toy> GetAllToys();
        Toy GetToyById(int id);
        void CreateToy(Toy toy);
        void UpdateToy(Toy toy);
        void DeleteToy(int id);
        IEnumerable<Toy> GetToysByCategory(int categoryID);
        IEnumerable<Toy> GetToysSortedByName();
        IEnumerable<Toy> SearchToys(string keyword);
    }
}
