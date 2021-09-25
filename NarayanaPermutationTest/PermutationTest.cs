using Microsoft.VisualStudio.TestTools.UnitTesting;
using NarayanaPermutationsLibrary;
using System;

namespace NarayanaPermutationTest
{
    [TestClass]
    public class PermutationTest
    {
        [TestMethod]
        public void NextPermutationTest()
        {
            string[] words = { "sad", "happy", "exelent" };
            int counter = 0;
            int expected = 6;

            Array.Sort(words);

            do 
            {
                counter++;
            } while (Permutation.NextPermutation(words, Permutation.IsLess));

            Assert.AreEqual(counter, expected);
        }

        [TestMethod]
        [DataRow("hey", "array")]
        public void IsGreaterTest(string word1, string word2)
        {
            Assert.IsTrue(Permutation.IsGreater(word1, word2));
        }

        [TestMethod]
        [DataRow("hey", "array")]
        public void IsLessTest(string word1, string word2)
        {
            Assert.IsTrue(Permutation.IsLess(word2, word1));
        }
    }
}
