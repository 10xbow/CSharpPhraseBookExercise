using System;
using System.IO;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File1?");
            var origin = Console.ReadLine();
            Console.WriteLine("File2?");
            var add = Console.ReadLine();

            var contents = File.ReadLines(add);

            File.AppendAllLines(origin, contents);
        }
    }
}
