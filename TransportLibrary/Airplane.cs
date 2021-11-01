﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TransportLibrary
{
    public class Airplane : Transport
    {
        string[] planeClasses = { "эконом", "бизнес", "первый" };
        public int CountOfSits { get; set; }
        public int FlightNumber { get; }
        public double[] PriceList = new double[3];

        public int this[string index] => FindKindIndex(index, planeClasses);

        public Airplane(int flightNumber, string departurePoint, string destinationPoint, params double[] prices)
            : base (departurePoint, destinationPoint)
        {
            FlightNumber = flightNumber;
            if (prices.Length > 3)
            {
                throw new Exception("Too many arguments passed");
            }
            for (int i = 0; i < prices.Length; i++)
            {
                PriceList[i] = prices[i];
            }
        }
        public override int GetCountOfSits()
        {
            throw new NotImplementedException();
        }
    }
}
