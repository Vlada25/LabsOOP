using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TireFittingLibrary;

namespace RepairTestProject
{
    [TestClass]
    public class RepairTest
    {
        [TestMethod]
        [DataRow(1, "Lada", "2003", "Замена шин", 18)]
        public void CreateRepairTest(int id, string carModel, string carNumber, string type, double price)
        {
            DateTime date = new DateTime(2021, 02, 25);

            Repair repair = RepairFactory.CreateRepair(id, date, carModel, carNumber, type, price);

            int expected1 = 1;
            DateTime expected2 = new DateTime(2021, 02, 25);
            string expected3 = "Lada",
                expected4 = "2003",
                expected5 = "Замена шин";
            double expected6 = 18;

            Assert.AreEqual(expected1, repair.Id);
            Assert.AreEqual(expected2, repair.Date);
            Assert.AreEqual(expected3, repair.Automobile.Model);
            Assert.AreEqual(expected4, repair.Automobile.Number);
            Assert.AreEqual(expected5, RepairMethods.GetTypeName(repair));
            Assert.AreEqual(expected6, repair.Price);
        }

        [TestMethod]
        [DataRow(1, "Lada", "2003", "Замена шин", 18)]
        public void GetTypeNameTest(int id, string carModel, string carNumber, string type, double price)
        {
            DateTime date = new DateTime(2021, 02, 25);

            Repair repair = RepairFactory.CreateRepair(id, date, carModel, carNumber, type, price);

            string expected = "Замена шин";

            Assert.AreEqual(expected, RepairMethods.GetTypeName(repair));
        }

        [TestMethod]
        [DataRow(1, "Lada", "2003", "Замена шин", 18)]
        public void GetCarModelsTest(int id, string carModel, string carNumber, string type, double price)
        {
            DateTime date = new DateTime(2021, 02, 25);

            Repair repair = RepairFactory.CreateRepair(id, date, carModel, carNumber, type, price);
            RepairMethods.RepairList.Add(repair);

            int expected = 1;

            Assert.AreEqual(expected, RepairMethods.GetCarModels().Count);
        }
    }
}
