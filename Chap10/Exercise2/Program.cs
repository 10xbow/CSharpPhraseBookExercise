using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = string.Join("",File.ReadLines("sample.txt"));
            var matches = Regex.Matches(text, @"\d{3,}");
            foreach (Match match in matches)
            {
                Console.WriteLine($"{match.Value}");
            }
        }
    }
}
