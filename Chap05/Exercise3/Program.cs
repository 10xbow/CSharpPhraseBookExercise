using System;
using System.Linq;
using System.Text;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var target = "Jackdaws love my big sphinx of quartz";

            // 5.3.1
            Console.WriteLine(target.Where(t => t == ' ').Count());

            // 5.3.2
            var toSmall = target.Replace("big", "small");
            Console.WriteLine(toSmall);

            // 5.3.3
            Console.WriteLine(target.Split(' ').Count());

            // 5.3.4
            target.Split(' ').Where(t => t.Length <= 4).ToList().ForEach(i => Console.WriteLine(i));

            // 5.3.5
            var words = target.Split(' ');
            if (words.Length > 0)
            {
                var sb = new StringBuilder(words[0]);
                words.Skip(1).ToList().ForEach(w => sb.Append(" " + w));
                Console.WriteLine(sb);
            }

            Console.ReadLine();
        }
    }
}
