using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.DAL.Entities;
using ToyShop.DAL.UnitOfWork;

namespace ToyShop.BLL.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Customer> GetAllCustomers() => _unitOfWork.CustomerRepository.GetAll();

        public Customer GetCustomerById(int id) => _unitOfWork.CustomerRepository.GetById(id);

        public void CreateCustomer(Customer customer)
        {
            _unitOfWork.CustomerRepository.Insert(customer);
            _unitOfWork.Save();
        }

        public void UpdateCustomer(Customer customer)
        {
            _unitOfWork.CustomerRepository.Update(customer);
            _unitOfWork.Save();
        }

        public void DeleteCustomer(int id)
        {
            _unitOfWork.CustomerRepository.Delete(id);
            _unitOfWork.Save();
        }
    }
}
