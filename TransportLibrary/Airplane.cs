using System;
using System.Collections.Generic;
using System.Text;

namespace TransportLibrary
{
    public class Airplane : Transport
    {
        string[] planeClasses = { "эконом", "бизнес", "первый" };
        public int CountOfSits { get; }
        public int FlightNumber { get; }
        public double[] Price { get; }

        public int this[string index] => FindKindIndex(index, planeClasses);

        public override int GetCountOfSits()
        {
            throw new NotImplementedException();
        }
    }
}
