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
        public static void Print(Class5 class5)
        {
            Console.WriteLine($"Class5.Фамилия = {class5.Фамилия}");
            Console.WriteLine($"Class5.Имя= {class5.Имя}");
            Console.WriteLine($"Class5. Отчество = {class5.Отчество}");
            Console.WriteLine($"Class5.Дата_Рождения = {class5.Дата_Рождения}");
            Print(class5.Группа);
        }
        public static void Print(Class4 class4)
        {
            Console.WriteLine($"Class4.Группа =");
        }
    }
}
