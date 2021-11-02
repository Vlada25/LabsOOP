using System;
using System.Collections.Generic;
using System.Text;
using TransportLibrary.LandTransportKinds;

namespace TransportLibrary
{
    public static class TransportFactory
    {
        const int TypeIndex = 0,
            NumberIndex = 1,
            StartPiontIndex = 2,
            EndPointIndex = 3,
            PriceIndex = 4;

        public static Transport CreateObject(string line)
        {
            Transport transport;
            string[] data = line.Split(' ');

            switch (data[TypeIndex])
            {
                case "автобус":
                    transport = new Bus(GetInt(data[NumberIndex]), data[StartPiontIndex], data[EndPointIndex], GetListOfPrices(data));
                    break;
                case "поезд":
                    transport = new Train(GetInt(data[NumberIndex]), data[StartPiontIndex], data[EndPointIndex], GetListOfPrices(data));
                    break;
                case "самолёт":
                    transport = new Airplane(GetInt(data[NumberIndex]), data[StartPiontIndex], data[EndPointIndex], GetListOfPrices(data));
                    break;
                default:
                    throw new Exception($"Type {data[TypeIndex]} is not supported");
            }

            return transport;
        }

        private static double[] GetListOfPrices(string[] data)
        {
            double[] prices = new double[data.Length - PriceIndex];

            for (int i = PriceIndex; i < data.Length; i++)
            {
                prices[i - PriceIndex] = GetDouble(data[i]);
            }

            return prices;
        }

        private static int GetInt(string value)
        {
            if(!int.TryParse(value, out int number))
            {
                throw new Exception("Can't parse to int");
            }

            return number;
        }

        private static double GetDouble(string value)
        {
            if (!double.TryParse(value, out double number))
            {
                throw new Exception("Can't parse to double");
            }

            return number;
        }
    }
}
