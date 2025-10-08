using Library.Controllers;
using Library.Data;
using Library.DatabaseConfig;

namespace Library
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var context = new AppDbContext();
            var unitOfWork = new UnitOfWork(context);
            var authcontroller = new AuthorController(unitOfWork);

            Application.Run(new Form1(unitOfWork,authcontroller));
        }
    }
}