using System;
using System.Globalization;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8.1
            var now = DateTime.Now;
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            Console.WriteLine($"{now:yyyy/M/d hh:mm}");
            Console.WriteLine($"{now:yyyy年MM月dd日 hh時mm分ss秒}");

            var era = culture.DateTimeFormat.Calendar.GetEra(now);
            var eraName = culture.DateTimeFormat.GetEraName(era);
            var dayOfWeek = culture.DateTimeFormat.GetDayName(now.DayOfWeek);

            Console.WriteLine($"{now.ToString("ggyy年 M月d日(dddd)", culture)}");

            Console.ReadLine();
        }
    }
}
