using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var texts = new[]
            {
                "Time is money.",
                "What time is it?",
                "It will take time.",
                "We reorganized the timetable."
            };

            foreach (var text in texts)
            {
                Regex.Matches(text, @"\btime\b",RegexOptions.IgnoreCase)
                     .Cast<Match>()
                     .ToList()
                     .ForEach(m => Console.WriteLine(m.Index));
            }
        }
    }
}
