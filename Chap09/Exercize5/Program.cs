using System;
using System.IO;
using System.Linq;

namespace Exercize5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dir?");
            var dir = Console.ReadLine();
            var di = new DirectoryInfo(dir);
            var files = di.EnumerateFiles("*",SearchOption.AllDirectories);
            files.Where(f => f.Length > 1048576).ToList().ForEach(f => Console.WriteLine(f.Name));
            Console.ReadLine();
        }
    }
}
