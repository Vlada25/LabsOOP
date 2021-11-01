using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TransportLibrary
{
    internal class Service
    {
        const string Filepath = @"..\data.txt";

        public static string[] ReadData()
        {
            string data = "";

            try
            {
                using (StreamReader sr = new StreamReader(Filepath))
                {
                    data = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return data.Split(';');
        }
    }
}
