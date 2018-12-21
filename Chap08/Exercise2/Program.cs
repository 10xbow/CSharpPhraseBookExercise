using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Today;
            var dayOfWeek = DayOfWeek.Saturday;
            Console.WriteLine($"{dayOfWeek} of next week is {NextWeek(now,dayOfWeek):yyyy-MM-dd}");
            Console.ReadLine();
        }

        static DateTime NextWeek(DateTime date, DayOfWeek dayOfWeek)
        {
            var nextWeek = date.AddDays(7);
            var days = (int)dayOfWeek - (int)date.DayOfWeek;
            return nextWeek.AddDays(days);
        }
    }
}
