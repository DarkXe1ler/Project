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
        public static void Print(Class2 class2)
        {
            Console.WriteLine($"Class2.Название = {class2.Name}");
            Print(class2.Class9);
            Console.WriteLine($"Class2.Количество мест = {class2.NumberMest}");
            Console.WriteLine($"Class2.Количество окон = {class2.NumberOkon}");
            Print(class2.Class15);
        }

        public static void Print(Discipline discipline)
        {
            Console.WriteLine($"Название дисциплины: {discipline.Name}");
            Console.WriteLine($"Сокращение дисциплины: {discipline.ShortName}");
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

        public static void Print(Student student)
        {
            Console.WriteLine($"Student Фамилия Студента = {student.Surname}");
            Console.WriteLine($"Student Имя Студента = {student.Name}");
            Console.WriteLine($"Student Отчество Студента = {student.Middlename}");
            Console.WriteLine($"Student Дата Рождения Студента = {student.DateOfBirth}");
            Print(student.Group);
        }
        public static void Print(Class6 class6)
        {
            Console.WriteLine($"Class6.Введите название специальности = {class6.Named}");
            Console.WriteLine($"Class6.Введите сокращение = {class6.Reduction}");
        }

        public static void Print(Class9 class9)
        {
            Console.WriteLine($"Director.Фамилия: {class9.Surname}");
            Console.WriteLine($"Director.Имя: {class9.Name}");
            Console.WriteLine($"Director.Отчество: {class9.Patronymic}");
            Print(class9._class10);
        }

        public static void Print(Class10 class10)
        {
            Console.WriteLine($"Class10.Имя = {class10.Name}");
            Console.WriteLine($"Class10.Оклад = {class10.Salary}");
            Print(class10.Class11);

        }

        public static void Print(Department class11)
        {
            Console.WriteLine($"Class11.Имя = {class11.Name}");
            Print(class11.Director);
            Print(class11.Organization);
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
