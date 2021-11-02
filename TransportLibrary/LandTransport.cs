using System;
using System.Collections.Generic;
using System.Text;

namespace TransportLibrary
{
    public abstract class LandTransport : Transport
    {
        public int TripNumber { get; }
        public List<double> PriceList = new List<double>();
        public LandTransport(int tripNumber, string startPoint, string endPoint, double[] prices)
            : base(startPoint, endPoint)
        {
            TripNumber = tripNumber;
            PriceList.AddRange(prices);
        }

        public override int GetCountOfSits()
        {
            throw new NotImplementedException();
        }
    }
}
