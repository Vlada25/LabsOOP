using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TireFittingLibrary
{
    public class Automobile
    {
        public string Model { get; }
        public string Number { get; }

        public Automobile(string model, string number)
        {
            Model = model;
            Number = SetNumber(number);
        }

        private string SetNumber(string number)
        {
            Exception error = new Exception("Incorrect automobile number");

            if (number.Length != 4)
            {
                throw error;
            }

            Regex numRegex = new Regex(@"\d{4}");
            Match numMatch = numRegex.Match(number);

            if (!numMatch.Success)
            {
                throw error;
            }

            return number;
        }
    }
}
