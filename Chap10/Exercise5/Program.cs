using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = @".\sample.html";
            var before = File.ReadAllText(file);
            Console.WriteLine(before);
            TagLower(file);
            var after = File.ReadAllText(file);
            Console.WriteLine(after);
        }

        static void TagLower(string file)
        {
            var sample = File.ReadAllText(file);
            var pattern = @"<(/?)([A-Z][A-Z0-9]*)(.*?)>";
            var s = Regex.Replace
            (
                sample,
                pattern,
                m => { return string.Format("<{0}{1}{2}>", m.Groups[1].Value, m.Groups[2].Value.ToLower(), m.Groups[3].Value); }
            );
            File.WriteAllText(file, s);
        }
    }
}
