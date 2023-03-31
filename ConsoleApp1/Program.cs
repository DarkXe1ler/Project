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
                    case "Подразделение": UI.Print(ClassCreator.Division()); break;
                    case "Должность": UI.Print(ClassCreator.Class10()); break;
<<<<<<< HEAD
                    case "Дисциплина": UI.Print(ClassCreator.Discipline()); break;
                    case "Студент": UI.Print(ClassCreator.Student());break;
                    case "Смена": UI.Print(ClassCreator.Smena());break;
                    case "Сотрудник": UI.Print(ClassCreator.Employee()); break;
                    case "Аудитория": UI.Print(ClassCreator.Auditoria()); break;
                    case "Занятие": UI.Print(ClassCreator.Lesson()); break;
                    case "Специальность": UI.Print(ClassCreator.Specialization()); break;
                    case "Группа": UI.Print(ClassCreator.Group()); break;
=======
                    case "Дисциплина": UI.Print(ClassCreator.Class3()); break;
                    case "Студент": UI.Print(ClassCreator.Class5());break;
                    case "Сотрудник": UI.Print(ClassCreator.Class9()); break;
                    case "Аудитория": UI.Print(ClassCreator.Class2()); break;
                    case "Занятие": UI.Print(ClassCreator.Class1()); break;
                    case "Специальность": UI.Print(ClassCreator.Specialization()); break;
                    case "Группа": UI.Print(ClassCreator.Class4()); break;
>>>>>>> d4a5461feb0600e827b2ba386a46313144cdc7b0
                    default: Console.WriteLine("Такой класс не реализован"); break;
                }
            }
        }
    }
}
