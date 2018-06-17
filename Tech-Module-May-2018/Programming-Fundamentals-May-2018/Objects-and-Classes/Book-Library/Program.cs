using System;
using System.Collections.Generic;
using System.Linq;

namespace Book_Library
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

            Dictionary<string, double> authorTotalSum = new Dictionary<string, double>();
            foreach (var book in books)
            {
                if (authorTotalSum.ContainsKey(book.Author))
                {
                    authorTotalSum[book.Author] += book.Price;
                }
                else
                {
                    authorTotalSum.Add(book.Author, book.Price);
                }
            }

            foreach (var author in authorTotalSum.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
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
