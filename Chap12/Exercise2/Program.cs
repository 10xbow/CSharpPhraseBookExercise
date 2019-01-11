using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 12.2.1
            using (var reader = XmlReader.Create("Sample.xml"))
            {
                var serializer = new XmlSerializer(typeof(Novelist));
                var novelist = serializer.Deserialize(reader) as Novelist;
                Console.WriteLine($"{novelist.Name}\t{novelist.Birth.ToString()}\n{string.Join("\t",novelist.Masterpieces)}");
                // 12.2.2
                using (var stream = new FileStream("novelist.json", FileMode.Create, FileAccess.Write))
                {
                    var settings = new DataContractJsonSerializerSettings
                    {
                        DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ssZ")
                    };
                    var jsonSerializer = new DataContractJsonSerializer(novelist.GetType(),settings);
                    jsonSerializer.WriteObject(stream, novelist);
                }
            }


        }
    }
}
