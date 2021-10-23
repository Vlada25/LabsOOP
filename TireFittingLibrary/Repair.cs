using System;
using System.Text.RegularExpressions;

namespace TireFittingLibrary
{
    public abstract class Repair
    {
        public DateTime Date { get; }
        public Automobile Automobile { get; } // можно ли называть как класс или лучше не стоит?
        public double Cost { get; }
        protected bool isRenovated = false;

        public Repair(string date, Automobile automobile, double cost)
        {
            Date = RepairMethods.SetDate(date);
            Automobile = automobile;
            Cost = cost;
        }

        public abstract string Renovate();
    }
}
