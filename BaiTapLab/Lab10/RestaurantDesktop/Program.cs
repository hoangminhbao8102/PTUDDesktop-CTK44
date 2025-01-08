using Restaurant.DAL;

namespace RestaurantDesktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            IUnitOfWork unitOfWork = new UnitOfWork(new RestaurantDbContext());
            Application.Run(new MainForm(unitOfWork));
        }
    }
}