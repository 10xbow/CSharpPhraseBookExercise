// 1.1.3
using Exercise1.Models;
using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.1.1
            var dorayaki = new Product(98, "どら焼き", 210);

            // 1.1.2
            Console.WriteLine(dorayaki.GetTax());
            Console.ReadLine();
        }
    }
}
