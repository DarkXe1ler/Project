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

        public static Class9 Class9()
        {
            return new Class9();
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
    }

    
}
