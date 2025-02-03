using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ToyShop.BLL.CustomerService;
using ToyShop.BLL.InvoiceDetailService;
using ToyShop.BLL.InvoiceService;
using ToyShop.BLL.ToyCategoryService;
using ToyShop.BLL.ToyService;
using ToyShop.DAL.Context;
using ToyShop.DAL.UnitOfWork;

namespace ToyShop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceProvider = ConfigureServices();

            var mainForm = serviceProvider.GetRequiredService<FormMain>();
            Application.Run(mainForm);
        }

        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<ToyShopContext>(options =>
                options.UseSqlServer("Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=ToyShopManagement;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;"));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IToyCategoryService, ToyCategoryService>();
            services.AddScoped<IToyService, ToyService>();
            services.AddScoped<IInvoiceService, InvoiceService>();
            services.AddScoped<IInvoiceDetailService, InvoiceDetailService>();

            // Ensure FormCustomer and FormInvoice are created and added here
            services.AddScoped<FormMain>();
            services.AddScoped<FormCustomer>();
            services.AddScoped<FormInvoice>();
            services.AddScoped<FormToy>();
            services.AddScoped<FormToyCategory>();

            return services.BuildServiceProvider();
        }
    }
}