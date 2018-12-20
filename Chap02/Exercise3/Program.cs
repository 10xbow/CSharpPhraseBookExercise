using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var sales = new SalesCounter("sales.csv");
            var amountPerProductCategory = sales.GetPerProductCategorySales();
            foreach (var obj in amountPerProductCategory)
            {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }
            Console.ReadLine();
        }
    }
}
