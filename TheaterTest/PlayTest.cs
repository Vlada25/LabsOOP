using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheaterLibrary;
using System;
using System.Collections.Generic;

namespace TheaterTest
{
    [TestClass]
    public class PlayTest
    {
        [TestMethod]
        public void PlayConstructorTest()
        {
            Play play = new Play("Круэлла", TheaterGenre.Extravaganza, new DateTime(2021, 3, 9), new DateTime(2021, 4, 9), 129837);

            string expected1 = "Круэлла";
            TheaterGenre expected2 = TheaterGenre.Extravaganza;
            DateTime expected3 = new DateTime(2021, 3, 9);
            DateTime expected4 = new DateTime(2021, 4, 9);
            int expected5 = 129837;

            Assert.AreEqual(expected1, play.Name);
            Assert.AreEqual(expected2, play.Genre);
            Assert.AreEqual(expected3, play.StartDate);
            Assert.AreEqual(expected4, play.EndDate);
            Assert.AreEqual(expected5, play.CountOfVisits);
        }

        [TestMethod]
        public void GetAllGenresInDateRange_Test()
        {
            Play play1 = new Play("Круэлла", TheaterGenre.Extravaganza, new DateTime(2021, 3, 9), new DateTime(2021, 4, 9), 129837);
            Play play2 = new Play("Белый баклажан", TheaterGenre.Extravaganza, new DateTime(2021, 5, 9), new DateTime(2021, 6, 9), 129837);

            List<Play> plays = new List<Play> { play1, play2 };
            DateTime startDate = new DateTime(2021, 2, 1);
            DateTime endDate = new DateTime(2021, 4, 20);

            List<TheaterGenre> genres = Play.GetAllGenresInDateRange(plays, startDate, endDate);

            int expected = 1;

            Assert.AreEqual(expected, genres.Count);
        }

        [TestMethod]
        public void GetIndexOfTheMostPopularGenre_Test()
        {
            Play play1 = new Play("Круэлла", TheaterGenre.Extravaganza, new DateTime(2021, 3, 9), new DateTime(2021, 4, 9), 129837);
            Play play2 = new Play("Белый баклажан", TheaterGenre.Extravaganza, new DateTime(2021, 5, 9), new DateTime(2021, 6, 9), 129837);
            Play play3 = new Play("Богомолиха", TheaterGenre.Tragedy, new DateTime(2021, 5, 9), new DateTime(2021, 6, 9), 129837);

            List<Play> plays = new List<Play> { play1, play2, play3 };
            DateTime startDate = new DateTime(2021, 2, 1);
            DateTime endDate = new DateTime(2021, 12, 20);

            List<TheaterGenre> genres = Play.GetAllGenresInDateRange(plays, startDate, endDate);

            int maxIndex = Play.GetIndexOfTheMostPopularGenre(plays, genres);

            TheaterGenre expected = TheaterGenre.Extravaganza;

            Assert.AreEqual(expected, genres[maxIndex]);
        }
    }
}
