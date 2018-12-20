using System;

namespace Exercise1
{
    // 4.1.1
    public class YearMonth
    {
        public int Year { get; private set; }
        public int Month { get; private set; }

        // 4.1.2
        public bool Is21Century => 2001 <= Year && Year <= 2100;

        public YearMonth(int year, int month)
        {
            Year = year;
            Month = month;
        }

        // 4.1.3
        public YearMonth AddOneMonth()
        {
            var temp = new DateTime(Year, Month, 1).AddMonths(1);
            return new YearMonth(temp.Year, temp.Month);
        }

        // 4.1.4
        public override string ToString()
        {
            return $"{Year}年{Month}月";
        }
    }
}
