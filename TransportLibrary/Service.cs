using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TransportLibrary
{
    public class Service
    {
        public struct TransportInfo
        {
            public int Id { get; }
            public string Type { get; }
            public int Number { get; }
            public string StartPoint { get; }
            public string EndPoint { get; }

            public TransportInfo(int id, string type, int number, string startPoint, string endPoint)
            {
                Id = id;
                Type = type;
                Number = number;
                StartPoint = startPoint;
                EndPoint = endPoint;
            }
        }

        const string Filepath = @"..\data.txt";
        public static List<Transport> TransportList = new List<Transport>();

        public static void ReadData()
        {
            List<string> data = new List<string>();

            using (StreamReader sr = new StreamReader(Filepath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    data.Add(line);
                }
            }

            foreach (string line in data)
            {
                Transport transport = TransportFactory.CreateObject(line);
                TransportList.Add(transport);
            }
        }

        public static List<TransportInfo> GetTransportInfo(List<Transport> transportList)
        {
            List<TransportInfo> info = new List<TransportInfo>();
            int index = 0;

            foreach (Transport transport in transportList)
            {
                index++;
                int number;

                if (transport.Kind != "Airplane")
                {
                    LandTransport landTransport = (LandTransport)transport;
                    number = landTransport.TripNumber;
                }
                else
                {
                    Airplane airplane = (Airplane)transport;
                    number = airplane.FlightNumber;
                }

                info.Add(new TransportInfo(index, transport.GetKindName(), number, transport.StartPoint, transport.EndPoint));
            }

            return info;
        }
    }
}
