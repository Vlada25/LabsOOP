using System;

namespace TireFittingLibrary.RepairTypes
{
    public class WheelAlignment : Repair
    {
        public WheelAlignment(int id, DateTime date, Automobile automobile, double cost)
            : base(id, date, automobile, cost) { }
    }
}
