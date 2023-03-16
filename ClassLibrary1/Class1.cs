using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public string Date { get; }
        public Class3 Class3 { get; }
        public Class9 Class9 { get; }
        public Class2 Class2 { get; }
        public Class4 Class4 { get; }
        public Class7 Class7 { get; }
        public Class14 Class14 { get; }

        public Class1(string date, Class3 class3, Class9 class9, Class2 class2, Class4 class4, Class7 class7, Class14 class14)
        {
            Date = date;
            Class3 = class3;
            Class9 = class9;
            Class2 = class2;
            Class4 = class4;
            Class7 = class7;
            Class14 = class14;
        }
    }
}
