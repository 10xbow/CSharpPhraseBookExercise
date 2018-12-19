using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass { X = 1, Y = 2 };
            var myStruct = new MyStruct { X = 3, Y = 4 };

            // 1.2.3
            PrintObjectsTwice(myClass, myStruct);

            // 1.2.2
            PrintObjects(myClass, myStruct);

            Console.ReadLine();
        }

        // 1.2.1
        static void PrintObjects(MyClass myClass, MyStruct myStruct)
        {
            ShowObjectInfo(myClass);
            ShowObjectInfo(myStruct);

            void ShowObjectInfo(object obj)
            {
                Console.WriteLine(obj.GetType());
                var properties = obj.GetType().GetProperties();
                foreach (var property in properties)
                {
                    Console.WriteLine($"{property.Name}: {property.GetValue(obj)}");
                }
            }
        }

        // 1.2.3
        static void PrintObjectsTwice(MyClass myClass, MyStruct myStruct)
        {
            ShowObjectInfo(myClass);
            ShowObjectInfo(myStruct);

            void ShowObjectInfo(object obj)
            {
                Console.WriteLine(obj.GetType());
                var properties = obj.GetType().GetProperties();
                foreach (var property in properties)
                {
                    property.SetValue(obj, (int)property.GetValue(obj) * 2);
                    Console.WriteLine($"{property.Name}: {property.GetValue(obj)}");
                }
            }
        }
    }
}
