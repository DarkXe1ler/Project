using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class11
    {
        public string Name { get; }
        public Class9 Class9 { get; }
        public Class12 Class12 { get; }


        public Class11(string name, Class9 class9, Class12 class12)
        {
            this.Name = name;
            this.Class9 = class9;
            this.Class12 = class12;
        }
    }
}
