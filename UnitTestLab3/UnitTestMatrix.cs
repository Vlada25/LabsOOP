using MatrixLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLab3
{
    [TestClass]
    public class UnitTestMatrix
    {
        [TestMethod]
        public void CountOfRowsProperty_ReturnIntRows()
        {
            const int Rows = 2,
                Columns = 3;
            int[,] arr = new int[Rows, Columns] { { 1, 2, 3 }, { 4, 5, 6 } };

            Matrix matrix = new Matrix(arr, Rows, Columns);

            Assert.AreEqual(Rows, matrix.CountOfRows);
        }

        [TestMethod]
        public void CountOfColumnsProperty_ReturnIntColumns()
        {
            const int Rows = 2,
                Columns = 3;
            int[,] arr = new int[Rows, Columns] { { 1, 2, 3 }, { 4, 5, 6 } };

            Matrix matrix = new Matrix(arr, Rows, Columns);

            Assert.AreEqual(Columns, matrix.CountOfColumns);
        }

        [TestMethod]
        public void Indexator_ReturnValueFromMatrix()
        {
            const int Rows = 2,
                Columns = 3;
            int[,] arr = new int[Rows, Columns] { { 1, 2, 3 }, { 4, 5, 6 } };

            Matrix matrix = new Matrix(arr, Rows, Columns);

            int expected = 3;

            Assert.AreEqual(expected, matrix[0, 2]);
        }

        [TestMethod]
        public void SetMatrix_ReturnValueFromMatrix()
        {
            const int Rows = 2,
                Columns = 3;
            int[,] arr = new int[Rows, Columns] { { 1, 2, 3 }, { 4, 5, 6 } };

            Matrix matrix = new Matrix();
            matrix.SetMatrix(arr, Rows, Columns);

            int expected = 3;

            Assert.AreEqual(expected, matrix[0, 2]);
        }

        [TestMethod]
        public void GetMatrix_ReturnValueFromMatrix()
        {
            const int Rows = 2,
                Columns = 3;
            int[,] arr = new int[Rows, Columns] { { 1, 2, 3 }, { 4, 5, 6 } };

            Matrix matrix = new Matrix();
            matrix.SetMatrix(arr, Rows, Columns);

            Matrix expected = new Matrix(matrix.GetMatrix(), Rows, Columns);

            Assert.IsTrue(matrix.Equals(expected));
        }

        [TestMethod]
        public void SumOfSquares_1_ReturnIntSum()
        {
            const int Rows = 3,
                Columns = 3;
            int[,] arr = new int[Rows, Columns] 
            { { 1, -2, 3 }, 
              { 4, 5, -6 },
              { -1, 1, 0 } };

            Matrix matrix = new Matrix(arr, Rows, Columns);

            int expected = 26;

            Assert.AreEqual(expected, matrix.SumOfSquares(2));
        }

        [TestMethod]
        public void SumOfSquares_2_ReturnIntSum()
        {
            const int Rows = 3,
                Columns = 3;
            int[,] arr = new int[Rows, Columns]
            { { 1, -2, 3 },
              { 4, 5, -6 },
              { -1, 1, 0 } };

            Matrix matrix = new Matrix(arr, Rows, Columns);

            int expected = 41;

            Assert.AreEqual(expected, matrix.SumOfSquares());
        }

        [TestMethod]
        public void Operator_Minus_ReturnNewMatrix()
        {
            const int Rows = 2,
                Columns = 2;
            int[,] arr1 = new int[Rows, Columns] { { 1, 2 }, { 3, 4 } },
                arr2 = new int[Rows, Columns] { { 6, 1 }, { 0, 9 } };

            Matrix matrix1 = new Matrix(arr1, Rows, Columns),
                matrix2 = new Matrix(arr2, Rows, Columns);

            Matrix matrix3 = matrix1 - matrix2;

            int[,] arr3 = new int[Rows, Columns] { { -5, 1 }, { 3, -5 } };
            Matrix expected = new Matrix(arr3, Rows, Columns);

            Assert.IsTrue(matrix3.Equals(expected));
        }

        [TestMethod]
        public void Operator_MoreOrEqual_ReturnTrue()
        {
            const int Rows = 2,
                Columns = 2;
            int[,] arr1 = new int[Rows, Columns] { { 4, -2 }, { 3, 4 } },
                arr2 = new int[Rows, Columns] { { 6, 1 }, { 0, -9 } };

            Matrix matrix1 = new Matrix(arr1, Rows, Columns),
                matrix2 = new Matrix(arr2, Rows, Columns);

            Assert.IsTrue(matrix1 >= matrix2);
        }

        [TestMethod]
        public void Operator_LessOrEqual_ReturnTrue()
        {
            const int Rows = 2,
                Columns = 2;
            int[,] arr1 = new int[Rows, Columns] { { 4, 1 }, { 1, 4 } },
                arr2 = new int[Rows, Columns] { { 5, 3 }, { 0, -9 } };

            Matrix matrix1 = new Matrix(arr1, Rows, Columns),
                matrix2 = new Matrix(arr2, Rows, Columns);

            Assert.IsTrue(matrix1 <= matrix2);
        }
    }
}
