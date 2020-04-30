using System.Collections.Generic;
using Fisher.Bookstore.Data;
using Fisher.Bookstore.Models;

namespace Fisher.Bookstore.Services
{
    public class BooksRepository : IBooksRepository
    {
        private readonly BookstoreContext db;
        public BooksRepository(BookstoreContext db)
        {
            this.db = db;
        }

        public int AddBook(Book book)
        {
            throw new System.NotImplementedException();
        }

        public bool BookExists(int bookId)
        {
            throw new System.NotImplementedException();
        }

        public bool BookExists(object bookId)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteBook(int bookId)
        {
            throw new System.NotImplementedException();
        }

        public Book GetBook(int bookId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Book> GetBooks()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            throw new System.NotImplementedException();
        }
    }
}