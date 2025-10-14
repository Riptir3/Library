using Library.DatabaseConfig;
using Library.DTOs;
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
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(AppDbContext context) : base(context)
        {  
        }
        public IEnumerable<Author> GetAllWithBooks()
        {
            return _context.Set<Author>()
                .Include(a => a.Books)
                .ToList();
        }

        public Author? GetByIdWithBooks(int id)
        {
            return _context.Set<Author>()
                .Include(a => a.Books)
                .FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<AuthorsGenreStat> GetAuthorGenreStatList(string name)
        {
            return _context.Books
                .Where(b => b.Author.Name == name)
                .GroupBy(b => new {b.Author.Name,b.Genre })
                .Select(g => new AuthorsGenreStat
                {
                    AuthorName = g.Key.Name,
                    Genre = g.Key.Genre,
                    BookCount = g.Count()
                })
                .ToList();
        }
    }
}
