using System;
using System.Collections.Generic;
using System.Text;

namespace TransportLibrary
{
    public abstract class LandTransport : Transport
    {
        public int TripNumber { get; }
        public double[] Price { get; }

        public override int GetCountOfSits()
        {
            throw new NotImplementedException();
        }
    }
}
