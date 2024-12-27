using DataAccess;

namespace RestaurantManagementProject
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
            ApplicationConfiguration.Initialize();
            // Application.Run(new frmFood());
            // Application.Run(new frmCategory());
            // Application.Run(new frmTable());
            // Application.Run(new frmBills());
            // Application.Run(new frmBillDetails());
            // Application.Run(new frmAccount());
            // Application.Run(new frmRole());
            // Application.Run(new frmRoleAccount());
            // Application.Run(new frmPhanQuyen());
            Account? loggedInUser = null;

            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    loggedInUser = loginForm.LoggedInAccount;
                }
                else
                {
                    return; // Thoát nếu không đăng nhập
                }
            }

            if (loggedInUser == null)
            {
                MessageBox.Show("Lỗi: Không thể xác định tài khoản người dùng.");
                return; // Đảm bảo ứng dụng không tiếp tục với tài khoản null
            }

            var mainForm = new MainForm(loggedInUser); // Đảm bảo loggedInUser không phải null
            Application.Run(mainForm);
        }
    }
}