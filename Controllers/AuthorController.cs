using Library.Data;
using Library.Models;

namespace Library.Controllers
{
    public class AuthorController
    {
        private readonly IUnitOfWork _unitOfWork;

        public AuthorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool AddAuthor(Author author)
        {
            if (_unitOfWork.Authors.GetAll().Any(a => a.Name?.ToLower() == author.Name?.ToLower()))
            {
                return false;
            }
            else
            {
                _unitOfWork.Authors.Add(author);
                _unitOfWork.Save();
                return true;
            }
        }
    }
}
