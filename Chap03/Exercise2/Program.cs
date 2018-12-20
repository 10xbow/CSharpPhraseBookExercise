using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>
            {
                "Tokyo",
                "New Delhi",
                "Bangkok",
                "London",
                "Paris",
                "Berlin",
                "Canberra",
                "Hong Kong",
            };

            // 3.2.1
            var line = Console.ReadLine();
            Console.WriteLine(names.FindIndex(f => f == line));

            // 3.2.2
            Console.WriteLine(names.Where(n => n.Contains("o")).Count());

            // 3.2.3
            var contains_o = names.Where(n => n.Contains("o"));
            Console.WriteLine(string.Join(", ",contains_o));

            // 3.2.4
            Console.WriteLine(string.Join(", ",names.Where(w => w.StartsWith("B")).Select(s => s.Length)));

            Console.ReadLine();
        }
    }
}
