using System;
using System.Collections.Generic;

namespace AccidentReportLibrary
{
    public class AccidentReport
    {
        const int CountryIndex = 2,
            VMIndex = 3,
            VNIndex = 4;

        private readonly Accident accident;
        private readonly Vehicle vehicle;
        public int Number { get; }
        public string Country { get; }

        private static readonly List<int> listOfNumbers = new List<int>();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="accident">Type and time of accident</param>
        /// <param name="country">Country</param>
        /// <param name="vehicleModel">Model of vehicle</param>
        /// <param name="vehicalNumber">Type of vehicle</param>
        public AccidentReport(Accident accident, string country, string vehicleModel, int vehicalNumber)
        {
            this.accident = accident;
            Number = GenerateNumber();
            Country = country;
            vehicle = new Vehicle(vehicleModel, vehicalNumber);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="data">String with all necessary info about accident</param>
        /// <param name="type">Type of accident</param>
        public AccidentReport(string data, AccidentType type)
        {
            Number = GenerateNumber();
            accident = new Accident(data, type);

            string[] dataArray = data.Split(',');

            Country = dataArray[CountryIndex];
            vehicle = new Vehicle(dataArray[VMIndex], dataArray[VNIndex]);

        }

        /// <summary>
        /// Generating number by random
        /// </summary>
        /// <returns>Number of accident</returns>
        private int GenerateNumber()
        {
            Random rand = new Random();
            int num;

            do
            {
                num = rand.Next(10000, 100000);
            } while (listOfNumbers.Contains(num));

            listOfNumbers.Add(num);

            return num;
        }

        /// <summary>
        /// Getting all vehicle numbers from reports
        /// </summary>
        /// <param name="reports">List of reports</param>
        /// <returns>List of numbers</returns>
        public static int[] GetVehicalNumbers(List<AccidentReport> reports)
        {
            int[] numbers = new int[reports.Count];

            for (int i = 0; i < reports.Count; i++)
            {
                numbers[i] = reports[i].vehicle.Number;
            }

            return numbers;
        }

        public override string ToString()
        {
            return $"\nДТП №{Number}\n{accident}\nСтрана регистрации: {Country}\n{vehicle}";
        }
    }
}
