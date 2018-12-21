using System;
using System.IO;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OriginalDir?");
            var originalDir = Console.ReadLine();
            Console.WriteLine("DestinationDir?");
            var destinationDir = Console.ReadLine();

            var di = new DirectoryInfo(originalDir);
            var files = di.EnumerateFiles();
            foreach (var file in files)
            {
                var newFile = $"{Path.GetFileNameWithoutExtension(file.FullName)}_bak{file.Extension}";
                file.CopyTo(Path.Combine(destinationDir, newFile),overwrite:true);
            }
        }
    }
}
