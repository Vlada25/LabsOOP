using AccidentReportLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AccidentReportTest
{
    [TestClass]
    public class AccidentTest
    {
        [TestMethod]
        public void AccidentConstructorTest1()
        {
            DateTime dateTime = new DateTime(2003, 02, 25, 18, 23, 0);

            Accident accident = new Accident(dateTime, AccidentType.HitCyclist);

            int expectedDay = 25;
            AccidentType expectedType = AccidentType.HitCyclist;

            Assert.AreEqual(accident.DateTime.Day, expectedDay);
            Assert.AreEqual(accident.Type, expectedType);
        }

        [TestMethod]
        [DataRow("18.02.2015,19:30,USA,Mazda,1498")]
        public void AccidentConstructorTest2(string data)
        {
            Accident accident = new Accident(data, AccidentType.HitCyclist);

            int expectedDay = 18;
            int expectedHour = 19;

            Assert.AreEqual(accident.DateTime.Day, expectedDay);
            Assert.AreEqual(accident.DateTime.Hour, expectedHour);
        }
    }
}
