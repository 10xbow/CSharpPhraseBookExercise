using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() == 0) return;
            var path = args[0];
            var lines = File.ReadAllLines(path);
            var newLines = lines.Select(s => Regex.Replace(s, @"\b[Vv]ersion\s*=\s*""v4\.0""", @"version=""v5.0"""));
            File.WriteAllLines(path, newLines);
        }
    }
}
