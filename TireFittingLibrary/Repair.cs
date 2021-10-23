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
        protected bool isRenovated = false;

        public Repair(int id, DateTime date, Automobile automobile, double price)
        {
            Id = id;
            Date = date;
            Automobile = automobile;
            Price = price;
        }

        public abstract string Renovate();

        public override string ToString()
        {
            return $"Id: {Id}\nDate: {Date:d}\n{Automobile}\nPrice: {Price}";

        }
    }
}
