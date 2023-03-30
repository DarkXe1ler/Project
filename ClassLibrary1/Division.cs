using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Division
    {
        public string Name { get; }
        public Class9 Director { get; }
        public Class12 Organization { get; }


        public Division(string name, Class9 director, Class12 organization)
        {
            Name = name;
            Director = director;
            Organization = organization;
        }
    }
}
