using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee { Id = 1, Name = "James", HireDate = new DateTime(1980, 2, 28) };

            // 12.1.1
            var settings = new XmlWriterSettings
            {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                IndentChars = "    ",
            };
            using (var writer = XmlWriter.Create("employee.xml", settings))
            {
                var serializer = new XmlSerializer(employee.GetType());
                serializer.Serialize(writer, employee);
            }

            // 12.1.2
            var employees = new List<Employee> { };
            employees.Add(employee);
            employees.Add(new Employee { Id = 2, Name = "Kirby", HireDate = new DateTime(2018, 2, 28) });

            using (var writer = XmlWriter.Create("employees.xml", settings))
            {
                var serializer = new DataContractSerializer(employees.GetType());
                serializer.WriteObject(writer, employees);
            }

            // 12.1.3
            using (XmlReader reader = XmlReader.Create("employees.xml"))
            {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var desirializedEmployees = serializer.ReadObject(reader) as Employee[];
                desirializedEmployees.ToList()
                                     .ForEach(e => Console.WriteLine($"{e.Id.ToString()}\t{e.Name}\t{e.HireDate.ToString()}"));
            }

            // 12.1.4
            var employees2 = new Employee2[]
            {
                new Employee2 {Id = 3, Name = "Mai", HireDate = new DateTime(2016, 9, 4) },
                new Employee2 {Id = 4, Name = "Azrael", HireDate = new DateTime(2016, 9, 7) },
            };
            using (var stream = new FileStream("enployee2.json", FileMode.Create, FileAccess.Write))
            {
                var serializer = new DataContractJsonSerializer(employees2.GetType());
                serializer.WriteObject(stream, employees2);
            }
        }
    }
}
