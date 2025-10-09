using Library.DatabaseConfig;
using Library.Models;
using Library.Repositories;
using Library.SpecialRepositories;

namespace Library.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IBookRepository Books {  get;}
        public IAuthorRepository Authors { get; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Books = new BookRepository(_context);
            Authors = new AuthorRepository(_context);
        }

        public void Save() => _context.SaveChanges();
        public void Dispose() => _context.Dispose();
    }
}
