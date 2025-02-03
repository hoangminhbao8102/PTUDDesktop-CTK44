using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.DAL.Context;
using ToyShop.DAL.Entities;
using ToyShop.DAL.Repository;

namespace ToyShop.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ToyShopContext _context;
        private IRepository<Customer>? _customerRepository;
        private IRepository<Invoice>? _invoiceRepository;
        private IRepository<InvoiceDetail>? _invoiceDetailRepository;
        private IRepository<Toy>? _toyRepository;
        private IRepository<ToyCategory>? _toyCategoryRepository;

        public UnitOfWork(ToyShopContext context)
        {
            _context = context;
        }

        public IRepository<Customer> CustomerRepository =>
            _customerRepository ??= new Repository<Customer>(_context);
        public IRepository<Invoice> InvoiceRepository =>
            _invoiceRepository ??= new Repository<Invoice>(_context);
        public IRepository<InvoiceDetail> InvoiceDetailRepository =>
            _invoiceDetailRepository ??= new Repository<InvoiceDetail>(_context);
        public IRepository<Toy> ToyRepository =>
            _toyRepository ??= new Repository<Toy>(_context);
        public IRepository<ToyCategory> ToyCategoryRepository =>
            _toyCategoryRepository ??= new Repository<ToyCategory>(_context);

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
