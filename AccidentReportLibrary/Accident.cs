using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public Accident(string data, AccidentType type)
        {
            DateTime dateTime = SetDateTime(data);

            DateTime = dateTime;
            Type = type;
        }
        private DateTime SetDateTime(string data)
        {
            Regex dateRegex = new Regex(@"\d{2}\.\d{2}\.\d{4}");
            Regex timeRegex = new Regex(@"\d{2}:\d{2}");

            Match dateMatch = dateRegex.Match(data);
            Match timeMatch = timeRegex.Match(data);

            if (!dateMatch.Success || !timeMatch.Success)
            {
                throw new Exception("String is not correct");
            }

            string date = dateMatch.Value,
                time = timeMatch.Value;

            const int dayIndex = 0,
                monthIndex = 3,
                yearIndex = 6,
                hourIndex = 0,
                minIndex = 3;

            int day = Convert.ToInt32(date.Substring(dayIndex, 2)),
                month = Convert.ToInt32(date.Substring(monthIndex, 2)),
                year = Convert.ToInt32(date.Substring(yearIndex, 4));

            int hour = Convert.ToInt32(time.Substring(hourIndex, 2)),
                min = Convert.ToInt32(time.Substring(minIndex, 2)),
                sec = 0;

            return new DateTime(year, month, day, hour, min, sec);
        }

        public override string ToString()
        {
            return $"Тип: {Type}\nДата и время: {DateTime}";
        }
    }
}
