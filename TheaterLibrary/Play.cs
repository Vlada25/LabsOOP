using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace TheaterLibrary
{
    public class Play
    {
        public string Name { get; }
        public TheaterGenre Genre { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public int CountOfVisits { get; }

        public Play(string name, TheaterGenre genre, DateTime startDate, DateTime endDate, int countOfVisits)
        {
            Name = name;
            Genre = genre;
            StartDate = startDate;
            EndDate = endDate;
            CountOfVisits = countOfVisits;
        }

        /// <summary>
        /// Getting all genres in range of date
        /// </summary>
        /// <param name="plays">List of plays</param>
        /// <param name="startDate">Start date</param>
        /// <param name="endDate">End date</param>
        /// <returns>List of genres</returns>
        public static List<TheaterGenre> GetAllGenresInDateRange(List<Play> plays, DateTime startDate, DateTime endDate) // лучше тут оставить метод или в service?
        {
            List<TheaterGenre> genres = new List<TheaterGenre>();

            for (int i = 0; i < plays.Count; i++)
            {
                if (startDate > plays[i].StartDate || endDate < plays[i].EndDate)
                {
                    plays.RemoveAt(i);
                    i--;
                }
                else
                {
                    if (!genres.Contains(plays[i].Genre))
                    {
                        genres.Add(plays[i].Genre);
                    }
                }
            }

            return genres;
        }

        /// <summary>
        /// Getting index of the most popular genre 
        /// </summary>
        /// <param name="plays">List of plays</param>
        /// <param name="genres">List of genres</param>
        /// <returns>Index of the most popular genre</returns>
        public static int GetIndexOfTheMostPopularGenre(List<Play> plays, List<TheaterGenre> genres)
        {
            int max = 0,
                maxIndex = 0,
                index = 0;

            foreach (TheaterGenre genre in genres)
            {
                int countOfPays = 0;

                foreach (Play play in plays)
                {
                    if (play.Genre == genre)
                    {
                        countOfPays++;
                    }
                }

                if (max < countOfPays)
                {
                    max = countOfPays;
                    maxIndex = index;
                }

                index++;
            }

            return maxIndex;
        }

        /// <summary>
        /// Getting name of genre for user
        /// </summary>
        /// <param name="genre">List of genres</param>
        /// <returns>String name of genre</returns>
        public static string GetDisplayName(TheaterGenre genre)
        {
            Type type = genre.GetType();
            var enumItem = type.GetField(genre.ToString());
            var attribute = enumItem?.GetCustomAttribute<DisplayAttribute>();
            return attribute?.Name;
        }
    }
}
