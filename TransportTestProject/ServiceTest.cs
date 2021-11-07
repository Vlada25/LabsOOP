using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportLibrary;
using TransportLibrary.LandTransportKinds;

namespace TransportTestProject
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        public void ReadDataTest()
        {
            Service.ReadData();
            int expected = 7;

            Assert.AreEqual(expected, Service.TransportList.Count);
        }

        [TestMethod]
        [DataRow(0)]
        public void SetCountOfPlacesTest(int transportIndex)
        {
            Service.SetCountOfPlaces(transportIndex, new string[] {"120"});
            int expected = 120;

            Assert.AreEqual(expected, Service.TransportList[transportIndex].GetCountOfSits());
        }

        [TestMethod]
        [DataRow(0)]
        public void SelectKindOfSitsTest(int transportIndex)
        {
            Service.ReadData();

            int result = Service.SelectKindOfSits(transportIndex).Length;
            int expected = 3;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(0, "эконом")]
        public void GetCorrespondingPriceTest(int transportIndex, string sitKind)
        {
            Service.ReadData();

            double result = Service.GetCorrespondingPrice(sitKind, transportIndex);
            double expected = 250;

            Assert.AreEqual(expected, result);
        }
    }
}