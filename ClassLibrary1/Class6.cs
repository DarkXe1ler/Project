using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class6
    {
        public string Named { get; }
        public string Reduction { get; }
        public Class6(string named, string reduction)
        {
            Named = named;
            Reduction = reduction;
        }
    }
}
