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

        public static void Print(ClassC classC)
        {

        }

        public static void Print(Class9 class9)
        {

        }

        public static void Print(Class11 class11)
        {
            Console.WriteLine($"Class11.Name = {class11.Name}");
            Print(class11.class9);
            Print(class11.class12);
        }

        public static void Print(Class12 class12)
        {

        }
    }
}
