using System;
using System.Linq;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Book book2 = book;
            book.Title = "blahblah";
            book.Author = "blahblah";
            book.Price = 22;

            Console.WriteLine(asd);
        }
    }
}
