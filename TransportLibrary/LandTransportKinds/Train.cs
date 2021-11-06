using System;
using System.Collections.Generic;
using System.Text;

namespace TransportLibrary.LandTransportKinds
{
    public class Train : LandTransport
    {
        public string[] CarriageKinds = { "люкс", "купейный", "плацкартный", "общий" };
        public int[] SitsInCarriage { get; set; }

        public int this[string index] => FindKindIndex(index, CarriageKinds);

        public Train(int tripNumber, string startPoint, string endPoint, double[] prices)
            : base(tripNumber, startPoint, endPoint, prices)
        {

        }
        public override int GetCountOfSits()
        {
            int totalCount = 0;

            if (SitsInCarriage == null)
            {
                return 0;
            }

            foreach (int countOfSits in SitsInCarriage)
            {
                totalCount += countOfSits;
            }

            return totalCount;
        }
    }
}
