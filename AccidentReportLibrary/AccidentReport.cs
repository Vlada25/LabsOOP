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
        const int CountryIndex = 2,
            VMIndex = 3,
            VNIndex = 4;

        private readonly Accident accident;
        private readonly Vehicle vehicle;
        public int Number { get; }
        public string Country { get; }

        private static readonly List<int> listOfNumbers = new List<int>();

        public AccidentReport(Accident accident, string country, string vehicleModel, int vehicalNumber)
        {
            this.accident = accident;
            Number = GenerateNumber();
            Country = country;
            vehicle = new Vehicle(vehicleModel, vehicalNumber);
        }

        public AccidentReport(string data, AccidentType type)
        {
            Number = GenerateNumber();
            accident = new Accident(data, type);

            string[] dataArray = data.Split(',');

            Country = dataArray[CountryIndex];
            vehicle = new Vehicle(dataArray[VMIndex], dataArray[VNIndex]);

        }

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
