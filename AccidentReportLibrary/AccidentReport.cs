using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AccidentReportLibrary
{
    public class AccidentReport
    {
        const int DateIndex = 0,
            TimeIndex = 1,
            CountryIndex = 2,
            ModelIndex = 3,
            NumberIndex = 4;

        Accident accident;
        public int Number { get; }
        public string Country { get; }
        public string VehicleModel { get; }
        public int VehicleNumber { get; }

        private static readonly List<int> listOfNumbers = new List<int>();

        public AccidentReport(Accident accident, string country, string vehicleModel, int vehicalNumber)
        {
            this.accident = accident;
            Number = GenerateNumber();
            Country = country;
            VehicleModel = vehicleModel;
            VehicleNumber = vehicalNumber;
        }
        public AccidentReport(string data)
        {
            Number = GenerateNumber();

            Regex dateRegex = new Regex(@"\d{2}\.\d{2}\.\d{4}");
            Regex timeRegex = new Regex(@"\d{2}:\d{2}");

            Match dateMatch = dateRegex.Match(data);
            Match timeMatch = timeRegex.Match(data);

            if (!dateMatch.Success || !timeMatch.Success)
            {
                throw new Exception("String is not correct");
            }

            DateTime dateTime = SetDateTime(dateMatch.Value, timeMatch.Value);

            Console.WriteLine(dateTime);
        }
        private int GenerateNumber()
        {
            Random rand = new Random();
            int num;

            do
            {
                num = rand.Next(10000, 100000);
            } while (listOfNumbers.Contains(num));

            return num;
        }
        private DateTime SetDateTime(string date, string time)
        {
            const int dayIndex = 0,
                monthIndex = 2;
            int day = Convert.ToInt32(date.Substring(0, 2)),
                month = Convert.ToInt32(date.Substring(3, 2)),
                year = Convert.ToInt32(date.Substring(6, 4));

            int hour = Convert.ToInt32(time.Substring(0, 2)),
                min = Convert.ToInt32(time.Substring(3, 2)),
                sec = 0;

            return new DateTime(year, month, day, hour, min, sec);
        }
    }
}
