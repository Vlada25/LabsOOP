using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLibrary
{
    public interface IMatrix
    {
        int[,] GetMatrix();
        void SetMatrix(int[,] matrix, int rows, int columns);
    }
}
