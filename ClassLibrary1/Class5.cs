using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class5
    {
        public string Фамилия { get; }
        public string Имя { get; }
        public string Отчество { get; }
        public string Дата_Рождения { get; }
        public Class4 Группа{ get; }

        public Class5(string фамилия, string имя, string отчество, string дата_рождения, Class4 группа)
        {
            Фамилия = фамилия;
            Имя = имя;
            Отчество = отчество;
            Дата_Рождения = дата_рождения;
            Группа = группа;
        }
    }
}
