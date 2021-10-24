using System;

namespace TireFittingLibrary.RepairTypes
{
    public class PunctureRepair : Repair
    {
        public PunctureRepair(int id, DateTime date, Automobile automobile, double cost)
            : base(id, date, automobile, cost) { }

    }
}
