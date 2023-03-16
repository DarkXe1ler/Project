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
            Console.Write("Укажите время начала пары");
            string TheStartTimeOfThePair = Console.ReadLine();
            Console.Write("Укажите время окончания пары");
            string TheEndTimeOfThePair = Console.ReadLine();
            Console.Write("Укажите время начала перерыва");
            string BreakStartTime = Console.ReadLine();
            Console.Write("Укажите время окончания перерыва");
            string BreakEndTime = Console.ReadLine();
            Smena smena = new Smena();

            return new Para(TheStartTimeOfThePair, TheEndTimeOfThePair, BreakStartTime, BreakEndTime, smena);
        }
    }

    
}
