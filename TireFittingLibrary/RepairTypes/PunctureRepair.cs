using System;
using System.Collections.Generic;
using System.Text;

namespace TireFittingLibrary.RepairTypes
{
    public class PunctureRepair : Repair
    {
        public PunctureRepair(string date, Automobile automobile, double cost)
            : base(date, automobile, cost) { }

        public override string Renovate()
        {
            isRenovated = true;
            return "Проколы устранены";
        }
    }
}
