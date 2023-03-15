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
        public Class9 class9 { get; }
        public Class12 class12 { get; }


        public Class11(string name, Class9 class9, Class12 class12)
        {
            this.Name = name;
            this.class9 = class9;
            this.class12 = class12;
        }
    }
}
