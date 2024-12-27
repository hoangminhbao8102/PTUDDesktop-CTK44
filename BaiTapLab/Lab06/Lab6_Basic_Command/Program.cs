namespace Lab6_Basic_Command
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
            // Application.Run(new Form1());
            // Application.Run(new BillsForm());
            // Application.Run(new AccountManagerForm());
            Application.Run(new MainForm());
        }
    }
}