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
            return new Lesson(date, Class3(), Class9(), Class2(), Group(), Para(), Class14());

        }

        public static Class2 Class2()
        {
            Console.Write("Введите название аудитории: ");
            string aud = Console.ReadLine();
            Console.Write("Введите количество мест: ");
            string mesta = Console.ReadLine();
            Console.Write("Введите количество окон: ");
            string okna = Console.ReadLine();
            return new Class2(aud, Class9(), mesta, okna, Class15());
        }
        public static Class3 Class3()
        {
            Console.Write("Введите дисциплину: ");
            string name = Console.ReadLine();
            Console.Write("Введите сокращение дисциплины: ");
            string shortName = Console.ReadLine();
            return new Class3(name, shortName);

        }



        public static Class5 Class5()
        {
            Console.Write("Введите имя: ");
            string имя = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string фамилия = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string отчество = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            string дата_рождения = Console.ReadLine();
            return new Class5(имя, фамилия, отчество, дата_рождения, Group());
        }
        public static Class9 Class9()
        {
            Console.Write("Введите фамилию: ");
            string surnname = Console.ReadLine();
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите Отчество: ");
            string patronymic = Console.ReadLine();
            return new Class9(surnname, name, patronymic, Class10());
        }
        public static Class6 Class6()
        {
            Console.WriteLine("Введите название специальности");
            string named = Console.ReadLine();
            Console.WriteLine("Введите сокращение");
            string reduction = Console.ReadLine();
            return new Class6(named, reduction);
        }

        public static Class10 Class10()
        {
            Console.Write("Введите название: ");
            string name = Console.ReadLine();
            Console.Write("Введите оклад: ");
            string salary = Console.ReadLine();
            return new Class10(name, salary, Class11());
        }

        public static Class11 Class11()
        {
            Console.Write("Введите название: ");
            string name = Console.ReadLine();  

            return new Class11(name, Class9(), Class12());
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
            return new Group(name, abbreviation, number, yearOfAdmission, Class6(), Class9());


        }
    }

    
}
