using System;
using System.Text.RegularExpressions;

namespace TireFittingLibrary
{
    public abstract class Repair
    {
        public int Id { get; }
        public DateTime Date { get; }
        public Automobile Automobile { get; } // можно ли называть как класс или лучше не стоит?
        public double Price { get; }

        public Repair(int id, DateTime date, Automobile automobile, double price)
        {
            Id = id;
            Date = date;
            Automobile = automobile;
            Price = price;
        }

        public override string ToString()
        {
            string type;

            switch (GetType().Name)
            {
                case "TireChange":
                    type = "Замена шин";
                    break;
                case "PunctureRepair":
                    type = "Ремонт проколов";
                    break;
                case "WheelBalancing":
                    type = "Балансировка колёс";
                    break;
                case "WheelAlignment":
                    type = "Развал-схождение";
                    break;
                default:
                    throw new Exception("Invalid type of repair");
            }

            return $"Id: {Id}\nDate: {Date:d}\n{Automobile}\nType: {type}\nPrice: {Price}";
        }
    }
}
