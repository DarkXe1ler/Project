using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Какой класс Вы хотите создать: ");
                switch (Console.ReadLine())
                {
                    case "Пара": UI.Print(ClassCreator.Para()); break;
                    case "Подразделение": UI.Print(ClassCreator.Class11()); break;
                    case "Должность": UI.Print(ClassCreator.Class10()); break;
                    case "Дисциплина": UI.Print(ClassCreator.Discipline()); break;
                    case "Студент": UI.Print(ClassCreator.Class5());break;
                    case "Сотрудник": UI.Print(ClassCreator.Class9()); break;
                    case "Аудитория": UI.Print(ClassCreator.Class2()); break;
                    case "Занятие": UI.Print(ClassCreator.Lesson()); break;
                    case "Специальность": UI.Print(ClassCreator.Class6()); break;
                    case "Группа": UI.Print(ClassCreator.Group()); break;
                    default: Console.WriteLine("Такой класс не реализован"); break;
                }
            }
        }
    }
}
