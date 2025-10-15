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
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetByIdWithBooks(int id);
        Author GetByName(string name);
        IEnumerable<Author> GetAllWithBooks();
        IEnumerable<AuthorsGenreStat> GetAuthorGenreStatList(string name);
        IEnumerable<AuhtorBookCount> GetAuthorsWithBookCount();
        IEnumerable<Author> GetAllForSearching(string searchText);
        List<string> GetAuthorsName();
        List<string> GetAuthorsNameWithBooks();
        List<AuthorExcel> GetAuthorsExportFormat();
        int GetAuthorIdByName(string name);
    }
}
