using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee
    {
        public string Surname { get; }
        public string Name { get; }
        public string Patronymic { get; }

        public Class10 Position { get; }

        public Employee(string surname, string name, string patronymic, Class10 position) 
        {
            Surname= surname;
            Name= name;
            Patronymic= patronymic;
            Position = position;
        }
    }
}
