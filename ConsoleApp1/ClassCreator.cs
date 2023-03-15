﻿using System;
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

        public static Class4 Class4()
        {
            return Class4();
        }
        
        public static Class5 Class5()
        {
            Console.Write("Введите имя: ");
            string имя= Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string фамилия = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string отчество = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            string дата_рождения = Console.ReadLine();
            Class4 группа=Class4();
            return new Class5(имя, фамилия, отчество, дата_рождения, группа);
        }
    }

    
}
