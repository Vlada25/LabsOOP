using NarayanaPermutationsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execution4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку, разделяя слова знаком \"_\":");
            string originalString = Console.ReadLine();
            string[] words = originalString.Split('_');

			Console.WriteLine("\nВыберите тип последовательности слов:\n" +
				"1 - Неубывающая\n" +
				"2 - Невозрастающая");

			int menuItem = int.Parse(Console.ReadLine());

            switch (menuItem)
            {
				case 1:
					Array.Sort(words);

					do // x < y — критерий сравнения для неубывающей последовательности
					{
						Console.WriteLine(Permutation.SequenceToString(words));
					} while (Permutation.NextPermutation(words, Permutation.IsLess));
					break;

				case 2:
					Array.Sort(words);
					words = Reverse(words);

					do // x > y — критерий сравнения для невозрастающей последовательности
					{
						Console.WriteLine(Permutation.SequenceToString(words));
					} while (Permutation.NextPermutation(words, Permutation.IsGreater));
					break;

				default:
					Console.WriteLine("Такого пункта нет");
					break;
            }
		}

		static string[] Reverse(string[] array)
        {
			string[] newArray = new string[array.Length];

			for(int i = array.Length-1; i >= 0; i--)
            {
				newArray[array.Length - i - 1] = array[i];
            }

			return newArray;
        }
	}
}
