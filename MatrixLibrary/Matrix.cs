using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLibrary
{
    public class Matrix
    {
        private int[,] _matrix;
        public int CountOfRows { get; private set; }
        public int CountOfColumns { get; private set; }
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
        public Matrix() { }
        public Matrix(int[,] matrix, int rows, int columns)
        {
            _matrix = matrix;
            CountOfRows = rows;
            CountOfColumns = columns;
        }
        public void SetMatrix(int[,] matrix, int rows, int columns)
        {
            _matrix = matrix;
            CountOfRows = rows;
            CountOfColumns = columns;
        }
        public int[,] GetMatrix()
        {
            return _matrix;
        }
        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < CountOfRows; i++)
            {
                for (int j = 0; j < CountOfColumns; j++)
                {
                    res += $"{_matrix[i, j]} ";
                }
            }
            return res;
        }
    }
}
