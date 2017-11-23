using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Problem_6
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

            var givenDate = Console.ReadLine();
            var date = DateTime.ParseExact(givenDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in library.Books.Where(b => b.ReleaseDate > date).OrderBy(b => b.ReleaseDate).ThenBy(b => b.Title))
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
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
