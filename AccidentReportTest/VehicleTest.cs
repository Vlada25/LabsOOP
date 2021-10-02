using AccidentReportLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AccidentReportTest
{
    [TestClass]
    public class VehicleTest
    {
        [TestMethod]
        [DataRow("BMW", 2365)]
        public void VehicleConstructorTest1(string model, int number)
        {
            Vehicle vehicle = new Vehicle(model, number);

            Assert.AreEqual(vehicle.Model, model);
            Assert.AreEqual(vehicle.Number, number);
        }

        [TestMethod]
        [DataRow("BMW", "2365")]
        public void VehicleConstructorTest2(string model, string number)
        {
            Vehicle vehicle = new Vehicle(model, number);

            Assert.AreEqual(vehicle.Model, model);
            Assert.AreEqual(vehicle.Number, Convert.ToInt32(number));
        }
    }
}
