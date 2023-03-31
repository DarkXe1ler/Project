using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        public string Surname { get; }
        public string Name { get; }
        public string Middlename { get; }
        public int DateOfBirth { get; }
        public Group Group{ get; }

        public Student(string surname, string name, string middlename, int dateOfBirth, Group group)
        {
            Surname = surname;
            Name = name;
            Middlename = middlename;
            DateOfBirth = dateOfBirth;
            Group = group;
        }
    }
}
