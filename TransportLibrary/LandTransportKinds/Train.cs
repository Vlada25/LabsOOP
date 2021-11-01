using System;
using System.Collections.Generic;
using System.Text;

namespace TransportLibrary.LandTransportKinds
{
    class Train : LandTransport
    {
        string[] carriageKinds = { "люкс", "купейный", "плацкартный", "общий" };
        public int[] sitsInCarriage { get; }

        public int this[string index] => FindKindIndex(index, carriageKinds);

        public Train(int tripNumber, string departurePoint, string destinationPoint, params double[] prices)
            : base(tripNumber, departurePoint, destinationPoint, prices)
        {

        }
        public override int GetCountOfSits()
        {
            int totalCount = 0;
            foreach (int countOfSits in sitsInCarriage)
            {
                totalCount += countOfSits;
            }

            return totalCount;
        }
    }
}
