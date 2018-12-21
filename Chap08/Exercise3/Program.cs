using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var tw = new TimeWatch();
            tw.Start();
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine(i);
            }
            TimeSpan duration = tw.Stop();
            Console.WriteLine($"処理時間は{duration.TotalMilliseconds}ミリ秒でした");
            Console.ReadLine();
        }
    }
}
