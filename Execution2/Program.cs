using ArrayOperationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массив:");
            double[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => double.Parse(i)).ToArray();

            MyArray myArray = new MyArray(arr);

            int flag = 0;
            while (flag != 4)
            {
                Console.WriteLine("\n\t╔═════════════════════════════════════════════════╗");
                Console.WriteLine("\t║                       МЕНЮ                      ║");
                Console.WriteLine("\t╟─────┬───────────────────────────────────────────╢");
                Console.WriteLine("\t║  1  │            Сложить массивы                ║");
                Console.WriteLine("\t╟─────┼───────────────────────────────────────────╢");
                Console.WriteLine("\t║  2  │           Умножить на число               ║");
                Console.WriteLine("\t╟─────┼───────────────────────────────────────────╢");
                Console.WriteLine("\t║  3  │           Разделить на число              ║");
                Console.WriteLine("\t╟─────┼───────────────────────────────────────────╢");
                Console.WriteLine("\t║  4  │                 Выход                     ║");
                Console.WriteLine("\t╚═════════════════════════════════════════════════╝");

                flag = Convert.ToInt32(Console.ReadLine());
                switch (flag)
                {
                    case 1:
                        AddArrays(myArray);
                        break;
                    case 2:
                        MultiplyArray(myArray);
                        break;
                    case 3:
                        DivideArray(myArray);
                        break;
                    case 4:
                        Console.WriteLine("\tПрограмма завершена");
                        break;
                    default:
                        Console.WriteLine("\tТакого пункта меню нет");
                        break;
                }
            }
        }

        /// <summary>
        /// Adding arrays
        /// </summary>
        /// <param name="myArray1"> Main array </param>
        static void AddArrays(MyArray myArray1)
        {
            Console.WriteLine("\tВведите ещё один массив: ");
            double[] arr2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => double.Parse(i)).ToArray();

            MyArray myArray2 = new MyArray(arr2);
            MyArray myArray3 = myArray1 + myArray2;

            Console.WriteLine("\tРезультат сложения массивов: ");
            Console.WriteLine("\t" + myArray3.ToString());
        }

        /// <summary>
        /// Multiplication of arrays
        /// </summary>
        /// <param name="myArray"> Main array </param>
        static void MultiplyArray(MyArray myArray)
        {
            Console.WriteLine("\tВведите число: ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\tРезультат умножения массива на число: ");

            MyArray newArray = myArray * num;
            Console.WriteLine("\t" + newArray.ToString());
        }

        /// <summary>
        /// Division of arrays
        /// </summary>
        /// <param name="myArray"> Main array </param>
        static void DivideArray(MyArray myArray)
        {
            Console.WriteLine("\tВведите число: ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\tРезультат деления массива на число: ");

            MyArray newArray = myArray / num;
            Console.WriteLine("\t" + newArray.ToString());
        }
    }
}
