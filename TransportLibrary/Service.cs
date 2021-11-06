using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TransportLibrary.LandTransportKinds;

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
            public string CountOfSits { get; }

            public TransportInfo(int id, string type, int number, string startPoint, string endPoint, string countOfSits)
            {
                Id = id;
                Type = type;
                Number = number;
                StartPoint = startPoint;
                EndPoint = endPoint;
                CountOfSits = countOfSits;
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

        public static void SetCountOfPlaces(int numOfItem, string kind, string[] textBoxValues)
        {
            Exception exception = new Exception("Incorrect entered value");

            if (textBoxValues.Length != 1)
            {
                if (kind != "Поезд" && textBoxValues.Length != 2)
                {
                    throw exception;
                }
            }

            if (!int.TryParse(textBoxValues[0], out int countOfSits))
            {
                throw exception;
            }

            Transport transport = TransportList[numOfItem];

            if (kind == "Самолёт")
            {
                Airplane airplane = (Airplane)transport;
                airplane.CountOfSits = countOfSits;
            }
            else if (kind == "Автобус")
            {
                Bus bus = (Bus)transport;
                bus.CountOfSits = countOfSits;
            }
            else if (kind == "Поезд")
            {
                if (!int.TryParse(textBoxValues[1], out int countOfCarriages))
                {
                    throw exception;
                }

                if (countOfSits % countOfCarriages != 0)
                {
                    throw new Exception("The number of sits must be a multiple of the number of carriages");
                }

                Train train = (Train)transport;
                train.SitsInCarriage = new int[countOfCarriages];

                for (int j = 0; j < train.SitsInCarriage.Length; j++)
                {
                    train.SitsInCarriage[j] = countOfSits / countOfCarriages;
                }
            }
        }

        public static string[] SelectKindOfSits(int numOfItem, string kind)
        {
            Transport transport = TransportList[numOfItem];

            if (kind == "Самолёт")
            {
                Airplane airplane = (Airplane)transport;
                return airplane.PlaneClasses;
            }
            else if (kind == "Автобус")
            {
                Bus bus = (Bus)transport;
                return bus.SitKinds;
            }
            else
            {
                Train train = (Train)transport;
                return train.CarriageKinds;
            }
        }

        public static double GetCorrespondingPrice(string sitKind, int numOfItem, string transportKind)
        {
            Transport transport = TransportList[numOfItem];

            if (transportKind == "Самолёт")
            {
                Airplane airplane = (Airplane)transport;
                return airplane.PriceList[airplane[sitKind]];
            }
            else if (transportKind == "Автобус")
            {
                Bus bus = (Bus)transport;
                return bus.PriceList[bus[sitKind]];
            }
            else
            {
                Train train = (Train)transport;
                return train.PriceList[train[sitKind]];
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
                string countOfSits = "-";

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

                if (transport.GetCountOfSits() != 0)
                {
                    countOfSits = Convert.ToString(transport.GetCountOfSits());
                }

                info.Add(new TransportInfo(index, transport.GetKindName(), number, transport.StartPoint, transport.EndPoint, countOfSits));
            }

            return info;
        }

        public static List<string> GetShortTransportInfo(List<Transport> transportList)
        {
            int index = 0;
            List<string> info = new List<string>();

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

                info.Add($"{index}. {transport.GetKindName()} #{number}");
            }

            return info;
        }
    }
}
