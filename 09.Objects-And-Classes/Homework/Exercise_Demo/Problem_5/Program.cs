using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();
            library.Books = new List<Book>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var bookArgs = Console.ReadLine().Split(' ');

                var title = bookArgs[0];
                var author = bookArgs[1];
                var publisher = bookArgs[2];
                var releaseDate = DateTime.ParseExact(bookArgs[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbn = int.Parse(bookArgs[4]);
                var price = decimal.Parse(bookArgs[5]);

                var book = new Book();

                book.Title = title;
                book.Author = author;
                book.Publisher = publisher;
                book.ReleaseDate = releaseDate;
                book.IsbnNumber = isbn;
                book.Price = price;

                library.Books.Add(book);
            }

            foreach (var book in library.Books.GroupBy(b => b.Author).OrderByDescending(b => b.Sum(b1 => b1.Price)).ThenBy(b => b.Key))
            {
                Console.WriteLine($"{book.Key} -> {book.Sum(b => b.Price):F2}");
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int IsbnNumber { get; set; }
        public decimal Price { get; set; }
    }

    public class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
