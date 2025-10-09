using Library.DatabaseConfig;
using Library.Models;
using Library.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.SpecialRepositories
{
    public class BookRepository : Repository<Book> ,IBookRepository
    {
        public BookRepository(AppDbContext context) : base(context) { }

        public IEnumerable<Book> GetAllWithAuthor()
        {
            return _context.Set<Book>()
                    .Include(b => b.Author)
                    .ToList();
        }

        public Book? GetByIdWithAuthor(int id)
        {
            return _context.Set<Book>()
                    .Include(b => b.Author)
                    .FirstOrDefault(b => b.Id == id);
        }
    }
}
