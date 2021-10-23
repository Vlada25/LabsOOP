using System;
using System.Text.RegularExpressions;

namespace TireFittingLibrary
{
    public abstract class Repair
    {
        public DateTime Date { get; }
        public Automobile Automobile { get; } // можно ли называть как класс или лучше не стоит?
        public double Cost { get; }
        protected bool isRenovated = false;

        public Repair(string date, Automobile automobile, double cost)
        {
            Date = SetDate(date);
            Automobile = automobile;
            Cost = cost;
        }

        public abstract string Renovate();
        private static DateTime SetDate(string date)
        {
            Regex dateRegex = new Regex(@"\d{2}\.\d{2}\.\d{4}");
            Match dateMatch = dateRegex.Match(date);

            if (!dateMatch.Success)
            {
                throw new Exception("Incorrect date");
            }

            const int dayIndex = 0,
                monthIndex = 3,
                yearIndex = 6,
                dayAndMonth_Strlen = 2,
                yearStrlen = 4;

            int day = Convert.ToInt32(date.Substring(dayIndex, dayAndMonth_Strlen)),
                month = Convert.ToInt32(date.Substring(monthIndex, dayAndMonth_Strlen)),
                year = Convert.ToInt32(date.Substring(yearIndex, yearStrlen));

            return new DateTime(year, month, day);
        }
    }
}
