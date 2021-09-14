using FigureLibrary;
using System;
using System.Xml;

namespace Execution
{
    class Program
    {
        const string Filepath = @"..\myXmlFile.xml";
        static XmlWriter xmlWriter;

        static void Main(string[] args)
        {
            try
            {
                xmlWriter = XmlWriter.Create(Filepath);
                Trapeze trapeze = Create();

                int flag = 0;
                while (flag != 7)
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
                    Console.WriteLine("\t║  6  │            Сохранить данные в xml-файл              ║");
                    Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                    Console.WriteLine("\t║  7  │                      Выход                          ║");
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
                            WriteToXml(trapeze);
                            break;
                        case 7:
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

        /// <summary>
        /// Writing trapeze info to xml-file
        /// </summary>
        /// <param name="trapeze"></param>
        static void WriteToXml(Trapeze trapeze)
        {
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("trapeze");

            xmlWriter.WriteAttributeString("sides", trapeze.FormatSidesForXml());
            xmlWriter.WriteAttributeString("perimetr", Convert.ToString(trapeze.GetPerimetr()));
            xmlWriter.WriteAttributeString("square", Convert.ToString(trapeze.GetSquare()));

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();

            Console.WriteLine("\tИнформация записана");
        }

    }
}
