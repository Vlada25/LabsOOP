using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarayanaPermutationsLibrary
{
    public class Permutation
    {
		/// <summary>
		/// Comparison function (predicate - отношение)
		/// </summary>
		/// <param name="firstValue">First value</param>
		/// <param name="secondValue">Second value</param>
		/// <returns></returns>
		public delegate bool DetermineSequenceType(string firstValue, string secondValue);

		/// <summary>
		/// Searching for the next permutation
		/// </summary>
		/// <param name="sequence">Selected sequence</param>
		/// <param name="compare">Method of comparing</param>
		/// <returns>Is the next permutation exist</returns>
		public static bool NextPermutation(string[] sequence, DetermineSequenceType compare)
		{
			// Этап № 1
			// Найти наибольшее i, для которого выполняется условие sequence[i] <(или >) sequence[i+1].
			// Если такого нет, значит все перестановки были сгенерированы.
			var i = sequence.Length;
			do
			{
				if (i < 2)
					return false; // Перебор окончен
				--i;
			} while (!compare(sequence[i - 1], sequence[i]));

			// Этап № 2
			// Найти наибольшее  j > i, для которого выполняется условие sequence[i] <(или >) sequence[j].
			// Затем поменять местами sequence[i] и sequence[j].
			var j = sequence.Length;
			while (i < j && !compare(sequence[i - 1], sequence[--j])) ;
			SwapItems(sequence, i - 1, j);

			// Этап № 3
			// Элементы sequence[j+1],... sequence[length] переставить в обратном порядке.
			j = sequence.Length;
			while (i < --j)
				SwapItems(sequence, i++, j);
			return true;
		}

		/// <summary>
		/// Comparing two elements
		/// </summary>
		/// <param name="firstValue">Value of element</param>
		/// <param name="secondValue">Value of another element</param>
		/// <returns>Is the first element less than second</returns>
		public static bool IsLess(string firstValue, string secondValue)
		{
			return String.Compare(firstValue, secondValue) < 0;
		}

		/// <summary>
		/// Comparing two elements
		/// </summary>
		/// <param name="firstValue">Value of element</param>
		/// <param name="secondValue">Value of another element</param>
		/// <returns>Is the first element greater than second</returns>
		public static bool IsGreater(string firstValue, string secondValue)
		{
			return String.Compare(firstValue, secondValue) > 0;
		}

		/// <summary>
		/// Swapping items of sequence
		/// </summary>
		/// <param name="sequence">Selected sequence</param>
		/// <param name="index0">First item index</param>
		/// <param name="index1">Second item index</param>
		private static void SwapItems(string[] sequence, int index0, int index1)
		{
			string item = sequence[index0];
			sequence[index0] = sequence[index1];
			sequence[index1] = item;
		}

		/// <summary>
		/// Getting sequecnce in string format
		/// </summary>
		/// <param name="sequence">Selected sequence</param>
		/// <returns>String result</returns>
		public static string SequenceToString(string[] sequence)
		{
			string res = "[";

			if (!(sequence == null) && (sequence.Length > 0))
			{
				res += sequence[0];
				for (var i = 1; i < sequence.Length; ++i)
				{
					res += $", {sequence[i]}";
				}
			}

			res += "]";

			return res;
		}
    }
}
