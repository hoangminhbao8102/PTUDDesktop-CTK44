using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyShop.BLL.CustomerService;
using ToyShop.DAL.Entities;

namespace ToyShop
{
    public partial class FormCustomer : Form
    {
        private readonly ICustomerService _customerService;

        public FormCustomer(ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            listViewCustomer.Items.Clear();
            var customers = _customerService.GetAllCustomers();
            foreach (var customer in customers)
            {
                var item = new ListViewItem(customer.CustomerID.ToString());
                item.SubItems.Add(customer.CustomerName);
                item.SubItems.Add(customer.PhoneNumber);
                listViewCustomer.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                CustomerName = txtCustomerName.Text,
                PhoneNumber = txtPhoneNumber.Text
            };
            _customerService.CreateCustomer(customer);
            LoadCustomers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listViewCustomer.SelectedItems.Count > 0)
            {
                var selectedItem = listViewCustomer.SelectedItems[0];
                var customerId = int.Parse(selectedItem.Text);
                var customer = _customerService.GetCustomerById(customerId);
                customer.CustomerName = txtCustomerName.Text;
                customer.PhoneNumber = txtPhoneNumber.Text;
                _customerService.UpdateCustomer(customer);
                LoadCustomers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewCustomer.SelectedItems.Count > 0)
            {
                var selectedItem = listViewCustomer.SelectedItems[0];
                var customerId = int.Parse(selectedItem.Text);
                _customerService.DeleteCustomer(customerId);
                LoadCustomers();
            }
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }
    }
}
