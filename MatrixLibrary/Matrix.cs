using System;
using System.Collections.Generic;

namespace MatrixLibrary
{
    public class Matrix : IMatrix
    {
        private int[,] _matrix;
        public int CountOfRows { get; private set; }
        public int CountOfColumns { get; private set; }

        /// <summary>
        /// Indexator
        /// </summary>
        /// <param name="i"> Number of row </param>
        /// <param name="j"> Number of column </param>
        /// <returns></returns>
        public int this[int i, int j]
        {
            get
            {
                return _matrix[i, j];
            }
            set
            {
                _matrix[i, j] = value;
            }
        }

        /// <summary>
        /// Constructor without perams
        /// </summary>
        public Matrix() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="matrix"> Matrix </param>
        /// <param name="rows"> Count of rows </param>
        /// <param name="columns"> Count of columns </param>
        public Matrix(int[,] matrix, int rows, int columns)
        {
            _matrix = matrix;
            CountOfRows = rows;
            CountOfColumns = columns;
        }

        /// <summary>
        /// Setting matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        public void SetMatrix(int[,] matrix, int rows, int columns)
        {
            _matrix = matrix;
            CountOfRows = rows;
            CountOfColumns = columns;
        }

        /// <summary>
        /// Getting matrix
        /// </summary>
        /// <returns> Matrix </returns>
        public int[,] GetMatrix()
        {
            return _matrix;
        }

        /// <summary>
        /// Calculating sum of squares of positiv elements of matrix 
        /// which located below the minimum element among the elements of strings numbered multiples of n
        /// (n >= 0)
        /// </summary>
        /// <param name="n"> Number </param>
        /// <returns> Sum of squares </returns>
        public int SumOfSquares(int n)
        {
            int sum = 0;
            int min = _matrix[0, 0], iMin = 0, jMin = 0;

            // нахождение минимального элемента в строках, кратных n
            // + нахождение номера его строки и столбца
            for (int i = 0; i < CountOfRows; i += n)
            {
                for (int j = 0; j < CountOfColumns; j++)
                {
                    if (_matrix[i, j] < min)
                    {
                        min = _matrix[i, j];
                        iMin = i;
                        jMin = j;
                    }
                }
            }

            // вычисление суммы квадратов положительных элементов под найденным минимальным
            for (int i = iMin; i < CountOfRows; i++)
            {
                if (_matrix[i, jMin] > 0)
                {
                    sum += (int)Math.Pow(_matrix[i, jMin], 2);
                }
            }

            return sum;
        }

        /// <summary>
        /// Calculation sum of squares of negative elements of matrix
        /// </summary>
        /// <returns></returns>
        public int SumOfSquares()
        {
            int sum = 0;

            for (int i = 0; i < CountOfRows; i++)
            {
                for (int j = 0; j < CountOfColumns; j++)
                {
                    if (_matrix[i, j] < 0)
                    {
                        sum += (int)Math.Pow(_matrix[i, j], 2);
                    }
                }
            }

            return sum;
        }

        /// <summary>
        /// Overloading operator "-"
        /// element-wise subtraction
        /// </summary>
        /// <param name="matrix1"> First matrix </param>
        /// <param name="matrix2"> Second matrix </param>
        /// <returns> New resulting matrix </returns>
        public static Matrix operator - (Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.CountOfRows != matrix2.CountOfRows || 
                matrix1.CountOfColumns != matrix2.CountOfColumns)
            {
                throw new Exception("Matrices must be of the same dimension");
            }

            int rows = matrix1.CountOfRows;
            int columns = matrix1.CountOfColumns;
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return new Matrix(matrix, rows, columns);
        }

        /// <summary>
        /// Overloading operator ">="
        /// comparison by sums of squares of positive elements of matrices
        /// </summary>
        /// <param name="matrix1"> First matrix </param>
        /// <param name="matrix2"> Second matrix </param>
        /// <returns> Is the first matrix >= than the second </returns>
        public static bool operator >= (Matrix matrix1, Matrix matrix2)
        {
            if (SumOfSquares(matrix1) >= SumOfSquares(matrix2))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Overloading operator "<="
        /// comparison by sums of squares of positive elements of matrices
        /// </summary>
        /// <param name="matrix1"> First matrix </param>
        /// <param name="matrix2"> Second matrix </param>
        /// <returns> Is the first matrix <= than the second </returns>
        public static bool operator <= (Matrix matrix1, Matrix matrix2)
        {
            if (SumOfSquares(matrix1) <= SumOfSquares(matrix2))
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// Counting sum of squares of positiv matrix elements
        /// </summary>
        /// <param name="matrix"> Selected matrix </param>
        /// <returns> Sum </returns>
        private static int SumOfSquares(Matrix matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.CountOfRows; i++)
            {
                for (int j = 0; j < matrix.CountOfColumns; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sum += (int)Math.Pow(matrix[i, j], 2);
                    }
                }
            }

            return sum;
        }
        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < CountOfRows; i++)
            {
                for (int j = 0; j < CountOfColumns; j++)
                {
                    res += String.Format("{0,4}", _matrix[i, j]);
                }
                res += "\n";
            }
            return res;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
            {
                return false;
            }

            Matrix matrix = (Matrix)obj;

            if (matrix.GetMatrix().Length != GetMatrix().Length)
            {
                return false;
            }
            else if (matrix.CountOfRows != CountOfRows || 
                matrix.CountOfColumns != CountOfColumns)
            {
                return false;
            }

            for (int i = 0; i < CountOfRows; i++)
            {
                for (int j = 0; j < CountOfColumns; j++)
                {
                    if (matrix[i,j] != this[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = -143828609;
            hashCode = hashCode * -1521134295 + EqualityComparer<int[,]>.Default.GetHashCode(_matrix);
            hashCode = hashCode * -1521134295 + CountOfRows.GetHashCode();
            hashCode = hashCode * -1521134295 + CountOfColumns.GetHashCode();
            return hashCode;
        }
    }
}
