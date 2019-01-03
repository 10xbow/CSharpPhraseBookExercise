using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sampleString = new List<string>{
                "090-9057-6930",
                "0A0-K730-20E5",
                "090-9057-69300",
                "0090-9057-6930",
            };

            sampleString.ForEach(s => Console.WriteLine($"{s}:{IsMobile(s).ToString()}"));
        }

        static bool IsMobile(string str)
        {
            return Regex.IsMatch(str, @"^0[7-9]0-\d{4}-\d{4}$");
        }
    }
}
