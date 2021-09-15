using FigureLibrary;
using System;

namespace Execution
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Trapeze trapeze = Create();

                int flag = 0;
                while (flag != 6)
                {
                    Console.WriteLine("\n\t╔═══════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t║                             МЕНЮ                          ║");
                    Console.WriteLine("\t╟─────┬─────────────────────────────────────────────────────╢");
                    Console.WriteLine("\t║  1  │              Создать новую трапецию                 ║");
                    Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                    Console.WriteLine("\t║  2  │               Длины сторон трапеции                 ║");
                    Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                    Console.WriteLine("\t║  3  │                Периметр трапеции                    ║");
                    Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                    Console.WriteLine("\t║  4  │                 Площадь трапеции                    ║");
                    Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                    Console.WriteLine("\t║  5  │           Проверить принадлежность точки            ║");
                    Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                    Console.WriteLine("\t║  6  │                      Выход                          ║");
                    Console.WriteLine("\t╚═══════════════════════════════════════════════════════════╝");

                    flag = Convert.ToInt32(Console.ReadLine());
                    switch (flag)
                    {
                        case 1:
                            trapeze = Create();
                            Console.WriteLine("\tНовая трапеция создана");
                            break;
                        case 2:
                            Console.WriteLine($"\tСтороны трапеции: {trapeze.ViewSides()}");
                            break;
                        case 3:
                            Console.WriteLine($"\tПериметр: {trapeze.GetPerimetr()}");
                            break;
                        case 4:
                            Console.WriteLine($"\tПлощадь: {trapeze.GetSquare()}");
                            break;
                        case 5:
                            CheckPointAffiliation(trapeze);
                            break;
                        case 6:
                            Console.WriteLine("\tПрограмма завершена");
                            break;
                        default:
                            Console.WriteLine("\tТакого пункта меню нет");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Trapeze creation
        /// </summary>
        /// <returns> Trapeze </returns>
        static Trapeze Create()
        {
            Console.WriteLine("\tВведите две точки:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());

            Trapeze trapeze = new Trapeze(x1, x2);

            return trapeze;
        }

        /// <summary>
        /// Checking point afflication to trapeze
        /// </summary>
        /// <param name="trapeze"> Selected trapeze </param>
        static void CheckPointAffiliation(Trapeze trapeze)
        {
            Console.WriteLine("\tВведите координаты точки:");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if (trapeze.IsPointBelong(x, y))
            {
                Console.WriteLine("\tТочка принадлежит трапеции");
            }
            else
            {
                Console.WriteLine("\tТочка НЕ принадлежит трапеции");
            }
        }
    }
}
