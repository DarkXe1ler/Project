using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class9
    {
        public string Surname { get; }
        public string Name { get; }
        public string Patronymic { get; }

        public Class10 _class10 { get; }

        public Class9(string surname, string name, string patronymic, Class10 class10) 
        {
            Surname= surname;
            Name= name;
            Patronymic= patronymic;
            _class10 = class10;
        }
    }
}
