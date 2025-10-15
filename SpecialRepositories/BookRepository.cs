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
    public class BookRepository : Repository<Book>, IBookRepository
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

        public bool BookIsNotEmpty()
        {
            return _context.Books.Any();
        }

        public IEnumerable<BooksExcel> GetBooksExportFormat()
        {
            return _context.Books
                    .Select(b => new BooksExcel
                    {
                        Title = b.Title,
                        Genre = b.Genre,
                        Author = b.Author.Name
                    })
                    .ToList();
        }

        public IEnumerable<Book> GetAllForSearching(string searchText)
        {
            return _context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Title.ToLower().Contains(searchText) ||
                                b.Genre.ToLower().Contains(searchText) ||
                                b.Author.Name.ToLower().Contains(searchText))
                    .ToList();
        }

        public Book? GetByTitle(string title)
        {
            return _context.Books
                    .Where(b => b.Title == title)
                    .FirstOrDefault();  
        }
    }
}
