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

        public static void Print(Employee employee)
        {
            Console.WriteLine($"Фамилия сотрудника : {employee.Surname}");
            Console.WriteLine($"Имя сотрудника : {employee.Name}");
            Console.WriteLine($"Отчество сотрудника : {employee.Patronymic}");
            Print(employee.Position);
        }

        public static void Print(Class10 class10)
        {

        }

        public static void Print(Class11 class11)
        {
            Console.WriteLine($"Class11.Имя = {class11.Name}");
            Print(class11.class9);
            Print(class11.class12);
        }

        public static void Print(Class12 class12)
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
            
        }
    }
}
