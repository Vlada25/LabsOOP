using MatrixLibrary;
using System;
using System.Linq;


namespace Execution3
{
    class Program
    {
        static void Main()
        {
            Matrix matrixA = new Matrix(),
                matrixB = new Matrix(),
                matrixC = new Matrix();

            try
            {
                CreateMatrix(matrixA);
                CreateMatrix(matrixB);
                CreateMatrix(matrixC);

                Console.WriteLine($"\nМатрица А:\n{matrixA}");
                Console.WriteLine($"\nМатрица B:\n{matrixB}");
                Console.WriteLine($"\nМатрица C:\n{matrixC}");

                Console.WriteLine("\nСуммы квадратов отрицательных элементов матриц:");
                Console.WriteLine($"Для матрицы А:\n{matrixA.SumOfSquares()}");
                Console.WriteLine($"Для матрицы B:\n{matrixB.SumOfSquares()}");
                Console.WriteLine($"Для матрицы C:\n{matrixC.SumOfSquares()}");

                Matrix matrixAB = matrixA - matrixB;
                Matrix matrixABC = matrixB - matrixA - matrixC;

                Console.WriteLine($"\nМатрица А-B:\n{matrixAB}");
                Console.WriteLine($"\nМатрица B-A-C:\n{matrixABC}");

                if (matrixA <= matrixB && matrixB <= matrixC)
                {
                    int sum = matrixC.SumOfSquares(3);

                    ChangeNegativeElements(matrixA, sum);
                    ChangeNegativeElements(matrixB, sum);
                }

                Console.WriteLine($"\nНовая матрица А:\n{matrixA}");
                Console.WriteLine($"\nНовая матрица B:\n{matrixB}");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        /// <summary>
        /// Changing negativ elements in selected matrix with selected number
        /// </summary>
        /// <param name="matrix">Selected matrix</param>
        /// <param name="num">Selected number</param>
        static void ChangeNegativeElements(Matrix matrix, int num)
        {
            for (int i = 0; i < matrix.CountOfRows; i++)
            {
                for (int j = 0; j < matrix.CountOfColumns; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = num;
                    }
                }
            }
        }

        /// <summary>
        /// Matrix creating
        /// </summary>
        /// <param name="matrix">Selected matrix</param>
        static void CreateMatrix(Matrix matrix)
        {
            int rows, columns;

            Console.WriteLine("\n*Формирование новой матрицы*");
            Console.WriteLine("Введите количество строк матрицы:");
            rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов матрицы:");
            columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выберите способ создания матрицы:");
            Console.WriteLine("1. Ввести матрицу вручную"); 
            Console.WriteLine("2. Cформировать матрицу рандомно");
            int item = Convert.ToInt32(Console.ReadLine());
            switch (item)
            {
                case 1:
                    matrix.SetMatrix(InputMatrix(rows, columns), rows, columns);
                    break;
                case 2:
                    matrix.SetMatrix(GenerateMatrixRandomly(rows, columns), rows, columns);
                    break;
                default:
                    Console.WriteLine("Такого пункта нет");
                    break;
            }
        }

        /// <summary>
        /// Creating matrix by yourselve
        /// </summary>
        /// <param name="rows">Count of rows</param>
        /// <param name="columns">Count of columns</param>
        /// <returns>Matrix</returns>
        static int[,] InputMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];

            Console.WriteLine($"Введите матрицу {rows}x{columns}:");

            for (int i = 0; i < rows; i++)
            {
                int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(p => int.Parse(p)).ToArray();
                
                if (arr.Length != columns)
                {
                    throw new Exception("Incorrect value of count of columns");
                }
                
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }

            return matrix;
        }

        /// <summary>
        /// Generating matrix randomly
        /// </summary>
        /// <param name="rows">Count of rows</param>
        /// <param name="columns">Count of columns</param>
        /// <returns>Matrix</returns>
        static int[,] GenerateMatrixRandomly(int rows, int columns)
        {
            Random random = new Random();
            int startValue, endValue;
            int[,] matrix = new int[rows, columns];

            Console.WriteLine("Выберете диапазон значений элементов\nВведите начальное значение:");
            startValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конечное значение:");
            endValue = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(startValue, endValue);
                }
            }

            return matrix;
        }
    }
}
