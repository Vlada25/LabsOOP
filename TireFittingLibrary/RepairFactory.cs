using System;
using System.Collections.Generic;
using System.Text;
using TireFittingLibrary.RepairTypes;

namespace TireFittingLibrary
{
    public class RepairFactory
    {
        public static Repair CreateRepair(int id, DateTime date, string carModel, string carNumber, string type, double price)
        {
            Repair repair = null;
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
