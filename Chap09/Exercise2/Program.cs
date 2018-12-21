using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) return;
            var file = args[0];
            if (!File.Exists(file)) return;

            var fileInfo = new FileInfo(file);
            var newFileName = "AddLineNumber_" + fileInfo.Name;

            var lines = Read(file).Select((s, ix) => $"{ix + 1}\t{s}");
            File.WriteAllLines(newFileName, lines);
        }

        static IEnumerable<string> Read(string file)
        {
            return File.ReadLines(file, Encoding.UTF8);
        }
    }
}
