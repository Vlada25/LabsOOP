using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
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

        public static List<Repair> RepairList = new List<Repair>();

        public static List<string> GetCarModels()
        {
            List<string> models = new List<string>();

            foreach (Repair repair in RepairList)
            {
                if (!models.Contains(repair.Automobile.Model))
                {
                    models.Add(repair.Automobile.Model);
                }
            }

            return models;
        }

        public static string ViewWorksByCarModel()
        {
            string result = "";

            foreach (string model in GetCarModels())
            {
                int countOfWoks = 0;

                foreach (Repair repair in RepairList)
                {
                    if (repair.Automobile.Model.Equals(model))
                    {
                        countOfWoks++;
                    }
                }

                result += $"Модель: {model}, количество работ: {countOfWoks}\n";
            }

            return result;
        }

        public static string FindMostPopularRepairByCarModel(string model)
        {
            string result = "";
            Dictionary<string, int> types = new Dictionary<string, int>();

            foreach (Repair repair in RepairList)
            {
                if (repair.Automobile.Model.Equals(model))
                {
                    if (!types.ContainsKey(GetTypeName(repair)))
                    {
                        types.Add(GetTypeName(repair), 1);
                    }
                    else
                    {
                        types[GetTypeName(repair)] += 1; 
                    }
                }
            }

            int max = 0;
            string maxType = "";

            foreach (KeyValuePair<string, int> pair in types)
            {
                result += $"{pair.Key} - {pair.Value}\n";

                if (max < pair.Value)
                {
                    max = pair.Value;
                    maxType = pair.Key;
                }
            }

            return $"{result}\nНаиболее часто выполняемая работа:\n{maxType}";
        }

        public static double CountTotalCost(DateTime startDate, DateTime endDate)
        {
            return 0;
        }

        public static List<RepairInfo> GetRepairInfo()
        {
            List<RepairInfo> info = new List<RepairInfo>();

            foreach (Repair repair in RepairList)
            {
                string type = GetTypeName(repair);

                info.Add(new RepairInfo(repair.Id, repair.Date.ToString("d"), repair.Automobile.Model, repair.Automobile.Number, type, repair.Price));
            }

            return info;
        }

        private static string GetTypeName(Repair repair)
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

            return type;
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
