using System;

namespace TireFittingLibrary
{
    /// <summary>
    /// Repair describtion
    /// </summary>
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
            return $"Id: {Id}\nDate: {Date:d}\n{Automobile}\nType: {RepairMethods.GetTypeName(this)}\nPrice: {Price}";
        }
    }
}
