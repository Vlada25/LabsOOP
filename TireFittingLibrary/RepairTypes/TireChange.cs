using System;

namespace TireFittingLibrary.RepairTypes
{
    public class TireChange : Repair
    {
        public TireChange(int id, DateTime date, Automobile automobile, double cost)
            : base(id, date, automobile, cost) { }
    }
}
