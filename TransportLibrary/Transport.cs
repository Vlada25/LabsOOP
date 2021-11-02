using System;

namespace TransportLibrary
{
    public abstract class Transport
    {
        public string StartPoint { get; }
        public string EndPoint { get; }
        public string Kind { get; }

        public Transport(string startPoint, string endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            Kind = GetType().Name;
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

        public string GetKindName()
        {
            string result = "";

            switch (Kind)
            {
                case "Bus":
                    result = "Автобус";
                    break;
                case "Train":
                    result = "Поезд";
                    break;
                case "Airplane":
                    result = "Самолёт";
                    break;
            }

            return result;
        }

        public override string ToString()
        {
            return GetKindName();
        }
    }
}
