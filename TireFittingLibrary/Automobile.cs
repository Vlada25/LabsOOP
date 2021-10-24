using System;

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

            if (!int.TryParse(number, out int _))
            {
                throw error;
            }

            return number;
        }

        public override string ToString()
        {
            return $"Car model: {Model}\nCar number {Number}";
        }
    }
}
