using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inch\tMeter");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}\t{InchToMeter(i)}");
            }
            Console.ReadLine();
        }

        static double InchToMeter(double inch)
        {
            return inch * 0.0254;
        }
    }
}
