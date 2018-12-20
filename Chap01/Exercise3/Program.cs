using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.3.2
            var arisa = new Student
            {
                Name = "Arisa",
                BirthDay = new DateTime(2005, 12, 15),
                Grade = 3,
                ClassNumber = 2
            };
            
            // 1.3.3
            ShowObjectInfo(arisa);

            // 1.3.4
            Person arisaAsPerson = arisa;
            object arisaAsObject = arisa;

            Console.ReadLine();
        }

        static void ShowObjectInfo(object obj)
        {
            Console.WriteLine(obj.GetType());
            var properties = obj.GetType().GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine($"{property.Name}: {property.GetValue(obj)}");
            }
        }

    }
}
