using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

        public class Class4
        {
            //group
            public string Name { get; }
            public string Abbreviation { get; }
            public int Number { get; }
            public int YearOfAdmission { get; }

            public Class6 Class6 { get; }
            public Class9 Class9 { get; }

            public Class4(string name, string abbreviation, int number, int yearOfAdmission, Class6 speciality, Class9 homeroomTeacher)
            {
                this.Name = name;
                this.Abbreviation = abbreviation;
                this.Number = number;
                this.YearOfAdmission = yearOfAdmission;
                Class6 = speciality;
                Class9 = homeroomTeacher;

            }
        }
    
}
