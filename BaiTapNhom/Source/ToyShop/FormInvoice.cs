using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyShop.BLL.InvoiceService;
using ToyShop.DAL.Entities;

namespace ToyShop
{
    public partial class FormInvoice : Form
    {
        private readonly IInvoiceService _invoiceService;

        public FormInvoice(IInvoiceService invoiceService)
        {
            InitializeComponent();
            _invoiceService = invoiceService;
            LoadInvoices();
        }

        private void LoadInvoices()
        {
            listViewInvoice.Items.Clear();
            var invoices = _invoiceService.GetAllInvoices();
            foreach (var invoice in invoices)
            {
                var item = new ListViewItem(invoice.InvoiceID.ToString());
                item.SubItems.Add(invoice.CustomerID.ToString());
                item.SubItems.Add(invoice.InvoiceDate.ToString());
                listViewInvoice.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var invoice = new Invoice
            {
                CustomerID = int.Parse(txtCustomerID.Text),
                InvoiceDate = DateTime.Parse(dtpInvoiceDate.Text)
            };
            _invoiceService.CreateInvoice(invoice);
            LoadInvoices();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listViewInvoice.SelectedItems.Count > 0)
            {
                var selectedItem = listViewInvoice.SelectedItems[0];
                var invoiceId = int.Parse(selectedItem.Text);
                var invoice = _invoiceService.GetInvoiceById(invoiceId);
                invoice.CustomerID = int.Parse(txtCustomerID.Text);
                invoice.InvoiceDate = DateTime.Parse(dtpInvoiceDate.Text);
                _invoiceService.UpdateInvoice(invoice);
                LoadInvoices();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewInvoice.SelectedItems.Count > 0)
            {
                var selectedItem = listViewInvoice.SelectedItems[0];
                var invoiceId = int.Parse(selectedItem.Text);
                _invoiceService.DeleteInvoice(invoiceId);
                LoadInvoices();
            }
        }
    }
}
