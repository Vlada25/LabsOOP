using System;
using System.Collections.Generic;
using System.Text;

namespace TireFittingLibrary.RepairTypes
{
    public class WheelAlignment : Repair
    {
        public WheelAlignment(string date, Automobile automobile, double cost)
            : base(date, automobile, cost) { }

        public override string Renovate()
        {
            isRenovated = true;
            return "Развал-схождение настроены";
        }
    }
}
