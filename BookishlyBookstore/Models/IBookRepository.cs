using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookishlyBookstore.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int bookId);
    }
}
