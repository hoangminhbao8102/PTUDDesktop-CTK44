using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.DAL.Entities;
using ToyShop.DAL.UnitOfWork;

namespace ToyShop.BLL.InvoiceService
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public InvoiceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Invoice> GetAllInvoices() => _unitOfWork.InvoiceRepository.GetAll();

        public Invoice GetInvoiceById(int id) => _unitOfWork.InvoiceRepository.GetById(id);

        public void CreateInvoice(Invoice invoice)
        {
            _unitOfWork.InvoiceRepository.Insert(invoice);
            _unitOfWork.Save();
        }

        public void UpdateInvoice(Invoice invoice)
        {
            _unitOfWork.InvoiceRepository.Update(invoice);
            _unitOfWork.Save();
        }

        public void DeleteInvoice(int id)
        {
            _unitOfWork.InvoiceRepository.Delete(id);
            _unitOfWork.Save();
        }
    }
}
