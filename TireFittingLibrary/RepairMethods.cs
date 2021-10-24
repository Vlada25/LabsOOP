using System;
using System.Collections.Generic;

namespace TireFittingLibrary
{
    /// <summary>
    /// Methods to interaction with repairs
    /// </summary>
    public static class RepairMethods
    {
        /// <summary>
        /// Struct for string repair describtion
        /// </summary>
        public struct RepairInfo
        {
            public int Id { get; }
            public string Date { get; }
            public string CarModel { get; }
            public string CarNumber { get; }
            public string RepairType { get; }
            public string Price { get; }

            public RepairInfo(int id, string date, string carModel, string carNumber, string repairType, string price)
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

        /// <summary>
        /// Getting automobile models from all repairs
        /// </summary>
        /// <returns>List of models</returns>
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

        /// <summary>
        /// Display information about the number of jobs by car models
        /// </summary>
        /// <returns>String info</returns>
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

        /// <summary>
        /// Find the most frequently performed work for a given car model
        /// </summary>
        /// <param name="model">Automobile model</param>
        /// <returns>Found work</returns>
        public static string FindMostPopularRepairByCarModel(string model)
        {
            string result = "";
            Dictionary<string, int> typeCountDict = new Dictionary<string, int>();

            foreach (Repair repair in RepairList)
            {
                if (repair.Automobile.Model.Equals(model))
                {
                    if (!typeCountDict.ContainsKey(GetTypeName(repair)))
                    {
                        typeCountDict.Add(GetTypeName(repair), 1);
                    }
                    else
                    {
                        typeCountDict[GetTypeName(repair)] += 1; 
                    }
                }
            }

            int max = 0;
            string maxType = "";

            foreach (KeyValuePair<string, int> pair in typeCountDict)
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

        /// <summary>
        /// Finding total cost by repair works
        /// </summary>
        /// <param name="selectedRepairList">List of repairs</param>
        /// <returns>Info</returns>
        public static string CountTotalCost(List<Repair> selectedRepairList)
        {
            string result = "";
            Dictionary<string, double> typeTotalPriceDict = new Dictionary<string, double>();

            foreach (Repair repair in selectedRepairList)
            {
                if (!typeTotalPriceDict.ContainsKey(GetTypeName(repair)))
                {
                    typeTotalPriceDict.Add(GetTypeName(repair), repair.Price);
                }
                else
                {
                    typeTotalPriceDict[GetTypeName(repair)] += repair.Price;
                }
            }

            foreach (KeyValuePair<string, double> pair in typeTotalPriceDict)
            {
                result += $"{pair.Key} - {pair.Value}$\n";
            }

            return result;
        }

        /// <summary>
        /// Getting repairs in selected interval
        /// </summary>
        /// <param name="startDate">Start date value</param>
        /// <param name="endDate">End date value</param>
        /// <returns>List of suit repairs</returns>
        public static List<Repair> GetRepairInInterval(DateTime startDate, DateTime endDate)
        {
            List<Repair> selectedRepairList = new List<Repair>();

            foreach (Repair repair in RepairList)
            {
                if (repair.Date > startDate && repair.Date < endDate)
                {
                    selectedRepairList.Add(repair);
                }
            }

            return selectedRepairList;
        }

        /// <summary>
        /// Getting info from repairs to add them to the table
        /// </summary>
        /// <param name="repairList">List of repairs</param>
        /// <returns>New list</returns>
        public static List<RepairInfo> GetRepairInfo(List<Repair> repairList)
        {
            List<RepairInfo> info = new List<RepairInfo>();

            foreach (Repair repair in repairList)
            {
                string type = GetTypeName(repair);

                info.Add(new RepairInfo(repair.Id, repair.Date.ToString("d"), repair.Automobile.Model, repair.Automobile.Number, type, $"{repair.Price}$"));
            }

            return info;
        }

        /// <summary>
        /// Getting string value of type of work
        /// </summary>
        /// <param name="repair">Repair object</param>
        /// <returns>String type</returns>
        public static string GetTypeName(Repair repair)
        {
            string type;

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
    }
}
