using System;
using System.Linq;
using System.Xml.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var xdoc = XDocument.Load("Sample.xml");
            var xelements = xdoc.Root.Elements();

            // 11.1.1
            xelements.Select(x => new
                        {
                            Name = (string)x.Element("name"),
                            Teammembers = (int)x.Element("teammembers")
                        })
                     .ToList()
                     .ForEach(x => Console.WriteLine($"{x.Name}\t{x.Teammembers.ToString()}"));

            // 11.1.2
            xelements.OrderBy(x => (int)x.Element("firstplayed"))
                     .ToList()
                     .ForEach(x => Console.WriteLine(x.Element("name").Attribute("kanji").Value));

            // 11.1.3
            xelements.OrderByDescending(x => (int)x.Element("teammembers"))
                     .Take(1)
                     .ToList()
                     .ForEach(x => Console.WriteLine($"{(string)x.Element("name")}"));

            // 11.1.4
            var element = new XElement("ballsport",
                new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                new XElement("teammembers", "11"),
                new XElement("firstplayed", "1863")
                );

            xdoc.Root.Add(element);
            xdoc.Save("addSoccer.xml");
        }
    }
}
