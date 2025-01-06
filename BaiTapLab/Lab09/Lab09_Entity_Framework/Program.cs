using Lab09_Entity_Framework.Models;

namespace Lab09_Entity_Framework
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Application.Run(new MainForm());
            // Application.Run(new RoleForm());
            // Application.Run(new AccountForm());
            // Application.Run(new BillsForm());
            // Application.Run(new FoodForm());
            // Application.Run(new TableForm());
            /*using var context = new RestaurantContext();

            // Hiển thị form đăng nhập
            AccountModel? loggedInAccount = null;
            using (var loginForm = new LoginForm(context))
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    loggedInAccount = loginForm.LoggedInAccount;
                }
            }

            // Nếu không đăng nhập, thoát chương trình
            if (loggedInAccount == null)
            {
                return;
            }

            // Khởi chạy form chính
            Application.Run(new AppMainForm(context, loggedInAccount));*/
            Application.Run(new MenuForm());
        }
    }
}