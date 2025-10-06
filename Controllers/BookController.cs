using Library.Data;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class BookController
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool AddBook(Book book)
        {
            if (_unitOfWork.Books.GetAll().Any(b => b.Title?.ToLower() == book.Title?.ToLower()))
            {
                return false;
            }
            else
            {
                _unitOfWork.Books.Add(book);
                _unitOfWork.Save();
                return true;
            }
        }
    }
}
