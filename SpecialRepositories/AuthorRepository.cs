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
                .Where(a => a.Author.Name == name)
                .GroupBy(b => new {b.Author.Name,b.Genre })
                .Select(g => new AuthorsGenreStat
                {
                    AuthorName = g.Key.Name,
                    Genre = g.Key.Genre,
                    BookCount = g.Count()
                })
                .ToList();
        }

        public IEnumerable<AuhtorBookCount> GetAuthorsWithBookCount()
        {
            return _context.Authors
                .Select(a => new AuhtorBookCount
                {
                    Name = a.Name,
                    BookCount = a.Books.Count()
                })
                .ToList();
        }

        public List<string> GetAuthorsNameWithBooks()
        {
            return _context.Authors
                .Where(a => a.Books.Count() > 0)
                .Select(a => a.Name)
                .ToList();
        }

        public List<string> GetAuthorsName()
        {
            return _context.Authors
                .Select(a => a.Name)
                .ToList();
        }

        public int GetAuthorIdByName(string name)
        {
            return _context.Authors
                    .Where(a => a.Name == name)
                    .Select(a => a.Id)
                    .First();
        }

        public List<AuthorExcel> GetAuthorsExportFormat()
        {
            return _context.Authors
                    .Select(a => new AuthorExcel
                    {
                        Name = a.Name,
                        BirthDate = a.BirthDate,
                        BookCount = a.Books.Count()
                    })
                    .ToList();
        }

        public Author GetByName(string name)
        {
            return _context.Authors
                    .Include(a => a.Books)
                    .Where(a => a.Name == name)
                    .First();
        }

        public IEnumerable<Author> GetAllForSearching(string searchText)
        {
            return _context.Authors
                    .Include(a => a.Books)
                    .Where(a => a.Name.ToLower().Contains(searchText) ||
                                a.BirthDate.ToString().Contains(searchText) ||
                                a.Books.Count.ToString().Contains(searchText))
                    .ToList();
        }
    }
}
