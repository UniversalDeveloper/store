using store;
using System;
using System.Linq;

namespace Store_Mamory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[] { 
        new Book(1, "Art of Programing","ISBN 12312-31231","D.Knuth"),
         new Book(2, "Refactorng","ISBN 12312-31232","M. Fowler"),
          new Book(3, "ISBN 12312-31231","B.Kernighan,D.Rit","C Programing Language"),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn).ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Title.Contains(query) || book.Author.Contains(query)).ToArray();
        }

       
    }
}
