using NarayanaPermutationsLibrary;
using System;
using System.Text;

namespace Execution4
{
    class Program
    {
        static void Main()
        {
			Console.WriteLine("\nВыберите номер задания (1 или 2):");

			int menuItem = int.Parse(Console.ReadLine());

			switch (menuItem)
            {
				case 1:
					Task_1();
					break;
				case 2:
					Task_2();
					break;
				default:
					Console.WriteLine("Такого пункта нет");
					break;
			}
		}

		/// <summary>
		/// Task 1
		/// </summary>
		static void Task_1()
        {
			Console.WriteLine("\nВведите строку, разделяя слова знаком \"_\":");
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

		/// <summary>
		/// Task 2
		/// </summary>
		static void Task_2()
        {
			StringBuilder newText = new StringBuilder();

			string givenText = "Обалдеть, с большой буквы «Х». То есть, когда доказательств не было," +
				" я был сразу убийцей, а сейчас, когда виновный очевиден, «Миша просто ошибся». " +
				"Нет, я не понимаю этого человека. С другой стороны, учитывая, что во время нашего прошлого " +
				"разговора девушка подтвердила свое вольное или невольное участие в смертельном вандализме, " +
				"может быть, это и не глупость. Надо бы понять, что именно она сделала. Тем более, я же под " +
				"гейсом пообещал раскрыть тайну, надо держать слово.";

			string[] allSentences = givenText.Split('.');

			Console.WriteLine($"\nИсходный текст:\n{givenText}");

			Console.WriteLine("\nВведите слово (для вывода строк, содержащих его):");
			string word = Console.ReadLine();

			foreach (string sentence in allSentences)
            {
				if (sentence.Contains(word))
                {
					newText.Append(sentence + ".");
                }
            }

			Console.WriteLine($"\nПолученный текст:\n{newText}\n");
		}

		/// <summary>
		/// Reversing array
		/// </summary>
		/// <param name="array">Selected array</param>
		/// <returns>Rewersed array</returns>
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
