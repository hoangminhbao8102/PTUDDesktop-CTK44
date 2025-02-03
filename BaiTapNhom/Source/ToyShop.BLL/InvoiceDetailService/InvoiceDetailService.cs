using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.DAL.Entities;
using ToyShop.DAL.UnitOfWork;

namespace ToyShop.BLL.InvoiceDetailService
{
    public class InvoiceDetailService : IInvoiceDetailService
    {
        private readonly IUnitOfWork _unitOfWork;

        public InvoiceDetailService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<InvoiceDetail> GetAllInvoiceDetails() => _unitOfWork.InvoiceDetailRepository.GetAll();

        public InvoiceDetail GetInvoiceDetailById(int id) => _unitOfWork.InvoiceDetailRepository.GetById(id);

        public void CreateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            _unitOfWork.InvoiceDetailRepository.Insert(invoiceDetail);
            _unitOfWork.Save();
        }

        public void UpdateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            _unitOfWork.InvoiceDetailRepository.Update(invoiceDetail);
            _unitOfWork.Save();
        }

        public void DeleteInvoiceDetail(int id)
        {
            _unitOfWork.InvoiceDetailRepository.Delete(id);
            _unitOfWork.Save();
        }
    }
}
