using System;

namespace AccidentReportLibrary
{
    public class Vehicle
    {
        public string Model { get; }
        public int Number { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="model">Model</param>
        /// <param name="number">Int number</param>
        public Vehicle(string model, int number)
        {
            if (number < 999 || number > 9999)
            {
                throw new Exception("Incorrect vehicle number");
            }

            Model = model;
            Number = number;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="model">Model</param>
        /// <param name="number">String number</param>
        public Vehicle(string model, string number)
        {
            Model = model;
            Number = SetNumber(number);
        }

        /// <summary>
        /// Setting vehicle number
        /// </summary>
        /// <param name="numStr"></param>
        /// <returns></returns>
        private int SetNumber(string numStr)
        {
            Exception error = new Exception("Vehicle number is incorrect");

            if (numStr.Length != 4)
            {
                throw error;
            }

            if (int.TryParse(numStr, out int number))
            {
                return number;
            }
            else
            {
                throw error;
            }
        }

        public override string ToString()
        {
            return $"Модель ТС: {Model}\nНомер ТС: {Number}";
        }
    }
}
