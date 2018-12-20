using System;

namespace Exercise1
{
    // 2.1.1
    class Song
    {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; }

        // 2.1.2
        public Song(string title, string artistName, int length)
        {
            Title = title;
            ArtistName = artistName;
            Length = length;
        }

        // 2.1.4
        public void Show()
        {
            var span = new TimeSpan(0, 0, Length);
            Console.WriteLine($"Title: {Title}, ArtistName: {ArtistName}, Length: {span.ToString(@"m\:ss")}");
        }
    }
}
