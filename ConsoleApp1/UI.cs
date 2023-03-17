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
        public static void Print(Para para)
        {
            Console.WriteLine($"Para.Время начала пары = {para.TheStartTimeOfThePair}");
            Console.WriteLine($"Para.Время окончания пары = {para.TheEndTimeOfThePair}");
            Console.WriteLine($"Para.Время начала перерыва = {para.BreakStartTime}");
            Console.WriteLine($"Para.Время окончания перерыва = {para.BreakEndTime}");
        }
        public static void Print(Lesson lesson)
        {
            Console.WriteLine($"Дата проведения занятия = {lesson.Date}");
            Print(lesson.Disciplina);
            Print(lesson.Sotrudnik);
            Print(lesson.Auditoria);
            Print(lesson.Group);
            Print(lesson.Para);
            Print(lesson.VidZanyatia);
        }
        public static void Print(Auditoria Auditoria)
        {
            Console.WriteLine($"Auditoria.Название = {Auditoria.Name}");
            Print(Auditoria.Class9);
            Console.WriteLine($"Auditoria.Количество мест = {Auditoria.NumberMest}");
            Console.WriteLine($"Auditoria.Количество окон = {Auditoria.NumberOkon}");
            Print(Auditoria.Class15);
        }

        public static void Print(Class3 class3)
        {
            Console.WriteLine($"Название дисциплины: {class3.Name}");
            Console.WriteLine($"Сокращение дисциплины: {class3.ShortName}");
        }

        public static void Print(Group group)
        {
            Console.WriteLine($"Group.Название = {group.Name}");
            Console.WriteLine($"Group.Сокращение = {group.Abbreviation}");
            Console.WriteLine($"Group.Численность = {group.Number}");
            Console.WriteLine($"Group.ГодПоступления = {group.YearOfAdmission}");
            Print(group.HomeroomTeacher);
            Print(group.Speciality);
        }

        public static void Print(Class5 class5)
        {
            Console.WriteLine($"Class5.Фамилия = {class5.Фамилия}");
            Console.WriteLine($"Class5.Имя = {class5.Имя}");
            Console.WriteLine($"Class5. Отчество = {class5.Отчество}");
            Console.WriteLine($"Class5.Дата_Рождения = {class5.Дата_Рождения}");
            Print(class5.Группа);
        }
        public static void Print(Class6 class6)
        {
            Console.WriteLine($"Class6.Введите название специальности = {class6.Named}");
            Console.WriteLine($"Class6.Введите сокращение = {class6.Reduction}");
        }

        public static void Print(Class9 class9)
        {
            Console.WriteLine($"Class9.Фамилия: {class9.Surname}");
            Console.WriteLine($"Class9.Имя: {class9.Name}");
            Console.WriteLine($"Class9.Отчество: {class9.Patronymic}");
            Print(class9._class10);
        }

        public static void Print(Class10 class10)
        {
            Console.WriteLine($"Class10.Имя = {class10.Name}");
            Console.WriteLine($"Class10.Оклад = {class10.Salary}");
            Print(class10.Class11);

        }

        public static void Print(Class11 class11)
        {
            Console.WriteLine($"Class11.Имя = {class11.Name}");
            Print(class11.Class9);
            Print(class11.Class12);
        }

        public static void Print(Class12 class12)
        {
            
            
        }

        public static void Print(Class14 class14)
        {

        }

        public static void Print(Class15 class15)
        {

        }
    }
}
