using System;
using System.Collections.Generic;
using System.Text;

namespace TireFittingLibrary.RepairTypes
{
    public class WheelBalancing : Repair
    {
        public WheelBalancing(int id, DateTime date, Automobile automobile, double cost) : base(id, date, automobile, cost) { }
    }
}
