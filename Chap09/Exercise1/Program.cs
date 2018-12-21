using System;
using System.IO;
using System.Text;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        // 9.1.1
        static void Main(string[] args)
        {
            var filePath = "Program.cs";
            if (File.Exists(filePath))
            {
                var cnt = 0;
                using (var reader = new StreamReader(filePath, Encoding.UTF8))
                {  
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (line.Contains(" class ")) cnt++;
                    }
                }
                Console.WriteLine(cnt);
            }
            Exercise9_1_2();
            Exercise9_1_3();
            Console.ReadLine();
        }

        // 9.1.2
        static void Exercise9_1_2()
        {
            var filePath = "Program.cs";
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath, Encoding.UTF8);
                var cnt = lines.Where(line => line.Contains(" class ")).Count();
                Console.WriteLine(cnt);
            }
        }

        // 9.1.3
        static void Exercise9_1_3()
        {
            var filePath = "Program.cs";
            if (File.Exists(filePath))
            {
                var lines = File.ReadLines(filePath, Encoding.UTF8);
                var cnt = lines.Where(line => line.Contains(" class ")).Count();
                Console.WriteLine(cnt);
            }
        }
    }
}
