
namespace MatrixLibrary
{
    public interface IMatrix
    {
        /// <summary>
        /// Getting matrix
        /// </summary>
        /// <returns> Matrix </returns>
        int[,] GetMatrix();

        /// <summary>
        /// Setting matrix
        /// </summary>
        /// <param name="matrix"> Selected matrix </param>
        /// <param name="rows"> Count of rows </param>
        /// <param name="columns"> Count of columns </param>
        void SetMatrix(int[,] matrix, int rows, int columns);
    }
}
