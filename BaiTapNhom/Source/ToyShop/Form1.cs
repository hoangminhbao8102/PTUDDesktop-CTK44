using Microsoft.Extensions.DependencyInjection;

namespace ToyShop
{
    public partial class FormMain : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public FormMain(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var formCustomer = _serviceProvider.GetRequiredService<FormCustomer>();
            formCustomer.Show();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            var formInvoice = _serviceProvider.GetRequiredService<FormInvoice>();
            formInvoice.Show();
        }

        private void btnToy_Click(object sender, EventArgs e)
        {
            var formToy = _serviceProvider.GetRequiredService<FormToy>();
            formToy.Show();
        }

        private void btnToyCategory_Click(object sender, EventArgs e)
        {
            var formToyCategory = _serviceProvider.GetRequiredService<FormToyCategory>();
            formToyCategory.Show();
        }

    }
}
