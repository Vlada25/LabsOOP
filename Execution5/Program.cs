using AccidentReportLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Execution5
{
    class Program
    {
        static void Main()
        {
            List <AccidentReport> reports = new List<AccidentReport>();
            StringBuilder data = new StringBuilder();
            Service.ReadData(data);

            string[] lines = Convert.ToString(data).Split(';');

            try
            {
                foreach (string line in lines)
                {
                    if (line == "")
                    {
                        continue;
                    }

                    reports.Add(new AccidentReport(line, AccidentType.Collision));
                }

                int[] numbers = AccidentReport.GetVehicalNumbers(reports);

                Console.WriteLine($"Отчёты:{Service.ViewAllReports(reports)}");
                Console.WriteLine($"Номера ТС:{Service.ViewVehicalNumbers(numbers)}");

                Service.SortByCountries(reports, numbers);

                Console.WriteLine($"Номера ТС, отсортированные по странам:{Service.ViewVehicalNumbers(numbers)}");
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        
    }
}
