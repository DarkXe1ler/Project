using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

        public class Group
        {
            //group
            public string Name { get; }
            public string Abbreviation { get; }
            public int Number { get; }
            public int YearOfAdmission { get; }

            public Class6 Speciality { get; }
            public Employee HomeroomTeacher { get; }

            public Group(string name, string abbreviation, int number, int yearOfAdmission, Class6 speciality, Class9 homeroomTeacher)
            {
                this.Name = name;
                this.Abbreviation = abbreviation;
                this.Number = number;
                this.YearOfAdmission = yearOfAdmission;
                Speciality = speciality;
                HomeroomTeacher = homeroomTeacher;

            }
        }
    
}
