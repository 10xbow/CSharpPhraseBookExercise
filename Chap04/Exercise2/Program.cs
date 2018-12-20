using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4.2.1
            var yearMonthList = new List<YearMonth>
            {
                new YearMonth(1980, 2),
                new YearMonth(1981, 5),
                new YearMonth(2005, 12),
                new YearMonth(1900, 1),
                new YearMonth(2078, 11),
            };

            // 4.2.2
            yearMonthList.ForEach(e => Console.WriteLine(e));

            // 4.2.4
            var first21Century = FindFirst21Century(yearMonthList);
            Console.WriteLine(first21Century == null ? "21世紀のデータはありません" : first21Century.Year.ToString());

            // 4.2.5
            var afterMonth = yearMonthList.Select(n => n.AddOneMonth()).ToList();
            afterMonth.ForEach(e => Console.WriteLine(e));

            Console.ReadLine();
        }

        // 4.2.3
        static YearMonth FindFirst21Century(ICollection<YearMonth> yearMonths)
        {
            foreach (var item in yearMonths)
            {
                if (item.Is21Century)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
