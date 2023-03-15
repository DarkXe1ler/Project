using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class UI
    {
        public static void Print(ClassA classA)
        {
            Console.WriteLine($"ClassA.Name = {classA.Name}");
            Console.WriteLine($"ClassA.LastName = {classA.LastName}");
        }

        public static void Print(ClassB classB)
        {
            Print(classB.ClassA);
            Print(classB.ClassC);
        }

        public static void Print(Class3 class3)
        {
            Console.WriteLine($"Название дисциплины: {class3.Name}");
            Console.WriteLine($"Сокращение дисциплины: {class3.ShortName}");
        }
        public static void Print(ClassC classC)
        {

        }
    }
}
