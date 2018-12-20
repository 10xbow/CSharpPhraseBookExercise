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
            // 2.1.3
            var songs = new List<Song>
            {
                new Song("Eternal Return", "CAPCOM", 320),
                new Song("Coils of Light", "CAPCOM", 256),
            };

            // 2.1.4
            songs.ForEach(s => s.Show());
            Console.ReadLine();
        }
    }
}
