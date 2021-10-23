using System;
using System.Collections.Generic;
using System.Text;

namespace TireFittingLibrary.RepairTypes
{
    public class TireChange : Repair
    {
        public TireChange(int id, DateTime date, Automobile automobile, double cost)
            : base(id, date, automobile, cost) { }

        public override string Renovate()
        {
            isRenovated = true;
            return "Колёса заменены";
        }
    }
}
