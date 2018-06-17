using System;
using System.Collections.Generic;
using System.Linq;

namespace Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();
            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string title = input[0];
                string author = input[1];
                string publisher = input[2];
                DateTime releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", null);
                string ISBN = input[4];
                double price = double.Parse(input[5]);
                books.Add(new Book
                {
                    Title = title,
                    Author = author,
                    Publisher = publisher,
                    ReleaseDate = releaseDate,
                    ISBN = ISBN,
                    Price = price
                });
            }
            DateTime finalDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
            foreach (var book in books.OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title))
            {
                if (book.ReleaseDate.Date > finalDate.Date)
                {
                    Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
                }
            }
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }
}
