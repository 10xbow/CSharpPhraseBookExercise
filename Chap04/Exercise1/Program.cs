using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ym = new YearMonth(2018, 12);
            var afterMonth = ym.AddOneMonth();
            Console.WriteLine(afterMonth.ToString());
            Console.WriteLine(afterMonth.Is21Century);
            Console.ReadLine();
        }
    }
}
