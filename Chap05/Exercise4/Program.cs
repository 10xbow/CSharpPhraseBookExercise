using System;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            args[0].Replace("Novelist=", "作家\t: ")
                   .Replace("BestWork=", "代表作\t: ")
                   .Replace("Born=", "誕生年\t: ")
                   .Split(';')
                   .ToList()
                   .ForEach(a => Console.WriteLine(a));
            Console.ReadLine();
        }
    }
}
