using Library.Data;
using Library.DatabaseConfig;

namespace Library
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

            var context = new AppDbContext();
            var unitOfWork = new UnitOfWork(context);

            Application.Run(new Form1(unitOfWork));
        }
    }
}