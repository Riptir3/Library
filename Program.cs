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

            Application.Run(new Form1(unitOfWork));
        }
    }
}