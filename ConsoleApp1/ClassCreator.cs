using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class ClassCreator
    {
        public static ClassA ClassA()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите второе имя: ");
            string lastName = Console.ReadLine();
            return new ClassA(name, lastName);
        }

        public static ClassB ClassB()
        {
            return new ClassB(ClassA(), ClassC());
        }

        public static ClassC ClassC()
        {
            return new ClassC();
        }
        public static Para Para()
        {
            Console.Write("Укажите время начала пары: ");
            string TheStartTimeOfThePair = Console.ReadLine();
            Console.Write("Укажите время окончания пары: ");
            string TheEndTimeOfThePair = Console.ReadLine();
            Console.Write("Укажите время начала перерыва: ");
            string BreakStartTime = Console.ReadLine();
            Console.Write("Укажите время окончания перерыва: ");
            string BreakEndTime = Console.ReadLine();
            Smena smena = new Smena();

            return new Para(TheStartTimeOfThePair, TheEndTimeOfThePair, BreakStartTime, BreakEndTime, smena);
        }
        public static Lesson Lesson()
        {
            Console.Write("Введите дату проведения: ");
            string date = Console.ReadLine();
            return new Lesson(date, Discipline(), Employee(), Auditoria(), Group(), Para(), Class14());

        }

        public static Auditoria Auditoria()
        {
            Console.Write("Введите название аудитории: ");
            string aud = Console.ReadLine();
            Console.Write("Введите количество мест: ");
            string mesta = Console.ReadLine();
            Console.Write("Введите количество окон: ");
            string okna = Console.ReadLine();
            return new Auditoria(aud, Employee(), mesta, okna, Class15());
        }


        public static Discipline Discipline()
        {
            Console.Write("Введите дисциплину: ");
            string name = Console.ReadLine();
            Console.Write("Введите сокращение дисциплины: ");
            string shortName = Console.ReadLine();
            return new Discipline(name, shortName);
        }



        public static Student Student()
        {
            Console.Write("Введите имя студента: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию студента: ");
            string surname = Console.ReadLine();
            Console.Write("Введите отчество студента: ");
            string middlename = Console.ReadLine();
            Console.Write("Введите дату рождения студента: ");
            string dateOfBirth = Console.ReadLine();
            return new Student(name, surname, middlename, dateOfBirth, Group());
        }

        public static Employee Employee()
        {
            Console.Write("Введите фамилию: ");
            string surnname = Console.ReadLine();
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите Отчество: ");
            string patronymic = Console.ReadLine();
            return new Employee(surnname, name, patronymic, Class10());
        }
        public static Class6 Class6()
        {
            Console.WriteLine("Введите название специальности");
            string named = Console.ReadLine();
            Console.WriteLine("Введите сокращение");
            string reduction = Console.ReadLine();
            return new Class6(named, reduction);
        }


        public static Class8 Smena()
        {
            Console.WriteLine("Введите название смены: ");
            string name = Console.ReadLine();
            return new Class8(name);
        }

        public static Class10 Class10()
        {
            Console.Write("Введите название: ");
            string name = Console.ReadLine();
            Console.Write("Введите оклад: ");
            string salary = Console.ReadLine();
            return new Class10(name, salary, Division());
        }

        public static Division Division()
        {
            Console.Write("Введите название подразделения: ");
            string name = Console.ReadLine();  


            return new Division(name, Employee(), Class12());
        }

        public static Class12 Class12()
        {
            return new Class12();

        }

        public static Class14 Class14()
        {
            return new Class14();
        }

        public static Class15 Class15()
        {
            return new Class15();
        }

        public static Group Group()
        {
            int yearOfAdmission;
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите сокращение: ");
            string abbreviation = Console.ReadLine();
            Console.Write("Введите численность: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Введите год поступления: ");
            try
            {
                yearOfAdmission = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                yearOfAdmission = DateTime.Now.Year;
            }
            return new Group(name, abbreviation, number, yearOfAdmission, Class6(), Employee());


        }
    }

    
}
