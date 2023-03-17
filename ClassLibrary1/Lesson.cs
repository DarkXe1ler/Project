using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Lesson
    {
        public string Date { get; }
        public Class3 Disciplina { get; }
        public Class9 Sotrudnik { get; }
        public Class2 Auditoria { get; }
        public Class4 Group { get; }
        public Para Para { get; }
        public Class14 VidZanyatia { get; }

        public Lesson(string date, Class3 disciplina, Class9 sotrudnik, Class2 auditoria, Class4 group, Para para, Class14 vidzanyatia)
        {
            Date = date;
            Disciplina = disciplina;
            Sotrudnik = sotrudnik;
            Auditoria = auditoria;
            Group = group;
            Para = para;
            VidZanyatia = vidzanyatia;
        }
    }
}
