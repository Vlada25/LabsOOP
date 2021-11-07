using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyArrayLibrary;
using System.Threading.Tasks;

namespace MyArrayTestProgect
{
    [TestClass]
    public class MyArrayTest
    {
        [TestMethod]
        public void GetArray_ReturnArray()
        {
            double[] arr = { 1, 2, 3 };
            MyArray myArray = new MyArray(arr);

            double expected = 2;
            double result = myArray.GetArray()[1];

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void SumArray_ReturnArray()
        {
            MyArray arr1 = new MyArray(new double[] { 1, 2, 3 });
            MyArray arr2 = new MyArray(new double[] { 4, 2, 3, 5 });
            MyArray arr3 = arr1 + arr2;

            double expected = 7;
            double result = arr3.GetArray().Length;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataRow(2)]
        public void Multiply_ReturnArray(double num)
        {
            MyArray arr1 = new MyArray(new double[] { 9 });

            MyArray arr2 = arr1 * num;
            Task.Run(() => { arr1.Multiply(num); });

            double expected = 18;
            double result = arr2.GetArray()[0];

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataRow(2)]
        public void Devide_ReturnArray(double num)
        {
            MyArray arr1 = new MyArray(new double[] { 8 });

            MyArray arr2 = arr1 / num;
            Task.Run(() => { arr1.Divide(num); });

            double expected = 4;
            double result = arr2.GetArray()[0];

            Assert.AreEqual(result, expected);
        }
    }
}
