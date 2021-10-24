using System;
using TireFittingLibrary.RepairTypes;

namespace TireFittingLibrary
{
    public class RepairFactory
    {
        /// <summary>
        /// Creating necessary repair object
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="date">Date</param>
        /// <param name="carModel">Automobile model</param>
        /// <param name="carNumber">Automobile number</param>
        /// <param name="type">Type of work</param>
        /// <param name="price">Price</param>
        /// <returns>Repair object</returns>
        public static Repair CreateRepair(int id, DateTime date, string carModel, string carNumber, string type, double price)
        {
            Repair repair;
            Automobile automobile = new Automobile(carModel, carNumber);

            switch (type)
            {
                case "Замена шин":
                    repair = new TireChange(id, date, automobile, price);
                    break;
                case "Ремонт проколов":
                    repair = new PunctureRepair(id, date, automobile, price);
                    break;
                case "Балансировка колёс":
                    repair = new WheelBalancing(id, date, automobile, price);
                    break;
                case "Развал-схождение":
                    repair = new WheelAlignment(id, date, automobile, price);
                    break;
                default:
                    throw new Exception("Invalid type of repair");
            }

            return repair;
        }
    }
}
