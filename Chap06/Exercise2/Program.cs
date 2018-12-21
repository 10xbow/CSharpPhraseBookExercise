using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            // 6.2.1
            books.Where(b => b.Title == "ワンダフル・C#ライフ")
                 .ToList()
                 .ForEach(b => Console.WriteLine($"価格: {b.Price}, ページ数: {b.Pages}"));

            // 6.2.2
            Console.WriteLine(books.Count(b => b.Title.Contains("C#")));

            // 6.2.3
            var avg = books.Where(b => b.Title.Contains("C#")).Average(b => b.Pages);
            Console.WriteLine(avg);

            // 6.2.4
            Console.WriteLine(books.FirstOrDefault(b => b.Price >= 4000).Title);

            // 6.2.5
            var max = books.Where(b => b.Price < 4000).Max(b => b.Pages);
            Console.WriteLine(max);

            // 6.2.6
            books.Where(b => b.Pages >= 400)
                 .OrderByDescending(b => b.Price)
                 .ToList()
                 .ForEach(b => Console.WriteLine($"タイトル: {b.Title}\t価格: {b.Price}"));

            // 6.2.7
            books.Where(b => b.Title.Contains("C#") && b.Pages <= 500)
                 .Select(b => b.Title)
                 .ToList()
                 .ForEach(b => Console.WriteLine(b));

            Console.ReadLine();
        }
    }
}
