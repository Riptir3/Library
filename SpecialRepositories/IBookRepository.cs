using Library.DTOs;
using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.SpecialRepositories
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetAllWithAuthor();
        IEnumerable<Book> GetAllForSearching(string searchText);
        Book? GetByIdWithAuthor(int id);

        Book? GetByTitle(string title);
        bool BookIsNotEmpty();
        IEnumerable<BooksExcel> GetBooksExportFormat();
    }
}
