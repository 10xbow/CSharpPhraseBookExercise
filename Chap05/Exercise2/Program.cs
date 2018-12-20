using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.TryParse(Console.ReadLine(), out int result);
            Console.WriteLine($"{result:#,0}");
            Console.ReadLine();
        }
    }
}
