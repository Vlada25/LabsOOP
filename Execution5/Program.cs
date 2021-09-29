using AccidentReportLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execution5
{
    class Program
    {
        static void Main()
        {
            StringBuilder data = new StringBuilder();
            ReadData(data);

            string[] lines = Convert.ToString(data).Split(';');

            try
            {
                foreach (string line in lines)
                {
                    if (line == "")
                    {
                        continue;
                    }
                    AccidentReport report = new AccidentReport(line);
                }
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
            
            Console.WriteLine(data);
        }

        static void ReadData(StringBuilder data)
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
    }
}
