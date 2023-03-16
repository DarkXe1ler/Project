using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class2
    {
        public string Name { get; }
        public Class9 Class9 { get; }
        public string NumberMest { get; }
        public string NumberOkon { get; }
        public Class15 Class15 { get; }

        public Class2(string name, Class9 class9, string numbermest, string numberokon, Class15 class15)
        {
            Name = name;
            Class9 = class9;
            NumberMest = numbermest;
            NumberOkon = numberokon;
            Class15 = class15;
        }
    }
}
