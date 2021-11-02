using System;
using System.Collections.Generic;
using TransportLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            List<string> data = Service.ReadData();

            foreach (string line in data)
            {
                Transport transport = TransportFactory.CreateObject(line);
                Console.WriteLine(transport.ToString());
            }
        }
    }
}
