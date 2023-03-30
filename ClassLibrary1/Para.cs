using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Para
    {
        public Smena Smena { get; }
        public string TheStartTimeOfThePair { get; }
        public string TheEndTimeOfThePair { get; }
        public string BreakStartTime { get; }
        public string BreakEndTime { get; }
        public Para(string theStartTimeOfThePair, string theEndTimeOfThePair, string breakStartTime, string breakEndTime, Smena smena)
        {
            TheStartTimeOfThePair = theStartTimeOfThePair;
            TheEndTimeOfThePair = theEndTimeOfThePair;
            BreakStartTime = breakStartTime;
            BreakEndTime = breakEndTime;
            Smena = smena;
        }
    }
}
