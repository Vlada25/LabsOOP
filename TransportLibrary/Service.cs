using System;
using System.Collections.Generic;
using System.IO;
using TransportLibrary.LandTransportKinds;

namespace TransportLibrary
{
    public class Service
    {
        /// <summary>
        /// Struct for view Transport object in table format
        /// </summary>
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

        /// <summary>
        /// Reading data from file
        /// </summary>
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

        /// <summary>
        /// Setting count of places for selected transport
        /// </summary>
        /// <param name="numOfItem">Index of transport in transport list</param>
        /// <param name="textBoxValues">Values from textBox</param>
        public static void SetCountOfPlaces(int numOfItem, string[] textBoxValues)
        {
            Exception exception = new Exception("Incorrect entered value");
            Transport transport = TransportList[numOfItem];
            string kind = transport.GetKindName();

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

        /// <summary>
        /// Getting array of kinds of sits in transport
        /// </summary>
        /// <param name="numOfItem">Index of transport in transport list</param>
        /// <returns>Kinds of sits</returns>
        public static string[] SelectKindOfSits(int numOfItem)
        {
            Transport transport = TransportList[numOfItem];
            string kind = transport.GetKindName();

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

        /// <summary>
        /// Getting correspond price of ticket
        /// </summary>
        /// <param name="sitKind">Kind of sit</param>
        /// <param name="numOfItem">Index of transport in transport list</param>
        /// <returns>Price</returns>
        public static double GetCorrespondingPrice(string sitKind, int numOfItem)
        {
            Transport transport = TransportList[numOfItem];
            string transportKind = transport.GetKindName();

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

        /// <summary>
        /// Getting list of string describtion of transport
        /// </summary>
        /// <param name="transportList">List of transport</param>
        /// <returns>List of transport info for table</returns>
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

        /// <summary>
        /// Getting short info about transport for combobox
        /// </summary>
        /// <param name="transportList">List of transport</param>
        /// <returns>Short transport info</returns>
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
