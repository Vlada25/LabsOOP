using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentReportLibrary
{
    public class AccidentReport
    {
        public int Number { get; }
        public string Country { get; }
        public string VehicleModel { get; }
        public int VehicleNumber { get; }

        private static readonly List<int> listOfNumbers = new List<int>();

        public AccidentReport(DateTime dateTime, string country, string vehicleModel, int vehicalNumber)
        {
            Number = GenerateNumber();
            Country = country;
            VehicleModel = vehicleModel;
            VehicleNumber = vehicalNumber;
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
    }
}
