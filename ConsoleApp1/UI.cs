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
    }
}
