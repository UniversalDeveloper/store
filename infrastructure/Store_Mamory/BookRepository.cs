using store;
using System;
using System.Linq;

namespace Store_Mamory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[] { 
        new Book(1, "Art of Programing","ISBN 12312-31231","D.Knuth","Обучение програмированию",1.5m),
         new Book(2, "Refactorng","ISBN 12312-31232","M. Fowler","Проведение правильного рефакторинга",3m),
          new Book(3, "ISBN 12312-31231","B.Kernighan,D.Rit","C Programing Language"," Базовые элементы языка С",5m),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn).ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Title.Contains(query) || book.Author.Contains(query)).ToArray();
        }

        Book IBookRepository.GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }
    }
}
