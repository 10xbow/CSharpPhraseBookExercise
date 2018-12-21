using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Console.WriteLine("問題6.2");
            Console.WriteLine(@"{ 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 }");

            // 6.1.1
            Console.WriteLine("\n1. 最大値は");
            Console.WriteLine(numbers.Max());

            // 6.1.2
            Console.WriteLine("\n2. 最後から2つの要素は");
            numbers.Reverse().Take(2).ToList().ForEach(a => Console.WriteLine(a));

            // 6.1.3
            Console.WriteLine("\n3. 文字列に変換した結果は");
            numbers.ToList().ForEach(a => Console.WriteLine(a));

            // 6.1.4
            Console.WriteLine("\n4. 数の小さい順の先頭から3つは");
            numbers.OrderBy(n => n).Take(3).ToList().ForEach(a => Console.WriteLine(a));

            // 6.1.5
            Console.WriteLine("\n5. 10より大きい値の個数は");
            Console.WriteLine(numbers.Distinct().Count(n => n > 10));

            Console.ReadLine();
        }
    }
}
