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
        public static string GetDisplayName(TheaterGenre genre)
        {
            Type type = genre.GetType();
            var enumItem = type.GetField(genre.ToString());
            var attribute = enumItem?.GetCustomAttribute<DisplayAttribute>();
            return attribute?.Name;
        }
    }
}
