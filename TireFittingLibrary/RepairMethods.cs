using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace TireFittingLibrary
{
    public static class RepairMethods
    {
        public static string ViewWorksByRepairType(List<Repair> repairList, RepairType repairType)
        {
            return "";
        }

        public static string FindMostPopularRepairByCarModel(List<Repair> repairList, string automobileModel)
        {
            return "";
        }

        public static double CountTotalCost(List<Repair> repairList, DateTime startDate, DateTime endDate)
        {
            return 0;
        }

        public static DateTime SetDate(string date)
        {
            Regex dateRegex = new Regex(@"\d{2}\.\d{2}\.\d{4}");
            Match dateMatch = dateRegex.Match(date);

            if (!dateMatch.Success)
            {
                throw new Exception("Incorrect date");
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

        public static string GetDisplayName(RepairType repairType)
        {
            Type type = repairType.GetType();
            var enumItem = type.GetField(repairType.ToString());
            var attribute = enumItem?.GetCustomAttribute<DisplayAttribute>();

            return attribute?.Name;
        }
    }
}
