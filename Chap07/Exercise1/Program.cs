using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var target = "Cozy lummox gives smart squid who asks for job pen";

            CountChar(target);
            CountChar2(target);
            Console.ReadLine();
        }

        // 7.1.1
        static void CountChar(string str)
        {
            var dictionary = str.ToUpper()
                                .GroupBy(c => c)
                                .ToDictionary(c => c.Key, c => c.Count())
                                .OrderBy(c => c.Key)
                                .Where(c => c.Key != ' ');

            foreach (var item in dictionary)
            {
                Console.WriteLine($"'{item.Key}': {item.Value}");
            }
        }

        // 7.1.2
        static void CountChar2(string str)
        {
            var dictionary = str.ToUpper()
                                .GroupBy(c => c)
                                .ToDictionary(c => c.Key, c => c.Count())
                                .OrderBy(c => c.Key)
                                .Where(c => c.Key != ' ');

            var sortedDictionary = new SortedDictionary<char, int> { };
            foreach (var item in dictionary)
            {
                sortedDictionary.Add(item.Key, item.Value);
            }

            foreach (var item in sortedDictionary)
            {
                Console.WriteLine($"'{item.Key}': {item.Value}");
            }
        }
    }
}
