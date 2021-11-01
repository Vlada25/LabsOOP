using System;
using System.Collections.Generic;
using System.Text;

namespace TransportLibrary.LandTransportKinds
{
    public class Bus : LandTransport
    {
        string[] sitKinds = {"жёсткий", "мягкий" };
        public int CountOfSits { get; }
        public int this[string index] => FindKindIndex(index, sitKinds);

        public Bus(int tripNumber, string departurePoint, string destinationPoint, params double[] prices)
            : base(tripNumber, departurePoint, destinationPoint, prices)
        {

        }


        public override int GetCountOfSits()
        {
            return CountOfSits;
        }
    }
}
