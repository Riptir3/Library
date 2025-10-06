using Library.DatabaseConfig;
using Library.Models;
using Library.Repositories;

namespace Library.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IRepository<Book> Books { get; }
        public IRepository<Author> Authors { get; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Books = new Repository<Book>(_context);
            Authors = new Repository<Author>(_context);
        }

        public void Save() => _context.SaveChanges();
        public void Dispose() => _context.Dispose();
    }
}
