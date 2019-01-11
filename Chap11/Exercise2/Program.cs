using System.Linq;
using System.Xml.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var xdoc = XDocument.Load("sample.xml");
            var dict = xdoc.Root.Elements().ToDictionary(x => (string)x.Element("kanji"), x => (string)x.Element("yomi"));
            xdoc.Root.RemoveAll();
            foreach (var item in dict)
            {
                var element = new XElement("word", new XAttribute("kanji", item.Key), new XAttribute("yomi", item.Value));
                xdoc.Root.Add(element);
            }
            xdoc.Save("result.xml");
        }
    }
}
