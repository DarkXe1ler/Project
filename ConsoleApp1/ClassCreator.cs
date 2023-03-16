using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public static Class1 Class1()
        {
            Console.Write("Введите дату проведения: ");
            string date = Console.ReadLine();
            return new Class1(date, Class3(), Class9(), Class2(), Class4(), Class7(), Class14());
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

        public static Class4 Class4()
        {
            return new Class4();
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
            Class4 группа = new Class4();
            return new Class5(имя, фамилия, отчество, дата_рождения, группа);
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
        public static Class7 Class7()
        {
            return new Class7();

        }

        public static Class10 Class10()
        {
            return new Class10();
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
    }

    
}
