using System;
using System.Collections.Generic;
using System.Text;

namespace TransportLibrary.LandTransportKinds
{
    public class Bus : LandTransport
    {
        public string[] SitKinds = {"жёсткий", "мягкий" };
        public int CountOfSits { get; set; }
        public int this[string index] => FindKindIndex(index, SitKinds);

        public Bus(int tripNumber, string startPoint, string endPoint, double[] prices)
            : base(tripNumber, startPoint, endPoint, prices)
        {

        }

        public override int GetCountOfSits()
        {
            return CountOfSits;
        }
    }
}
