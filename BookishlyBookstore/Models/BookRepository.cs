using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookishlyBookstore.Models
{
    public class BookRepository:IBookRepository
    {
        private readonly AppDbContext _appDbContext;

        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _appDbContext.Books;
        }

        public Book GetBookById(int bookId)
        {
            return _appDbContext.Books.FirstOrDefault(b => b.Id == bookId);
        }
    }
}
