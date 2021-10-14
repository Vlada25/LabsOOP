using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;
using TheaterLibrary;

namespace WinFormsAppTheater
{
    class Service
    {
        public static List<Play> PlaysList = new List<Play>();

        /// <summary>
        /// Reading data from XML-file
        /// </summary>
        public static void Read()
        {
            PlaysList = new List<Play>();

            const string FileName = @"..\PlaysXML.xml";
            try
            {
                XmlReader xmlReader = XmlReader.Create(FileName);

                while (xmlReader.Read())
                {
                    if (xmlReader.NodeType == XmlNodeType.Element)
                    {
                        if (xmlReader.HasAttributes)
                        {
                            string name = xmlReader.GetAttribute("name");
                            string genre = xmlReader.GetAttribute("genre");
                            DateTime startDate = GetDate(xmlReader.GetAttribute("startDate"));
                            DateTime endDate = GetDate(xmlReader.GetAttribute("endDate"));
                            int countOfVisits = Convert.ToInt32(xmlReader.GetAttribute("countOfVisits"));

                            Play play = PlayFactory.CreatePlay(name, genre, startDate, endDate, countOfVisits);
                            PlaysList.Add(play);
                        }
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// Getting date
        /// </summary>
        /// <param name="date">String date</param>
        /// <returns>Date</returns>
        private static DateTime GetDate(string date)
        {
            Regex dateRegex = new Regex(@"\d{2}\.\d{2}\.\d{4}");
            Match dateMatch = dateRegex.Match(date);

            if (!dateMatch.Success)
            {
                throw new Exception("дата введена некорректно"); 
            }

            const int dayIndex = 0,
                monthIndex = 3,
                yearIndex = 6,
                dayAndMonth_Strlen = 2,
                yearStrlen = 4;

            int day = Convert.ToInt32(date.Substring(dayIndex, dayAndMonth_Strlen)), 
                month = Convert.ToInt32(date.Substring(monthIndex, dayAndMonth_Strlen)),
                year = Convert.ToInt32(date.Substring(yearIndex, yearStrlen));

            return new DateTime(year, month, day);
        }
        
    }
}
