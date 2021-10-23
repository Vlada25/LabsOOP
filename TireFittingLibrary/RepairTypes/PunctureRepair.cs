using System;
using System.Collections.Generic;
using System.Text;

namespace TireFittingLibrary.RepairTypes
{
    public class PunctureRepair : Repair
    {
        public PunctureRepair(int id, DateTime date, Automobile automobile, double cost)
            : base(id, date, automobile, cost) { }

        public override string Renovate()
        {
            isRenovated = true;
            return "Проколы устранены";
        }
    }
}
