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
        public struct RepairInfo
        {
            public int Id { get; }
            public string Date { get; }
            public string CarModel { get; }
            public string CarNumber { get; }
            public string RepairType { get; }
            public double Price { get; }

            public RepairInfo(int id, string date, string carModel, string carNumber, string repairType, double price)
            {
                Id = id;
                Date = date;
                CarModel = carModel;
                CarNumber = carNumber;
                RepairType = repairType;
                Price = price;
            }
        }
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

        public static List<RepairInfo> GetRepairInfo(List<Repair> repairList)
        {
            List<RepairInfo> info = new List<RepairInfo>();

            foreach (Repair repair in repairList)
            {
                string type = null;

                switch (repair.GetType().Name)
                {
                    case "TireChange":
                        type = "Замена шин";
                        break;
                    case "PunctureRepair":
                        type = "Ремонт проколов";
                        break;
                    case "WheelBalancing":
                        type = "Балансировка колёс";
                        break;
                    case "WheelAlignment":
                        type = "Развал-схождение";
                        break;
                    default:
                        throw new Exception("Invalid type of repair");
                }

                info.Add(new RepairInfo(repair.Id, repair.Date.ToString("d"), repair.Automobile.Model, repair.Automobile.Number, type, repair.Price));
            }

            return info;
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
