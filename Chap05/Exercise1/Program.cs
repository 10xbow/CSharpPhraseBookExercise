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
            // 5.1.1
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();

            Console.WriteLine(string.Compare(str1, str2, ignoreCase:true) == 0 ? "等しい" : "等しくない");
            Console.ReadLine();
        }
    }
}
