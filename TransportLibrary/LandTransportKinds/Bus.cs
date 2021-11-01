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
        
        public override int GetCountOfSits()
        {
            return CountOfSits;
        }
    }
}
