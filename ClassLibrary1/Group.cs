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

<<<<<<< HEAD:ClassLibrary1/Group.cs
            public Specialization Speciality { get; }
            public Employee HomeroomTeacher { get; }

            public Group(string name, string abbreviation, int number, int yearOfAdmission, Specialization speciality, Employee homeroomTeacher)
=======
            public Specialization Class6 { get; }
            public Class9 Class9 { get; }

            public Class4(string name, string abbreviation, int number, int yearOfAdmission, Specialization speciality, Class9 homeroomTeacher)
>>>>>>> d4a5461feb0600e827b2ba386a46313144cdc7b0:ClassLibrary1/Class4.cs
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
