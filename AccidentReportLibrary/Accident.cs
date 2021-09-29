using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentReportLibrary
{
    public class Accident
    {
        public DateTime DateTime { get; }
        public AccidentType Type { get; }

        public Accident(DateTime dateTime, AccidentType type)
        {
            DateTime = dateTime;
            Type = type;
        }
    }
}
