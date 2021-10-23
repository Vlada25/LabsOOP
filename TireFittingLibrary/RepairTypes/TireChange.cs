using System;
using System.Collections.Generic;
using System.Text;

namespace TireFittingLibrary.RepairTypes
{
    public class TireChange : Repair
    {
        public TireChange(string date, Automobile automobile, double cost)
            : base(date, automobile, cost) { }

        public override string Renovate()
        {
            isRenovated = true;
            return "Колёса заменены";
        }
    }
}
