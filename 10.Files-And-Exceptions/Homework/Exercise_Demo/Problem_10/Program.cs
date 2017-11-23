using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Problem_10
{
    class Program
    {
        static void Main()
        {
            var books = new List<Book>();

            var input = File.ReadAllLines(@"../../Input.txt");
            File.Delete(@"../../Output.txt");

            for (int i = 1; i < input.Length - 1; i++)
            {
                var bookArgs = input[i].Split(' ');

                var title = bookArgs[0];
                var author = bookArgs[1];
                var publisher = bookArgs[2];
                var releaseDate = DateTime.ParseExact(bookArgs[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbn = bookArgs[4];
                var price = decimal.Parse(bookArgs[5]);

                var book = new Book
                {
                    Title = title,
                    Author = author,
                    Publisher = publisher,
                    ReleaseDate = releaseDate,
                    Isbn = isbn,
                    Price = price
                };

                books.Add(book);
            }

            var date = DateTime.ParseExact(input[input.Length - 1], "dd.MM.yyyy", CultureInfo.InvariantCulture);


            var sortedBooks = books.Where(b => b.ReleaseDate > date).OrderBy(b => b.ReleaseDate).ThenBy(b => b.Title);

            foreach (var book in sortedBooks)
            {
                File.AppendAllText(@"../../Output.txt", $"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}" + Environment.NewLine);
            }
        }
    }

    public class Library
    {
        public string Name { get; set; }

        public List<Book> List { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Isbn { get; set; }
        public decimal Price { get; set; }
    }
}
