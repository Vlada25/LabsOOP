using System;
using System.Collections.Generic;
using System.Text;

namespace TireFittingLibrary.RepairTypes
{
    public class WheelBalancing : Repair
    {
        public WheelBalancing(string date, Automobile automobile, double cost)
            : base(date, automobile, cost) { }

        public override string Renovate()
        {
            isRenovated = true;
            return "Балансировка настроена";
        }
    }
}
