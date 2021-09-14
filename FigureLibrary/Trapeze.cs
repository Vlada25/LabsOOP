using System;

namespace FigureLibrary
{
    public class Trapeze
    {
        const int IndexSide1 = 0,
            IndexSide2 = 1,
            IndexSide3 = 2,
            IndexSide4 = 3;

        private readonly double x1;
        private readonly double x2;
        private readonly double[] sides = new double[4];
        public double Perimetr { get; }
        public double Square { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x1"> Point 1 on the Ox axis </param>
        /// <param name="x2"> Point 2 on the Ox axis </param>
        public Trapeze(double x1, double x2)
        {
            this.x1 = x1;
            this.x2 = x2;
            CheckExistance();
            FindSides();
            Perimetr = FindPerimetr();
            Square = FindSquare();
        }

        /// <summary>
        /// Checking existanse of trapeze
        /// </summary>
        private void CheckExistance()
        {
            if (x1 * x2 < 0 || x1 == 0 || x2 == 0)
            {
                throw new Exception("Фигура не может существовать");
            }
        }

        /// <summary>
        /// Searching values of sides
        /// </summary>
        private void FindSides()
        {
            sides[IndexSide1] = Math.Abs(x2 - x1); // ось Ох
            sides[IndexSide2] = Func(x1);
            sides[IndexSide3] = Func(x2);
            sides[IndexSide4] = CountIntegral();
        }

        /// <summary>
        /// Searching perimetr
        /// </summary>
        /// <returns> Perimetr </returns>
        private double FindPerimetr()
        {
            double p = 0;

            foreach (double side in sides)
            {
                p += side;
            }

            return Math.Round(p, 3);
        }

        /// <summary>
        /// Searching value of square
        /// </summary>
        /// <returns> Square </returns>
        private double FindSquare()
        {
            return Math.Round(CountIntegral(), 3);
        }

        /// <summary>
        /// Hyperbolic function
        /// </summary>
        /// <param name="x"> x parametr </param>
        /// <returns> y parametr </returns>
        private double Func(double x)
        {
            // функция гиперболы: y = 1 / x
            return (1 / x);
        }

        /// <summary>
        /// Counting value of integral
        /// </summary>
        /// <returns> Value of integral </returns>
        private double CountIntegral()
        {
            int countOfSplits = 100;
            double h = (x2 - x1) / countOfSplits;
            double integral = 0;

            for (int step = 0; step < countOfSplits; step++)
            {
                double a = x1 + step * h;
                double b = x1 + (step + 1) * h;

                integral += 0.5 * (b - a) * (Func(a) + Func(b));
            }

            return integral;
        }

        /// <summary>
        /// Checking affiliation of point
        /// </summary>
        /// <param name="x"> x coordinate </param>
        /// <param name="y"> y coordinate </param>
        /// <returns> Is point belong (true or false) </returns>
        public bool IsPointBelong(double x, double y)
        {
            if (((x >= x1 && x <= x2) || (x >= x2 && x <= x1)) && y <= Func(x))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Viewing values of sides
        /// </summary>
        /// <returns> Sides values </returns>
        public string ViewSides()
        {
            string res = "";

            foreach (double side in sides)
            {
                res += $"\n\t{Math.Round(side, 3)}; ";
            }

            return res;
        }

        /// <summary>
        /// Shaping string with values of sides to write them to xml-file
        /// </summary>
        /// <returns> String sides </returns>
        public string FormatSidesForXml()
        {
            string res = "";

            foreach (double side in sides)
            {
                res += $"{Math.Round(side, 3)}; ";
            }

            return res;
        }

    }
}
