using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.DAL.Entities;
using ToyShop.DAL.Repository;

namespace ToyShop.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Customer> CustomerRepository { get; }
        IRepository<Invoice> InvoiceRepository { get; }
        IRepository<InvoiceDetail> InvoiceDetailRepository { get; }
        IRepository<Toy> ToyRepository { get; }
        IRepository<ToyCategory> ToyCategoryRepository { get; }
        void Save();
    }
}
