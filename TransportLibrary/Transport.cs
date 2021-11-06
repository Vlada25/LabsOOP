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

        /// <summary>
        /// Searching index of sit kind
        /// </summary>
        /// <param name="kind">Kind of sit</param>
        /// <param name="values">Kinds array</param>
        /// <returns>Index of kind</returns>
        protected int FindKindIndex(string kind, string[] kindsList)
        {
            for (int i = 0; i < kindsList.Length; i++)
            {
                if (kindsList[i] == kind)
                {
                    return i;
                }
            }

            throw new Exception($"Kind \"{kind}\" is not supported");
        }

        /// <summary>
        /// Getting count of all sits
        /// </summary>
        /// <returns></returns>
        public abstract int GetCountOfSits();

        /// <summary>
        /// Getting russian value of name of type
        /// </summary>
        /// <returns>New name</returns>
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
