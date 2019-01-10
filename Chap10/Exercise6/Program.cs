using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "しるし しんぶんし きたのたき きもの いろしろい トマト ヨクナクヨ";
            var pattern = @"\b(\w)(\w)\w\2\1\b";
            Regex.Matches(text, pattern)
                 .Cast<Match>()
                 .ToList()
                 .ForEach(m => Console.WriteLine(m.Value));
        }
    }
}
