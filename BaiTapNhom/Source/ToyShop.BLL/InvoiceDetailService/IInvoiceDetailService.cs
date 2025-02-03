using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.DAL.Entities;

namespace ToyShop.BLL.InvoiceDetailService
{
    public interface IInvoiceDetailService
    {
        IEnumerable<InvoiceDetail> GetAllInvoiceDetails();
        InvoiceDetail GetInvoiceDetailById(int id);
        void CreateInvoiceDetail(InvoiceDetail invoiceDetail);
        void UpdateInvoiceDetail(InvoiceDetail invoiceDetail);
        void DeleteInvoiceDetail(int id);
    }
}
