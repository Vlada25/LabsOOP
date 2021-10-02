using AccidentReportLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AccidentReportTest
{
    [TestClass]
    public class ReportTest
    {
        [TestMethod]
        [DataRow("Belarus", "Mersedes", 1234)]
        public void ReportConstructorTest1(string country, string vModel, int vNumber)
        {
            DateTime dateTime = new DateTime(2003, 02, 25, 18, 23, 0);

            Accident accident = new Accident(dateTime, AccidentType.HitCyclist);
            AccidentReport report = new AccidentReport(accident, country, vModel, vNumber);

            Assert.AreEqual(report.Country, country);
        }

        [TestMethod]
        [DataRow("18.02.2015,19:30,USA,Mazda,1498")]
        public void ReportConstructorTest2(string data)
        {
            AccidentReport report = new AccidentReport(data, AccidentType.CollisionWithStationaryVehicle);

            string expected = "USA";

            Assert.AreEqual(report.Country, expected);
        }

        [TestMethod]
        [DataRow("18.02.2015,19:30,USA,Mazda,1498", "10.11.2018,20:12,Canada,Opel,3290")]
        public void GetVehicalNumbersTest(string data1, string data2)
        {
            List<AccidentReport> reports = new List<AccidentReport>
            {
                new AccidentReport(data1, AccidentType.Collision),
                new AccidentReport(data2, AccidentType.HitAnimal)
            };

            int expected1 = 1498,
                expected2 = 3290;

            Assert.AreEqual(AccidentReport.GetVehicalNumbers(reports)[0], expected1);
            Assert.AreEqual(AccidentReport.GetVehicalNumbers(reports)[1], expected2);
        }
    }
}
