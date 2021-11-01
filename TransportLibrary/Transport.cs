using System;

namespace TransportLibrary
{
    public abstract class Transport
    {
        public string DeparturePoint { get; }
        public string DestinationPoint { get; }
        public string Kind()
        {
            return GetType().Name;
        }

        protected int FindKindIndex(string kind, string[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == kind)
                {
                    return i;
                }
            }

            throw new Exception($"Kind \"{kind}\" is not supported");
        }

        public abstract int GetCountOfSits();
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
