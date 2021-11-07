using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportLibrary;
using TransportLibrary.LandTransportKinds;

namespace TransportTestProject
{
    [TestClass]
    public class TransportTest
    {
        [TestMethod]
        [DataRow("самолёт 290 Минск Дубай 340 370 410")]
        public void CreateObjectTest(string line)
        {
            Transport transport = TransportFactory.CreateObject(line);

            string expected = "Airplane";

            Assert.AreEqual(expected, transport.Kind);
        }

        [TestMethod]
        [DataRow(290, "Минск", "Дубай", new double[] { 340, 370, 410 }, "бизнес")]
        public void AirplaneIndexatorTest(int number, string startPoint, string endPoint, double[] prices, string kind)
        {
            Airplane airplane = new Airplane(number, startPoint, endPoint, prices);

            double expected = 370;

            Assert.AreEqual(expected, airplane.PriceList[airplane[kind]]);
        }

        [TestMethod]
        [DataRow(248, "Жлобин", "Рогачёв", new double[] { 3, 5 }, "мягкий")]
        public void BusIndexatorTest(int number, string startPoint, string endPoint, double[] prices, string kind)
        {
            Bus bus = new Bus(number, startPoint, endPoint, prices);

            double expected = 5;

            Assert.AreEqual(expected, bus.PriceList[bus[kind]]);
        }

        [TestMethod]
        [DataRow(345, "Минск", "Гомель", new double[] { 25, 20, 15, 13 }, "купейный")]
        public void TrainIndexatorTest(int number, string startPoint, string endPoint, double[] prices, string kind)
        {
            Train train  = new Train(number, startPoint, endPoint, prices);

            double expected = 20;

            Assert.AreEqual(expected, train.PriceList[train[kind]]);
        }

        [TestMethod]
        [DataRow("поезд 846 Москва Минск 100 80 75 60")]
        public void GetKindNameTest(string line)
        {
            Transport transport = TransportFactory.CreateObject(line);

            string expected = "Поезд";

            Assert.AreEqual(expected, transport.GetKindName());
        }

        [TestMethod]
        [DataRow(290, "Минск", "Дубай", new double[] { 340, 370, 410 })]
        public void Airplane_GetCountOfSits_Test(int number, string startPoint, string endPoint, double[] prices)
        {
            Airplane airplane = new Airplane(number, startPoint, endPoint, prices);

            airplane.CountOfSits = 100;
            int expected = 100;

            Assert.AreEqual(expected, airplane.GetCountOfSits());
        }

        [TestMethod]
        [DataRow(248, "Жлобин", "Рогачёв", new double[] { 3, 5 })]
        public void Bus_GetCountOfSits_Test(int number, string startPoint, string endPoint, double[] prices)
        {
            Bus bus = new Bus(number, startPoint, endPoint, prices);

            bus.CountOfSits = 45;
            int expected = 45;

            Assert.AreEqual(expected, bus.GetCountOfSits());
        }

        [TestMethod]
        [DataRow(345, "Минск", "Гомель", new double[] { 25, 20, 15, 13 })]
        public void Train_GetCountOfSits_Test(int number, string startPoint, string endPoint, double[] prices)
        {
            Train train = new Train(number, startPoint, endPoint, prices);

            train.SitsInCarriage = new int[] { 50, 50, 50, 50 };
            double expected = 200;

            Assert.AreEqual(expected, train.GetCountOfSits());
        }
    }
}
