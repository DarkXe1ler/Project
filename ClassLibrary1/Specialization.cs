using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Specialization
    {
        public string Named { get; }
        public string Reduction { get; }
        public Specialization(string named, string reduction)
        {
            Named = named;
            Reduction = reduction;
        }
    }
}
