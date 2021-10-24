using System;
using System.Collections.Generic;
using System.Text;

namespace TireFittingLibrary.RepairTypes
{
    public class WheelAlignment : Repair
    {
        public WheelAlignment(int id, DateTime date, Automobile automobile, double cost)
            : base(id, date, automobile, cost) { }
    }
}
