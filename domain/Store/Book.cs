using System;

namespace store
{
    public class Book

    {public int Id { get; }
        public string Title { get; }
        public Book(int id,string title) {
            Title = title;
            Id = id;
        }
    }
}
