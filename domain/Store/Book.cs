using System;
using System.Text.RegularExpressions;

namespace store
{
    public class Book

    {public int Id { get; }
        public string Title { get; }
        public string  Isbn{ get; }
        public string Author { get; }

        public string Description { get; }
        public decimal Price { get; }
        public Book(int id,string title, string isbn, string author,string description,decimal price) {
            Title = title;
            Isbn = isbn;
            Author = author;
            Id = id;
           Description = description;
            Price = price;

        }

        internal static bool IsIsbn(string s)
        {
            if (s == null)
                return false;

            s = s.Replace("-", "")
                .Replace(" ", "")
                .ToUpper();

            return Regex.IsMatch(s,"^ISBN\\d{10}(\\d{3})?$");
        }
    }
}
