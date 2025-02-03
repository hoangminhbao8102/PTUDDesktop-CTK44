using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.DAL.Entities;

namespace ToyShop.BLL.InvoiceService
{
    public interface IInvoiceService
    {
        IEnumerable<Invoice> GetAllInvoices();
        Invoice GetInvoiceById(int id);
        void CreateInvoice(Invoice invoice);
        void UpdateInvoice(Invoice invoice);
        void DeleteInvoice(int id);
    }
}
