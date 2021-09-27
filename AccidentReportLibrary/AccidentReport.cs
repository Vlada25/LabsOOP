using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentReportLibrary
{
    public enum AccidentType
    {
        Collision,
        Rollover,
        HitObstacle,
        HitPedestrian,
        HitCyclist,
        HitAnimal,
        HitHorseDrawnVehicle,
        CollisionWithStationaryVehicle
    }
    public class AccidentReport
    {
        public int Number { get; }
        public DateTime DateTime { get; }
        public AccidentType AccidentType { get; }
        public string Country { get; }
        public string VehicleModel { get; }
        public int VehicleNumber { get; }

        private static readonly List<int> listOfNumbers = new List<int>();

        public AccidentReport(DateTime dateTime, AccidentType type, string country, string vehicleModel, int vehicalNumber)
        {
            Number = GenerateNumber();
            DateTime = dateTime;
            AccidentType = type;
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
