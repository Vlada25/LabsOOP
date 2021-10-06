using AccidentReportLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Execution5
{
    static class Service
    {
        /// <summary>
        /// Reading data from file
        /// </summary>
        /// <param name="data">Data</param>
        public static void ReadData(StringBuilder data)
        {
            string path = @"..\data.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    data.Append(sr.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Sorting by countries
        /// </summary>
        /// <param name="reports">List of reports</param>
        /// <param name="numbers">List of vehicle numbers</param>
        public static void SortByCountries(List<AccidentReport> reports, int[] numbers)
        {
            int len = reports.Count;
            string[] countries = new string[len];

            for (int i = 0; i < len; i++)
            {
                countries[i] = reports[i].Country;
            }

            for (int i = 0; i < len - 1; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (countries[i].CompareTo(countries[j]) == 1)
                    {
                        string tmp1 = countries[i];
                        countries[i] = countries[j];
                        countries[j] = tmp1;

                        int tmp2 = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = tmp2;
                    }
                }
            }
        }

        /// <summary>
        /// Viewing all of reports
        /// </summary>
        /// <param name="reports">List of reports</param>
        /// <returns>String reports</returns>
        public static string ViewAllReports(List<AccidentReport> reports)
        {
            string res = "\n";

            foreach (AccidentReport report in reports)
            {
                res += report.ToString() + "\n";
            }

            return res;
        }

        /// <summary>
        /// Viewing all vehicle numbers
        /// </summary>
        /// <param name="numbers">List of vehicle numbers</param>
        /// <returns>String numbers</returns>
        public static string ViewVehicleNumbers(int[] numbers)
        {
            string res = "\n";

            foreach (int num in numbers)
            {
                res += num + "\n";
            }

            return res;
        }

        /// <summary>
        /// Random types generation 
        /// </summary>
        /// <returns>Accident type</returns>
        public static AccidentType GenerateAccidentType()
        {
            Thread.Sleep(100);

            Random random = new Random();
            int num = random.Next(0, 8);

            return (AccidentType)num;
        }
    }
}
