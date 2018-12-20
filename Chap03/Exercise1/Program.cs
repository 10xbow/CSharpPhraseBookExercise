using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            // 3.1.1
            Console.WriteLine(numbers.Exists(n => n % 8 == 0 || n % 9 == 0).ToString());

            // 3.1.2
            numbers.ForEach(n => Console.WriteLine($"{n / 2.0}"));

            // 3.1.3
            Console.WriteLine(string.Join("\t", numbers.Where(n => n >= 50)));

            // 3.1.4
            var twice = numbers.Select(n => n * 2).ToList();
            Console.WriteLine(string.Join("\t",twice));

            Console.ReadLine();
        }
    }
}
